using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martype.XrmToolBox.AccessTeamUpdater.Model
{
    public class AccessTeam : EntityBase
    {
        public override string LogicalName => "team";

        public const string EntityLogicalName = "team";

        public static class Fields
        {
            public const string TeamId = "teamid";
            public const string Name = "name";
            public const string RegardingObjectId = "regardingobjectid";
            public const string TeamTemplateId = "teamtemplateid";
        }

        public EntityReference RegardingObjectId { get; set; }

        public EntityReference TeamTemplateId { get; set; }      
    }
}