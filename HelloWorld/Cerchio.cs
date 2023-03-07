namespace HelloWorld
{
    internal class Cerchio : Figura
    {
        public float Raggio { get; set; }

        public Cerchio(float raggio)
        {
            Raggio = raggio;
        }

        public override double Perimetro()
        {
            return 2 * Raggio * Math.PI;
        }

        public override double Area()
        {
            return MathF.Pow(Raggio, 2) * Math.PI;
        }

    }
}
