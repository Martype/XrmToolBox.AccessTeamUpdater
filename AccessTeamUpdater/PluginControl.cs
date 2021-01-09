using Martype.XrmToolBox.AccessTeamUpdater.Model;
using Martype.XrmToolBox.AccessTeamUpdater.Workers;
using McTools.Xrm.Connection;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace Martype.XrmToolBox.AccessTeamUpdater
{
    public partial class PluginControl : PluginControlBase
    {
        private Settings mySettings;
        public List<AccessTeam> AcceessTeams;
        public AccessTeamTemplate SelectedTemplate;

        public PluginControl()
        {
            InitializeComponent();
        }

        private void LoadPlugin(object sender, EventArgs e)
        {
            AddDivergentOnlyToolTip();
            
            // Loads or creates the settings for the plugin
            if (!SettingsManager.Instance.TryLoad(GetType(), out mySettings))
            {
                mySettings = new Settings();

                LogWarning("Settings not found => a new settings file has been created!");
            }
            else
            {
                LogInfo("Settings found and loaded");
            }
        }

        private void GetAccessTeamTemplates(object sender, EventArgs e)
        {
            var worker = new GetAccessTeamTemplatesWorker(this);
            worker.DoWork();
        }

        private void GetAccessTeams(object sender, EventArgs e)
        {
            var worker = new GetAccessTeamsWorker(this);
            worker.DoWork();
        }

        private void UpdateAccessTeams(object sender, EventArgs e)
        { 
            var worker = new UpdateAccessTeamsWorker(this);
            worker.DoWork();
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            if (mySettings != null && detail != null)
            {
                mySettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
                LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);
            }
        }

        private void UndoSelection(object sender, EventArgs e)
        {
            dataGridView_AccessTeams.ClearSelection();
        }

        private void AddDivergentOnlyToolTip()
        {
            var toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 500;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;

            toolTip.SetToolTip(this.checkBox_DivergentOnly, "Select whether to only show access teams with access rights other than the access team template");
        }

        private void dataGridView_AccessTeamTemplates_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (e.ColumnIndex == dataGridView_AccessTeamTemplates.Columns["TeamTemplateName"].Index)
            {
                var hyperLink = (HyperLink)dataGridView_AccessTeamTemplates.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                e.Value = hyperLink.Title;
            }
            else if (e.ColumnIndex == dataGridView_AccessTeamTemplates.Columns["AccessRights"].Index)
            {
                var accessRights = (AccessRights)dataGridView_AccessTeamTemplates.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                e.CellStyle.WrapMode = DataGridViewTriState.True;
                e.Value = FormatAccessRights(accessRights);
            }
        }

        private void dataGridView_AccessTeamTemplates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (e.ColumnIndex == dataGridView_AccessTeamTemplates.Columns["TeamTemplateName"].Index)
            {
                var hyperLink = (HyperLink)dataGridView_AccessTeamTemplates.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                Process.Start(hyperLink.Url);
            }
        }     

        private void dataGridView_AccessTeams_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (e.ColumnIndex == dataGridView_AccessTeams.Columns["TeamId"].Index
               || e.ColumnIndex == dataGridView_AccessTeams.Columns["RegardingObject"].Index)
            {
                var hyperLink = (HyperLink)dataGridView_AccessTeams.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                e.Value = hyperLink.Title;
            }
            else if (e.ColumnIndex == dataGridView_AccessTeams.Columns["TeamAccessRights"].Index)
            {
                var accessRights = (AccessRights)dataGridView_AccessTeams.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                e.Value = accessRights.ToString();
            }
        }

        private void dataGridView_AccessTeams_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if ((e.ColumnIndex == dataGridView_AccessTeams.Columns["TeamId"].Index 
                || e.ColumnIndex == dataGridView_AccessTeams.Columns["RegardingObject"].Index))
            {
                var hyperLink = (HyperLink)dataGridView_AccessTeams.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                Process.Start(hyperLink.Url);
            }
        }

        private string FormatAccessRights(AccessRights accessRights)
        {
            return accessRights.ToString().Replace(", ", "\n\r");
        }      
    }
}