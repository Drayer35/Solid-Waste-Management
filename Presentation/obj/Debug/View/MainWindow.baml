   M S B A M L   `   `   `  ����G  CPresentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Presentation.ViewPresentation.View  5   9       Presentation.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	   0
viewmodelsclr-namespace:Presentation.View  69   -   5          � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$
 None=�5	   	    � AllowsTransparency . 
������  � Title$ 
MainWindow��5   	   $	��800��6   $
��1380��6)    � 	Resources 5       �� DataType!   Presentation.View.Dashboard � DataContext#   Presentation.View.Instructivo#   Presentation.View.Operaciones��%9  (��       5   *   *, +)(�� N     5   ,   *, +)(�� �     5   ,   *, +)�� 5   
   	Dashboard��"  6*   .R�5         6#   �� 5      �� 5   
   Instructivo��"  6,   .R�5         6%   �� 5      �� 5   
   Operaciones��"  6,   .R�5         6%   �� 5      5      .��5      ��  �� CornerRadius$ 5��6    J� Opacity$ 1Q�5      $��1q�5      ._�5   
   � 	 � ColumnDefinitions	 5!      �� 5"      $	��250 �6#   �� 5#      $��* �6#   .+�5%      �� $ 	20,0,0,20��6    
  Color1#��[  5&      $��0��5'      ._�5(      �� .+�5)      �� 
 �� Orientation$
 Vertical=�5*      $	��800��5+      .+�5,      �� $��GESTION RRSS��6$     	TitleText#��[ 68    
 Color2#��[ 5-   $   	� 50      -   5         	�Name$ activeDashboard��54   &     
menuButton#��[ 50   &   
 � Tag# [ 51   &    d� 	IsChecked$
 TrueY�52   &   .��56      �� $
 
Horizontal=�6)   $��Center=�57   )   .+�58   "   "  FontAwesome.WPF.ImageAwesome     Icon$
 Home=�62     menuButtonIcon#��[ 6>   �� 59   "   $��	Dashboard��6,     menuButtonText#��[ 6=   5:      5;      	� 5<      #��[ 6&   # [ 5=   &   .��5?      �� $
 
Horizontal=�6)   $��Center=�5@   )   .+�5A   "     $ Database=�62   #��[ 6B   �� 5B   "   $��	Registros��6,   #��[ 6=   5C      5D      	� 5F      #��[ 6&   # [ 5G   &   .��5J      �� $
 
Horizontal=�6)   $��Center=�5K   )   .+�5L   "     $
 List=�62   #��[ 6>   �� 5M   "   $��Residuos��6,   #��[ 6<   5N      5O      	� 5P      #��[ 6&   # [ 5Q   &   .��5S      �� $
 
Horizontal=�6)   $��Center=�5T   )   .+�5U   "     $ Gears=�62   #��[ 6@   �� 5V   "   $��Operaciones��6,   #��[ 6?   5W      5X      	� 5Y      -   5        #��[ 5Y   &   # [ 5Z   &   .��5\      �� $
 
Horizontal=�6)   $��Center=�5]   )   .+�5^   "     $ Wrench=�62   #��[ 6@   �� 5_   "   $��Instructivo��6,   #��[ 6?   5`      5a      	� 5b      -   5        #��[ 5b   &   # [ 5c   &   .��5e      �� $
 
Horizontal=�6)   $��Center=�5f   )   .+�5g   &     $ PowerOff=�66   #��[ 5h   6   �� 5i   "   $��Cerrar Sesion��6,   #��[ 5j   ,   5k      5l      5m      5n      5o      �� 5p      $ 	0,20,20,0��6   #��[ 5q      $��1��5r      ._�5t      �  � RowDefinitions 5u      �� 5w      $��35 �6(   �� 5y      $��55 �6(   �� 5{      $��* �6(   .+�5      �� -   5         ��Name$ 
controlBar��5   !   $��0��5�   !   $
 
Horizontal=�5�   !   $��RightToLeft=�5�   !   
������ $��0,0,4,0q�5�   !   .+�5�      �� -   5         ��Name$ btnClose��5�   !     controlButton#��[ 5�   !   .��5�        $ Close=�6.     controlButtonIcon#��[ 6;    
 Color5   
Foreground# [ 6f   5�      �� 5�      -   5        $ btnMax��5�   !   #��[ 5�   !   .��5�        $ WindowMaximize=�6.   #��[ 6D   # [ 6o   5�      �� 5�      -   5        $ btnMin��5�   !   #��[ 5�   !   .��5�        $ WindowMinimize=�6.   #��[ 6D   # [ 6o   5�      5�      �� 5�      -	   5        $ Header��5�   !   $��1��5�   !   $
 
Horizontal=�5�   !   #��[  5�   !   .+�5�      �� $
 
Horizontal=�6%   $��Center=�5�   %   $��Center=�5�   %   $��	10,0,10,0q�5�   %   .+�5�      �� $��/Img/lock2.png��6$   $��45��6<   $��0,0,5,0q�6H   �� 5�      $
 Vertical=�6)   $
��Left=�6@   .+�5�   "   �� -
   5         ��Name$ txtFullName��5�   ,   $��	Full Name��6A   
�������$��25(�6e   $��0q�6s   �� 5�   "   -   5        $ txtNameUser��5�   ,   $��	User Name��6A   
�������$��15(�6e   $��1,0,0,0q�6s   5�      5�      5�      �� 5�      -   5         ��Name$ controlContent��5�   %   $��2��5�   %   $��20q�5�   %   ��5�   %   �� 5�      5�      5�      5�      5�      5�      