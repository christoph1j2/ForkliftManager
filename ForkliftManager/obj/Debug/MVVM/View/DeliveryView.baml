   M S B A M L   `   `   `  ����J  FForkliftManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ForkliftManager.MVVM.ViewForkliftManager.MVVM.View  5      O,clr-namespace:ForkliftManager.MVVM.ViewModelForkliftManager.MVVM.ViewModel  6D   ,    &ForkliftManager.MVVM.View.CreatePallet   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:ForkliftManager.MVVM.View     5      ?local1,clr-namespace:ForkliftManager.MVVM.ViewModel     6D     � DataContext  5	      6  0ForkliftManager.MVVM.ViewModel.DeliveryViewModel  5
   
   .��5      � .+�5   
   �� -   5         ��Name$ PalettenAuswahl��5   7   $��50q�6   $	��220��6   $��30��6+   ��6P   �� *List+ �� SelectedItem 6m   �� *SelectedPallet+��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $��Nummer: ��6$   �� 5      
���  ��$��0,0,5,0q�6S   ��6$   �� *PalletNumber+6S   �� 5      $��Von Halle: ��6$   �� 5      
���  ��$��0,0,5,0q�6Q   ��6$   �� *
HallNumber+6Q   �� 5      $
��In: ��6$   �� 5      
���  ��$��0,0,5,0q�6Q   ��6$   �� *
TargetHall+6Q   �� 5      $��	Größe: ��6$   �� 5      
���  ����6$   �� *
PalletSize+6@   5      5      5      �� 5   
   $	��150��6   $��30��6    � Cursor$
 Hand��6)   $��319,296,331,124q�6S   ��67   �� *	Execute+6S   5       5!      