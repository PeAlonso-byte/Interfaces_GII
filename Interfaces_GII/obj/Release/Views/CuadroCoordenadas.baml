   M S B A M L   `   `   `  ����   PruebaInterfaces,    &Interfaces_GII.Views.CuadroCoordenadas   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Icon$  ../Resources/icono.ico�� � Title$ Coordenadas��$	��450��$	��800��.��� -    �Name$ gridVentana�����#3a3d57 � RowDefinitions �� $
��auto ��� $��* ��� $
��auto �.+��� $��0��$
��Left=� �� Orientation$ 
Horizontal=�.+��  �� $
��auto ��� $
��auto � � ColumnDefinitions �� $
��auto ��� $
��auto �.+��� -    ��Name$ xText��$	��X: ��$��0��$��0��
�������$
��Left=�$��10q��� -    ��Name$ xTextBox��$��0��$��1��$��Right=�$��10q�$��50�� J� 	AllowDrop .  ���� *CoorX+�� -   $ yText��$	��Y: ��$��1��$��0��
�������$
��Left=�$��10q��� -   $ yTextBox��$��1��$��1��$
��Left=� .  $��50��$��10q����� *CoorY+�� -   	 ��Name$	 	btnAnadir��$��Añadir�����#53577d$
��10 7q�$��25 10q�
�������
����������� *AddCoordCommand+�� $��3��$��center=�$ 
Horizontal=�.+��� -   $	 
btnAceptar��$��Aceptar�����#53577d$��10 10q�$��20 10q�
�������
��������� -   $	 btnCancelar��$��Cancelar�����#53577d$��10 10q�$��20 10q�
�������
��������� $��0��$��Center=�$ 
Horizontal=�.+��� -	   $	 
btnLimpiar��$��Vaciar Datos�����#53577d$
��10 7q�$��25 10q�
�������
����������� *ClearListCommand+�� $��0��$��Right=�$ 
Horizontal=�.+��� -
   $	 btnAleatorio��$��Generar aleatorio�����#53577d$
��10 7q�$��20 10q�
�������
�������&   System.Windows.Controls.DataGrid  -   
  Name$
 	gridCoord��   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ *    CanUserAddRows .  $��1��$��10 10q�   AlternatingRowBackground
 ��ح� �� AlternationCount$ 2�����#53577d �� SelectedIndex �� *SelectedIndexOfCollection+ �� Mode$ TwoWay=� � 	Resources =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value*  $System.Windows.Controls.DataGridCell��%�   '        '  �     �� "  .���  � ��$ center=���  � ��$
 Bold"���  � ��
 �������  � ��$ 0,0,1,0q���  � ��
 �   ��� "  .���  �@��TextAlignment$ Center=�