namespace Indkapsling
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Navn = "x";
            Console.WriteLine(p.Navn);
        }
    }

    class Person
    {
        private string navn;

        public string Navn
        {
            get { return navn; }
            set { Navn = value; }
        }
    }
}