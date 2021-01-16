using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CD_Lehre.InterfacesFortbewegungsmittel
{
	/// <summary>
	/// Aufzählungstyp für den Verkehrsweg.
	/// </summary>
	class Verkehrsweg
	{
		/// <summary>
		/// Beschreibt das Medium, in bzw. auf dem sich das Fahrzeug bewegt
		/// </summary>
		public enum Fortbewegungsmedium
		{
			/// <summary>
			/// für Schiffe und Amphibienfahrzeuge
			/// </summary>
			Wasser,
			/// <summary>
			/// für Amphibienfahrzeuge, Landfahrzeuge und Luftfahrzeuge
			/// </summary>
			Land,
			/// <summary>
			/// für Luftfahrzeuge
			/// </summary>
			Luft
		};
	}
}

