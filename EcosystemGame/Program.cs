﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcosystemGame
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Enables visual styles for the application (colors, fonts etc.).
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Runs the GameMenu form.
            Application.Run(new GameMenu());
        }
    }
}
