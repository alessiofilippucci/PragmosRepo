using HelloWorld;

namespace PragmosRepo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Scegli una figura");
            Console.WriteLine("1 - Cerchio");
            Console.WriteLine("2 - Quadrato");

            Metodo1();
            Metodo2();
        }

        private static void Metodo1()
        {
            if (int.TryParse(Console.ReadLine(), out int type))
            {
                switch (type)
                {
                    case 1:
                        if (float.TryParse(Console.ReadLine(), out float raggio))
                        {
                            var c = new Cerchio(raggio);

                            Console.WriteLine(c.Perimetro());
                        }
                        break;
                    case 2:
                        if (float.TryParse(Console.ReadLine(), out float lato))
                        {
                            var q = new Quadrato(lato);

                            Console.WriteLine(q.Perimetro());
                        }
                        break;
                    default:
                        Console.WriteLine("Not managed");
                        break;
                }
            }
        }

        private static void Metodo2()
        {
            Figura figura = null;

            if (int.TryParse(Console.ReadLine(), out int type))
            {
                switch (type)
                {
                    case 1:
                        if (float.TryParse(Console.ReadLine(), out float raggio))
                            figura = new Cerchio(raggio);
                        break;
                    case 2:
                        if (float.TryParse(Console.ReadLine(), out float lato))
                            figura = new Quadrato(lato);
                        break;
                    default:
                        Console.WriteLine("Not managed");
                        break;
                }
            }

            if(figura != null)
            {
                Console.WriteLine(figura.Perimetro());
            }
        }
    }
}