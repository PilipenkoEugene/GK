   M S B A M L   `   `   `  ����A  =LW__18, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:LW__18LW__18  5   	       LW__18.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:LW__18     5   	     � Title$.  (Лабораторная работа 18��5   	   $	��450��6(   $	��800��65   $	��300��5	   	   $	��500��6    � 	Resources 5
       �� 
TargetType �� Property �� Value��%  '��       '� �     �� 5   
   " ��6   .�5      ��  � ��$ 17(�6)   �� 5       � ��$ 0 0 0 0q�6'   �� 5       � ��$ Center=�62   5      �� 5   
   " �6   .�5      ��  � ��$ 10q�6'   �� 5       � ��$ Center=�62   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $	��150��6   �� 5      �� 5      $	��150��6   .+�5   
   � 
�������$��3��6!    � ColumnDefinitions 5      �� 5      �� 5      �� 5      �� 5       .+�5"      � $��0��6   $��40q�6(   .+�5#      �� $
��N = ��6   $��0��6(   �� 5$      -   5         ��Name$ textBoxN��5$      $��0��6,   $��70��6<   5%      � 5&      $��1��6   $��40q�6(   .+�5'      �� $
��K = ��6   $��0��6(   �� 5(      -   5        $ textBoxK��5(      $��0��6,   $��70��6<   5)      � 5*      $��2��6   $��40q�6(   .+�5+      �� $
��x = ��6   $��0��6(   �� 5,      -   5        $ textBoxX��5,      $��0��6,   $��70��6<   5-      � 5.      $��3��6   $��40q�6(   .+�5/      �� $
��y = ��6   $��0��6(   �� 50      -   5        $ textBoxY��50      $��0��6,   $��70��6<   51      52      �� 53   
   $��	MyVar.png��6   $��10q�6#   $	��200��6/   � 54   
   $��2��6    55      �� 56      $	��180��6#   �� 57      .+�59      �� -   5         ��Name$ 
calcButton��59      $��Расчитать��6<   $	��120��5:      $��30��6$   $��17(�63   � 5;      $��1��6   $��Center=�6(   .+�5<      �� $��25(�6   $��SemiBold"�6*   $��Ответ: ��6@   �� 5=      -   5        	 ��Name$	 
textBoxAns��5=      $��25(�60   $��Italic$�6>   5>      5?      5@      5B      