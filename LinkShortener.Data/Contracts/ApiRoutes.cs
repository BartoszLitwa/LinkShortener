using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkShortener.Data.Contracts
{
    public static class ApiRoutes
    {
        public const string Api = "api/";
        public static class V1
        {
            public const string version = $"{Api}v1/";
            public static class Test
            {
                public const string Controller = $"{version}Test/";
            }
        }
    }
}
