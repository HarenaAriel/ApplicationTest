   M S B A M L   `   `   `  ����  	WpfReCode    WpfReCode.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � WindowState$ Normal=�5   	    � Title$ 
MainWindow��5	   	   $
��1000��6   $
��1920��6-    � DataContext 5
   	   ��  �� Path$
 Main�   Locator �� Source# [  .��5      �  � RowDefinitions 5      �� 5      $��70 �6   �� 5      $��40 �6   �� 5      $��* �6   .+�5      �� $��0��6   ���#CECECE$��0 0 0 1q�60   ._�5      �� $��center=�6   $��Center=�6)   $��25(�5      ��5   F   �� $
 Name�5      5      �� 5      $��1��6   ���#CECECE$��0 0 0 1q�60   ._�5      �  � ColumnDefinitions 5   
   �� 5   
   $	��200 �6   �� 5   
   $��* �6   .+�5       � $��0��6   .+�5!   
   �� $��	Bienvenue��6   $��DemiBold"�6$   $��13(�6:   $��Center=�6H   $��Center=�6c   5"   	   � 5$      $��1��6   $��5 0 5 0q�6   $
��Left=�6.   .+�5%      �� $��30��6   $��30��6   $��0q�5&      ��5'      �� $ ShowAddWindow�.��5(      �� $��Stretch=�6    �� Orientation$ 
Horizontal=�67   .+�5)      '  !MaterialDesignThemes.Wpf.PackIcon  
�������$��15��5*   (   $��15��5+   (   $��Center=�5,   (   	   Kind$		 Add=�5-   (   5.      5/      50   	   52      53      � 55      $��2��6    57      �� 58   
   $	��200 �6   �� 59   
   $��* �6   .+�5<      �� $��0��6   $��5q�6   ���#CECECE$��0 0 1 0q�6@   ._�5>   
   �  5@      �� 5A      $��* �6   �� 5B      $��* �6   .+�5E      �� $��0��6   $ Vertical=�6$   $	��Top=�6;   $��Center=�6S   .+�5G      �� $��0 0 0 0q�6   
 � Cursor$

 Hand��5I      $	��150��5J      ��5H      �� *HomePageView+.��5K      �� $��Stretch=�6   $ 
Horizontal=�69   .+�5L        
�������$
	 Home=�6=   �� 5M      $��8,0,9,0q�5N      $��Stretch=�5O      $��Center=�5P      $��13(�5Q      
�������$
��Home��5S      5T      5U      �� 5W      $��0 5 0 0q�6   $

 Hand��5Y      $	��150��5Z      ��5X      �� *ManagePageView+.��5[      �� $��Stretch=�6   $ 
Horizontal=�69   .+�5\        
�������$	 Settings=�6=   �� 5]      $��8,0,9,0q�5^      $��Stretch=�5_      $��Center=�5`      $��13(�5a      
�������$��Manage��5c      5d      5e      5g      �� 5i      $��1��6   $ Vertical=�6$   $��Bottom=�6;   $��Center=�6V   .+�5k      �� $
��Logo��6   $��18(�6#   $��DemiBold"�61   $��Center=�6G   $��Center=�6b   �� 5l      $��Powered By Ramora��6   $��Center=�60   $��Center=�6K   5n      5q      5s   	   � 5u      $��1��6   .+�5v   
   >� ��6   �� $ CurrentView�6=   5w   	   5y      5{      5|      