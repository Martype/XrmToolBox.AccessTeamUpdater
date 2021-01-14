using Martype.XrmToolBox.AccessTeamUpdater.Model;
using Martype.XrmToolBox.AccessTeamUpdater.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
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

                if (templates.Count == 0)
                    ShowInfo("Couldn't find any Access Team Templates.");
                else
                    templates.ForEach(t =>
                    {
                        Control.dataGridView_AccessTeamTemplates.Rows.Add(new object[] {
                        t.Id,
                        new HyperLink(t.Name, t.GetRecordUrl(Control.ConnectionDetail)),
                        t.DefaultAccessRightsMask,
                        t.AccessRights
                        });
                    });
            }
        }
    }
}
