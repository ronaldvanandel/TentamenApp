﻿using Microsoft. LightSwitch. Presentation. Extensions;
using Microsoft. LightSwitch. Presentation;
using Microsoft. LightSwitch. Framework. Client;
using Microsoft. LightSwitch;
using System. Collections. Generic;
using System. IO. IsolatedStorage;
using System. IO;
using System. Linq;
using System;

namespace LightSwitchApplication
{
    public partial class CreateNewPersoon
    {
        partial void CreateNewPersoon_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Write your code here.
            this.PersoonProperty = new Persoon();
        }

        partial void CreateNewPersoon_Saved()
        {
            // Write your code here.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.PersoonProperty);
        }
    }
}