   M S B A M L   `   `   `  ����  PruebaInterfaces*    $PruebaInterfaces.Views.PruebaVentana   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5      � -   5         �Name$ gridVentana��5       � RowDefinitions 5   
   �� 5	      �� 5
      �� 5      �� 5      �� 5      $	��200��6    � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5      .+�5   
   �� -   5         ��Name$ txbNameLabel��5      $��Center=�6*   $��	20 10 0 0q�6E   $��0��6X   $��1��6h   $��CoorX��6u   $��15(�6�   �� 5   
   -   5         ��Name$ txtName��5      $��1��6:   $��1��6J   $��20��6W   $��
20 10 20 0q�6c   $��Center=�6w   ��6#   �� *CoorX+6w   �� 5   
   -   5        $ txbLastNameLabel��5      $��Center=�6.   $��	20 10 0 0q�6I   $��0��6\   $��2��6l   $��CoorY��6y   $��15(�6�   �� 5   
   -   5        $ txtLastName��5      $��1��6>   $��2��6N   $��20��6[   $��
20 10 20 0q�6g   $��Center=�6{   ��6'   �� *CoorY+6{   �� 5   
   -   5         ��Name$ stcpButtons��5       �� Orientation$ 
Horizontal=�6*   $��0��6C   $��3��6S   $��2��6`   $��20 10 20 10 q�6t   .+�5      �� $��Clear��6   $��40��6%   $��60��61   ��6<   �� *ClearCommand+�� 5      $	��Add��6   $��40��6#   $��60��6/   $��10 0 0 0q�6:   ��6L   �� *AddCoordCommand+5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	gridCoord��5      	   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 * 6g   
   CanUserAddRows
 .   �� DisplayMemberPath$ DisplayName��6�   $��0��6�   $��4��6�   $��2��6�   $��20 10 20 50q�6�    �� SelectedIndex 6&   �� *SelectedIndexOfCollection+ �� Mode$ TwoWay=� � 	Resources 5       =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value*  $System.Windows.Controls.DataGridCell��%U  '        '  �     �� 5"      "  6   .�5#      ��  � ��$ center=�6C   �� 5$       � ��$
 Bold"�63   �� 5%       � ��
 �����63   �� 5&       � ��$ 0,0,1,0q�68   �� 5'       � ��
 �   �64   5)      �� 5*      "  6   .�5+      ��  �@��TextAlignment$ Center=�6@   5,      5-      5.      5/      50      