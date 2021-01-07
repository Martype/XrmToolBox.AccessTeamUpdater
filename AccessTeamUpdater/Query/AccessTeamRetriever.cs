using Martype.XrmToolBox.AccessTeamUpdater.Factory;
using Martype.XrmToolBox.AccessTeamUpdater.Model;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martype.XrmToolBox.AccessTeamUpdater.Query
{
    public class AccessTeamRetriever : RetrieverBase
    {
        public AccessTeamRetriever(IOrganizationService service)
            : base(service) { }

        public List<AccessTeam> GetListByAccessTeamTemplateId(Guid templateId, string fetchXmlFilter = null)
        {
            var query = new QueryExpression(AccessTeam.EntityLogicalName)
            {
                ColumnSet = new ColumnSet(new string[] { 
                    AccessTeam.Fields.TeamId,
                    AccessTeam.Fields.Name,
                    AccessTeam.Fields.RegardingObjectId,
                    AccessTeam.Fields.TeamTemplateId
                })
            };

            var filter = new FilterExpression();
            filter.AddCondition(AccessTeam.Fields.TeamTemplateId, ConditionOperator.Equal, templateId);

            query.Criteria.AddFilter(filter);

            var result = Service.RetrieveMultiple(query);

            return AccessTeamFactory.FromEntityCollection(result);
        }
    }
}
