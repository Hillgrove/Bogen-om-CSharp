
namespace N208_Linked_liste
{
    public class MyLinkedList
    {
        private Node? _head;

        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = _head;
            _head = newNode;
        }

        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            
            if (_head == null)
            {
                _head = newNode;
                return;
            }

            Node? current = _head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;            
        }

        public void PrintAllNodes()
        {
            Node current = _head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }   
    }
}
