﻿using ForkliftManager.Core;
using ForkliftManager.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForkliftManager.MVVM.ViewModel
{
    class DeliverViewModel:ObservableObject
    {
        public ObservableCollection<Pallet> List { get; set; }
        public Pallet SelectedPallet { get; set; }

        public RelayCommand Execute { get; set; }

        public DeliverViewModel()
        {
            List = PalletManager.GetPallets();
            Execute = new RelayCommand(ChangeHall);
        }

        private void ChangeHall(object obj)
        {
            if (SelectedPallet != null)
            {
                SelectedPallet.HallNumber = SelectedPallet.TargetHallNumber;
                SelectedPallet.TargetHallNumber = 0;
            }
        }
    }
}
