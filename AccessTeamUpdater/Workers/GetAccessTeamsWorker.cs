using Martype.XrmToolBox.AccessTeamUpdater.Factory;
using Martype.XrmToolBox.AccessTeamUpdater.Model;
using Martype.XrmToolBox.AccessTeamUpdater.Query;
using Microsoft.Crm.Sdk.Messages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace Martype.XrmToolBox.AccessTeamUpdater.Workers
{
    public class GetAccessTeamsWorker : WorkerBase
    {
        public object SelectedTemplate { get; private set; }

        public GetAccessTeamsWorker(PluginControl control)
            : base(control) { }

        public override void DoWork()
        {
            try
            {
                Reset();

                if (!TemplateSelected())
                    return;

                SetSelectedTemplate();

                Control.WorkAsync(new WorkAsyncInfo
                {
                    Message = "Getting Access Team Templates",
                    Work = (worker, args) =>
                    {
                        args.Result = RetrieveAccessTeams();
                    },
                    PostWorkCallBack = (args) =>
                    {
                        HandleAccessTeamsCallBack(args);
                    }
                });
            }
            catch (Exception exception)
            {
                HandleException(exception);
            }
        }

        private void Reset()
        {
            Control.AcceessTeams = null;
            Control.dataGridView_AccessTeams.Rows.Clear();

            Control.textBox_AccessTeamTemplate.Text = null;
            Control.textBox_AccessRights.Text = null;
        }

        private bool TemplateSelected()
        {
            bool selected = true;

            if (Control.dataGridView_AccessTeamTemplates.SelectedRows.Count < 1)
            {
                selected = false;
                MessageBox.Show("Please select an access team template.", "No access team template selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return selected;
        }

        private void SetSelectedTemplate()
        {
            var selectedRow = Control.dataGridView_AccessTeamTemplates.SelectedRows[0];
            Control.SelectedTemplate = AccessTeamTemplateFactory.FromDataGridViewRow(selectedRow);
        }

        private void SetPreviewControls()
        {
            Control.textBox_AccessTeamTemplate.Text = Control.SelectedTemplate.Name;
            Control.textBox_AccessRights.Text = Control.SelectedTemplate.AccessRights.ToString();
        }

        private List<AccessTeam> RetrieveAccessTeams()
        {
            var retriever = new AccessTeamRetriever(Service);

            var accessTeams = retriever.GetListByAccessTeamTemplateId(Control.SelectedTemplate.Id, Control.textBox_FetchXmlFilter.Text);

            accessTeams.ForEach(team =>
            {

                var principalAccessRequest = new RetrievePrincipalAccessRequest
                {
                    Principal = team.ToEntityReference(),
                    Target = team.RegardingObjectId
                };

                var principalAccessResponse = (RetrievePrincipalAccessResponse)Service.Execute(principalAccessRequest);

                team.AccessRights = principalAccessResponse.AccessRights;
            });

            return accessTeams;
        }

        private void HandleAccessTeamsCallBack(RunWorkerCompletedEventArgs args)
        {
            if (WorkSucceeded(args))
            {
                SetPreviewControls();

                var accessTeams = args.Result as List<AccessTeam>;

                var accessTeamsForUpdate = new List<AccessTeam>();

                var divergentOnly = Control.checkBox_DivergentOnly.Checked;

                accessTeams.ForEach(team =>
                {
                    if (!divergentOnly || (divergentOnly && team.AccessRights != Control.SelectedTemplate.AccessRights))
                    {
                        accessTeamsForUpdate.Add(team);
                    }
                });

                Control.AcceessTeams = accessTeamsForUpdate;

                Control.AcceessTeams.ForEach(team =>
                {
                    Control.dataGridView_AccessTeams.Rows.Add(new object[] {
                        new HyperLink(team.Id.ToString(), team.GetRecordUrl(Control.ConnectionDetail)),
                        team.AccessRights,
                        new HyperLink(team.RegardingObjectId.Id.ToString(), team.RegardingObjectId.GetRecordUrl(Control.ConnectionDetail))
                    });
                });
            }
        }
    }
}
