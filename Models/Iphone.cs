using Newtonsoft.Json;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {

        AppStore store = new AppStore();
    
        public Iphone() : base(){}

        public Iphone(int memoria, string marca, string modelo, bool status) : base()
        {
            this.Memoria = memoria;
            this.Marca = marca;
            this.Modelo = modelo; 
            this.Status = status;
        }

        public Iphone(int numero, string modelo, string marca, int imei, int memoria, int lote, string nome, string config, bool status, List<string> celularesAtivos, List<string> aplicativos) : base()
        {
            this.Modelo = modelo; 
            this.Nome = nome; 
            this.Marca = marca;
            this.Config = config; 
            this.Numero = numero; 
            this.IMEI = imei; 
            this.Memoria = memoria; 
            this.Lote = lote; 
            this.Status = status;
            this.celularesAtivos = celularesAtivos;
            this.aplicativos = aplicativos;
        }   
        // TODO: Sobrescrever o método "InstalarAplicativo"

        public override void MenuAppStore()
        {
            
            Dictionary<string, List<string>> categoriasDeApps = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(store.apps);
            

                Console.Clear();
                Console.WriteLine(
                    $"AppStore: \n\n" +

                    "1 - Apps de Mensagem \n" +
                    "2 - Apps de Musicas \n" +
                    "3 - Apps de Fotos e Videos \n" + 
                    "4 - Apps de Redes Sociais \n" +

                    "\n0 - Voltar \n");

            string opcao = Console.ReadLine();
                
                switch (opcao)
                {
                    case "1":
                    if (categoriasDeApps.ContainsKey("AppsMensagem"))
                    {
                        List<string> AppsMensagem = categoriasDeApps["AppsMensagem"];

                        Console.Clear();
                        Console.WriteLine("Aplicativos de Mensagem: \n");
                        foreach (string app in AppsMensagem)
                        {
                            Console.WriteLine(app);
                        }
                        Console.WriteLine("\nEscreva o nome do aplicativo que deseja instalar \n");
                        
                        string baixarApp = Console.ReadLine();

                        if(AppsMensagem.Contains(baixarApp))
                        {
                            InstalarAplicativo(baixarApp);
                        }
                        else
                        {
                            Console.WriteLine($"Erro ao tentar instalar {baixarApp}!");
                            
                            Console.ReadKey();
                            MenuAppStore();
                        }
                    }
                    break;
                    
                    case "2":
                    if (categoriasDeApps.ContainsKey("AppsMusicas"))
                    {
                        List<string> AppsMusicas = categoriasDeApps["AppsMusicas"];
                        
                        Console.Clear();
                        Console.WriteLine("Aplicativos de Musicas: \n");
                        foreach (string app in AppsMusicas)
                        {
                            Console.WriteLine(app);
                        }
                        Console.WriteLine("\nEscreva o nome do aplicativo que deseja instalar \n");
                        
                        string baixarApp = Console.ReadLine();

                        if(AppsMusicas.Contains(baixarApp))
                        {
                            InstalarAplicativo(baixarApp);
                        }
                        else
                        {
                            Console.WriteLine($"Erro ao tentar instalar {baixarApp}!");
                            
                            Console.ReadKey();
                            MenuAppStore();
                        }
                    }
                    break;
                    
                    case "3":
                    if (categoriasDeApps.ContainsKey("AppsFotosVideos"))
                    {
                        List<string> AppsFotosVideos = categoriasDeApps["AppsFotosVideos"];
                        
                        Console.Clear();
                        Console.WriteLine("Aplicativos de Fotos e Videos: \n");
                        foreach (string app in AppsFotosVideos)
                        {
                            Console.WriteLine(app);
                        }
                        Console.WriteLine("\nEscreva o nome do aplicativo que deseja instalar \n");
                        
                        string baixarApp = Console.ReadLine();

                        if(AppsFotosVideos.Contains(baixarApp))
                        {
                            InstalarAplicativo(baixarApp);
                        }
                        else
                        {
                            Console.WriteLine($"Erro ao tentar instalar {baixarApp}!");
                            
                            Console.ReadKey();
                            MenuAppStore();
                        }
                    }
                    break;

                    case "4":
                    if (categoriasDeApps.ContainsKey("AppsRedesSociais"))
                    {
                        List<string> AppsRedesSociais = categoriasDeApps["AppsRedesSociais"];
                        
                        Console.Clear();
                        Console.WriteLine("Aplicativos de Redes Sociais: \n");
                        foreach (string app in AppsRedesSociais)
                        {
                            Console.WriteLine(app);
                        }
                        Console.WriteLine("\nEscreva o nome do aplicativo que deseja instalar \n");
                        
                        string baixarApp = Console.ReadLine();

                        if(AppsRedesSociais.Contains(baixarApp))
                        {
                            InstalarAplicativo(baixarApp);
                        }
                        else
                        {
                            Console.WriteLine($"Erro ao tentar instalar {baixarApp}!");
                            
                            Console.ReadKey();
                            MenuAppStore();
                        }

                    
                    }
                    break;
                    
                    case "0":
                        Menu(Config);
                    break;

                    default:
                        Console.WriteLine("Opção invalida!");
                        
                        Console.ReadKey();
                        MenuAppStore();
                    break;
                }

       
        
        }
        public override void InstalarAplicativo(string nomeApp)
        {   

                

            Console.Clear();
            Console.WriteLine($"\nInstalando {nomeApp} em seu {Marca} \n");
                
            aplicativos.Add(nomeApp);

            Console.WriteLine(
            
                        $"\n\n - {Marca} de {Nome}: {nomeApp} instalado com sucesso \n" + 
                        "\nPresione qualquer tecla \n");

            string aplicativosInstaladosSerializado = JsonConvert.SerializeObject(aplicativos);
            File.WriteAllText("Aplicativos/aplicativosInstalados.json", aplicativosInstaladosSerializado);
                    
            Console.ReadKey();
            Menu(Config);
                
            
                    
                
            }


        public override void DesinstalarAplicativo()
        {
            Console.Clear();
            Console.WriteLine("\nEscreva o nome do aplicativo que deseja desinstalar \n");
                        
                        string nomeApp = Console.ReadLine();

                        if (aplicativos.Contains(nomeApp))
                        {

                            try
                            {
                                aplicativos.Remove(nomeApp);
                            }
                            catch
                            {
                                    Console.WriteLine($"Erro ao tentar Desinstalar {nomeApp}!");
                                    Console.ReadKey();
                                    DesinstalarAplicativo();
                            }
                            
                        }
                        else
                        {
                                Console.WriteLine($"Erro ao tentar Desinstalar {nomeApp}!");
                                Console.ReadKey();
                                Menu(Config);

                        }


                        Console.WriteLine($"\nDesinstalando {nomeApp} em seu {Marca} \n");
                

                        Console.WriteLine(
            
                                $"\n\n - {Marca} de {Nome}: {nomeApp} desinstalado com sucesso \n" + 
                                
                                "\nPresione qualquer tecla \n");
                                
                        string aplicativosInstaladosSerializado = JsonConvert.SerializeObject(aplicativos);
                        File.WriteAllText("Aplicativos/aplicativosInstalados.json", aplicativosInstaladosSerializado);

                        Console.ReadKey();
                        Menu(Config);
                        
                        
        }
    }
}
