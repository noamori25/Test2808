using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2808
{
    public class ViewModel : INotifyPropertyChanged
    {
        private Double height;
        public Double HeightBtn
        {
            get
            {
                return this.height;
            }

            set
            {
                height = value;
                OnPropertyChanged("HeightBtn");
            }
        }
        private Double width;
        public Double WidthBtn
        {
            get
            {
                return this.width;
            }

            set
            {
                width = value;
                OnPropertyChanged("WidthBtn");
            }
        }
        private string text;
        public string TextBtn
        {
            get
            {
                return this.text;
            }

            set
            {
                text = value;
                OnPropertyChanged("TextBtn");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged (string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
