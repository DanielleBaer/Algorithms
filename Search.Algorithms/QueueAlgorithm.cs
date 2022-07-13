namespace Search.Algorithms
{
    internal class QueueAlgorithm
    {
        public void ExecuteQueueAlgorithm()
        {
            var queue = new Queue<int>();

            queue.Enqueue(1); //-> first in and first out
            queue.Enqueue(12);
            queue.Enqueue(5);
            queue.Enqueue(26);
            queue.Enqueue(35);
            queue.Enqueue(48);
            queue.Enqueue(3);

            //Removing from the queue in sequence, because the queue works like this:
            //first in, first out (the element)
            while (queue.TryDequeue(out int current))
                Console.WriteLine(current);
        }
    }
}