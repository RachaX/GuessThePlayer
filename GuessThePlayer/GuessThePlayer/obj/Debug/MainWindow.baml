   M S B A M L   `   `   `  ����I  EGuessThePlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:GuessThePlayerGuessThePlayer  5   	       GuessThePlayer.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:GuessThePlayer     5   	     � Title$  GuessThePlayer��5   	   $	��350��6    $	��600��6-    � WindowStartupLocation$ CenterScreen=�5	   	    � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�5   	   ��5   
   �� 5   
    �� ImageSource$> 8/GuessThePlayer;component/Resources/Background/qMark.jpg��6   .��5      �  � RowDefinitions 5   
   �� 5      $
��0.1* �6   �� 5      $
��0.9* �6   .+�5      �� -   5        $��welcomeBlock��5      $��0��6,   $#��Dobrodošlli u GuessThePlayer��69   $��24(�6]   $
��Bold"�6k   
�������$��Center=�6�   $	��Top=�6�   � 5      $��Center=�6   $��20,40,20,60q�60   $��1��6E    5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$    � ColumnDefinitions 5      �� 5      $
��Auto �6'   �� 5      $
��Auto �6'   .+�5!      �� -   5        $��sportLbl��5!      $��0��6(   $��0��68   $��Izaberite sport:��6E   $��Center=�6`   $��16(�6{   
�������6�   �� 5"      -   5        $��	sportCBox��5"   1   
�������$��0��6B   $��1��6O   $��5q�6_   $	��120��6j   $��16(�6v   .@�5#      �� -   5        $��footballItem��5#      $��Fudbal��63   �� 5$      -   5        $��basketballItem��5$      $��Kosarka��65   5%      �� 5'      -   5        $��	weightLbl��5'      $��0��6%   $��1��65   $��Izaberite težinu:��6B   $��Center=�6^   $��16(�6y   
�������6�   �� 5(      -   5        $��diffCBox��5(   1   
�������$��1��6A   $��1��6N   $��5q�6^   $	��120��6i   $��16(�6u   .@�5)      �� -   5        $��easyItem��5)      $
��Easy��6/   �� 5*      -	   5        $��
mediumItem��5*      $��Normal��61   �� 5+      -
   5        $��hardItem��5+      $
��Hard��6/   5,      �� 5.      $��2��6    �� Orientation$ Vertical=�6&   $��2��6=   .+�5/      �� -   5        $��startBtn��5/      $��
30,20,30,0q�6)   $��16(�6=   $��Započni igru��6K   
���iii�6y   �� 50      $	��ILI��6   
�������$��Center=�6A   $��16(�6^   $��5q�6l   �� 51      -   5        $��walkBtn��51      
���iii�$��16(�6=   $��	30,0,30,0q�6K   $��Testiraj znanje��6^   6x   52      54      � 56   
   $��Right=�6   $��Bottom=�6+   $��	0,0,10,10q�6F    57      �� 58      $
��Auto �6#   �� 59      $
��Auto �6#    5;      �� 5<      $
��Auto �6    5>      5@      5A      