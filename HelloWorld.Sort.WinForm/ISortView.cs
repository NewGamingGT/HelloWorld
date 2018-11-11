using System;
using System.Collections.Generic;

namespace HelloWorld.Sort.WinForm
{
    public class SortEventArgs : EventArgs
    {
        public SortEventArgs(List<int> numbersToSort)
        {
            NumbersToSort = numbersToSort;
        }
        public List<int> NumbersToSort { get; }
    }
    public interface ISortView
    {
        void DisplayResults(List<int> numbersAfterSort);
        event EventHandler<SortEventArgs> OnSort;
    }
}