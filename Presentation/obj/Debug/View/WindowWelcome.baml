   M S B A M L   `   `   `  ����G  CPresentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Presentation.ViewPresentation.View  5   	   %    Presentation.View.WindowWelcome   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Presentation.View     5   	     � WindowStartupLocation$  CenterScreen=�5   	    J� Opacity$ 1Q�5	   	    � WindowStyle$
 None=�5
   	    � AllowsTransparency . 
������  � 
ResizeMode$ NoResize=�5   	    � Title$ 
MainWindow��5   	   $	��450��6   $	��800��6)   .��5      ��  �� CornerRadius$ 10��6   ��5   
   �� 5       �� ImageSource$ /Img/welcome.jpg��6   ._�5   
   �� $ 10��6   $
 0.80Q�6#   ��5      �� 5       �� 
StartPoint$	 0,1&�6&   	 �� EndPoint$		 0,0&�67   .��5      � 
 � Color$
 #000320��6#    � Offset$
 0.10Q�63   � 5      $
 #16113A��6#   $ 1Q�63   5      ._�5      �  � RowDefinitions 5      �� 5      $��* �6$   .+�5      ��  �� Orientation$ Vertical=�6   $	��650��65   $��Center=�6A   .+�5       �� $��0��6!   $��0,100,0,100q�5!   !   $ 
Horizontal=�5"   !   .+�5$      �� $��/Img/usermain.png��6    $	��150��6;   $	��220��6G   �� 5%      $ Vertical=�6%   $��Center=�6<   $
��Left=�6W   $��0,0,0,0q�6r   .+�5&      �� $��BIENVENIDO!��6)   
�������   	TitleText#��[  6O   $��0q�6r   $��45(�6}   $��Stretch=�6�   �� 5'      -   5         ��Name$ txtUserFullName��5'   (   
�������#��[  6U   $��0q�6x   $��35(�6�   $��Stretch=�6�   5(      5)      �� 5*      .+�5+      �� -   5        $ 
porcentaje��5+   %   
�������$��Right=�6L   6j   � 5,      -   5         �Name$ 
barraCarga��5,   1   $��3��6&     
BarraLogin#��[ 6E   5-      5.      51      52      53      54      