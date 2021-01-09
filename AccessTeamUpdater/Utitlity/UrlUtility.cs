using McTools.Xrm.Connection;
using System;

namespace Martype.XrmToolBox.AccessTeamUpdater.Utitlity
{
    public static class UrlUtility
    {
        public static string GetRecordUrl(string logicalName, Guid id, ConnectionDetail detail)
        {
            var mainPage = "main.aspx";
            var pageTypePart = "?pagetype=entityrecord";
            var etnPart = "&etn=" + logicalName;
            var idPart = "&id=" + id;

            return new Uri(new Uri(detail.WebApplicationUrl), mainPage + pageTypePart + etnPart + idPart).AbsoluteUri;
        }
    }
}
