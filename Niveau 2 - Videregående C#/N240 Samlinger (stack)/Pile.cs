namespace N240_Samlinger__stack_
{
    public class Pile
    {
        private Stack<Card> _stack = new Stack<Card>();

        public void AddCard(Card card)
        {
            _stack.Push(card);
        }

        public Card RemoveCard()
        {
            return _stack.Pop();
        }

        public void ShowPile()
        {
            foreach (var card in _stack)
            {
                Console.WriteLine(card);
            }
        }
    }
}
