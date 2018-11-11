using System.Diagnostics;

namespace HelloWorld.Sort.WinForm
{
    public class SortPresenter
    {
        public SortPresenter(ISortView view)
        {
            SortView = view;
            SortAlgorithm = new SortAlgorithm();
            SortView.OnSort += SortView_OnSort;
        }

        private void SortView_OnSort(object sender, SortEventArgs e)
        {
            Debug.WriteLine("Sort needed!");
            var sortedNumers = SortAlgorithm.Sort(e.NumbersToSort);
            SortView.DisplayResults(sortedNumers);
        }

        public SortAlgorithm SortAlgorithm { get; set; }
        public ISortView SortView { get; set; }
    }
}