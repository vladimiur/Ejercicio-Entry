using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio_Entry
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            String pasado = e.OldTextValue;
            String nuevo = e.NewTextValue;
        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            String text = ((Entry)sender).Text;
        }
    }
}
