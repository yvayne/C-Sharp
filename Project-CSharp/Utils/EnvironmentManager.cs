using Newtonsoft.Json;
using Project_CSharp.Utils;

namespace Project_CSharp
{
    class EnvironmentManager
    {
        public const string EnvironmentFile = "Environment.json";
        public static Environment GetEnvironment()
        {
            return JsonConvert.DeserializeObject<Environment>(JsonManager.GetJsonInStringFormat(EnvironmentFile));
        }
    }
}
