﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new start());
           

        }
        public static void RunTimer() {
            System.Timers.Timer timer = new System.Timers.Timer(2000);
            timer.Elapsed += async (sender, e) => await HandleTimer();
            timer.Start();
        }
        private static Task HandleTimer()
        {
            Console.WriteLine("\nHandler not implemented...");
            throw new NotImplementedException();
        }
    }
}
