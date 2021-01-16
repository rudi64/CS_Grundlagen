using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CD_Lehre.InterfacesFortbewegungsmittel
{
	/// <summary>
	/// Zusammenfassung für IFliegen.
	/// </summary>
	interface IFliegen
	{
        /// <summary>
        /// beschreibt Flugvorgänge
        /// </summary>
		void Fliegen();

        /// <summary>
        /// Get-/Set-Eigenschaft für die Geschwindigkeit
        /// </summary>
		double Geschwindigkeit
		{
			get;
			set;
		}
	}
}
