using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HelloWorld.Sort.WinForm
{
    public partial class Form1 : Form, ISortView
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            var numToSortString = tbxInput.Text;
            if (!string.IsNullOrEmpty(numToSortString))
            {
                var numbers = numToSortString.Split(' ', ',');
                var numsToSort = new List<int>();
                foreach (var numberString in numbers)
                {
                    int number;
                    if (int.TryParse(numberString, out number))
                    {
                        numsToSort.Add(number);
                    }
                }
                AddDisplay("To Sort:", numsToSort);

                OnSort?.Invoke(this, new SortEventArgs(numsToSort));
            }
        }

        public void DisplayResults(List<int> numbersAfterSort)
        {
            AddDisplay("Sorted", numbersAfterSort); 
        }

        void AddDisplay(string title, List<int> numbers)
        {
            string resultString = string.Empty;
            foreach (var num in numbers)
            {
                resultString += " " + num;
            }

            txtResults.Text += Environment.NewLine + title + ": " +resultString;
        }

        public event EventHandler<SortEventArgs> OnSort;
    }
}
