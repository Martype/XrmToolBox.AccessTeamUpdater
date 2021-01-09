using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Reflection;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace Martype.XrmToolBox.AccessTeamUpdater
{
    // Do not forget to update version number and author (company attribute) in AssemblyInfo.cs class
    // To generate Base64 string for Images below, you can use https://www.base64-image.de/
    [Export(typeof(IXrmToolBoxPlugin)),
        ExportMetadata("Name", "Access Team Updater"),
        ExportMetadata("Description", "XrmToolBox plugin for updating the access rights of access teams."),
        // Please specify the base64 content of a 32x32 pixels image
        ExportMetadata("SmallImageBase64", "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"),
        // Please specify the base64 content of a 80x80 pixels image
        ExportMetadata("BigImageBase64", "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"),
        ExportMetadata("BackgroundColor", "Lavender"),
        ExportMetadata("PrimaryFontColor", "Black"),
        ExportMetadata("SecondaryFontColor", "Gray")]
    public class Plugin : PluginBase
    {
        public override IXrmToolBoxPluginControl GetControl()
        {
            return new PluginControl();
        }

        /// <summary>
        /// Constructor 
        /// </summary>
        public Plugin()
        {
            // If you have external assemblies that you need to load, uncomment the following to 
            // hook into the event that will fire when an Assembly fails to resolve
            // AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(AssemblyResolveEventHandler);
        }

        /// <summary>
        /// Event fired by CLR when an assembly reference fails to load
        /// Assumes that related assemblies will be loaded from a subfolder named the same as the Plugin
        /// For example, a folder named Sample.XrmToolBox.MyPlugin 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        private Assembly AssemblyResolveEventHandler(object sender, ResolveEventArgs args)
        {
            Assembly loadAssembly = null;
            Assembly currAssembly = Assembly.GetExecutingAssembly();

            // base name of the assembly that failed to resolve
            var argName = args.Name.Substring(0, args.Name.IndexOf(","));

            // check to see if the failing assembly is one that we reference.
            List<AssemblyName> refAssemblies = currAssembly.GetReferencedAssemblies().ToList();
            var refAssembly = refAssemblies.Where(a => a.Name == argName).FirstOrDefault();

            // if the current unresolved assembly is referenced by our plugin, attempt to load
            if (refAssembly != null)
            {
                // load from the path to this plugin assembly, not host executable
                string dir = Path.GetDirectoryName(currAssembly.Location).ToLower();
                string folder = Path.GetFileNameWithoutExtension(currAssembly.Location);
                dir = Path.Combine(dir, folder);

                var assmbPath = Path.Combine(dir, $"{argName}.dll");

                if (File.Exists(assmbPath))
                {
                    loadAssembly = Assembly.LoadFrom(assmbPath);
                }
                else
                {
                    throw new FileNotFoundException($"Unable to locate dependency: {assmbPath}");
                }
            }

            return loadAssembly;
        }
    }
}