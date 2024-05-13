using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForkliftManager.MVVM.Model
{
    class Pallet
    {

        public Pallet(int palletNumber, int hallNumber, int targetHall, string palletSize)
        {
            PalletNumber = palletNumber;
            HallNumber = hallNumber;
            TargetHall = targetHall;
            PalletSize = palletSize;
        }

        public string PalletSize { get; set; }
        public int PalletNumber { get; set; }
        public int HallNumber { get; set; }
        public int TargetHall { get; set; }
    }
}
