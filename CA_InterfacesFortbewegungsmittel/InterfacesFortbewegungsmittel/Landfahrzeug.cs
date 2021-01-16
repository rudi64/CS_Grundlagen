using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CD_Lehre.InterfacesFortbewegungsmittel
{
	/// <summary>
	/// Einfache Klasse Landfahrzeug, von Fortbewegungsmittel abgeleitet, mit Interface IFahren.
	/// </summary>
	class Landfahrzeug: Fortbewegungsmittel, IFahren
    {
		#region Konstruktor
		/// <summary>
		/// Standardkonstruktor
		/// </summary>
		/// <param name="beförderungskapazität">Beförderungskapazität</param>
		public Landfahrzeug(
			int beförderungskapazität): base(beförderungskapazität)
		{
			//
			// TODO: Fügen Sie hier die Konstruktorlogik hinzu
			//
			this.art = "Landfahrzeug";
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

		#region überschriebene Methoden
		/// <summary>
		/// Ausgabe der aktuellen Eigenschaften und der Fortbewegungsart
		/// </summary>
		public override void Ausgeben()
		{
			Console.WriteLine(this);
			this.Fahren();
		}
		#endregion
	}
}
