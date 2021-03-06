/*
 * Base64 ToolBox 1.0
 *
 * Copyright (C) 2005 Sébastien Santoro
 *
 * Ce logiciel est librement diffusé sous licence BSD.
 * 
 * Ce programme est diffusé en espérant qu'il vous sera utile, mais
 * SANS AUCUNE GARANTIE, en ce inclut la garantie de conformité avec
 * un usage particulier.
 *
 * Vous utilisez donc ce logiciel à vos propres risques et périls.
 *
 * Le présent code peut librement être réutilisé dans d'autres applications,
 * y compris payantes ou non open source.
 *
 * Si vous l'utiliser ainsi ou l'améliorer, ce serait très gentil de votre part
 * d'envoyer un e-mail à  afin de donner à l'auteur une idée de la
 * "vie" de son code.
 *
*/

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Base64ToolBox {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main () {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new Base64ToolBoxForm());
        }
    }
}