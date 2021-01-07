using Martype.XrmToolBox.AccessTeamUpdater.Model;
using Martype.XrmToolBox.AccessTeamUpdater.Query;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace Martype.XrmToolBox.AccessTeamUpdater.Workers
{
    public class GetAccessTeamTemplatesWorker : WorkerBase
    {
        public GetAccessTeamTemplatesWorker(PluginControl control)
            : base(control) { }

        public override void DoWork()
        {
            try
            {
                Control.dataGridView_AccessTeamTemplates.Rows.Clear();

                Control.WorkAsync(new WorkAsyncInfo
                {
                    Message = "Getting Access Team Templates",
                    Work = (worker, args) =>
                    {
                        args.Result = RetrieveAccessTeamTemplates();
                    },
                    PostWorkCallBack = (args) =>
                    {
                        HandleAccessTeamTemplatesCallBack(args);
                    }
                });
            }
            catch (Exception exception)
            {
                HandleException(exception);
            }
        }

        private List<AccessTeamTemplate> RetrieveAccessTeamTemplates()
        {
            var retriever = new AccessTeamTemplateRetriever(Service);

            return retriever.GetList();
        }

        private void HandleAccessTeamTemplatesCallBack(RunWorkerCompletedEventArgs args)
        {
            if (WorkSucceeded(args))
            {
                var templates = args.Result as List<AccessTeamTemplate>;

                templates.ForEach(t =>
                {
                    Control.dataGridView_AccessTeamTemplates.Rows.Add(new string[] {
                        t.Id.ToString(),
                        t.GetRecordUrl(Control.ConnectionDetail),
                        t.Name,
                        t.DefaultAccessRightsMask.ToString(),
                        t.AccessRights.ToString()
                    });
                });
            }
        }      
    }
}
