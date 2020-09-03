using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace Docs.Utilities
{
    public static class VersionUtilities
    {
        public static string GetVersion()
        {
            return GetVersion(typeof(VersionUtilities).Assembly);
        }

        private static string GetVersion(Assembly assembly)
        {
            if (assembly == null)
            {
                return "?";
            }

            try
            {
                var info = FileVersionInfo.GetVersionInfo(assembly.Location);
                return info.ProductVersion ?? "?";
            }
            catch
            {
                return "?";
            }
        }
    }
}
