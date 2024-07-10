namespace OneSearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }
        /// <summary>
        /// Finds the single element in a sorted array where every element appears twice except for one.
        /// Uses a binary search approach to achieve O(log n) time complexity.
        /// </summary>
        /// <param name="arr">A sorted array of integers where every element appears exactly twice, except for one element which appears only once.</param>
        /// <returns>The single element that appears only once in the array. Returns -1 if no such element is found.</returns>
        public static int findSingle(int[] arr)
        {
            int lower = 0, upper = arr.Length - 1;

            while (lower < upper)
            {
                int mid = (lower + upper) / 2;

                if (mid % 2 == 1) mid--; // Ensure mid is even

                if (arr[mid] == arr[mid + 1])
                {
                    lower = mid + 2;
                }
                else
                {
                    upper = mid;
                }
            }

            // Verify if the single element is found or not
            if (lower == upper && (lower == 0 || arr[lower] != arr[lower - 1]) && (lower == arr.Length - 1 || arr[lower] != arr[lower + 1]))
            {
                return arr[lower];
            }

            return -1;
        }
    }
}
