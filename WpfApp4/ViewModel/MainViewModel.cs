using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp4.Commands;

namespace WpfApp4.ViewModel
{
   public class MainViewModel:BaseViewModel
    {
        public AddCommand AddCommand => new AddCommand(this);
        public UpdateCommand UpdateCommand => new UpdateCommand(this);
        public RejectCommand RejectCommand => new RejectCommand(this);
        private int state;
        public int State {
            get
            {
                return state;
            }
            set
            {
                state = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(State)));
            }
        }
    }

}
