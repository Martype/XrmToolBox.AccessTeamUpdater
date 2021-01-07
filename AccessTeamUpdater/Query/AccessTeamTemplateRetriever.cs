using Martype.XrmToolBox.AccessTeamUpdater.Factory;
using Martype.XrmToolBox.AccessTeamUpdater.Model;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System.Collections.Generic;

namespace Martype.XrmToolBox.AccessTeamUpdater.Query
{
    public class AccessTeamTemplateRetriever : RetrieverBase
    {
        public AccessTeamTemplateRetriever(IOrganizationService service)
            : base(service) { }

        public List<AccessTeamTemplate> GetList()
        {
            var query = new QueryExpression(AccessTeamTemplate.EntityLogicalName)
            {
                ColumnSet = new ColumnSet(new string[] {
                    AccessTeamTemplate.Fields.TeamTemplateId,
                    AccessTeamTemplate.Fields.TeamTemplateName,
                    AccessTeamTemplate.Fields.DefaultAccessRightsMask
                })
            };

            var result = Service.RetrieveMultiple(query);

            return AccessTeamTemplateFactory.FromEntityCollection(result);
        }
    }
}
