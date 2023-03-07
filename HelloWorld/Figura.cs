namespace HelloWorld
{
    internal abstract class Figura
    {
        public Dictionary<string, string> ValuesToPrint = new Dictionary<string, string>();

        public abstract double Perimetro();
        public abstract double Area();

        public void Stampa()
        {
            foreach (var kvp in ValuesToPrint)
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}
