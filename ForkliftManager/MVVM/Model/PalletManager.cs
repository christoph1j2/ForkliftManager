using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForkliftManager.MVVM.Model
{
    class PalletManager
    {
        public static ObservableCollection<Pallet> PalletList = new ObservableCollection<Pallet>();

        public static ObservableCollection<Pallet> GetPallets()
        {
            return PalletList;
        }

        public static void removePallet(Pallet pallet)
        {
            PalletList.Remove(pallet);
        }

        public static void addPallet(Pallet pallet)
        {
            PalletList.Add(pallet);
        }
    }
}
