   M S B A M L   `   `   `  ����D  @Interlock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Interlock	Interlock  5   	       Interlock.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Interlock     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��600��6)   .��5	      �  � RowDefinitions 5   
   �� 5      $
��181* �6   �� 5      $��7* �6   �� 5      $	��29* �6   .+�5   
   �� -   5        $��listview��5      $��0��6#   $��20,20,20,20q�60   ��5      �� 5      .R�5      �  � ColumnDefinitions 5      �� 5      $
��Auto �6/   �� 5      $
��Auto �6/   �� 5      $
��Auto �6/   �� 5      $
��Auto �6/   .+�5      �� $��5q�6;   ��6$   �� *Marka+6;   �� 5      $��5q�6;   $��1��6F   ��6$   �� *Model+6F   �� 5      $��5q�6:   $��2��6E   ��6$   �� *Year+6E   �� 5      $��50��6    $��50��6+   $��5q�6P   $��3��6[   ��67   �� *Photo+6[   5       5!      5#      	� 5%   
   -   5        $��single��5%      $��20��6$   $��Single��60   $��70��6A   
�������$��2��6_   $��160,18,370,20q�6l   	� 5&   
   -   5        $��multi��5&      $��20��6#   $��Multi��6/   $��60��6?   
�������$��2��6^   $��48,18,492,20q�6k   �� 5(   
   -   5        $��2��5(      $��30��6   $��80��6*   $��start��65   $��	500,0,0,0q�6X   �� 5*   
   $��40��6   $��40��6   $��Time:��6(   $��2��68   �� 5+   
   -   5         ��Name$
 time��5+      $��40��6   $	��150��6*   $��	200,0,0,0q�67   $��2��6J   5.      5/      