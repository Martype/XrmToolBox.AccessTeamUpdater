using Microsoft.Crm.Sdk.Messages;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace Martype.XrmToolBox.AccessTeamUpdater.Workers
{
    public class UpdateAccessTeamsWorker : WorkerBase
    {
        public UpdateAccessTeamsWorker(PluginControl control)
            : base(control) { }

        public override void DoWork()
        {
            try
            {
                if (!AccessTeamLoaded())
                    return;

                Control.WorkAsync(new WorkAsyncInfo
                {
                    Message = "Updating Access Teams",
                    Work = (worker, args) =>
                    {
                        var result = new List<ModifyAccessResponse>();

                        Control.AcceessTeams.ForEach(team =>
                        {
                            // Grant the first user delete access to the lead.
                            var request = new ModifyAccessRequest
                            {
                                PrincipalAccess = new PrincipalAccess
                                {
                                    AccessMask = Control.SelectedTemplate.AccessRights,
                                    Principal = team.ToEntityReference()
                                },
                                Target = team.RegardingObjectId
                            };

                            var response = (ModifyAccessResponse)Service.Execute(request);

                            result.Add(response);
                        });

                        args.Result = result;
                    },
                    PostWorkCallBack = (args) =>
                    {
                        if (WorkSucceeded(args))
                        {
                            var result = args.Result as List<ModifyAccessResponse>;

                            if (result != null)
                            {
                                result.ForEach(response =>
                                {
                                });
                            }
                        }
                    }
                });
            }
            catch (Exception exception)
            {
                HandleException(exception);
            }
        }

        private bool AccessTeamLoaded()
        {
            var loaded = true;

            if (string.IsNullOrEmpty(Control.textBox_AccessTeamTemplateId.Text))
            {
                loaded = false;
                MessageBox.Show("Please select an access team template and load the access teams.", "No access teams loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return loaded;
        }
    }
}
