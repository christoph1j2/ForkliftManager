using ForkliftManager.Core;
using ForkliftManager.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForkliftManager.MVVM.ViewModel
{
    class PlaceOrderViewModel
    {
        public string Size { get; set; }
        public int Hall { get; set; }
        public int TargetHall { get; set; }
        public int Num { get; set; }

        public RelayCommand addPallet { get; set; }

        public PlaceOrderViewModel()
        {
            addPallet = new RelayCommand(AddPallet);
        }

        private void AddPallet(object obj)
        {
            Pallet pallet = new Pallet(Num, Hall, TargetHall, Size);
            PalletManager.addPallet(pallet);
        }
    }
}
