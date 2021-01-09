using Martype.XrmToolBox.AccessTeamUpdater.Factory;
using Martype.XrmToolBox.AccessTeamUpdater.Model;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;

namespace Martype.XrmToolBox.AccessTeamUpdater.Query
{
    public class AccessTeamRetriever : RetrieverBase
    {
        public AccessTeamRetriever(IOrganizationService service)
            : base(service) { }

        public List<AccessTeam> GetListByAccessTeamTemplateId(Guid templateId, string fetchXmlFilter = null)
        {
            var fetchXml = $@"  
               <fetch mapping='logical'>  
                 <entity name='{AccessTeam.EntityLogicalName}'>   
                    <attribute name='{AccessTeam.Fields.TeamId}'/>   
                    <attribute name='{AccessTeam.Fields.Name}'/> 
                    <attribute name='{AccessTeam.Fields.RegardingObjectId}'/> 
                    <attribute name='{AccessTeam.Fields.TeamTemplateId}'/> 
                    <filter type='and'>   
                        <condition attribute='{AccessTeam.Fields.TeamTemplateId}' operator='eq' value='{templateId}' />   
                    </filter>
                    {fetchXmlFilter}
                 </entity>   
               </fetch> ";

            var fetchExpression = new FetchExpression(fetchXml);

            var result = Service.RetrieveMultiple(fetchExpression);

            return AccessTeamFactory.FromEntityCollection(result);
        }
    }
}
