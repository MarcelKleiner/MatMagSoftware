   M S B A M L   `   `   `  ����A  =MatMag, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MatMag.CardsMatMag.Cards  5          MatMag.Cards.CardAddress   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:MatMag.Cards     5      $��738.6��5      $��1299.2��6.   .��5      � $��
0,0,0,-0.4q�6   .+�5	   
   � -   5          �Name$  gridOrderPreparation��5	      $��0q�6-   
������� � ColumnDefinitions 5
      �� 5      $	��79* �6#   �� 5      $
��121* �6#   .+�5      � -   5        $  overviewGrid��5      
������� � RowDefinitions 5      �� 5      $��50 �6$   �� 5      �� 5      $��60 �6$   .+�5      � $��0q�6   
������� 5      �� 5      $��20 �6+   �� 5      $��50 �6+   �� 5      .+�5      � $��1��6   $��0q�6+   .+�5      �� -   5         ��Name$ image��5       $��15q�6/   $��../Icon/Search_64px.png��6;   5      �� 5      -   5         ��Name$ textBox��5      $��2��6/   $
��0,16q�6?    �� TextWrapping$
 Wrap=�6M   $��	suchen...��6a   $��Center=�6r   
�������$
��Left=�6�   $	��236��6  ��6�   Z� ��6�   Z�  �� SelectionBrush 6�   Z� .��6   � 	Resources 5       �� 
TargetType	 �� Property
 �� Value��%T   '��       �� 5      " ��6$   .�5    "   �� 	 � ��

 ���� 6@   5!      5#      .��6-   5%      �� 5&      $��2��6    
���   �$��1��6=   $��	2,34,10,0q�6H   
���   �$	��Top=�6j   $	��246��6�   $
��Left=�6�   5'      � 5(      $��
40,5,40,35q�6   $��2��6+   
������� 5)      �� 5*      $	��110 �6+   �� 5+      .+�5-      	� -   5         	�Name$ radioButton��5-   "   $��Offene��67   $
��Left=�6H   $��10,3,0,3q�6c   $��Center=�6u   	� 5.      -   5        $ radioButton1��5.   "   $
��Alle��68   $
��Left=�6G   $��0,3,0,0q�6b   $��Center=�6s   $��1��6�    d� 	IsChecked$
 TrueY�6�   $��17��6�   $��51��6�   5/      &   System.Windows.Controls.DataGrid  50      -   5          Name$ dgOrderOverview��50      $��10q�64      HorizontalGridLinesBrush
 �����   VerticalGridLinesBrush
 �����
����������	#FFCFCFCF K� ZIndex$	 -13��6�   $��15(�6�      CanUserAddRows .     ColumnHeaderHeight$ 35Q�6�      AlternatingRowBackground
 �����
���   � �� AlternationCount$ 1��63     RowHeaderWidth$ 80Q�6H     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6\     AutoGenerateColumns .     CanUserResizeRows .     HeadersVisibility$ Column=�6�  !   EnableColumnVirtualization .    EnableRowVirtualization .  $��1��6
   51      *  $System.Windows.Controls.DataGridCell �� Triggers P� Property P� Value �� Color=  7System.Windows.Controls.Primitives.DataGridColumnHeader)  #System.Windows.Controls.DataGridRow��%�  '        (�� �     5>   *   * SystemColors.HighlightBrushKey+)'  �     '  �    '      �� 53      "  6     54      P� 55   "    �@ 
IsSelected . . �56   &   �� 	 � ��
 �	#FFD3D3D36C   �� 57   &   	 � ��
 �	#FFD3D3D36D   58   #   5:      �� 5>      $ 	#FF8090F7��6\   �� 5?      "  6    .�5@      �� 	 � ��

 ���� 6;   �� 5A      	 � ��$
 0.5,0.5,1,1q�6@   �� 5B      	 � ��
 �	#FFD3D3D36<   �� 5C      	 � ��

 �   �6;   �� 5D      	 � ��$
 35��67   5E      �� 5F      "  6    .�5G      �� 	 � ��

 ���� 6;   5H      �� 5I      "  6    .�5J      �� 	 � ��
 �	#FF80B6F76<   �� 5K      	 � ��$
 1,1,1,1q�6@   5L      5N          Columns  5O      0  *System.Windows.Controls.DataGridTextColumn  5P      ,  &System.Windows.Controls.DataGridColumn!   Header$! Anrede��6c   "   Width$	" 100 6s   1  +System.Windows.Controls.DataGridBoundColumn#   Binding# 6-   Z� $   ClipboardContentBinding$ 6@   Z� 6s     5Q      $
! Name��6c   $	" 100 6q   # 6-   Z� $ 6@   Z� 6q     5R      $! Vorname��6c   $	" 130 6t   # 6-   Z� $ 6@   Z� 6t     5S      $! 
Kunden Nr.��6c   $	" 130 6w   # 6-   Z� $ 6@   Z� 6w     5T      $! Organisation��6c   # 6-   Z� $ 6@   Z� 6c   .@�5V      �� 5X      5Y      �� 5Z      -   5        % ��Name$% gridSplitter��5Z      $��1��61   $
��Left=�6A   $��0q�6\   $��10��6g   � 5[      $��1��6   $��4,0,0,0q�6#   
�������.+�5\      � $��0,0,0,17q�6   
������� 5]      �� 5^      $	��300 �6(   �� 5_      $��352.4 �6(   �� 5`      $��70 �6(   .+�5b      � $��	0,0,0.4,0q�6   ���	#FFFBFAFA 5c      �� 5d      $	��100 �6/   �� 5e      $	��200 �6/   �� 5f      $��80 �6/   �� 5g      $	��180 �6/   �� 5h      $
��Auto �6/   $	��129��6<    5j      �� 5k      $��0* �6,   �� 5l      $��50 �6,   �� 5m      $��40 �6,   �� 5n      $��40 �6,   �� 5o      $��40 �6,   �� 5p      $��40 �6,   �� 5q      $��40 �6,   �� 5r      .+�5u      �� -	   5        $ txtCustomerNr��5u   "   $��0,0,30,0q�69   $
 Wrap=�6K   $��Center=�6_   ���	#FFD6D6D6{�.  $��13545��6�   $��1��6�   $��2q�6�   $��1��6�   ��6�   Z� 6�   �� 5v      -
   5        & ��Name$& lblCustomerNr��5v       $��
Kunden Nr.��67   $��20,14,0,9.6q�6L   $��Center=�6a   $��1��6|   $
��Left=�6�   $��90��6�   $��26��6�   �� 5w      -   5        $& lblName��5w       $��Name*��61   $��20,0,0,0q�6A   $��Center=�6S   $��3��6n   $
��Left=�6{   $��77��6�   $��26��6�   �� 5x      -   5        ' ��Name$' cbSalutation��5x   #   $��1��69   $��	0,0,110,0q�6F   $��2��6Y   $��Center=�6f   ( �� 
IsEditable( . $��1��6�   .@�5y      �� -   5        $
��cbi1��5y   +   .��67   Herr6=   �� 5z      -   5        $
��cbi2��5z   +   .��67   Frau6=   5{      �� 5|      -   5        $& lblFirstName��5|       $��Vorname*��66   $��	20,0,10,0q�6I   $��Center=�6\   $��4��6w   �� 5}      -   5        $& lblTelephoneNr��5}       $��Telefon Nr.��68   $��0q�6N   $��Center=�6Y   $��6��6t   $��2��6�   ) J� RenderTransformOrigin$) 0.567,-0.853&�6�   �� 5~      -   5        $& lblPlace��5~       $
��Ort*��62   $��	20,0,10,0q�6A   $��Center=�6T   $��5��6o   �� 5      -   5        $& lblPLZ��5       $
��PLZ*��60   $��0q�6?   $��Center=�6J   $��5��6e   $��2��6r   $) 0.622,-0.706&�6�   $��26��6�   �� 5�      -   5        $& lblEmail��5�       $��E-Mail��62   $��	20,0,10,0q�6C   $��Center=�6V   $��6��6q   $��26��6~   �� 5�      -   5        $& lblOrganisation��5�       $��Organisation*��69   $��0,7.4,0,6.6q�6Q   $��Center=�6f   $��4��6�   $��2��6�   $) 0.622,-0.706&�6�   $��26��6�   �� 5�      -   5        $& lblSalutatino��5�       $��Anrede*��67   $��20,0,0,0q�6I   $��Center=�6[   $��2��6v   $
��Left=�6�   $��77��6�   $��26��6�   �� 5�      -   5        $ txtFirstName��5�   "   $��1��68   $��0,0,30,0q�6H   $��4��6Z   $
 Wrap=�6g   $��Center=�6{   $��22��6�   $��Center=�6�   �� 5�      -   5        $ txtPlace��5�   "   $��1��64   $��0,0,30,0q�6D   $��5��6V   $
 Wrap=�6c   $��Center=�6w   $��22��6�   $��Center=�6�   �� 5�      -   5        $ txtEmail��5�   "   $��1��64   $��0,0,30,0q�6D   $��6��6V   $
 Wrap=�6c   $��Center=�6w   $��22��6�   $��Center=�6�   �� 5�      -   5        $ txtOrganisation��5�   "   $��3��6;   $��0,0,30,0q�6K   $��4��6]   $
 Wrap=�6j   $��Center=�6~   $��22��6�   $��Center=�6�   �� 5�      -   5        $ txtPLZ��5�   "   $��3��62   $��0,0,30,0q�6B   $��5��6T   $
 Wrap=�6a   $��Center=�6u   $��22��6�   $��Center=�6�   �� 5�      -   5        $ txtTelephoneNr��5�   "   $��3��6:   $��0,0,30,0q�6J   $��6��6\   $
 Wrap=�6i   $��Center=�6}   $��22��6�   $��Center=�6�   �� 5�      -   5        $ txtName��5�   "   $��1��63   $��0,0,30,0q�6C   $��3��6U   $
 Wrap=�6b   $��Center=�6v   $��22��6�   $��Center=�6�   5�        5�      -   5        $ dgOrderOverview_Copy��5�      $��10q�6=   
 �����
 �����
����������	#FFCFCFCF$	 -13��6�   $��15(�6�    .  $ 35Q�6�   
 �����
���   �$ 1��6<  $ 80Q�6Q  $ SizeToHeader 6e   .   .  $ Column=�6�   .  .  $��1��6   5�      ��%�  '        (�� �     5�   .   * SystemColors.HighlightBrushKey+)'  �     '  �    '      �� 5�      "  6$    5�   "   P� 5�   &    �@ 
IsSelected . . �5�   *   �� 	 � ��
 �	#FFD3D3D36G   �� 5�   *   	 � ��
 �	#FFD3D3D36H   5�   '   5�      �� 5�      $ 	#FF8090F7��6`   �� 5�      "  6$   .�5�   "   �� 	 � ��

 ���� 6?   �� 5�   "   	 � ��$
 0.5,0.5,1,1q�6D   �� 5�   "   	 � ��
 �	#FFD3D3D36@   �� 5�   "   	 � ��

 �   �6?   �� 5�   "   	 � ��$
 35��6;   5�      �� 5�      "  6$   .�5�   "   �� 	 � ��

 ���� 6?   5�      �� 5�      "  6$   .�5�   "   �� 	 � ��
 �	#FF80B6F76@   �� 5�   "   	 � ��$
 1,1,1,1q�6D   5�      5�        5�        5�      $! Bestell Nr.��6g   $	" 100 6|   # 61   Z� $ 6D   Z� 6|     5�      $! Datum Fassung��6g   $	" 150 6~   # 61   Z� $ 6D   Z� 6~     5�      $! Datum Rückgabe��6g   $	" 100 6   # 61   Z� $ 6D   Z� 6     5�      $! Bestellstatus��6g   $	" 200 6~   # 61   Z� $ 6D   Z� 6~   .@�5�      �� $��10��6!   $��10��6-   $��Center=�68   �� 5�      �� 5�      �� 5�      5�      �� 5�      ���	#FFF4F4F5$��1��61   $��30,0,30.4,0.4q�6<   $��1��6S   
���   �$��Bottom=�6o   � 5�      $��0,0.6,0.4,-0.6q�6   $��2��63   
������� 5�      �� 5�      $	��160 �6/   �� 5�      �� 5�      $	��160 �6/   �� 5�      $	��160 �6/   �� 5�      $	��160 �6/   .+�5�      �� -   5        * ��Name$* cmdUserSave��5�   !   $��	Speichern��66   $��20,10q�6J   ���	#FF2F7AC4
�������$��4��6�   ��6Y   Z� 6�   �� 5�      -   5        $* cmdUserCancel��5�   !   $��	Abbrechen��68   $��20,10q�6L   ���	#FF2F7AC4
�������$��3��6�   ��6[   Z� 6�   �� 5�      -    5        $* 
cmdUserNew��5�   !   $	��Neu��65   $��20,10q�6C   ���	#FF2F7AC4
�������$��2��6�   ��6R   Z� 6�   5�      5�      5�      �� 5�      -!   5        $% gridSplitter1��5�      $��1��62   $
��Left=�6B   $��0q�6]   $��4��6h   5�      5�      5�      