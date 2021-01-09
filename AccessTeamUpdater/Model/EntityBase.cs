using Martype.XrmToolBox.AccessTeamUpdater.Utitlity;
using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using System;

namespace Martype.XrmToolBox.AccessTeamUpdater.Model
{
    abstract public class EntityBase
    {
        public abstract string LogicalName { get; }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public EntityReference ToEntityReference()
        {
            return new EntityReference(LogicalName, Id);
        }

        public string GetRecordUrl(ConnectionDetail detail)
        {
            return UrlUtility.GetRecordUrl(LogicalName, Id, detail);
        }
    }
}
