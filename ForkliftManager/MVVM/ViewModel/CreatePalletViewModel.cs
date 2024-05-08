using ForkliftManager.Core;
using ForkliftManager.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForkliftManager.MVVM.ViewModel
{
    class CreatePalletViewModel
    {
        public string Size { get; set; }
        public int Hall { get; set; }
        public int TargetHall { get; set; }
        public int Number { get; set; }

        public RelayCommand addPallet { get; set; }

        public CreatePalletViewModel()
        {
            addPallet = new RelayCommand(palletAdd);
        }
        private void palletAdd(object obj)
        {
            Pallet pallet = new Pallet(Number, Hall, TargetHall, Size);
            PalletManager.addPallet(pallet);
        }
    }
}
