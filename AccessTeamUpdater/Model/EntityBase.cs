using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var main = "main.aspx";
            var pageType = "?pagetype=entityrecord";
            var etn = "&etn=" + LogicalName;
            var id = "&id=" + Id;

            return new Uri(new Uri(detail.WebApplicationUrl), main + pageType + etn + id).AbsoluteUri;
        }
    }
}
