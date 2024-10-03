
namespace N207_Simpel_klasse__Yatzy_bæger_
{
    public class Bæger
    {
        private Terning[] _bæger = new Terning[5];

        public Bæger()
        {
            for (int i = 0; i < 5; i++)
            {
                _bæger[i] = new Terning();
                Ryst();
            }
        }

        public void Skriv()
        {
            for (int i = 0; i < 5; i++)
            {
                _bæger[i].Skriv();
            }
            Console.WriteLine();
        }

        public void Ryst()
        {
            foreach(Terning t in _bæger)
            {
                t.Ryst();
            }
        }
    }
}
