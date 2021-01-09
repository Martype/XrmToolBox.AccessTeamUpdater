using Microsoft.Xrm.Sdk;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Martype.XrmToolBox.AccessTeamUpdater.Workers
{
    abstract public class WorkerBase
    {
        protected PluginControl Control;
        protected IOrganizationService Service;

        public WorkerBase(PluginControl control)
        {
            Control = control;
            Service = control.Service;
        }

        public abstract void DoWork();

        protected bool WorkSucceeded(RunWorkerCompletedEventArgs args)
        {
            bool succeeded = true;

            if (args.Error != null)
            {
                succeeded = false;
                MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return succeeded;
        }

        protected void HandleException(Exception exception)
        {
            MessageBox.Show(exception.Message + exception.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
