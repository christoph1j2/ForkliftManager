   M S B A M L   `   `   `  ����J  FForkliftManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ForkliftManager.MVVM.ViewForkliftManager.MVVM.View  5      O,clr-namespace:ForkliftManager.MVVM.ViewModelForkliftManager.MVVM.ViewModel  6D   *    $ForkliftManager.MVVM.View.PalletList   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:ForkliftManager.MVVM.View     5      ?local1,clr-namespace:ForkliftManager.MVVM.ViewModel     6D     � DataContext  5	      8  2ForkliftManager.MVVM.ViewModel.PalletListViewModel  5
   
   .��5      � .+�5   
   ��  �� View 5      �� 5      .P�5      ��  �� Width$
 Auto��6%   $��Palettennummer��62    �� DisplayMemberBinding 6J   �� *PalletNumber+�� 5      $
 Auto��6%   $��Hallennummer��62    6H   �� *
HallNumber+�� 5      $
 Auto��6%   $��Zielhallennummer��62    6L   �� *
TargetHall+�� 5      $
 Auto��6%   $��Palettengröße��62    6I   �� *
PalletSize+5      5      5      5      