   M S B A M L   `   `   `  ����I  EGuessThePlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:GuessThePlayerGuessThePlayer  5   	   %    GuessThePlayer.CustomMessageBox   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:GuessThePlayer     5   	     � Title$  CustomMessageBox��5   	   $	��250��6"   $	��400��6/    � WindowStartupLocation$ CenterScreen=�5	   	    � WindowStyle$
 None=�5
   	    � AllowsTransparency .  � 
ResizeMode$ NoResize=�5   	   $��18(�5   	   ��5      �� 5   
    �� ImageSource$> 8/GuessThePlayer;component/Resources/Background/qMark.jpg��6   .��5      �  � RowDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $
��0.8* �6   .+�5   
   �� $��0��6   ._�5      �� -   5        $��Naslov��5      
�������$��Center=�6X   $��	10 0 0 20q�6s   $	��180��6�   $��Center=�6�   $��20(�6�   ��6&   �� *Titlee+6�   5      �� 5   
   $��1��6   ._�5      �  5      �� 5      $
��0.8* �6$   �� 5       $
��0.2* �6$   .+�5"      �� -   5        $��Description��5"      $�� ��5#       �� TextWrapping$
 Wrap=�5$      
�������" �� VerticalScrollBarVisibility$
 Auto=�5&      $��Center=�5'      	 �� AcceptsReturn	 . 
 �� 
IsReadOnly
 . $��14(�5*      $��10q�5+      $��10q�5,      �� 5-      -   5        $��1��5-      
���   �$	��100��69   
�������$��OK��6\   $
��10 0q�6~   5.      5/      51      52      