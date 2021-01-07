using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martype.XrmToolBox.AccessTeamUpdater.Query
{
    public abstract class RetrieverBase
    {
        protected IOrganizationService Service;

        public RetrieverBase(IOrganizationService service)
        {
            Service = service;
        }
    }
}
