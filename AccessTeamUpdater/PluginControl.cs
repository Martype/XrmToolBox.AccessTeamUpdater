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

namespace Martype.XrmToolBox.AccessTeamUpdater
{
    public partial class PluginControl : PluginControlBase
    {
        private Settings mySettings;

        public PluginControl()
        {
            InitializeComponent();
        }

        private void MyPluginControl_Load(object sender, EventArgs e)
        {
            //ShowInfoNotification("This is a notification that can lead to XrmToolBox repository", new Uri("https://github.com/MscrmTools/XrmToolBox"));

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

        private void tsbClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        private void tsbSample_Click(object sender, EventArgs e)
        {
            // The ExecuteMethod method handles connecting to an
            // organization if XrmToolBox is not yet connected
            ExecuteMethod(GetAccounts);
        }

        private void GetAccounts()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Getting accounts",
                Work = (worker, args) =>
                {
                    args.Result = Service.RetrieveMultiple(new QueryExpression("account")
                    {
                        TopCount = 50
                    });
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    var result = args.Result as EntityCollection;
                    if (result != null)
                    {
                        MessageBox.Show($"Found {result.Entities.Count} accounts");
                    }
                }
            });
        }

        /// <summary>
        /// This event occurs when the plugin is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPluginControl_OnCloseTool(object sender, EventArgs e)
        {
            // Before leaving, save the settings
            SettingsManager.Instance.Save(GetType(), mySettings);
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

        private void GetAccessTeamTemplates(object sender, EventArgs e)
        {
            dataGridView_AccessTeamTemplates.Rows.Clear();

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Getting Access Team Templates",
                Work = (worker, args) =>
                {
                    var query = new QueryExpression("teamtemplate");
                    query.ColumnSet = new ColumnSet(new string[] {
                        "teamtemplateid",
                        "teamtemplatename",
                        "defaultaccessrightsmask"
                    });

                    args.Result = Service.RetrieveMultiple(query);
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    var result = args.Result as EntityCollection;

                    if (result != null)
                    {
                        result.Entities.ToList().ForEach(template =>
                        {
                            dataGridView_AccessTeamTemplates.Rows.Add(new string[] {
                                template.GetAttributeValue<Guid>("teamtemplateid").ToString(),
                                template.GetAttributeValue<string>("teamtemplatename"),
                                template.GetAttributeValue<int>("defaultaccessrightsmask").ToString(),
                                ((AccessRights)template.GetAttributeValue<int>("defaultaccessrightsmask")).ToString()
                            });
                        });
                    }
                }
            });
        }

        private List<Entity> AcceessTeams;
        private Guid? SelectedTeamTemplateId;
        private string SelectedTeamTemplateName;
        private AccessRights? AccessMask;

        private void GetAccessTeams(object sender, EventArgs e)
        {
            AcceessTeams = null;
            SelectedTeamTemplateId = null;
            SelectedTeamTemplateName = null;
            AccessMask = null;

            dataGridView_AccessTeams.Rows.Clear();           
            textBox_AccessTeamTemplateId.Text = null;
            textBox_AccessMask.Text = null;

            if (dataGridView_AccessTeamTemplates.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select an access team template.", "No access team template selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var teamTemplateId = new Guid((string)dataGridView_AccessTeamTemplates.SelectedRows[0].Cells[0].Value);
            var teamTemplateName = (string)dataGridView_AccessTeamTemplates.SelectedRows[0].Cells[1].Value;
            var accessMask = (AccessRights)(int.Parse((string)dataGridView_AccessTeamTemplates.SelectedRows[0].Cells[2].Value));

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Getting Access Team Templates",
                Work = (worker, args) =>
                {
                    var query = new QueryExpression("team");
                    query.ColumnSet = new ColumnSet(new string[] {
                        "teamid",
                        "name",
                        "regardingobjectid",
                        "teamtemplateid"
                    });

                    var filter = new FilterExpression();
                    filter.AddCondition("teamtemplateid", ConditionOperator.Equal, teamTemplateId);

                    query.Criteria.AddFilter(filter);

                    args.Result = Service.RetrieveMultiple(query);
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    var restult = args.Result as EntityCollection;

                    if (restult != null)
                    {
                        AcceessTeams = restult.Entities.ToList();
                        SelectedTeamTemplateId = teamTemplateId;
                        SelectedTeamTemplateName = teamTemplateName;
                        AccessMask = accessMask;

                        textBox_AccessTeamTemplateId.Text = SelectedTeamTemplateName;
                        textBox_AccessMask.Text = AccessMask.ToString();

                        AcceessTeams.ForEach(team =>
                        {
                            dataGridView_AccessTeams.Rows.Add(new string[] {
                                team.GetAttributeValue<Guid>("teamid").ToString(),
                                team.GetAttributeValue<string>("name"),
                                team.GetAttributeValue<EntityReference>("regardingobjectid").Id.ToString(),
                                team.GetAttributeValue<EntityReference>("regardingobjectid").Name
                            });
                        });
                    }
                }
            });
        }

        private void UpdateAccessTeams(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_AccessTeamTemplateId.Text))
            {
                MessageBox.Show("Please select an access team template and load the access teams.", "No access teams loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var teamTemplateId = new Guid(textBox_AccessTeamTemplateId.Text);

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Updating Access Teams",
                Work = (worker, args) =>
                {
                    var result = new List<ModifyAccessResponse>();

                    AcceessTeams.ForEach(team =>
                    {
                        // Grant the first user delete access to the lead.
                        var request = new ModifyAccessRequest
                        {
                            PrincipalAccess = new PrincipalAccess
                            {
                                AccessMask = AccessMask.Value,
                                Principal = team.ToEntityReference()
                            },
                            Target = team.GetAttributeValue<EntityReference>("regardingobjectid")
                        };

                        var response = (ModifyAccessResponse)Service.Execute(request);

                        result.Add(response);
                    });

                    args.Result = result;
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    var result = args.Result as List<ModifyAccessResponse>;

                    if (result != null)
                    {
                        result.ForEach(response =>
                        {
                        });
                    }
                }
            });
        }

        private void dataGridView_AccessTeams_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView_AccessTeams.ClearSelection();
        }
    }
}