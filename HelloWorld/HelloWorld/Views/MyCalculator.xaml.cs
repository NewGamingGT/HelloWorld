using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyCalculatorPage : ContentPage
	{
		public MyCalculatorPage()
		{
			InitializeComponent ();
		    PlusMinusSign.Text = ((char)0x00B1).ToString();
		    BackSign.Text = ((char)0x2B05).ToString();
		    DivideSign.Text = ((char) 0xF7).ToString();
		    Multiplysign.Text = ((char)0x2A09).ToString();
            MinusSign.Text = ((char)0x2212).ToString();

        }
    }
}