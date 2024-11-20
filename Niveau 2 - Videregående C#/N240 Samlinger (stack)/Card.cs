namespace N240_Samlinger__stack_
{
    public class Card
    {
        public string Suit { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return $"{Value} of {Suit}";
        }
    }
}
