   M S B A M L   `   `   `  ����I  EInterfaces_GII, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Interfaces_GIIInterfaces_GII  5   	   ;"clr-namespace:Interfaces_GII.ModelInterfaces_GII.Model  5   	   I EJungleControls, Version=1.8.0.0, Culture=neutral, PublicKeyToken=nullG4clr-namespace:JungleControls;assembly=JungleControlsJungleControls 5   	       Interfaces_GII.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   +ccclr-namespace:Interfaces_GII     5   	   1cm"clr-namespace:Interfaces_GII.Model     5   	   Cjc4clr-namespace:JungleControls;assembly=JungleControls     5   	     � Icon$  ./Resources/icono.ico��5   	    � Title$ 
DrawWindow��5   	   $	��450��6   $	��800��6)   $	��450��65   $	��800��6E   .��5
      � -   5         �Name$ miGrid��5
      ���#3a3d57 � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ lineaX��5   8   $��2��6+   	 �� X1$ 0��6I   
�������$��3��5   &    K� ZIndex$ 1��6:   y�5      �� *Ejes+	 �� Y1 6P   �� *MitadAltura+	 �� X2 5      �� *AnchoCanvas+		 �� Y2	 62   �� *MitadAltura+5   :   �� 5   
   -   5        $ lineaY��5   8   $��2��6+   $ 0��6e   
�������$��3��5   &   $ 1��6:   y�5      �� *Ejes+ 6I   �� *MitadAnchura+ 5      �� *MitadAnchura+	 63   �� *AnchoCanvas+5   :   "   Interfaces_GII.MyItemControl  5   
   -   5        
  Name$
 controlCanvas��5      $��2��62   ��6?   ��  �� Path$ Coordenadas�y�6h   �� *BarrasCanvas+��5      �� 5      .R�5      ��  ��Name$ miCanvas��6   $��2��6/   ���#53577d  JungleControls.DataPipe   Pipes 5           Source 5   !   �� *ActualWidth+ �� ElementName$ miCanvas��   Target 5   !   �� *AnchoCanvas+ �� Mode$ OneWayToSource=�  5       5    !   �� *ActualHeight+$ miCanvas�� 5!   !   �� *AlturaCanvas+$ OneWayToSource=�5$      5&      ��5(      �� 5)      .R�5*      �� 
�������$��3��5,   &    5*      �� *FromX+ 60   �� *FromY+ 5+      �� *ToX+	 6*   �� *ToY+5,   &   5-      50        51   
   -   5        $
 controlCanvasPuntos��51      $��2��68   y�6E   �� *
PoliCanvas+��6g   �� *Puntos+��52      �� 53      .R�54      �� $ 	miCanvas2��6   $��2��60   ���#53577d55      56      ��58      �� 59      .R�5:      �  �Name$ 
miPolyline��5;       �� Stretch$
 Fill=�5:      $��0��6.   
���  ��$��3��5;   :   5<      5=      5?      o� 5A   
   $��0��6   ���#3a3d57
�������.@�5B      m� -   5        $��CDModal��5B   4   $��Consultar Valores��6    m� Command 6C   �� *OpenCoordDialogCommand+m� 5C      -   5        $��MTipo��5C   7   ��6   �� *
MTipo_Text+ 6D   �� *MTipo_ClickCommand+ m� CommandParameter 6k   ��  �� RelativeSource �� *Self+m� 5D      -   5        $��MEjes��5D   7   ��6   �� *
MEjes_Text+ 6D   �� *MEjes_ClickCommand+ 6k   ��  �� *Self+5E      5F      5G      