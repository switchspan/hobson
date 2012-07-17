using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;

using log4net;
using log4net.Config;

namespace Hobson
{
    public partial class HobsonService : ServiceBase
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(HobsonService));

        public HobsonService()
        {
            this.ServiceName = "Hobson Automated File Organizer";
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            log.Info("Hobson service started.");
            Debug.WriteLine("The service started.");
        }

        protected override void OnStop()
        {
            log.Info("Hobson service stopped.");
            Debug.WriteLine("The service stopped.");
        }
    }
}
