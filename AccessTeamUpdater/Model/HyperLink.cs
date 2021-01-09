namespace Martype.XrmToolBox.AccessTeamUpdater.Model
{
    public class HyperLink
    {
        public string Title { get; private set; }
        public string Url { get; private set; }

        public HyperLink(string title, string url)
        {
            Title = title;
            Url = url;
        }
    }
}
