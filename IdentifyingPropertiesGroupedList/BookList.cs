using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentifyingPropertiesGroupedList
{
    public class BookList : INotifyPropertyChanged
    {
        public string _BookAddress;

        public string BookAddress
        {
            get { return _BookAddress; }
            set
            {
                _BookAddress = value;
                OnPropertyChanged("BookAddress");
            }
        }

        public BookList(string name)
        {
            this.BookAddress = name;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}