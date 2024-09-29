using Newtonsoft.Json;

namespace DesafioPOO.Models
{
    public class AppStore
    {
        public string apps;


        public AppStore()
        {
            apps = File.ReadAllText("Aplicativos/store.json").Trim();
            Dictionary<string, List<string>> categoriasDeApps = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(apps);
        }
    }
}