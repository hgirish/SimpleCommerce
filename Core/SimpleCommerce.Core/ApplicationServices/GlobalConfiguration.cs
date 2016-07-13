using System.Collections.Generic;

namespace SimpleCommerce.Core.ApplicationServices
{
    public static class GlobalConfiguration
    {
        static GlobalConfiguration()
        {
            Modules = new List<HvModule>();
        }
        public static string ConnectionString { get; set; }

        public static string ApplicationPath { get; set; }
        public static IList<HvModule> Modules { get; set; }
    }
}