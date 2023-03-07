namespace HelloWorld
{
    internal class Quadrilatero : Figura
    {
        public float Base { get; set; }
        public float Altezza { get; set; }

        public Quadrilatero(float _base, float altezza)
        {
            Base = _base;
            Altezza = altezza;

            ValuesToPrint.Add("Base", Base.ToString());
            ValuesToPrint.Add("Altezza", Altezza.ToString());
        }

        public override double Area()
        {
            return Base * Altezza;
        }

        public override double Perimetro()
        {
            return (Base + Altezza) * 2;
        }
    }
}
