using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using HelloWorld.Annotations;
using Xamarin.Forms;

namespace HelloWorld.ViewModels
{
    public class MyCalculatorModel: INotifyPropertyChanged
    {
        private string _result = "888";

        public string Result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged();
            }
        }
        public ICommand ClearCommand=>new Command(() => { Result = string.Empty; });
        public string Title { get; set; } = "My Calculator";

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}