using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;
using McTools.Xrm.Connection;
using Microsoft.Crm.Sdk.Messages;
using Martype.XrmToolBox.AccessTeamUpdater.Factory;
using Martype.XrmToolBox.AccessTeamUpdater.Model;
using Martype.XrmToolBox.AccessTeamUpdater.Query;
using Martype.XrmToolBox.AccessTeamUpdater.Workers;
using System.Diagnostics;

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

            toolTip.SetToolTip(this.checkBox_DivergentOnly, "Select whether to show only Access Teams with AccessRights other than the Access Team Template.");
        }

        private void dataGridView_AccessTeamTemplates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView_AccessTeamTemplates.Columns["Browse"].Index && e.RowIndex != -1)
            {
                var url = (string)dataGridView_AccessTeamTemplates.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                Process.Start(url);
            }
        }

        private void dataGridView_AccessTeams_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView_AccessTeams.Columns["BrowseTeam"].Index && e.RowIndex != -1)
            {
                var url = (string)dataGridView_AccessTeams.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                Process.Start(url);
            }
        }
    }
}