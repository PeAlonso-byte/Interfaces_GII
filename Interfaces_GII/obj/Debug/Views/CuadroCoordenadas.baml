   M S B A M L   `   `   `  ����I  EInterfaces_GII, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Interfaces_GIIInterfaces_GII  5   	   ,    &Interfaces_GII.Views.CuadroCoordenadas   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   .localclr-namespace:Interfaces_GII     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3e+http://schemas.microsoft.com/xaml/behaviors  5   	     � Icon$  ../Resources/icono.ico��5   	    � Title$ Coordenadas��5   	   $	��450��6   $	��800��6*   $	��450��66   $	��800��6F   .��5      � -   5         �Name$ gridVentana��5       ���#3a3d57 � RowDefinitions 5	   
   �� 5
      $��* �6   �� 5      $
��auto �6   .+�5   
   �� -   5         ��Name$ TestTabs��5      $��0��5      $��0q�5       �� TabStripPlacement$	 Top=�5       �� SelectedIndex 5      �� *SelectedTab+.@�5      �� 
������ ��5      �� 5      $��50��6   $��../Resources/tabla2.png��6'   .��5      � -   5        $ 
gridManual��5   ,   ���#3a3d57 5      �� 5      $
��auto �6(   �� 5      $��* �6(   .+�5      �� $��0��6!   $��Center=�6.    �� Orientation$ 
Horizontal=�6K   .+�5      �  5       �� 5!   "   $
��auto �60   �� 5"   "   $
��auto �60    � ColumnDefinitions 5$      �� 5%   "   $
��auto �63   �� 5&   "   $
��auto �63   .+�5)      �� -   5        	 ��Name$	 xText��5)   (   $	��X: ��67   $��0��6B   $��0��6O   
�������$
��Left=�6r   $��10q�6�   �� 5*      -   5        
 ��Name$
 xTextBox��5*   &   $��0��68   $��1��6E   $��Right=�6U   $��10q�6q   $��50��6}    J� 	AllowDrop .  ��6�   �� *CoorX+�� 5,      -   5        $	 yText��5,   (   $	��Y: ��67   $��1��6B   $��0��6O   
�������$
��Left=�6r   $��10q�6�   �� 5-      -   5        $
 yTextBox��5-   &   $��1��68   $��1��6E   $
��Left=�6V    .  $��50��6�   $��10q�6�   ��6�   �� *CoorY+5.      �� 5/      -   5         ��Name$ 	btnAnadir��5/   !   $��Añadir��64   ���#53577d$
��10 7q�6~   $��25 10q�6�   
�������
���������6E   �� *AddCoordCommand+6�   50      &   System.Windows.Controls.DataGrid  51      -	   5          Name$ 	gridCoord��51         SelectionUnit$
 Cell=�6h      SelectionMode$ Single=�6}      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�      CanUserAddRows .  $��1��6�   $��10 10q�6�      AlternatingRowBackground
 ��ح� �� AlternationCount$ 2��6�   ���#53577d   AutoGenerateColumns .  ��62   ��  �� Path$ Coordenadas� �� Mode$ TwoWay=� � 	Resources 52      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value*  $System.Windows.Controls.DataGridCell��%U  '        '  �     �� 53      "  6$   .�54   "   ��  � ��$ center=�6O   �� 55   "    � ��$
 Bold"�6?   �� 56   "    � ��
 �����6?   �� 57   "    � ��$ 0,0,1,0q�6D   �� 58   "    � ��
 �   �6@   59      �� 5:      "  6$   .�5;   "   ��  �@��TextAlignment$ Center=�6L   5<      5=         Columns 5>      0  *System.Windows.Controls.DataGridTextColumn  5?      ,  &System.Windows.Controls.DataGridColumn   Header$ CoorX��61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� *CoorX+  5@      $ CoorY��61    6@   �� *CoorY+*  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5B      +	  %Microsoft.Xaml.Behaviors.EventTrigger	  5C       	  	EventName$ CellEditEnding��6-   *
  $Microsoft.Xaml.Behaviors.TriggerBase  
  Actions.  5D   "   2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction  !   Command! 68   �� *GridCellEditEndingCommand+5E      5G      5I      5J      �� 5N      
������ 
���������5O      �� 5P      $��50��6   $ ��../Resources/function2.png��6'   .��5R      � -
   5        $ gridPolinomio��5R   ,   ���#3a3d57 5S      �� 5T      $
��auto �6(   �� 5U      $��* �6(   .+�5X      �� $��0��6!   $
��Left=�6.   $ 
Horizontal=�6I   .+�5Y      �  5Z      �� 5[   "   $
��auto �60   �� 5\   "   $
��auto �60    5^      �� 5_   "   $
��auto �63   �� 5`   "   $
��auto �63   5d      5e      �� 5f      $��0��6!   $��Right=�6.   $ 
Horizontal=�6J   .+�5g      �� -   5        $ btnAleatorio��5g   !   $��Generar aleatorio��67   ���#53577d$
��10 7q�6h   $��20 10q�6v   
�������
�������6�   5h        5i      -   5        $ gridCoordPolinomio��5i      $ * 6q    .  $��1��6�   $��10 10q�6�   
 ��ح�$ 2��6�   ���#53577d .  ��6;   �� $ Coordenadas�$ TwoWay=� 5j      ��%U  '        '  �     �� 5k      "  6$   .�5l   "   ��  � ��$ center=�6O   �� 5m   "    � ��$
 Bold"�6?   �� 5n   "    � ��
 �����6?   �� 5o   "    � ��$ 0,0,1,0q�6D   �� 5p   "    � ��
 �   �6@   5q      �� 5r      "  6$   .�5s   "   ��  �@��TextAlignment$ Center=�6L   5t      5u       5v        5w      $ CoorX��61    6@   �� *CoorX+  5x      $ CoorY��61    6@   �� *CoorY+5z      5|      5}      5�      �� 5�   
   $��1��6   $��center=�6"   $ 
Horizontal=�6?   .+�5�      �� -   5        $ 	btnCerrar��5�      $��Cerrar��6(   ���#53577d$��10 10q�6N   $��30 10q�6�   
�������
���������6]   �� *CloseCoordDialogCommand+6�   �� 5�      -   5        $ 	btnVaciar��5�      $��Vaciar Lista��6(   ���#53577d$��10 10q�6y   $��20 10q�6�   
�������
���������6?   �� *ClearListCommand+6�   5�      5�      5�      