using System;
using System.ComponentModel;
using System.Diagnostics;
using Microsoft.Maui.Controls;

namespace Lab1.Pages
{
    public partial class Page3 : ContentPage, INotifyPropertyChanged
    {
        private string _screen = "";
        public string Screen
        {
            get { return _screen; }
            set
            {
                if (_screen != value)
                {
                    _screen = value;
                    OnPropertyChanged(nameof(Screen));
                }
            }
        }

        public Page3()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        private async void AddNumber(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null || Screen.Length >= 12) return;

            // Add the number to the screen
            Screen += btn.Text;

            // Add a space after every 3 numbers
            if (Screen.Length % 4 == 0 && Screen.Length < 12)
            {
                Screen += " ";
            }
        }

        private void Clear(object sender, EventArgs e)
        {
            Screen = "";
            Trace.WriteLine("Welcome C#");
        }

        private void DialUp(object sender, EventArgs e)
        {
            Trace.WriteLine("Welcome C#");
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
