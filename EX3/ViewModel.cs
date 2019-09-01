using Prism.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace EX3
{
    class ViewModel : DispatcherObject , INotifyPropertyChanged
    {
        private bool canexecute = true;
        public DelegateCommand command { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        private string size;
        public string Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                OnPropertyChanged("Size");
            }
        }
        private string url;
        public string Url
        {
            get
            {
                return url;
            }
            set
            {
                url = value;
                OnPropertyChanged("Url");
            }
        }
        public ViewModel()
        {
            Url = "";
            Size = "Please wait...";
            command = new DelegateCommand(Execute, CanExecute);
        }
        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public async void GetSizeFromFile()
        {
            canexecute = false;
            command.RaiseCanExecuteChanged();
            WebRequest webRequest = WebRequest.Create(Url);
            WebResponse response = await webRequest.GetResponseAsync();
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                string text = reader.ReadToEndAsync().ToString();
                Size = text.Length.ToString();
            }
            canexecute = true;
            command.RaiseCanExecuteChanged();
        }
        public void Execute ()
        {
               //GetSizeFromFile();
              SafeInvoke(GetSizeFromFileDispatcher);
        }
        public bool CanExecute ()
        {
            return canexecute;
        }

        public void GetSizeFromFileDispatcher ()
        {
            canexecute = false;
            command.RaiseCanExecuteChanged();
            Task.Run(() =>
            {
                WebRequest webRequest = WebRequest.Create(Url);
                WebResponse response = webRequest.GetResponse();
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string text = reader.ReadToEndAsync().ToString();
                    Size = text.Length.ToString();
                    canexecute = true;
                    command.RaiseCanExecuteChanged();
                }
            });
         
        }

         private void SafeInvoke(Action work)
        {
               if (Dispatcher.CheckAccess())
               {
                   work.Invoke();
                   return;
               }
               this.Dispatcher.BeginInvoke(work);
        
        }
    }
}
