namespace Search.Algorithms
{
    internal class DictionaryType
    {
        private static void DisplayFreqOfEachElement(int[] arr)
        {
            var freqDictionary = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (freqDictionary.ContainsKey(arr[i]))
                    freqDictionary[arr[i]]++;
                else
                    freqDictionary[arr[i]] = 1;
            }

            foreach (KeyValuePair<int, int> x in freqDictionary)
                Console.WriteLine(x.Key + " -> " + x.Value);
        }

        public void ExecuteDictionaryType()
        {
            //Will be returned how many times the elements appeared in the array
            DisplayFreqOfEachElement(new int[] { 3, 0, 2, 4, 7, 3, 4, 5, 7, 6, 7 });
        }
    }
}