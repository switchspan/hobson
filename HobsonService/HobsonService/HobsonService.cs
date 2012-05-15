using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace HobsonService
{
    public partial class HobsonService : ServiceBase
    {
        public HobsonService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Debug.WriteLine("The service started.");
        }

        protected override void OnStop()
        {
            Debug.WriteLine("The service stopped.");
        }
    }
}
