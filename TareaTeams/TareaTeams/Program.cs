﻿using System;
using System.Windows.Forms;
using Tarea;

namespace Tarea
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Figuras());
        }
    }
}
