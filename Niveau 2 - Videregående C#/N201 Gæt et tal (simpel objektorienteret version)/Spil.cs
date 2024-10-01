
namespace N201_Gæt_et_tal__simpel_objektorienteret_version_
{
    public class Spil
    {
        private int _tilfaeldigtTal;

        public void GenerereTilfaeldigtTal()
        {
            Random random = new Random();
            _tilfaeldigtTal = random.Next(1, 101);
        }

        public int HentTalFraBruger()
        {
            Console.WriteLine("Gæt et tal mellem 1 og 100: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public void GivFeedback(int gaettetTal)
        {
            if (gaettetTal < _tilfaeldigtTal)
            {
                Console.WriteLine("For lavt!");
            }
            else if (gaettetTal > _tilfaeldigtTal)
            {
                Console.WriteLine("For højt!");
            }
            else
            {
                Console.WriteLine("Tillykke! Du har gættet rigtigt!");
            }
        }

        public void Start()
        {
            GenerereTilfaeldigtTal();
            int gaettetTal = 0;
            while (gaettetTal != _tilfaeldigtTal)
            {
                gaettetTal = HentTalFraBruger();
                GivFeedback(gaettetTal);
            }
        }
    }
}
