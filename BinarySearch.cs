namespace Lab1Alexey {
    public class BinarySearch {
        /**
         * Бинарный поиск в отсортированном массиве.
         * Делим массив пополам до тех пор, пока заданный ключ не будет равен среднему (по индексу) элементу массива
         */
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