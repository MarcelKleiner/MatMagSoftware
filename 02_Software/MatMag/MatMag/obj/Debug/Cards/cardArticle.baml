   M S B A M L   `   `   `  ����A  =MatMag, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MatMag.CardsMatMag.Cards  5          MatMag.Cards.CardArticle   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:MatMag.Cards     5      $��880.8��5      $��1443.2��6.   .��5      � $��
0,0,0,-0.4q�6   .+�5	   
   � $��0q�6   
�������  � ColumnDefinitions  5
      �� 5      $	��500 �6#   �� 5      $
��407* �6#   �� 5      $
��474* �6#   .+�5      �� -   5         ��Name$ gridSplitter��5      $��0q�61   $��5��6<   �� 5      -   5        $ gridSplitter_Copy��5      $��0q�66   $��5��6A   $��1��6K   � 5      $��0,0,5,0q�6   ���	#FFAFFFEF � RowDefinitions 5      �� 5      $	��205 �6$   �� 5      �� 5      $	��160 �6$   .+�5      � $��0q�6   
�������  5      �� 5      $	��150 �6+   �� 5       5      �� 5      $��40 �6(   �� 5      $��55 �6(   �� 5      $��55 �6(   �� 5       .+�5"      �� -   5         ��Name$ label��5"      $��
Kisten Nr.��6+   $
��Left=�6@   $��10,16,0,13.2q�6[   $��1��6q   $��Center=�6~   $��26��6�   $��61��6�   �� 5#      -   5        $ 
label_Copy��5#      $��Kisten Name��60   $
��Left=�6F   $��10,17.8,0,13.4q�6a   $��2��6y   $��Center=�6�   $��24��6�   $��77��6�   �� 5$      -   5         ��Name$ textBox��5$      $��25��6/   $��150,16,30.2,14.2q�6;   $��1��6U    �� TextWrapping$
 Wrap=�6b   $��Center=�6v   $��Center=�6�   $��2��6�   $	��200��6�   $
��Left=�6�   �� 5%      -   5        $ textBox_Copy��5%      $��25��64   $��150,16.8,30.2,13.4q�6@   $��2��6\   $
 Wrap=�6i   $��Center=�6}   $��Center=�6�   $��2��6�   $
��Left=�6�   $	��200��6�   �� 5&      -   5         ��Name$ 
cmdUserNew��5&      $��Kiste erstellen��61   $��0q�6K   ���	#FF2F7AC4
�������$��1��6�   $��3��6�   $	��120��6�   $��37��6�   $
��Left=�6�   $��Center=�6�   ��6V   Z� 6�   5'      &   System.Windows.Controls.DataGrid  5(      -   5          Name$ dgOrderOverview_Copy��5(      $��10,10.2,10,5.2q�69      HorizontalGridLinesBrush
 �����	   VerticalGridLinesBrush
	 �����
����������	#FFCFCFCF
 K� ZIndex$	
 -13��6�   $��15(�6�      CanUserAddRows .     ColumnHeaderHeight$ 35Q�6�      AlternatingRowBackground
 �����
���   � �� AlternationCount$ 1��6D     RowHeaderWidth$ 80Q�6Y     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6m     AutoGenerateColumns .     CanUserResizeRows .     HeadersVisibility$ Column=�6�  !   EnableColumnVirtualization .    EnableRowVirtualization .  $��1��6   � 	Resources 5)      *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value �� Color=  7System.Windows.Controls.Primitives.DataGridColumnHeader)  #System.Windows.Controls.DataGridRow��%�  '        (�� �     55   *   * SystemColors.HighlightBrushKey+)'  �     '  �    '      �� 5*      "  6     5+      P� 5,   "    �@ 
IsSelected . . �5-   &   ��  � �� �	#FFD3D3D36C   �� 5.   &    � �� �	#FFD3D3D36D   5/   #   51      �� 55      $ 	#FF8090F7��6\   �� 56      "  6    .�57      ��  � ��
 ���� 6;   �� 58       � ��$ 0.5,0.5,1,1q�6@   �� 59       � �� �	#FFD3D3D36<   �� 5:       � ��
 �   �6;   �� 5;       � ��$ 35��67   5<      �� 5=      "  6    .�5>      ��  � ��
 ���� 6;   5?      �� 5@      "  6    .�5A      ��  � �� �	#FF80B6F76<   �� 5B       � ��$ 1,1,1,1q�6@   5C      5D         Columns 5F      0  *System.Windows.Controls.DataGridTextColumn  5G      ,  &System.Windows.Controls.DataGridColumn   Header$ Bestell Nr.��6c       Width$	  100 6x   1  +System.Windows.Controls.DataGridBoundColumn!   Binding! 6-   Z� "   ClipboardContentBinding" 6@   Z� 6x     5H      $ Datum Fassung��6c   $	  150 6z   ! 6-   Z� " 6@   Z� 6z     5I      $ Datum Rückgabe��6c   $	  100 6{   ! 6-   Z� " 6@   Z� 6{     5J      $ Bestellstatus��6c   $	  200 6z   ! 6-   Z� " 6@   Z� 6z   .@�5L      �� $��10��6   $��10��6)   $��Center=�64   �� 5M      �� 5N      �� 5O      5Q      � 5R      $��0q�6   $��2��6"   
������� 5S      �� 5T      �� 5U      .+�5W      �� -	   5        $ cmdUserNew_Copy��5W      $��Kiste erstellen��66   $��338,25,0,18q�6P   ���	#FF2F7AC4
�������$	��120��6�   $��37��6�   $
��Left=�6�   $��Center=�6�   ��6e   Z� 6�   �� 5X      -
   5        $ cmdUserNew_Copy1��5X      $��Kiste erstellen��67   $��167,25,0,18q�6Q   ���	#FF2F7AC4
�������$	��120��6�   $��37��6�   $
��Left=�6�   $��Center=�6�   ��6f   Z� 6�   �� 5Y      -   5        $ cmdUserNew_Copy2��5Y      $��Kiste erstellen��67   $��167,22,0,21q�6Q   ���	#FF2F7AC4
�������$	��120��6�   $��37��6�   $
��Left=�6�   $��Center=�6�   $��1��6�   ��6f   Z� 6�   �� 5Z      -   5        $ cmdUserNew_Copy3��5Z      $��Kiste erstellen��67   $��338,22,0,21q�6Q   ���	#FF2F7AC4
�������$	��120��6�   $��37��6�   $
��Left=�6�   $��Center=�6�   $��1��6�   ��6f   Z� 6�   5[      5\      � 5]      $��0,0,5,0q�6   ���	#FFAFFFEF$��1��6;    5^      �� 5_      $	��205 �6$   �� 5`      �� 5a      $	��160 �6$   .+�5c      � $��0q�6   
�������  5d      �� 5e      $	��150 �6+   �� 5f       5h      �� 5i      $��40 �6(   �� 5j      $��55 �6(   �� 5k      $��55 �6(   �� 5l      .+�5n      �� -   5        $ label1��5n      $��
Kisten Nr.��6,   $
��Left=�6A   $��10,16,0,13.2q�6\   $��1��6r   $��Center=�6   $��26��6�   $��61��6�   �� 5o      -   5        $ label_Copy1��5o      $��Kisten Name��61   $
��Left=�6G   $��10,17.8,0,13.4q�6b   $��2��6z   $��Center=�6�   $��24��6�   $��77��6�   �� 5p      -   5        $ textBox1��5p      $��25��60   $��150,16,30.2,14.2q�6<   $��1��6V   $
 Wrap=�6c   $��Center=�6w   $��Center=�6�   $��2��6�   $	��200��6�   $
��Left=�6�   �� 5q      -   5        $ textBox_Copy1��5q      $��25��65   $��150,16.8,30.2,13.4q�6A   $��2��6]   $
 Wrap=�6j   $��Center=�6~   $��Center=�6�   $��2��6�   $
��Left=�6�   $	��200��6�   �� 5r      -   5        $ cmdUserNew1��5r      $��Kiste erstellen��62   $��0q�6L   ���	#FF2F7AC4
�������$��1��6�   $��3��6�   $	��120��6�   $��37��6�   $
��Left=�6�   $��Center=�6�   ��6W   Z� 6�   5s        5t      -   5        $ dgOrderOverview_Copy1��5t      $��10,10.2,10,5.2q�6:   
 �����
	 �����
����������	#FFCFCFCF$	
 -13��6�   $��15(�6�    .  $ 35Q�6�   
 �����
���   �$ 1��6E  $ 80Q�6Z  $ SizeToHeader 6n   .   .  $ Column=�6�   .  .  $��1��6   5u      ��%�  '        (�� �     5�   *   * SystemColors.HighlightBrushKey+)'  �     '  �    '      �� 5v      "  6     5w      P� 5x   "    �@ 
IsSelected . . �5y   &   ��  � �� �	#FFD3D3D36C   �� 5z   &    � �� �	#FFD3D3D36D   5{   #   5}      �� 5�      $ 	#FF8090F7��6\   �� 5�      "  6    .�5�      ��  � ��
 ���� 6;   �� 5�       � ��$ 0.5,0.5,1,1q�6@   �� 5�       � �� �	#FFD3D3D36<   �� 5�       � ��
 �   �6;   �� 5�       � ��$ 35��67   5�      �� 5�      "  6    .�5�      ��  � ��
 ���� 6;   5�      �� 5�      "  6    .�5�      ��  � �� �	#FF80B6F76<   �� 5�       � ��$ 1,1,1,1q�6@   5�      5�       5�        5�      $ Bestell Nr.��6c   $	  100 6x   ! 6-   Z� " 6@   Z� 6x     5�      $ Datum Fassung��6c   $	  150 6z   ! 6-   Z� " 6@   Z� 6z     5�      $ Datum Rückgabe��6c   $	  100 6{   ! 6-   Z� " 6@   Z� 6{     5�      $ Bestellstatus��6c   $	  200 6z   ! 6-   Z� " 6@   Z� 6z   .@�5�      �� $��10��6   $��10��6)   $��Center=�64   �� 5�      �� 5�      �� 5�      5�      � 5�      $��0q�6   $��2��6"   
������� 5�      �� 5�      �� 5�      .+�5�      �� -   5        $ cmdUserNew_Copy4��5�      $��Kiste erstellen��67   $��338,25,0,18q�6Q   ���	#FF2F7AC4
�������$	��120��6�   $��37��6�   $
��Left=�6�   $��Center=�6�   ��6f   Z� 6�   �� 5�      -   5        $ cmdUserNew_Copy5��5�      $��Kiste erstellen��67   $��167,25,0,18q�6Q   ���	#FF2F7AC4
�������$	��120��6�   $��37��6�   $
��Left=�6�   $��Center=�6�   ��6f   Z� 6�   �� 5�      -   5        $ cmdUserNew_Copy6��5�      $��Kiste erstellen��67   $��167,22,0,21q�6Q   ���	#FF2F7AC4
�������$	��120��6�   $��37��6�   $
��Left=�6�   $��Center=�6�   $��1��6�   ��6f   Z� 6�   �� 5�      -   5        $ cmdUserNew_Copy7��5�      $��Kiste erstellen��67   $��338,22,0,21q�6Q   ���	#FF2F7AC4
�������$	��120��6�   $��37��6�   $
��Left=�6�   $��Center=�6�   $��1��6�   ��6f   Z� 6�   5�      5�      � 5�      $��0q�6   ���	#FFAFFFEF$��2��65    5�      �� 5�      $	��205 �6$   �� 5�      �� 5�      $	��160 �6$   .+�5�      � $��0q�6   
�������  5�      �� 5�      $	��150 �6+   �� 5�       5�      �� 5�      $��40 �6(   �� 5�      $��55 �6(   �� 5�      $��55 �6(   �� 5�      .+�5�      �� -   5        $ label2��5�      $��
Kisten Nr.��6,   $
��Left=�6A   $��10,16,0,13.2q�6\   $��1��6r   $��Center=�6   $��26��6�   $��61��6�   �� 5�      -   5        $ label_Copy2��5�      $��Kisten Name��61   $
��Left=�6G   $��10,17.8,0,13.4q�6b   $��2��6z   $��Center=�6�   $��24��6�   $��77��6�   �� 5�      -   5        $ textBox2��5�      $��25��60   $��150,16,30.2,14.2q�6<   $��1��6V   $
 Wrap=�6c   $��Center=�6w   $��Center=�6�   $��2��6�   $	��200��6�   $
��Left=�6�   �� 5�      -   5        $ textBox_Copy2��5�      $��25��65   $��150,16.8,30.2,13.4q�6A   $��2��6]   $
 Wrap=�6j   $��Center=�6~   $��Center=�6�   $��2��6�   $
��Left=�6�   $	��200��6�   �� 5�      -   5        $ cmdUserNew2��5�      $��Kiste erstellen��62   $��0q�6L   ���	#FF2F7AC4
�������$��1��6�   $��3��6�   $	��120��6�   $��37��6�   $
��Left=�6�   $��Center=�6�   ��6W   Z� 6�   5�        5�      -   5        $ dgOrderOverview_Copy2��5�      $��10,10.2,10,5.2q�6:   
 �����
	 �����
����������	#FFCFCFCF$	
 -13��6�   $��15(�6�    .  $ 35Q�6�   
 �����
���   �$ 1��6E  $ 80Q�6Z  $ SizeToHeader 6n   .   .  $ Column=�6�   .  .  $��1��6   5�      ��%�  '        (�� �     5�   *   * SystemColors.HighlightBrushKey+)'  �     '  �    '      �� 5�      "  6     5�      P� 5�   "    �@ 
IsSelected . . �5�   &   ��  � �� �	#FFD3D3D36C   �� 5�   &    � �� �	#FFD3D3D36D   5�   #   5�      �� 5�      $ 	#FF8090F7��6\   �� 5�      "  6    .�5�      ��  � ��
 ���� 6;   �� 5�       � ��$ 0.5,0.5,1,1q�6@   �� 5�       � �� �	#FFD3D3D36<   �� 5�       � ��
 �   �6;   �� 5�       � ��$ 35��67   5�      �� 5�      "  6    .�5�      ��  � ��
 ���� 6;   5�      �� 5�      "  6    .�5�      ��  � �� �	#FF80B6F76<   �� 5�       � ��$ 1,1,1,1q�6@   5�      5�       5�        5�      $ Bestell Nr.��6c   $	  100 6x   ! 6-   Z� " 6@   Z� 6x     5�      $ Datum Fassung��6c   $	  150 6z   ! 6-   Z� " 6@   Z� 6z     5�      $ Datum Rückgabe��6c   $	  100 6{   ! 6-   Z� " 6@   Z� 6{     5�      $ Bestellstatus��6c   $	  200 6z   ! 6-   Z� " 6@   Z� 6z   .@�5�      �� $��10��6   $��10��6)   $��Center=�64   �� 5�      �� 5�      �� 5�      5�      � 5�      $��0q�6   $��2��6"   
������� 5�      �� 5�      �� 5�      .+�5�      �� -   5        $ cmdUserNew_Copy8��5�      $��Kiste erstellen��67   $��338,25,0,18q�6Q   ���	#FF2F7AC4
�������$	��120��6�   $��37��6�   $
��Left=�6�   $��Center=�6�   ��6f   Z� 6�   �� 5�      -   5        $ cmdUserNew_Copy9��5�      $��Kiste erstellen��67   $��167,25,0,18q�6Q   ���	#FF2F7AC4
�������$	��120��6�   $��37��6�   $
��Left=�6�   $��Center=�6�   ��6f   Z� 6�   �� 5�      -   5        $ cmdUserNew_Copy10��5�      $��Kiste erstellen��68   $��167,22,0,21q�6R   ���	#FF2F7AC4
�������$	��120��6�   $��37��6�   $
��Left=�6�   $��Center=�6�   $��1��6�   ��6g   Z� 6�   �� 5�      -    5        $ cmdUserNew_Copy11��5�      $��Kiste erstellen��68   $��338,22,0,21q�6R   ���	#FF2F7AC4
�������$	��120��6�   $��37��6�   $
��Left=�6�   $��Center=�6�   $��1��6�   ��6g   Z� 6�   5�      5�      5�      5�      5�      