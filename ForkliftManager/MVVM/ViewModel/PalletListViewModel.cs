using ForkliftManager.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForkliftManager.MVVM.ViewModel
{
    class PalletListViewModel
    {
        public ObservableCollection<Pallet> List { get; set; }
        public PalletListViewModel()
        {
            List = PalletManager.GetPallets();
        }
    }
}
