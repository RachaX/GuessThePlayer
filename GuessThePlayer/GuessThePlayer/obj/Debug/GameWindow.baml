   M S B A M L   `   `   `  ����I  EGuessThePlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:GuessThePlayerGuessThePlayer  5   	       GuessThePlayer.GameWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:GuessThePlayer     5   	     � Title$   ��5   	   $	��350��6   $	��600��6    � WindowStartupLocation$ CenterScreen=�5	   	    � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�5   	    � 	Resources 5         AnswerButton �� 
TargetType �� Triggers �� Binding �� Value	 �� Property
 �� Value��%w  &	        �� 5   
   " ��6&    5      �� 5       6   �� *	IsCorrect+ True6<   .a�5      �� 	 � ��

 � � �63   5      �� 5       6   �� *	IsCorrect+	 False6=   .a�5      �� 	 � ��

 �  ��63   5      �� 5       6   �� *	IsCorrect+ 6<   Z� .a�5      �� 	 � ��

 �����63   5      5      5      ��5      �� 5   
    �� ImageSource$> 8/GuessThePlayer;component/Resources/Background/qMark.jpg��6   .��5      �  � RowDefinitions 5   
   �� 5       $	��280 �6   �� 5!      $��* �6   .+�5#   
   ��  �� Orientation$ Vertical=�6   .+�5$      �� $ 
Horizontal=�6   .+�5%      �� 
�������$��16(�6M   $��10 0 0 0q�6[   ��6   �� *Sport+6[   �� 5&      
�������$��16(�6R   $��10 0 0 0q�6`   ��6   �� *
Difficulty+6`   5'      �� 5(      $ 
Horizontal=�6   .+�5)      �� $��
200 45 0 0q�6   $��0q�6-   $��Center=�6B   $��Center=�6_   $	��220��6z   $	��180��6�   ._�5*      �� $��Uniform=�65   $��Center=�6G   $��Center=�6d   ��6   �� *Image+6d   5+      �� 5,      $��
10 220 0 0q�68   $��Right=�6M   $��Center=�6i   $
��Bold"�6�   
���Gc��$��14(�6�   ��6   �� *
TimeLeft+6�   5-      5.      � 51   
   $��1��6    � ColumnDefinitions 52      �� 53      $��* �6#   �� 54      $��* �6#   �� 55      $��* �6#   .+�57      �� -   5        $��answ1��57      ��6"   �� *Options[0].Player.Name+��6M   �� *
Options[0]+��58      �� 59      " ��6   .�5:      �� 	 � ��$
 10 18 10 10q�63   �� 5;      	 � ��$
 14(�65   �� 5<      	 � ��
 64   �� *CheckAnswerCommand+ 5=      �� 5>       6*   �� *Options[0].IsCorrect+ True6S   .a�5?   "   �� 	 � ��

 � � �6?   5@      �� 5A       6*   �� *Options[0].IsCorrect+	 False6S   .a�5B   "   �� 	 � ��

 �  ��6?   5C      �� 5D       6*   �� *Options[0].IsCorrect+ 6S   Z� .a�5E   "   �� 	 � ��

 �����6?   5F      5H      5J      �� 5K      -   5        $��answ2��5K      $��1��6"   ��62   �� *Options[1].Player.Name+��6]   �� *
Options[1]+��5L      �� 5M      " ��6   .�5N      �� 	 � ��$
 10 18 10 10q�63   �� 5O      	 � ��$
 14(�65   �� 5P      	 � ��
 64   �� *CheckAnswerCommand+ 5Q      �� 5R       6*   �� *Options[1].IsCorrect+ True6S   .a�5S   "   �� 	 � ��

 � � �6?   5T      �� 5U       6*   �� *Options[1].IsCorrect+	 False6S   .a�5V   "   �� 	 � ��

 �  ��6?   5W      �� 5X       6*   �� *Options[1].IsCorrect+ 6S   Z� .a�5Y   "   �� 	 � ��

 �����6?   5Z      5\      5^      �� 5_      -   5        $��answ3��5_      $��2��6"   ��62   �� *Options[2].Player.Name+��6]   �� *
Options[2]+��5`      �� 5a      " ��6   .�5b      �� 	 � ��$
 10 18 10 10q�63   �� 5c      	 � ��$
 14(�65   �� 5d      	 � ��
 64   �� *CheckAnswerCommand+ 5e      �� 5f       6*   �� *Options[2].IsCorrect+ True6S   .a�5g   "   �� 	 � ��

 � � �6?   5h      �� 5i       6*   �� *Options[2].IsCorrect+	 False6S   .a�5j   "   �� 	 � ��

 �  ��6?   5k      �� 5l       6*   �� *Options[2].IsCorrect+ 6S   Z� .a�5m   "   �� 	 � ��

 �����6?   5n      5p      5r      5s      5u      5v      