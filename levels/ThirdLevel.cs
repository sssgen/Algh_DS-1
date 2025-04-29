namespace levels.Third
{
    public class VectorQueue
    {
        private int[] data;
        private int front;
        private int rear;
        private int count;

        public VectorQueue(int size)
        {
            data = new int[size];
            front = 0;
            rear = -1;
            count = 0;
        }

        public bool IsFull() => count == data.Length;
        public bool IsEmpty() => count == 0;

        public bool Enqueue(int value)
        {
            if (IsFull()) return false;
            rear = (rear + 1) % data.Length;
            data[rear] = value;
            count++;
            return true;
        }

        public void Print()
        {
            Console.Write("Queue: ");
            for (int i = 0; i < count; i++)
            {
                Console.Write(data[(front + i) % data.Length] + " ");
            }
            Console.WriteLine();
        }
    }
}