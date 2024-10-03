
using N208_Linked_liste;

MyLinkedList linkedList = new MyLinkedList();
linkedList.AddLast(1);
linkedList.AddLast(2);
linkedList.AddLast(3);
linkedList.PrintAllNodes();

Console.WriteLine("Indsætter 5 i starten.");
linkedList.AddFirst(5);
linkedList.PrintAllNodes();