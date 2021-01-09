using Martype.XrmToolBox.AccessTeamUpdater.Utitlity;
using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;

namespace Martype.XrmToolBox.AccessTeamUpdater.Model
{
    public static class EntityReferenceExtensions
    {
        public static string GetRecordUrl(this EntityReference entityReference, ConnectionDetail detail)
        {
            return UrlUtility.GetRecordUrl(entityReference.LogicalName, entityReference.Id, detail);
        }
    }
}
