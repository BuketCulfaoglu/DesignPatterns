namespace StrategyPattern
{
    public class QuickSort : ISortStrategy
    {
        public void Sort(List<int> list)
        {
            Console.WriteLine("Using Quick Sort");

            QuickSortHelper(list, 0, list.Count - 1);
        }

        private void QuickSortHelper(List<int> list, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(list, low, high);

                QuickSortHelper(list, low, pi - 1);
                QuickSortHelper(list, pi + 1, high);
            }
        }

        private int Partition(List<int> list, int low, int high)
        {
            int pivot = list[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (list[j] < pivot)
                {
                    i++;
                    (list[i], list[j]) = (list[j], list[i]);
                }
            }

            (list[i + 1], list[high]) = (list[high], list[i + 1]);
            return i + 1;
        }
    }
}
