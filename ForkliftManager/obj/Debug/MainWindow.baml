   M S B A M L   `   `   `  ����J  FForkliftManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:ForkliftManager.MVVM.ViewModelForkliftManager.MVVM.ViewModel  5   	   E'clr-namespace:ForkliftManager.MVVM.ViewForkliftManager.MVVM.View  6H   1clr-namespace:ForkliftManagerForkliftManager  5   	        ForkliftManager.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   B	viewModel,clr-namespace:ForkliftManager.MVVM.ViewModel     5   	   8view'clr-namespace:ForkliftManager.MVVM.View     6H   /localclr-namespace:ForkliftManager     5   	     � Title$  
MainWindow��5	   	   $	��600��6   $	��920��6)    � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5   	    � DataContext 5      2  ,ForkliftManager.MVVM.ViewModel.MainViewModel  5   
   .��5      �� ���#272537 �� CornerRadius$ 20��5      ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5       � RowDefinitions 5      �� 5      $��75 �6    �� 5      .+�5!      �� $��Forklift Manager��6   $��Center=�5"      $��Center=�5#      
�������$��22(�5%      �� 5'      $��1��6   .+�5)      	� $
��Home��6   $��50��5*      
�������$��14(�5,         MenuButtonTheme#��[  5-      	 d� 	IsChecked$
	 TrueY�5.      ��5/      �� *HomeViewCommand+	� 50      $��Place Order��6   $��50��51      
�������$��14(�53      #��[  54      ��55      �� *PlaceOrderViewCommand+	� 56      $��Palletes��6   $��50��57      
�������$��14(�59      #��[  5:      ��5;      �� *PalletListViewCommand+	� 5<      $��Delivery��6   $��50��5=      
�������$��14(�5?      #��[  5@      ��5A      �� *DeliveryViewCommand+5C      �� 5E      $��0��6   $��1��5F      
 �� Stretch$

 Fill=�5G      ��5H      �� 5I       �� Color$ #273045��6&   5K      �� 5L      $��1��6   $��1��5M      $

 Fill=�5N      ��5O      �� 5P      $ #273045��6&   5R      �� 5T      -   5        $��40��5U      $��40��5V      $��Center=�5W      $��Right=�5X      $��0,0,20,0q�5Y      $��1��5Z      $��X��5[      $��20(�5\      
�������
������ 5_      �� 5a      $��1��6   $��1��5b      $��10q�5c      ��5d      �� *CurrentView+5f      5i      5j      