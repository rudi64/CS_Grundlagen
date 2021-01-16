using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CD_Lehre.InterfacesFortbewegungsmittel
{
	/// <summary>
	/// Testtreiber zum Thema Interfaces anhand einer Basisklasse Fortbewegungsmittel und
	/// daraus abgeleiteten Klassen Landfahrzeug, Amphibienfahrzeug, Schiff und Luftfahrzeug.
	/// </summary>
    class Program
    {
		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
        static void Main()
        {
			Fortbewegungsmittel[] verkehrsmittel = new Fortbewegungsmittel[4];

			verkehrsmittel[0] = new Schiff(1000);
			verkehrsmittel[1] = new Landfahrzeug(4);
			verkehrsmittel[2] = new Luftfahrzeug(1);
			verkehrsmittel[3] = new Amphibienfahrzeug(2);

			// Geschwindigkeiten im spezifischen Format setzen
			((ISchwimmen)verkehrsmittel[0]).Geschwindigkeit = 10.0; // [sm/h]
			verkehrsmittel[1].GeschwindigkeitAktuell = 60.0;		// [km/h]
			((IFliegen)verkehrsmittel[2]).Geschwindigkeit = 1.0;    // [Mach]
			verkehrsmittel[3].GeschwindigkeitAktuell = 10.0;        // [km/h]

			foreach (Fortbewegungsmittel einVerkehrsmittel in verkehrsmittel)
			{
				einVerkehrsmittel.Ausgeben();
			}

			Console.WriteLine();

			// Art des Verkehrsweges umsetzen, wo sinnvoll
			((Luftfahrzeug)verkehrsmittel[2]).Medium = Verkehrsweg.Fortbewegungsmedium.Land;
			((Amphibienfahrzeug)verkehrsmittel[3]).Medium = Verkehrsweg.Fortbewegungsmedium.Land;

			// Geschwindigkeiten im spezifischen Format setzen
			((IFliegen)verkehrsmittel[2]).Geschwindigkeit = 0.1;    // [Mach]

			foreach (Fortbewegungsmittel einVerkehrsmittel in verkehrsmittel)
			{
				einVerkehrsmittel.Ausgeben();
			}

			// Verwendung von is
			Console.WriteLine("\nVerwendung von 'is'\n");

			foreach (Fortbewegungsmittel einVerkehrsmittel in verkehrsmittel)
			{
				if (einVerkehrsmittel is IFahren)
				{
					((IFahren)einVerkehrsmittel).Fahren();
				}
				if (einVerkehrsmittel is IFliegen)
				{
					((IFliegen)einVerkehrsmittel).Fliegen();
				}
				if (einVerkehrsmittel is ISchwimmen)
				{
					((ISchwimmen)einVerkehrsmittel).Schwimmen();
				}
			}

			// Verwendung von as
			Console.WriteLine("\nVerwendung von 'as'\n");

			foreach (Fortbewegungsmittel einVerkehrsmittel in verkehrsmittel)
			{
				IFahren landfahrzeug = einVerkehrsmittel as IFahren;
				if (landfahrzeug != null)
				{
					landfahrzeug.Fahren();
				}
				IFliegen luftfahrzeug = einVerkehrsmittel as IFliegen;
				if (luftfahrzeug != null)
				{
					luftfahrzeug.Fliegen();
				}
				ISchwimmen wasserfahrzeug = einVerkehrsmittel as ISchwimmen;
				if (wasserfahrzeug != null)
				{
					wasserfahrzeug.Schwimmen();
				}
			}
		}
	}
}

