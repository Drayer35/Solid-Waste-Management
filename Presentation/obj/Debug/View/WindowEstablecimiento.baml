   M S B A M L   `   `   `  ����  Presentation-    'Presentation.View.WindowEstablecimiento   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	   -   5          � 
ResizeMode$  NoResize=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowStyle$
 None=�5   	   
������  � AllowsTransparency .  � Title$ 
MainWindow��5   	   $	��650��5   	   $	��800��5   	   .��5      ��  �� CornerRadius$ 15��6   $��1q�6   
�������._�5   
   �  � RowDefinitions 5      �� 5      $��25 �6    �� 5      $��* �6    .+�5      �� $��0��6   
�������$ 	15,15,0,0��65   ._�5      �� -   5         ��Name$ 
controlBar��5      $��0��5       �� Orientation$ 
Horizontal=�5      $��RightToLeft=�5      
������ $��0,0,4,0q�5      .+�5       �� -   5        	 ��Name$	 btnClose��5          controlButton#��[  5!      .��5#      "  FontAwesome.WPF.ImageAwesome  
   Icon$
 Close=�6*     controlButtonIcon#��[ 67      
Foreground
 �   �6b   5$      5%      5&      �� 5)      $��1��6   $ 	0,0,15,15��6"   
�������._�5*      �  � ColumnDefinitions 5+      �� 5,      .+�5.      �� $ Vertical=�6!   $��Center=�68   .+�5/      �� $"��REGISTRO DE ESTABLECIMIENTOS��6$   $��Center=�6H     	TitleText#��[ 6e   $��20q�6�   �� 50      $ 
Horizontal=�6&   $��Center=�6?   .+�51      �� -   5         ��Name$ TxtIdEstablecimiento��52       $��ID��53       $��30��54       {�.    OnlyBox#��[ 57       $��	0,20,20,0q�58       .��63   59      �� 5:      -   5        $ TxtNameEstablecimiento��5;   $   $��Nombre Establecimiento��5<   $   $	��300��5=   $    �� 	MaxLength$ 40��5>   $   #��[ 5A   $   $��0,20,0,0q�6E   .��6W   5B      �� 5C      -   5        $��BtnAddEstablecimiento��5G   &     contentButton#��[ 5C   %     Color10
 � Tag# [ 5D   &   $��90��5E   &   $��	20,20,0,0q�5F   &   $��40��5H   &   .��5J   "   �� $ 
Horizontal=�6-   $��Center=�5K   -   .+�5L   &   �� -   5         ��Name$ TextAddEstablecimiento��5L   0   $��Agregar��6P     contentButtonText#��[ 6_   5M   #   5N      5O      &   System.Windows.Controls.DataGrid  5Q      -   5          Name$ TableEstablecimientos��5R   #      CanUserResizeColumns .     CanUserAddRows .     
IsReadOnly . $	��350��5V   #     DataGridRowStyle1   RowStyle# [ 5W   #      AutoGenerateColumns .  $��30,20q�5Y   #     miEstiloDeCelda   	CellStyle# [ 5Z   #    	 	gridTable#��[	 5[   #   ��5Q   #   ��    ColumnHeaderStyle 5]      �� 5^   "    �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6(    
 DataGridColumnHeaderStyle1 �� BasedOn# [
 6J    � 	Resources 5`        CustomVerticalScrollBar��%0   '��       7  �� 5a   "   " ��6(   8   6H   5b         Columns 5d      4  .System.Windows.Controls.DataGridCheckBoxColumn  5e   "   ,  &System.Windows.Controls.DataGridColumn   CanUserResize .     Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6O      HeaderTemplate 5f   &   �� 5g   *   .R�5h   .   �� 5i   +   5k   #   0  *System.Windows.Controls.DataGridTextColumn  5m   "       Header$  ID��65   $ 80 6Y   1  +System.Windows.Controls.DataGridBoundColumn!   Binding! 6A   �� *ID+6Y     5n   "   $  NOMBRE��65   ! 6E   �� *NOMBRE+4	  .System.Windows.Controls.DataGridTemplateColumn	  5o   "   $  OPCIONES��69   $ 80 6K   " 	  CellTemplate" 5p   &   �� 5q   *   .R�5r   .   �� $ 
Horizontal=�69   $��Center=�6R   .+�5s   2   �� $	 ButtonDeleteRecord��6t   -	   5          gridButtonEdit#��[ 5s   9   .��5t   6   !
  FontAwesome.WPF.FontAwesome
  # 
  Icon$# Pencil=�6E   5u   3   �� 5v   2   -
   5          gridButtonClose#��[ 5v   9   .��5w   6   
  $# Close=�6E   5x   3   5y   /   5z   +   5|   #   5      �� 5�      -   5        $��BtnDeleteSelectionTable��5�   "   #��[ 5�   !   $
��Left=�6H   ���#B22F22$��90��5�   "   $��	20,20,0,0q�5�   "   $��40��5�   "   .��5�      �� $ 
Horizontal=�6)   $��Center=�5�   )   .+�5�   "   �� $��Borrar Selección��6-   #��[ 6E   5�      5�      5�      5�      5�      5�      5�      5�      