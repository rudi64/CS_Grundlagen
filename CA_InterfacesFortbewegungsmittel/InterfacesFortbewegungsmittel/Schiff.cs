using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CD_Lehre.InterfacesFortbewegungsmittel
{
	/// <summary>
	/// Einfache Klasse Schiff, von Fortbewegungsmittel abgeleitet, mit Interface ISchwimmen.
	/// </summary>
	class Schiff: Fortbewegungsmittel, ISchwimmen
	{
		#region Konstruktoren
		/// <summary>
		/// Standardkonstruktor
		/// </summary>
		/// <param name="beförderungskapazität">Beförderungskapazität</param>
		public Schiff(
			int beförderungskapazität): base(beförderungskapazität)
		{
			this.art = "Schiff";
		}
		#endregion

		#region ISchwimmen Member
		/// <summary>
		/// Ausgabe der Art und der spezifischen Geschwindigkeit
		/// </summary>
		public void Schwimmen()
		{
			Console.WriteLine("Das {0} schwimmt mit einer Geschwindigkeit von {1} [sm/h]!", this.Art, this.Geschwindigkeit);
		}

		/// <summary>
		/// set-/get-Eigenschaft für die Geschwindigkeit in [sm/h]
		/// </summary>
		public double Geschwindigkeit
		{
			get
			{
				return (this.GeschwindigkeitAktuell/1.6);
			}
			set
			{
				this.GeschwindigkeitAktuell = value*1.6;
			}
		}
		#endregion

		#region überschriebene Methoden
		/// <summary>
		/// Ausgabe der aktuellen Eigenschaften und der Fortbewegungsart
		/// </summary>
		public override void Ausgeben()
		{
			Console.WriteLine(this);
			this.Schwimmen();
		}
		#endregion
	}
}

