﻿using System.ServiceProcess;

namespace FileSharing.Serveri.Service
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new FileSharingSherbimi() 
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
