using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CD_Lehre.InterfacesFortbewegungsmittel
{
	/// <summary>
	/// Einfache Klasse Landfahrzeug, von Fortbewegungsmittel abgeleitet, mit Interfaces IFahren und ISchwimmen.
	/// </summary>
	class Amphibienfahrzeug: Fortbewegungsmittel, IFahren, ISchwimmen
	{
		#region zusätzliche Membervariable
		/// <summary>
		/// Medium: Wasser oder Land
		/// </summary>
		private Verkehrsweg.Fortbewegungsmedium medium;
		#endregion

		#region Konstruktor
		/// <summary>
		/// Standardkonstruktor
		/// </summary>
		/// <param name="beförderungskapazität">Beförderungskapazität</param>
		public Amphibienfahrzeug(
			int beförderungskapazität): base(beförderungskapazität)
		{
			this.art = "Amphibienfahrzeug";
			this.Medium = Verkehrsweg.Fortbewegungsmedium.Wasser;
		}
		#endregion

		#region Eigenschaften
		/// <summary>
		/// get-/set-Eigenschaft für das Medium: per Default Wasser, aber auch Land möglich
		/// </summary>
		public Verkehrsweg.Fortbewegungsmedium Medium
		{
			get
			{
				return (this.medium);
			}
			set
			{
				if (value == Verkehrsweg.Fortbewegungsmedium.Wasser)
				{
					this.medium = value;
				}
				else
				{
					this.medium = Verkehrsweg.Fortbewegungsmedium.Land;
				}
			}
		}
		#endregion

		#region IFahren Member
		/// <summary>
		/// Ausgabe der Art und der spezifischen Geschwindigkeit
		/// </summary>
		public void Fahren()
		{
			Console.WriteLine("Das {0} fährt mit einer Geschwindigkeit von {1} [km/h]!", this.Art, this.GeschwindigkeitAktuell);
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
			if (this.Medium == Verkehrsweg.Fortbewegungsmedium.Land)
			{
				this.Fahren();
			}
			else
			{
				this.Schwimmen();
			}
		}
		#endregion

	}
}
