using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CD_Lehre.InterfacesFortbewegungsmittel
{
	/// <summary>
	/// Einfache Klasse Luftfahrzeug, von Fortbewegungsmittel abgeleitet, mit Interfaces IFahren und IFliegen.
	/// </summary>
	class Luftfahrzeug: Fortbewegungsmittel, IFahren, IFliegen
    {
		#region zusätzliche Membervariable
		/// <summary>
		/// Medium: Luft oder Land
		/// </summary>
		private Verkehrsweg.Fortbewegungsmedium medium;
		#endregion

		#region Konstruktor
		/// <summary>
		/// Standardkonstruktor
		/// </summary>
		/// <param name="beförderungskapazität">Beförderungskapazität</param>
		public Luftfahrzeug(
			int beförderungskapazität): base(beförderungskapazität)
		{
			this.art = "Luftfahrzeug";
			this.Medium = Verkehrsweg.Fortbewegungsmedium.Luft;
		}
		#endregion

		#region Eigenschaften
		/// <summary>
		/// get-/set-Eigenschaft für das Fortbewegungsmedium: per Default Luft, Land auch möglich
		/// </summary>
		public Verkehrsweg.Fortbewegungsmedium Medium
		{
			get
			{
				return (this.medium);
			}
			set
			{
				if (value == Verkehrsweg.Fortbewegungsmedium.Land)
				{
					this.medium = value;
				}
				else
				{
					this.medium = Verkehrsweg.Fortbewegungsmedium.Luft;
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
			Console.WriteLine("Das {0} rollt mit einer Geschwindigkeit von {1} [km/h]!", this.Art, this.GeschwindigkeitAktuell);
		}
		#endregion

		#region IFliegen Member
		/// <summary>
		/// Ausgabe der Art und der spezifischen Geschwindigkeit
		/// </summary>
		public void Fliegen()
		{
			Console.WriteLine("Das {0} fliegt mit einer Geschwindigkeit von {1} [Mach]!", this.Art, this.Geschwindigkeit);
		}

		/// <summary>
		/// set-/get-Eigenschaft für die Geschwindigkeit in [Mach]
		/// </summary>
		public double Geschwindigkeit
		{
			get
			{
				return (this.GeschwindigkeitAktuell/1200.0);
			}
			set
			{
				this.GeschwindigkeitAktuell = value*1200.0;
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
				this.Fliegen();
			}
		}
		#endregion
	}
}

