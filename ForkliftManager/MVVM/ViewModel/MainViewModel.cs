using ForkliftManager.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForkliftManager.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        //create a command for every window/button
        public RelayCommand CreatePalletCommand { get; set; }
        public RelayCommand PalletListCommand { get; set; }
        public RelayCommand DeliverCommand { get; set; }

        public CreatePalletViewModel CreateVM { get; set; }
        public DeliverViewModel DeliverVM { get; set; }
        public PalletListViewModel ListVM { get; set; }

        public MainViewModel()
        {
            CreateVM = new CreatePalletViewModel();
            CreatePalletCommand = new RelayCommand(o => { CurrentView = CreateVM; });

            DeliverVM = new DeliverViewModel();
            DeliverCommand = new RelayCommand(o => { CurrentView = DeliverVM; });

            ListVM = new PalletListViewModel();
            PalletListCommand = new RelayCommand(o => { CurrentView = ListVM; });
        }

    }
}
