   M S B A M L   `   `   `  ����G  CPresentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Presentation.ViewPresentation.View  5   	   !    Presentation.View.LoginUser   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Presentation.View     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  67   -   5          � 
ResizeMode$  NoResize=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowStyle$
 None=�5   	   
������  � AllowsTransparency .  � Title$ 
MainWindow��5   	   $	��600��6   $	��900��6)   .��5      ��  �� CornerRadius$ 10��6   ._�5   
   �� $ 10��6    J� Opacity$ 1Q�6#   ��5      �� 5       �� 
StartPoint$	 0,1&�6&    �� EndPoint$	 0,0&�67   .��5      � 	 � Color$	 #000320��6#   
 � Offset$

 0.10Q�63   � 5      $	 #16113A��6#   $
 1Q�63   5      ._�5      �  � RowDefinitions 5      �� 5      $��35 �6$   �� 5      $��* �6$   .+�5!      � $��0��6    � ColumnDefinitions 5"      �� 5#      �� 5$      $��30 �6+   �� 5%      $��30 �6+   �� 5&      $��5 �6+   .+�5)      �� $��Login��6    $��0��6-      menuButtonText#��[  6=   $��15,0,0,0q�6e    
 Color2#��[ 6w   �� 5*      -   5         ��Name$ btnMin��5*      $��1��6-     controlButton#��[ 5+      .��5-      "  FontAwesome.WPF.ImageAwesome     Icon$ WindowMinimize=�6*     controlButtonIcon#��[ 6@      
Foreground# [ 6k   5.      �� 5/      -   5        $ btnClose��5/      $��2��6/   #��[ 50      .��52        $ Close=�6*   #��[ 67   # [ 6b   53      55      �� 56      $��1��6    �� Orientation$ Vertical=�57      $��0,5,0,0q�58      $	��360��59      .+�5:      �� $��/Img/logo2.png��6   $��98��64   $��80��6?   �� 5;      $��
GESTION RS��6    
�������  	TitleText#��[ 6E   $��0q�6h   �� 5<      $����¡Gestiona tus residuos con nosotros! 
Haz del mundo un lugar más limpio y sostenible.
Únete al movimiento por un futuro más verde.��6    $��0,10,0,0q�5=       
�������$
��Wrap=�5?       $��13(�5@        �� TextAlignment$ Center=�5A       $��Medium"�5B       5E      �� 5G      -   5        $��txtUser��5H      $��UserName��5I       �� 	MaxLength$ 14��5J        nameBox#��[ 5M      .��5N      ��5O      �� 5P       �� ImageSource$ /Img/user2.png��5Q   !    j� Stretch$
 None=�5R   !    j� 
AlignmentX$
 Left=�5S   !   .��5U   .   5V      G� 5W      -   5        $��txtPass��5Y       G� PasswordChar$ *��5Z       G� 	MaxLength$ 12��5[        PassBox#��[ 5^      ��5_      �� 5`      -   5        imgPass��$ /Img/lock.png��5c   !   $
 None=�5d   !   $
 Left=�5e   !   5h      �� 5i      6   �� 5j      -   5        $��lblAlert��5j   J   $��	35,0,35,0q�6!   $y�Hidden=�66   �� 5k      $ 
Horizontal=�6%   .+�5l        $ ExclamationCircle=�6/   $��20��6H    �#67679F$��0,0,5,0q�6i   6}   �� 5m      -   5        $��lblAlertText��5m   >   ���#67679F5n      5p      �� 5q      $��0,0,35,0q�6    $��12(�5r       $��Right=�5s       �� 5t      -	   5        $��https://drayer.surge.sh/?�5t   %    �� TextDecorations$
 None{�5u   %   ���#0275FE.�5w   =   ¿Olvidaste la Contraseña?6X   5x      �� 5z      -
   5        $��btnLogin��5~        contentButton#��[ 5z        Color10
 � Tag# [ 5{      $	��210��5|      $��0,30,0,0q�5}      $��55��5      .��5�      �� $ 
Horizontal=�6%   $��Center=�5�   %   .+�5�      �� $��Login��6(    	 contentButtonText#��[	 65   5�      5�      �� 5�      
������� 
 SubTitle#��[
 63   $��11(�6U   $��0,10,0,0q�6c   �� 5�      $!��¿Aun no tienes una cuenta?��6$    �� 5�      -   5        $��https://drayer.surge.sh/?�5�   $   $
��Bold"�6K   $
 None{�6]   ���#0275FE.�6�   
Registrate6�   5�      �� 5�      
�������#��[
 63   $��10(�6U   $��0,90,0,0q�6c   �� 5�      $��
Adapted by��6$    �� 5�      -   5        $��https://drayer.surge.sh/?�5�   $   $
��Bold"�6K   $
 None{�6]   ���#0275FE.�6�   Franco Monrroy 🐺6�   5�      5�      5�      5�      5�      5�      