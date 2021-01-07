using Martype.XrmToolBox.AccessTeamUpdater.Model;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martype.XrmToolBox.AccessTeamUpdater.Factory
{
    public static class AccessTeamFactory
    {
        public static AccessTeam FromEntity(Entity entity)
        {
            return new AccessTeam()
            {
                Id = entity.Id,
                Name = entity.GetAttributeValue<string>(AccessTeam.Fields.Name),
                RegardingObjectId = entity.GetAttributeValue<EntityReference>(AccessTeam.Fields.RegardingObjectId),
                TeamTemplateId = entity.GetAttributeValue<EntityReference>(AccessTeam.Fields.TeamTemplateId),
            };
        }

        public static List<AccessTeam> FromEntityCollection(EntityCollection entityCollection)
        {
            return entityCollection.Entities.ToList().Select(e => FromEntity(e)).ToList();
        }
    }
}
