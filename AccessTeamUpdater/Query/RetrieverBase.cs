using Microsoft.Xrm.Sdk;

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
