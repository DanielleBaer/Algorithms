namespace Search.Algorithms
{
    internal class LinearSearch
    {
        public void ExecuteLinearSearch()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine(LinearSeachReturnsBool(arr, 4));
            Console.WriteLine(LinearSeachReturnsTheElement(arr, 4));

            //C# built-in functions
            //Returns the first element that is equal the specified value
            var element = Array.Find(arr, e => e == 3);

            //Returns all elements that are greater than or equal to 4
            int[] elements = Array.FindAll(arr, e => e >= 4);

            Console.WriteLine("\nElement found: " + element);
            Console.WriteLine("\nElements greater than or equal to 4:");
            Array.ForEach(elements, Console.WriteLine);
        }

        private static bool LinearSeachReturnsBool(int[] input, int n)
        {
            foreach (int i in input)
            {
                if (n == i)
                    return true;
            }
            return false;
        }

        private static int? LinearSeachReturnsTheElement(int[] input, int n)
        {
            foreach (int i in input)
            {
                if (n == i)
                    return n;
            }
            return null;
        }
    }
}