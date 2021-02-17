namespace Lab1Alexey {
    public class QuickSort {
        
        /**
         * Быстрая сортировка.
         * Находим опорный элемент (pivot), далее переставляем все большие элементы в правую часть от этого элемента,
         * А меньшие - в левую. Продолжаем рекурсивно
         */
        public static void sort(int[] arr, int left, int right) {
            if (left < right) {
                int pivot = Partition(arr, left, right);

                if (pivot > 1) {
                    sort(arr, left, pivot - 1);
                }

                if (pivot + 1 < right) {
                    sort(arr, pivot + 1, right);
                }
            }

        }

        /**
         * Вспомогательный метод, который находит опорный элемент, после чего переставляет элементы
         */
        private static int Partition(int[] arr, int left, int right) {
            int pivot = arr[left];
            while (true) {

                while (arr[left] < pivot) {
                    left++;
                }

                while (arr[right] > pivot) {
                    right--;
                }

                if (left < right) {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else {
                    return right;
                }
            }
        }
    }
}