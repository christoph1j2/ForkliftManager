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

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand PlaceOrderViewCommand { get; set; }
        public RelayCommand PalletListViewCommand { get; set; }
        public RelayCommand DeliveryViewCommand { get; set; }


        public HomeViewModel HomeVM { get; set; }
        public PlaceOrderViewModel PlaceOrderVM { get; set; }
        public PalletListViewModel PalletListVM { get; set; }
        public DeliveryViewModel DeliveryVM { get; set; }


        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { 
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            PlaceOrderVM = new PlaceOrderViewModel();
            PalletListVM = new PalletListViewModel();
            DeliveryVM = new DeliveryViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });
            PlaceOrderViewCommand = new RelayCommand(o =>
            {
                CurrentView = PlaceOrderVM;
            });
            PalletListViewCommand = new RelayCommand(o =>
            {
                CurrentView = PalletListVM;
            });
            DeliveryViewCommand = new RelayCommand(o =>
            {
                CurrentView = DeliveryVM;
            });
        }
    }
}
