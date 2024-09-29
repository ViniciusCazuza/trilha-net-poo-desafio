using System.Data;
using System.Reflection;
using Newtonsoft.Json;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public List<int> imei = new List<int>();
        public List<string> aplicativos = new List<string>();
        public List<string> celularesAtivos = new List<string>();

        private string ativo;

        private int _DDD;
        public int DDD { get => _DDD; set => _DDD = value; }
        
        private int _Numero;
        public int Numero { get => _Numero; set => _Numero = value; }

        private string _Marca;
        public string Marca { get => _Marca; set => _Marca = value; }
        private string _Modelo;
        public string Modelo { get => _Modelo; set => _Modelo = value; }
        
        private int _IMEI;
        public int IMEI { get => _IMEI; set => _IMEI = value; }
        
        private int _Lote;
        public int Lote { get => _Lote; set => _Lote = value; }
        
        private int _Memoria;
        public int Memoria { get => _Memoria; set => _Memoria = value; }
        
        private string _Nome;
        public string Nome { get => _Nome; set => _Nome = value; }
        
        private bool _Status;
        public bool Status { get => _Status; set => _Status = value;}

        private string _Config;
        public string Config { get => _Config; set => _Config = value; }

        // TODO: Implementar as propriedades faltantes de acordo com o diagrama ----- FEITO

        public Smartphone()
        {
            // TODO: Passar os parâmetros do construtor para as propriedades
        }
        public Smartphone(int numero, string modelo, int imei, int memoria, int lote, string nome, string config, bool status) : base()
        {
            this.Modelo = modelo; 
            this.Nome = nome; 
            this.Config = config; 
            this.Numero = numero; 
            this.IMEI = imei; 
            this.Memoria = memoria; 
            this.Lote = lote; 
            this.Status = status;
            // TODO: Passar os parâmetros do construtor para as propriedades ----- FEITO
        }


        public void Ligar()
        {
            Console.Clear();
            Console.WriteLine("Ligando... \n");
            Console.ReadKey();
            Console.WriteLine(".\n.\n.\n.Ligação encerrada");
            Console.ReadKey();

            Menu(_Config);

        }

        public void ReceberLigacao()
        {
            Console.Clear();
            Console.WriteLine("Recebendo ligação...");
            Console.ReadKey();
            Console.WriteLine(".\n.\n.\n.Ligação encerrada");
            Console.ReadKey();

            Menu(_Config);
        }


        public void Editar()
        {
            Console.Clear();
            Console.WriteLine("Configuração: \nDigite o seu novo nome: \n\n");
            
            Nome = Console.ReadLine();

            if (Nome == "" || Nome == null)
            {
                Console.WriteLine(
                    "\nInformação invalida: Nome não pode ser vazio\n" +
                    "\nPressione qualquer tecla.");
            
                Console.ReadKey();
                Editar();
            }
            
            Ativacao();

            Console.WriteLine("Configuração: \nNome atualizado com sucesso! \n\n");

            Informacoes();

        }


        public void Informacoes()
        {
            Console.Clear();

            if (celularesAtivos.Any())
            {
                foreach(var item in celularesAtivos)
                    Console.WriteLine(item);
                    AplicativosInstalados();
                
            }
            else 
            {
                Console.WriteLine($"Nenhum {_Marca} ativo encontrado");
                Console.ReadKey();

                Menu(_Config);
            }
        }



        public void AplicativosInstalados ()
        {

            try
            {
                string aplicativosInstaladosDeserializado = File.ReadAllText("Aplicativos/aplicativosInstalados.json");
                List<string> aplicativos = JsonConvert.DeserializeObject<List<string>>(aplicativosInstaladosDeserializado);
            }
            catch
            {
                Console.WriteLine("Erro, não foi possivel Deserializar o Aquivo JSON");
            }

            Console.WriteLine(
                "\n1 - Aplicativos instalados" + 
                $"\n0 - editar nome do {_Marca}"        
                        );

            string opcao = Console.ReadLine();
            

            
            
                switch (opcao)
                {

                    case "1":

                    if (aplicativos.Any())
                    {
                        Console.Clear();
                        foreach ( string ativos in celularesAtivos)
                        {
                            Console.Clear();
                            Console.WriteLine(ativos);
                        }
                        Console.WriteLine($"\nAplicativos instalados: \n");
                        
                        foreach ( string item in aplicativos)
                        {
                            Console.WriteLine(item);
                        }

                        Console.WriteLine($"\n0 - Voltar \n");

                        opcao = Console.ReadLine();

                        switch (opcao)
                        {
                            case "0":
                                Informacoes();
                            break;

                            default:
                                Menu(_Config);
                            break;
                        }


                    }
                    else 
                    {
                        Console.Clear();
                        foreach ( string ativos in celularesAtivos)
                        {
                            Console.WriteLine(ativos);
                        }
                        Console.WriteLine("\nNenhum aplicativo instalado \n");
                        
                        Console.WriteLine($"\n0 - Voltar \n");

                        opcao = Console.ReadLine();

                        switch (opcao)
                        {
                            case "0":
                                Informacoes();
                            break;

                            default:
                                Menu(_Config);
                            break;
                        }
                    }
                    break;

                    
                    case "0":
                        Editar();
                    break;

                    
                    default:
                        Menu(_Config);
                    break;


                }
        }


        public void Configuracao()
        {
        Random random = new Random();

            if ( Lote <= 5 )
            {
                Lote = 01;
            }
            else if ( Lote > 5 && Lote <= 10 )
            {
                Lote = 02;
            }

            IMEI = random.Next(100000, 999999);

            Console.Clear();
            Console.WriteLine($"Olá sejá bem vindo a primeira configuração do seu {_Marca} vamos lá! \n\n" +
                "Pressione qualquer tecla" 
                );

            Console.ReadKey();


            Console.Clear();
            Console.WriteLine(
                $"Configuração: \n\n" +
                $"Seu IMEI é {IMEI}-{Lote.ToString("00")} \n\n" +
                "Pressione qualquer tecla" 
                );
            

            Console.ReadKey();


            Console.Clear();
            Console.WriteLine( 
                $"Configuração: \n\n" +
                $"Escolha um nome para o seu {_Marca}: \n\n" 
                );
            
                Nome = Console.ReadLine();
            
                while (Nome == "" || Nome == null)
                {
                    Console.WriteLine(
                    $"Informação invalida: Nome não pode ser vazio \n" +
                    "\nDigite novamente \n");

                    Nome = Console.ReadLine();

                }

                

            
            
            Console.Clear();
            Console.WriteLine(
                $"Configuração: \n\n" +
                $"Ótimo {_Marca} de {Nome} Configurado! \n\n" +
                "Pressione qualquer tecla" 
                );

            Console.ReadKey();


            Console.Clear();
            Console.WriteLine(
                $"Configuração: \n\n" +
                "Agora vamos configurar seu número de Celular: \n\n" +
                "Digite seu DDD ():" 
                );

            try 
            {
                DDD = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                while (DDD == 0)
                {
                    Console.WriteLine(
                    $"Informação invalida: Número de DDD não pode ser vazio \n" +
                    "\nDigite novamente \n");

                    try 
                    {
                        DDD = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        
                        Console.WriteLine(
                        $"Informação invalida: Número de DDD não pode ser vazio \n" +
                        "\nPressione qualquer tecla. \n");

                        Console.ReadKey();

                        Menu(_Config);

                    

                    }

                }

            }



            Numero = random.Next(900000000, 999999999);

            Console.Clear();
            Console.WriteLine(
                $"Configuração: \n\n" +
                $"Prontinho, seu número de Celular é ({_DDD.ToString("00")}) {_Numero.ToString("00000-0000")} \n\n" + 
                "Configuração concluida! \n" +
                "Pressione qualquer tecla" 
                );
            
            Console.ReadKey();


            Ativacao();

            var celularesAtivosSerializado = JsonConvert.SerializeObject(celularesAtivos);
            File.WriteAllText("Aplicativos/celularesAtivos.json", celularesAtivosSerializado);

            Menu(_Config);
 
        }


        public void Ativacao()
        {
            
            _Status = true;

            Config = "Configurado";

            ativo =  $"Informações do {_Marca} de {_Nome}: \n\n" +
                        
                        $"Modelo: {_Marca} {_Modelo} \n" +
                        $"Memoria: {_Memoria}GB \n" +
                        $"Numero: ({_DDD.ToString("00")}) {_Numero.ToString("00000-0000")} \n" +
                        $"IMEI: {_IMEI}-{_Lote.ToString("00")}\n" +
                        $"Status: {_Config} \n";
            
            if (imei.Contains(_IMEI))
            {
                celularesAtivos[0] = ativo;
            }
            else
            {
                celularesAtivos.Add(ativo);
                imei.Add(_IMEI);
            }
        }



         public void Menu (string config)
        {
            try 
            {
                string celularesAtivosDeserializado = File.ReadAllText("Aplicativos/celularesAtivos.json");
                List<string> celularesAtivos = JsonConvert.DeserializeObject<List<string>>(celularesAtivosDeserializado);
            }
            catch{}

            
            
            Console.Clear();
            Console.WriteLine(
                $"Menu: \n\n" +
                
                $"1 - Ativar {Marca} \n" +
                "2 - Instalar Aplicativos \n" +
                "3 - Desinstalar Aplicativos \n" +
                "4 - Informações Gerais \n" +
                "5 - Ligar \n" +
                "6 - Receber Ligação \n" +
                
                
                "\n0 - Desligar \n"
            
            );

            string opcao = Console.ReadLine();
            switch (opcao)
            {
                
                case "1":
                if (_Config == "" || _Config == null)
                {
                    Configuracao();
                }
                else
                {
                    Console.WriteLine($"\nVocê já configurou seu {_Marca}. \n");
                    Console.ReadKey();
                    Menu(_Config);
                }
                Console.ReadKey();
                break;
                
                case "2":
                if (_Status != false )
                {
                    if(_Marca == "iPhone")
                    {
                        Smartphone iphone = new Iphone(_Numero, _Modelo, _Marca, _IMEI, _Memoria, _Lote, _Nome, _Config, _Status, celularesAtivos, aplicativos);
                        iphone.MenuAppStore();
                    }
                    else if (_Marca == "Nokia")
                    {
                        Smartphone nokia = new Nokia(_Numero, _Modelo, _Marca, _IMEI, _Memoria, _Lote, _Nome, _Config, _Status, celularesAtivos, aplicativos);
                        nokia.MenuAppStore();
                    }
                }
                else
                {
                    Console.WriteLine($"\nFuncionalidade indisponível, ative seu {_Marca}. \n");
                    Console.ReadKey();
                    Menu(_Config);
                }
                break;
                
                case "3":
                if (_Status == true && aplicativos.Count() == 0)
                {
                    Console.WriteLine("Nenhum aplicativo instalado \n");
                    Console.ReadKey();
                    Menu(_Config);
                }
                else if (_Status == true && aplicativos.Count() != 0 )
                {
                    if(_Marca == "iPhone")
                    {
                        Smartphone iphone = new Iphone(_Numero, _Modelo, _Marca, _IMEI, _Memoria, _Lote, _Nome, _Config, _Status, celularesAtivos, aplicativos);
                        iphone.DesinstalarAplicativo();
                    }
                    else if (_Marca == "Nokia")
                    {
                        Smartphone nokia = new Nokia(_Numero, _Modelo, _Marca, _IMEI, _Memoria, _Lote, _Nome, _Config, _Status, celularesAtivos, aplicativos);
                        nokia.DesinstalarAplicativo();
                    }
                }
                else
                {
                    Console.WriteLine($"\nFuncionalidade indisponível, ative seu {_Marca}. \n");
                    Console.ReadKey();
                    Menu(_Config);
                }
                break;

                case "4":
                Informacoes();
                break;

                case "5":
                if (_Status == true )
                {
                    Ligar();
                }
                else
                {
                    Console.WriteLine($"\nNúmero ainda não configurado, ative seu {_Marca}. \n");
                    Console.ReadKey();
                    Menu(_Config);
                }
                break;
                
                case "6":
                if (_Status == true )
                {
                    ReceberLigacao();
                }
                else
                {
                    Console.WriteLine($"\nNúmero ainda não configurado, ative seu {_Marca}. \n");
                    Console.ReadKey();
                    Menu(_Config);
                }
                break;
                
                case "0":
                Console.Clear();
                Console.WriteLine("Desligando... \n\n");
                
                Console.ReadKey();
                Console.Clear();

                Environment.Exit(0);
                break;

                default:
                Console.WriteLine("Opção invalida!");
                Console.ReadKey();
                
                Menu(_Config);
                break;

            }

            
        }


        public abstract void InstalarAplicativo(string nomeApp);

        public abstract void MenuAppStore ();

        public abstract void DesinstalarAplicativo ();


    }
}