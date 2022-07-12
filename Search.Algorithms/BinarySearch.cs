namespace Search.Algorithms
{
    internal class BinarySearch
    {
        public void ExecuteBinarySearch()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };

            //The array needs to be sorted in ascending order to work as expected
            Console.WriteLine(BinarySeachReturnsBool(arr, 5));

            //Built-in function
            var item = Array.BinarySearch(arr, 5);
        }

        private static bool BinarySeachReturnsBool(int[] input, int item)
        {
            int min = 0;
            int max = input.Length - 1; //end of array

            while (min <= max)
            {
                int mid = (min + max) / 2;

                if (item == input[mid])
                    return true;
                else if (item < input[mid])
                    max = mid - 1;
                else
                    min = mid + 1;
            }
            return false;
        }
    }
}