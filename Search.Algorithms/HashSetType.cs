namespace Search.Algorithms
{
    internal class HashSetType
    {
        private static List<int> FindMissingElements(int[] first, int[] second)
        {
            var missingElements = new List<int>();
            var secondArrayItems = new HashSet<int>();

            foreach (int item in second)
                secondArrayItems.Add(item);

            foreach (int item in first)
            {
                if (!secondArrayItems.Contains(item))
                    missingElements.Add(item);
            }
            return missingElements;
        }

        public void ExecuteHashSetType()
        {
            //Will be returned the elements that exist in one array but don't exist in the another one
            FindMissingElements(new int[] { 1, 2, 3, 4 }, new int[] { 2, 4 }).ForEach(Console.WriteLine);

            Console.WriteLine();

            FindMissingElements(new int[] { 3, 2, 8, 4, 5 }, new int[] { 5, 7, 3, 0, 2 }).ForEach(Console.WriteLine);
        }
    }
}