﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp4.ViewModel;

namespace WpfApp4.Commands
{
    public class AddCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public MainViewModel MainViewModel { get; set; }
        public AddCommand(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (MainViewModel.State == 1)
            {
                MainViewModel.State = 2;
            }
            else
            {

                MainViewModel.State = 1;
            }

        }
    }
}
