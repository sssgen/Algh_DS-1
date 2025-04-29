namespace SecondLevel
{
    public class DoublyNode
    {
        public string Value;
        public DoublyNode Prev;
        public DoublyNode Next;

        public DoublyNode(string value)
        {
            Value = value;
        }
    }

    public class DoublyLinkedList
    {
        private DoublyNode head;
        private DoublyNode tail;

        public bool IsEmpty() => head == null;

        public void AddLast(string value)
        {
            var node = new DoublyNode(value);
            if (IsEmpty())
            {
                head = tail = node;
            }
            else
            {
                tail.Next = node;
                node.Prev = tail;
                tail = node;
            }
        }

        public void Remove(DoublyNode node)
        {
            if (node.Prev != null) node.Prev.Next = node.Next;
            else head = node.Next;

            if (node.Next != null) node.Next.Prev = node.Prev;
            else tail = node.Prev;
        }

        public void Print()
        {
            Console.Write("List: ");
            var current = head;
            while (current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }

        public void MoveEvenToQueue(ThirdLevel.VectorQueue queue)
        {
            var current = head;
            while (current != null)
            {
                var next = current.Next;
                if (int.TryParse(current.Value, out int number) && number % 2 == 0)
                {
                    queue.Enqueue(number);
                    Remove(current);
                }
                current = next;
            }
        }
    }
}