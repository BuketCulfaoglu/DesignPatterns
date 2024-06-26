namespace StrategyPattern
{
    internal class SortContext
    {
        private ISortStrategy _sortStrategy;

        public void SetSortStrategy(ISortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void SortList(List<int> list)
        {
            _sortStrategy.Sort(list);
        }
    }
}
