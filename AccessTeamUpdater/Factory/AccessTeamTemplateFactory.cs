using Martype.XrmToolBox.AccessTeamUpdater.Model;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Martype.XrmToolBox.AccessTeamUpdater.Factory
{
    public static class AccessTeamTemplateFactory
    {
        public static AccessTeamTemplate FromEntity(Entity entity)
        {
            var defaultAccessRightsMask = entity.GetAttributeValue<int>(AccessTeamTemplate.Fields.DefaultAccessRightsMask);

            return new AccessTeamTemplate()
            {
                Id = entity.Id,
                Name = entity.GetAttributeValue<string>(AccessTeamTemplate.Fields.TeamTemplateName),
                DefaultAccessRightsMask = defaultAccessRightsMask,
                AccessRights = (AccessRights)defaultAccessRightsMask
            };
        }

        public static List<AccessTeamTemplate> FromEntityCollection(EntityCollection entityCollection)
        {
            return entityCollection.Entities.ToList().Select(e => FromEntity(e)).ToList();
        }

        public static AccessTeamTemplate FromDataGridViewRow(DataGridViewRow row)
        {
            var teamTemplateId = (Guid)row.Cells["TeamTemplateId"].Value;
            var teamTemplateName = ((HyperLink)row.Cells["TeamTemplateName"].Value).Title;
            var defaultAccessRightsMask = (int)row.Cells["DefaultAccessRightsMask"].Value;
            var accessRights = (AccessRights)row.Cells["AccessRights"].Value;

            return new AccessTeamTemplate()
            {
                Id = teamTemplateId,
                Name = teamTemplateName,
                DefaultAccessRightsMask = defaultAccessRightsMask,
                AccessRights  = accessRights
            };
        }
    }
}
