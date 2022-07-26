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
            var stackAlgorithm = new StackAlgorithm();
            var hashSetType = new HashSetType();
            var dictionaryType = new DictionaryType();
            var binaryTreeAlgorithm = new BinaryTreeAlgorithm();

            Console.WriteLine("--LinearSearch--");

            linearSearch.ExecuteLinearSearch();

            Console.WriteLine("\n--BinarySearch--");

            binarySearch.ExecuteBinarySearch();

            Console.WriteLine("\n--AggregateArray--");

            aggregateArray.ExecuteAggregateArray();

            Console.WriteLine("\n--QueueAlgorithm--");

            queueAlgorithm.ExecuteQueueAlgorithm();

            Console.WriteLine("\n--StackAlgorithm--");

            stackAlgorithm.ExecuteStackAlgorithm();

            Console.WriteLine("\n--HashSetType--");

            hashSetType.ExecuteHashSetType();

            Console.WriteLine("\n--DictionaryType--");

            dictionaryType.ExecuteDictionaryType();

            Console.WriteLine("\n--BinaryTreeAlgorithm--");

            binaryTreeAlgorithm.ExecuteBinaryTree();
        }
    }
}