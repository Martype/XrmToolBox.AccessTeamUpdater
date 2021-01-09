using Microsoft.Crm.Sdk.Messages;

namespace Martype.XrmToolBox.AccessTeamUpdater.Model
{
    public class AccessTeamTemplate : EntityBase
    {
        public override string LogicalName => "teamtemplate";

        public const string EntityLogicalName = "teamtemplate";

        public static class Fields
        {
            public const string TeamTemplateId = "teamtemplateid";
            public const string TeamTemplateName = "teamtemplatename";
            public const string DefaultAccessRightsMask = "defaultaccessrightsmask";
        }

        public int DefaultAccessRightsMask { get; set; }
        public AccessRights AccessRights { get; set; }
    }
}