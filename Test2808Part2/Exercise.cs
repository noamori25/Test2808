using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2808Part2
{
   public class Exercise :INotifyPropertyChanged
    {
        private int correctAnswer;
        private int optional1;
        private int optional2;
        private int optional3;

        public int CorrectAnswer
        {
            get
            {
                return correctAnswer;
            }
            set
            {
                correctAnswer = value;
                OnPropertyChanged("CorrectAnswer");
            }
        }

        public int Optional1
        {
            get
            {
                return optional1;
            }
            set
            {
                optional1 = value;
            }
        }

        public int Optional2
        {
            get
            {
                return optional2;
            }
            set
            {
                optional2 = value;
            }
        }

        public int Optional3
        {
            get
            {
                return optional3;
            }
            set
            {
                optional3 = value;
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
