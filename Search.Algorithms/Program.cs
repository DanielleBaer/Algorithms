namespace Search.Algorithms
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var linearSearch = new LinearSearch();
            var binarySearch = new BinarySearch();
            var aggregateArray = new AggregateArray();
            var queueAlgorithm = new QueueAlgorithm();

            Console.WriteLine("--LinearSearch--");

            linearSearch.ExecuteLinearSearch();

            Console.WriteLine("\n--BinarySearch--");

            binarySearch.ExecuteBinarySearch();

            Console.WriteLine("\n--AggregateArray--");

            aggregateArray.ExecuteAggregateArray();

            Console.WriteLine("\n--QueueAlgorithm--");

            queueAlgorithm.ExecuteQueueAlgorithm();
        }
    }
}