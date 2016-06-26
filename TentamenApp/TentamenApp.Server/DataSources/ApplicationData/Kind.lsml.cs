using Microsoft. LightSwitch;
using System. Text;
using System. Linq;
using System. Collections. Generic;
using System;

namespace LightSwitchApplication
    {
    public partial class Kind
        {
        partial void VolledigeNaam_Compute(ref string result)
            {
            // Set result to the desired field value
            result = Voornaam + " " + Persoon. Achternaam;
             }

        partial void AantalBroersEnZussen_Compute(ref int result)
            {
            // Set result to the desired field value
            result = Persoon. Kinds. Count();
            }

        partial void Leeftijd_Compute(ref int result)
            {
            // Set result to the desired field value
            if (Geboortedatum !=null)
            result = DateTime. Now. Year - Geboortedatum. Year;
            }
        }
    }