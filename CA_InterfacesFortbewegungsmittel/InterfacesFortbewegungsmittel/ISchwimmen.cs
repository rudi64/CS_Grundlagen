using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CD_Lehre.InterfacesFortbewegungsmittel
{
	/// <summary>
	/// Zusammenfassung für ISchwimmen.
	/// </summary>
	interface ISchwimmen
	{
        /// <summary>
        /// beschreibt Schwimmvorgänge
        /// </summary>
		void Schwimmen();

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
