namespace Lab1Alexey {
    public class BinarySearch {
        public static int BinarySearchRecursive(int[] inputArray, int key, int start, int end) {
            if (start <= end) {
                int mid = (start + end) / 2;

                if (key == inputArray[mid])
                    return mid;
                else if (key < inputArray[mid])
                    return BinarySearchRecursive(inputArray, key, start, mid - 1);
                else
                    return BinarySearchRecursive(inputArray, key, mid + 1, end);
            }

            return -1;
        }
    }
}