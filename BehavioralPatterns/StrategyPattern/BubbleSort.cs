namespace StrategyPattern
{
    public class BubbleSort : ISortStrategy
    {
        public void Sort(List<int> list)
        {
            Console.WriteLine("Using Bubble Sort");
            int n = list.Count;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        //swap via deconstruction
                        (list[j], list[j + 1]) = (list[j + 1], list[j]);

                        //swap
                        //int temp = list[j];
                        //list[j] = list[j + 1];
                        //list[j + 1] = temp;
                    }

                }
            }
        }
    }
}
