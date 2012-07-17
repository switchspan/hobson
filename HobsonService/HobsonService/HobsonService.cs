/*
 *	Hobson - An automated file organizer
 *	Copyright (C) 2012  Ken Taylor
 *
 *	This program is free software: you can redistribute it and/or modify
 *	it under the terms of the GNU General Public License as published by
 *	the Free Software Foundation, either version 3 of the License, or
 *	(at your option) any later version.
 *
 *	This program is distributed in the hope that it will be useful,
 *	but WITHOUT ANY WARRANTY; without even the implied warranty of
 *	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *	GNU General Public License for more details.
 *
 *	You should have received a copy of the GNU General Public License
 *	along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */
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
