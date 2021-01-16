using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CD_Lehre.InterfacesFortbewegungsmittel
{
	/// <summary>
	/// <para>Die Klasse Fortbewegungsmittel bildet eine abstrakte Basisklasse, von der
	/// Landfahrzeuge, Schiffe, Amphibienfahrzeuge und Luftfahrzeuge abgeleitet werden.</para>
	/// </summary>
	abstract class Fortbewegungsmittel
	{
		#region Membervariable
		/// <summary>
		/// Beförderungskapazität für Personen: Minimum 1 Person
		/// </summary>
		protected int beförderungskapazität;
		/// <summary>
		/// Aktuelle Geschwindigkeit in km/h
		/// </summary>
		protected double geschwindigkeitAktuell;
		/// <summary>
		/// Art des Fahrzeuges
		/// </summary>
		protected string art;
		#endregion

		#region Konstruktoren
		/// <summary>
		/// Standardkonstruktor
		/// </summary>
		/// <param name="beförderungskapazität">Beförderungskapazität</param>
		public Fortbewegungsmittel(
			int beförderungskapazität)
		{
			this.Beförderungskapazität = beförderungskapazität;
			this.GeschwindigkeitAktuell = 0.0;
		}
		#endregion

		#region Eigenschaften
		/// <summary>
		/// get-/set-Eigenschaft für die Beförderungskapazität
		/// </summary>
		public int Beförderungskapazität
		{
			get
			{
				return (this.beförderungskapazität);
			}
			set
			{
				if (value < 1)
				{
					this.beförderungskapazität = 1;
				}
				else
				{
					this.beförderungskapazität = value;
				}
			}
		}

		/// <summary>
		/// get-/set-Eigenschaft für die aktuelle Geschwindigkeit
		/// </summary>
		public double GeschwindigkeitAktuell
		{
			get
			{
				return (this.geschwindigkeitAktuell);
			}
			set
			{
				this.geschwindigkeitAktuell = Math.Abs(value);
			}
		}

		/// <summary>
		/// get-Eigenschaft für die Art
		/// </summary>
		public string Art
		{
			get
			{
				return (this.art);
			}
		}
		#endregion

		#region abstracte Methoden
		/// <summary>
		/// Ausgabe der Eigenschaften
		/// </summary>
		public abstract void Ausgeben();
		#endregion

		#region überschriebene Methoden
		/// <summary>
		/// Überschriebene ToString()-Methode
		/// </summary>
		/// <returns>Ausgabetext</returns>
		public override string ToString()
		{
			string text = String.Format("Art = {0}, Kapazität = {1}, V[km/h] = {2}",
				this.Art, this.Beförderungskapazität, this.GeschwindigkeitAktuell);
			return (text);
		}
		#endregion
	}
}

