namespace DesafioPOO.Models


{
    public class Compra
    {

        
        public string Modelo { get; set; }
        public int Memoria { get; set; }

        public static void Comprar()
        {
            Console.Clear();
            Console.WriteLine("Escolha um celular: \n\n1 - iPhone \n2 - Nokia \n" );

            string opcaoCelular = Console.ReadLine();

            if ( opcaoCelular == "1")
            {
                Console.Clear();
                Console.WriteLine(
                    "Modelo: \n\n" +
                    "1 - iPhone 16 - 256GB \n" + 
                    "2 - iPhone 16 - 512GB \n");

                    opcaoCelular = Console.ReadLine();
                    
                    if ( opcaoCelular == "1")
                    {
                        Smartphone iphone = new Iphone(memoria: 256, marca: "iPhone", modelo: "16", status: false);
                        iphone.Menu("");
                    }
                    else if ( opcaoCelular == "2")
                    {
                        Smartphone iphone = new Iphone(memoria: 512, marca: "iPhone", modelo: "16", status: false);
                        iphone.Menu("");
                    }
                    else
                    {
                        Console.WriteLine("Opção invalida!");
                        Console.ReadKey();
                        Comprar();
                    }
            }
            else if ( opcaoCelular == "2" )
            {
                Console.Clear();
                Console.WriteLine(
                    "Modelo: \n\n" +
                    "1 - Nokia Max - 128GB \n" + 
                    "2 - Nokia Ultra - 256GB \n");
                        opcaoCelular = Console.ReadLine();
                    
                    if ( opcaoCelular == "1")
                    {
                        Smartphone nokia = new Nokia(memoria: 128, marca: "Nokia", modelo: "Max", status: false);
                        nokia.Menu("");
                    }
                    else if ( opcaoCelular == "2")
                    {
                        Smartphone nokia = new Nokia(memoria: 256, marca: "Nokia", modelo: "Ultra", status: false);
                        nokia.Menu("");
                    }
                    else
                    {
                        Console.WriteLine("Opção invalida!");
                        Console.ReadKey();
                        Comprar();
                    }
            }
            else
            {
                Console.WriteLine("Opção invalida!");
                Console.ReadKey();

                Comprar();
            }
            
        }
    }
}