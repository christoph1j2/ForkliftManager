using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForkliftManager.MVVM.Model
{
    class Pallet
    {
        public Pallet(int palletNum, int hallNum, int targetHallNum, string palletSize)
        {
            PalletNumber = palletNum;
            HallNumber = hallNum;
            TargetHallNumber = targetHallNum;
            PalletSize = palletSize;
        }

        public int PalletNumber { get; set; }
        public int HallNumber { get; set; }
        public int TargetHallNumber { get; set; }
        public string PalletSize { get; set; }
    }
}
