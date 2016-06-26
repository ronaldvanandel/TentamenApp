using Microsoft. LightSwitch;
using System. Text;
using System. Linq;
using System. Collections. Generic;
using System;

namespace LightSwitchApplication
    {
    public partial class Persoon
        {
        partial void VolledigeNaam_Compute(ref string result)
            {
            // Set result to the desired field value
            result = Voornaam + " " + Achternaam;
            }

        partial void AantalKinderen_Compute(ref int result)
            {
            // Set result to the desired field value
            result = Kinds. Count();
            }
        }
    }