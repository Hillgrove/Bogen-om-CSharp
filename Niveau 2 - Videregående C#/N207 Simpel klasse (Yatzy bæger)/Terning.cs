
namespace N207_Simpel_klasse__Yatzy_bæger_
{
    public class Terning
    {
        // Ved .NET Core behøver den ikke være statisk!!
        private static Random rnd = new Random();
        public int værdi;

        public Terning()
        {
            this.værdi = 1;
        }

        public void Skriv()
        {
            Console.Write("[" + this.værdi + "]");
        }

        public void Ryst()
        {
            this.værdi = rnd.Next(1, 7);
        }
    }
}
