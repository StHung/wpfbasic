using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.Models;
namespace WpfApp1.ViewModels
{
    public class MainViewModel: INotifyPropertyChanged
    {
        private MainModel mainModel;

        public event PropertyChangedEventHandler PropertyChanged;

        public MainModel MainModel
        {
            get { return mainModel; }
            set
            {
                mainModel = value;
            }
        }
        public MainViewModel()
        {
            mainModel = new MainModel();
        }
    }
}
