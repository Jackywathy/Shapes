   M S B A M L   `   `   `  ����  MarioShapes    WPF_Shapes.ThreeDimShapes   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   J FWpfAnimatedGif, Version=1.4.14.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  5   	   -   5          � Title$  	3D Shapes��5	   	   $	��750��6   $
��1200��6(    � Icon$ images/icon.ico��5
      ��5      �� 5   
    �� ImageSource$ images/underground.jpg��6   6<   .��5      � -   5         �Name$ 
LayoutRoot��5      $��./Fonts/#Super Mario 256)�6    � RowDefinitions 5   
   �� 5      $��0.12* �6   6-   �� 5      $��1* �6   6*   .+�5   
   � -   5        $ HeaderGroup��5      $��0��6$    � ColumnDefinitions 5      �� 5      $
��0.2* �6#   62   �� 5      $��1* �6#   60   �� 5      $
��0.2* �6#   62   .+�5      �� -   5         ��Name$ 
TitleGroup��5      $��1��6.    �� Orientation$ 
Horizontal=�6>   $��Center=�6W   $��Center=�6t   $��0,10,0,0q�6�   .+�5      �� 
���  ��$��./Fonts/#Super Mario 256)�6-   $��60(�6S   36d   �� 5       
����� �$��./Fonts/#Super Mario 256)�6.   $��60(�6T   D6e   �� 5!      
���  ��$��./Fonts/#Super Mario 256)�6-   $��60(�6S   $�� ��6a   6l   �� 5"      
��� ���$��./Fonts/#Super Mario 256)�60   $��60(�6V   S6g   �� 5#      
������$��./Fonts/#Super Mario 256)�64   $��60(�6Z   H6k   �� 5$      
����� �$��./Fonts/#Super Mario 256)�6.   $��60(�6T   A6e   �� 5%      
��� ���$��./Fonts/#Super Mario 256)�60   $��60(�6V   P6g   �� 5&      
���  ��$��./Fonts/#Super Mario 256)�6-   $��60(�6S   E6d   �� 5'      
������$��./Fonts/#Super Mario 256)�64   $��60(�6Z   S6k   5(      �� 5*      $ 
Horizontal=�6   $��0��62   $��2��6?   $��Right=�6O   .+�5+      �� -   5         ��Name$ 	Button_2D��5+      $
��Left=�6,   $��Center=�6G   $��Center=�6k   $
��15,5q�6�   $��3q�6�   ��5,      �� 5-      $ images/arrow_right.png��6%   	 J� Effect	 5/      3  -System.Windows.Media.Effects.DropShadowEffect  50      .��52      �� $	��Top=�6    $��Center=�68   $��0,30,0,0q�6U   ���	#FFFF0051$��16(�6~   	2D Shapes6�   53      54      �� 56      $ 
Horizontal=�6   $��0��62   $��0��6?   $
��Left=�6O   .+�57      �� -   5        $ 
ButtonBack��57      $
��Left=�6-   $��Center=�6H   $��Center=�6l   $
��15,5q�6�   $��3q�6�   ��58      �� 59      $ images/arrow_left.png��6%   	 5;        5<      .��5>      �� $	��Top=�6    $��Center=�68   $��0,30,0,0q�6U   ���	#FFFF0051$��16(�6~   
Go Back!6�   5?      5@      5A      � 5C   
   -   5        $ 
TwoDimGrid��5C   "   $��1��6   $��0��6   $��50q�66   $��Stretch=�6C   $��Stretch=�6a    5D      �� 5E      $��* �6#   �� 5F      $��0.18* �6#   .+�5I      �� -   5        
 ��Name$
 MainTab��5I      $��0��6*   
�������
��� ���$��15q�6g   $��./Fonts/#Super Mario 256)�6|   .@�5L      �� -	   5         ��Name$ RectangleTab��5L      $y�	Collapsed=�60   $��./Fonts/#Super Mario 256)�6G   .��5M      �  5N      �� 5O      $
��0.6* �6/   �� 5P      $
��0.3* �6/   .+�5S      �� 
���   �$��0,0,2,0q�65   ._�5T      �  5U   "   �� 5V   &   $	��0.0 �64   6C   �� 5W   &   $
��0.4* �64   6D   �� 5X   &   $
��0.1* �64   6D   �� 5Y   &   $
��0.1* �64   6D   .+�5[   "   �� -
   5         ��Name$ RectangleMeasure��5[   (   $$��images/measure/rect_prism1.png��6B   $��1��6j   �� 5]   "   $ 
Horizontal=�6-   $��2��6F   $��Center=�6S   $��Center=�6p   $
��10,0q�6�   .+�5^   &   �� $��./Fonts/#Super Mario 256)�60   $
��10,0q�6W   $��20(�6e   Width:6{   �� 5_   &   -   5         ��Name$ RectangleWidth��5_   T   $��./Fonts/#Super Mario 256)�6.   $
��10,0q�6l    �� 	MaxLength$ 2��6z   $��30��6�   $��20(�6�   6�   �� 5`   &   $��./Fonts/#Super Mario 256)�60   $
��10,0q�6V   $��20(�6d   	Length:6{   �� 5a   &   -   5        $ RectangleLength��5a   T   $��./Fonts/#Super Mario 256)�6.   $
��10,0q�6m   $ 2��6{   $��30��6�   $��20(�6�   6�   �� 5b   &   $��./Fonts/#Super Mario 256)�60   $
��10,0q�6V   $��20(�6d   	Height:6{   �� 5c   &   -   5        $ RectangleHeight��5c   T   $��./Fonts/#Super Mario 256)�6.   $
��10,0q�6m   $ 2��6{   $��30��6�   $��20(�6�   6�   5e   #   �� 5f   "   $ 
Horizontal=�6-   $��3��6F   $��Center=�6S   $��Center=�6p   $
��10,0q�6�   .+�5g   &   �� -   5         ��Name$ RectangleOut��5g   V   $��./Fonts/#Super Mario 256)�60   $��25(�6l    Volume = 0 x 0 x 0 = 0 units³6�   5h   #   5j      5k      � 5m      $��1��6    5n      �� 5o   "   $
��0.1* �60   6@   �� 5p   "   $
��0.2* �60   6@   .+�5r      �� "  WpfAnimatedGif.ImageBehavior   AnimatedSource$ images/koopa.gif��6$   $��0��6X   6g   �� 5s      $��1��6)   .+�5t   "   �� $��./Fonts/#Super Mario 256)�6(   $��16(�6N   $��Center=�6\   .��6y   The rectangular prism6�   �� 5u   "   $��16(�6(   $��Center=�66   .��6S   is a 3D shape!6c   �� 5v   "   ���	#FF6C994E.��6?   $"- 6 faces, that are all rectangles6c   �� 5w   "   ���	#FFCD6930.��6?   - All angles are 90°6U   �� 5x   "   ���	#FF19BED8$��11(�6?   .��6M   - Two types6Z   �� 5y   "   $��0,5,0,0q�6)   
���   �$��0,5,0,0q�6W   � 5z   "    5{   &   �� 5|   *   $��* �68   6E   �� 5}   *   $��* �68   6E    5   &   �� 5�   *   $��1* �6;   6H   �� 5�   *   $
��0.7* �6;   6J   .+�5�   &   �� $��0��61   $��0��6>   $��Center=�6N   $��Center=�6k   .+�5�   *   �� ���	#FF551136.��6G   Square Prism6U   �� 5�   *   .��60   - Two sides equal6C   5�   '   � 5�   &   $��0��6+   $��1��68    5�   *   �� 5�   .   $
��0.1* �6?   6N   �� 5�   .   $
��0.4* �6?   6N   �� 5�   .   $
��0.1* �6?   6N   .+�5�   *   �� $��1��60   $$��images/measure/squre_prism.jpg��6@   6j   5�   '   �� 5�   "   $��1��6-   $��0��6:   $��Center=�6J   $��Center=�6g   .+�5�   *   �� ���	#FFDC1E1E.��6G   Cube6M   �� 5�   *   .��60   - 3 Equal Sides6A   5�   '   � 5�   &   $��1��6+   $��1��68    5�   *   �� 5�   .   $
��0.1* �6?   6N   �� 5�   .   $
��0.4* �6?   6N   �� 5�   .   $
��0.1* �6?   6N   .+�5�   *   �� $��1��60   $��images/measure/cube.jpg��6@   6c   5�   '   5�   #   �� 5�   "   $��0,5,0,0q�6)   
���   �$��0,5,0,0q�6W   5�   #   �� 5�   "   $��17(�6(   $��Center=�66   $��Center=�6Z   ���	#FF2D6EE0$��Center=�6�   $��Center=�6�   .��6�   Volume = Width x Length6�   �� 5�   "   $��17(�6(   $��Center=�66   $��Center=�6Z   ���	#FF2D6EE0$��Center=�6�   $��Center=�6�   $��    x Height��6�   6�   5�      5�      5�      5�      �� 5�      -   5        $ TriangleTab��5�      $y�	Collapsed=�6/   .��5�      �  5�      �� 5�      $
��0.6* �6/   �� 5�      $
��0.3* �6/   .+�5�      �� 
���   �$��0,0,2,0q�65   ._�5�      �  5�   "   �� 5�   &   $��0.05* �64   6E   �� 5�   &   $
��0.4* �64   6D   �� 5�   &   $
��0.1* �64   6D   �� 5�   &   $
��0.1* �64   6D   .+�5�   "   �� -   5        $ TriangleMeasure��5�   (   $#��images/measure/tri_prism1.png��6A   $��1��6h   �� 5�   "   $ 
Horizontal=�6-   $��2��6F   $��Center=�6S   $��Center=�6p   $
��10,0q�6�   .+�5�   &   �� $��./Fonts/#Super Mario 256)�60   $
��10,0q�6W   $��20(�6e   Width:6{   �� 5�   &   -   5        $ TriangleWidth��5�   T   $��./Fonts/#Super Mario 256)�6.   $
��10,0q�6k   $ 2��6y   $��30��6�   $��20(�6�   6�   �� 5�   &   $��./Fonts/#Super Mario 256)�60   $
��10,0q�6V   $��20(�6d   	Height:6{   �� 5�   &   -   5        $ TriangleHeight��5�   T   $��./Fonts/#Super Mario 256)�6.   $
��10,0q�6l   $ 2��6z   $��30��6�   $��20(�6�   6�   �� 5�   &   $��./Fonts/#Super Mario 256)�60   $
��10,0q�6V   $��20(�6d   
Thickness:6~   �� 5�   &   -   5        $ TriangleThickness��5�   T   $��./Fonts/#Super Mario 256)�6.   $
��10,0q�6o   $ 2��6}   $��30��6�   $��20(�6�   6�   5�   #   �� 5�   "   $ 
Horizontal=�6-   $��3��6F   $��Center=�6S   $��Center=�6p   $
��10,0q�6�   .+�5�   &   �� -   5        $ TriangleOut��5�   W   $��./Fonts/#Super Mario 256)�60   $��25(�6l   $��Center=�6z   $��Center=�6�   
Volume =6�   �� 5�   &   $ Vertical=�61   .+�5�   *   �� -   5        $ TriangleTop��5�   4   $��25(�6I   $��Center=�6W   0 x 06{   �� 5�   *   $��images/line.png��60   $	��120��6I   6W   �� 5�   *   -   5        $ TriangleBottom��5�   4   $��25(�6L   $��Center=�6Z   26z   5�   '   �� 5�   &   -   5        $ TriangleRight��5�   0   $��./Fonts/#Super Mario 256)�6G   $��25(�6m   $��Center=�6{   $��Center=�6�   x 0 = 0 units³6�   5�   #   5�      5�      � 5�      $��1��6    5�      �� 5�   "   $
��0.1* �60   6@   �� 5�   "   $
��0.4* �60   6@   .+�5�      �� $��0��6$   $��images/lakitu.png��61   6N   �� 5�      $��1��6)   .+�5�   "   �� $��./Fonts/#Super Mario 256)�6(   $��15(�6N   $��Center=�6\   .��6y   A triangular prism is a6�   �� 5�   "   $��16(�6(   $��Center=�66   .��6S   	3D shape!6^   �� 5�   "   ���	#FF6C994E.��6?   - Two faces are triangles6Z   �� 5�   "   ���	#FFCD6930.��6?   - Three faces are rectangles6]   �� 5�   "   ���	#FF561DD1.��6?    - The triangle can be scalene,6_   �� 5�   "   $"��   equlaterial, or isocelles��6(   ���	#FF561DD16h   �� 5�   "   $��0,5,0,0q�6)   
���   �$��0,5,0,0q�6W   ._�5�   &   �  5�   *   �� 5�   *   $
��0.1* �6;   6J   �� 5�   *   $
��0.4* �6;   6J   �� 5�   .   $
��0.1* �6?   6N   .+�5�   *   �� $��1��60   $"��images/measure/tri_prism.png��6@   5�   '   5�   #   �� 5�   "   $��0,5,0,0q�6)   
���   �$��0,5,0,0q�6W   5�   #   �� 5�   "   $��16(�6(   ���	#FF2D6EE0$��Center=�6M   $��Center=�6h   .��6�   Volume = Width x Height ÷ 26�   �� 5�   "   $��16(�6(   ���	#FF2D6EE0$��Center=�6M   $��Center=�6h   $��x thickness��6�   6�   5�      5�      5�      5�      �� 5�      -   5        $ SquarePyTab��5�      $y�	Collapsed=�6/   .��5�      �  5�      �� 5�      $
��0.6* �6/   �� 5�      $
��0.3* �6/   .+�5�      �� 
���   �$��0,0,2,0q�65   ._�5      �  5  "   �� 5  &   $��0.05* �64   6E   �� 5  &   $
��0.5* �64   6D   �� 5  &   $
��0.1* �64   6D   �� 5  &   $
��0.1* �64   6D   .+�5  "   �� -   5        $ TrapeziumMeasure��5  (   $#��images/measure/square_py1.png��6B   $��1��6i   $��Center=�6v   $��Center=�6�   6�   �� 5	  "   $ 
Horizontal=�6-   $��2��6F   $��Center=�6S   $��Center=�6p   $
��10,0q�6�   .+�5
  &   �� $��./Fonts/#Super Mario 256)�60   $
��10,0q�6W   $��16(�6e   	Length:6|   �� 5  &   -   5        $ SquarePyLength��5  T   $��./Fonts/#Super Mario 256)�6.   $
��10,0q�6l   $ 2��6z   $��24��6�   $��16(�6�   6�   �� 5  &   $��./Fonts/#Super Mario 256)�60   $
��10,0q�6V   $��16(�6d   	Height:6{   �� 5  &   -   5        $ SquarePyHeight��5  T   $��./Fonts/#Super Mario 256)�6.   $
��10,0q�6l   $ 2��6z   $��24��6�   $��16(�6�   6�   5  #   �� 5  "   $��3��6-   $ 
Horizontal=�6;   $��Center=�6T   $��Center=�6q   .+�5  &   �� $��./Fonts/#Super Mario 256)�60   $��Center=�6V   $��Center=�6s   $��25(�6�   
Volume =6�   �� 5  &   .+�5  *   �� -   5        $ SquarePyTop��5  4   $��Center=�6I   $��./Fonts/#Super Mario 256)�6f   $��25(�6�   	0 x 0 x 06�   �� 5  *   $��images/line.png��60   $��Center=�6I   $	��200��6f   6w   �� 5  *   -   5        $ TrapOutBottom��5  Z   $��./Fonts/#Super Mario 256)�64   $��Center=�6q   $��Center=�6�   $��25(�6�   36�   5  '   �� 5  &   -   5        $ SquarePyOut��5  �   $��./Fonts/#Super Mario 256)�60   $��Center=�6V   $��Center=�6s   $��25(�6�   = 0 units³6�   5  #   5     5     � 5     $��1��6    5     �� 5  "   $
��0.1* �60   6@   �� 5  "   $
��0.4* �60   6@   .+�5!     �� $��0��6$   $��images/spike.png��61   6M   �� 5"     $��1��6)   .+�5#  "   �� $��./Fonts/#Super Mario 256)�6(   $��15(�6N   $��Center=�6\   .��6y   A Square Pyramid is a6�   �� 5$  "   $��16(�6(   $��Center=�66   .��6S   
3D Shape6]   �� 5%  "   ���	#FF6C994E.��6?   !- It has a square on the bottom6`   �� 5&  "   ���	#FFCD6930.��6?   $"- There are 4 triangles which join6c   �� 5'  "   ���	#FFCD6930$��   together at a point��6?   6b   �� 5(  "   ���	#FF1ED15F.��6?   	- 5 Faces6J   �� 5)  "   $��0,5,0,0q�6)   
���   �$��0,5,0,0q�6W   ._�5*  &   �  5,  *   �� 5-  .   $
��0.2* �6?   6N   �� 5.  .   $��1* �6?   6L   �� 5/  .   $
��0.2* �6?   6N   .+�52  *   �� $��0��60   $��1��6=   $"��images/measure/square_py.png��6M   6u   56  '   57  #   �� 58  "   
���   �$��0,5,0,0q�6=   59  #   �� 5:  "   $��15(�6(   ���	#FF2D6EE0$��Center=�6M   $��Center=�6h   .��6�   Volume = Length x Length6�   �� 5;  "   $��15(�6(   ���	#FF2D6EE0$��Center=�6M   $��Center=�6j   .��6�   x height ÷ 36�   5<     5=     5>     5?     �� 5A     -   5        $ 	SphereTab��5A     $y�	Collapsed=�6-   .��5B     �  5C     �� 5D     $
��0.6* �6/   �� 5E     $
��0.3* �6/   .+�5H     �� 
���   �$��0,0,2,0q�65   ._�5I     �  5J  "   �� 5K  &   $��0.05* �64   6E   �� 5L  &   $
��0.5* �64   6D   �� 5M  &   $
��0.1* �64   6D   �� 5N  &   $
��0.1* �64   6D   .+�5P  "   �� -    5        $ SphereMeasure��5P  (   $ ��images/measure/sphere1.png��6?   $��1��6c   $��Center=�6p   $��Center=�6�   6�   �� 5R  "   $ 
Horizontal=�6-   $��2��6F   $��Center=�6S   $��Center=�6p   $
��10,0q�6�   .+�5S  &   �� $��./Fonts/#Super Mario 256)�60   $
��10,0q�6W   $��20(�6e   	Radius:6|   �� 5T  &   -!   5        $ SphereRadius��5T  T   $��./Fonts/#Super Mario 256)�6.   $
��10,0q�6j   $ 2��6x   $��30��6�   $��20(�6�   6�   5V  #   �� 5X  "   $��3��6-   $ 
Horizontal=�6;   $��Center=�6T   $��Center=�6q   .+�5Y  &   �� $��./Fonts/#Super Mario 256)�60   $��Center=�6V   $��Center=�6s   $��25(�6�   $��	Volume = ��6�   6�   �� 5Z  &   $ Vertical=�61   .+�5[  *   �� $��./Fonts/#Super Mario 256)�61   $��Center=�6W   $��Center=�6t   $��20(�6�   .��6�   46�   �� 5\  *   $��images/line.png��60   $��52��6I   $��8��6T   6a   �� 5]  *   $��./Fonts/#Super Mario 256)�61   $��Center=�6W   $��Center=�6t   $��20(�6�   .��6�   36�   5^  '   �� 5_  &   -"   5         ��Name$ 	SphereOut��5_  ,   $��./Fonts/#Super Mario 256)�6@   $��Center=�6f   $��Center=�6�   $��25(�6�   .��6�   x 3.14 x 0³ = 06�   5`  #   5a     5b     � 5d     $��1��6    5e     �� 5f  "   $
��0.1* �60   6@   �� 5g  "   $
��0.4* �60   6@   .+�5i     �� $��0��6$   $��images/yellow_toad.png��61   6S   �� 5j     $��1��6)   .+�5k  "   �� $��./Fonts/#Super Mario 256)�6(   $��15(�6N   $��Center=�6\   .��6y   A sphere is a special6�   �� 5l  "   $��16(�6(   $��Center=�66   .��6S   	3D shape!6^   �� 5m  "   ���	#FF6C994E.��6?   " - They are perfectly symmetrical6a   �� 5n  "   ���	#FF357A2E.��6?    - They have 0 edges or corners6_   �� 5o  "   ���	#FFC519E0.��6?   - They have one face6U   �� 5p  "   ���	#FF36B9B3.��6?   '%- The radius is the distance from the6f   �� 5q  "   ���	#FF36B9B3$&��   center to any part of the side��6?   6l   �� 5t  "   $��0,5,0,0q�6)   
���   �$��0,5,0,0q�6W   5v  #   � 5w  "    5x  &   �� 5y  *   $
��0.4* �6;   6J   �� 5z  *   $
��0.8* �6;   6J   �� 5{  *   $
��0.4* �6;   6J   .+�5}  &   �� $��1��6,   $��images/measure/sphere.png��6<   6a   5~  #   �� 5  "   $��0,5,0,0q�6)   
���   �$��0,5,0,0q�6W   5�  #   �� 5�  "   $ 
Horizontal=�6-   .+�5�  &   �� $��15(�6,   ���	#FF2D6EE0$��Center=�6Q   $��Center=�6l   .��6�   
Volume =6�   �� 5�  &   $ Vertical=�61   .+�5�  *   �� $��15(�60   ���	#FF2D6EE0$��Center=�6U   $��Center=�6p   .��6�   46�   �� 5�  *   $��images/line.png��60   $��50��6I   6V   �� 5�  *   $��15(�60   ���	#FF2D6EE0$��Center=�6U   $��Center=�6p   .��6�   36�   5�  '   �� 5�  &   $��15(�6,   ���	#FF2D6EE0$��Center=�6Q   $��Center=�6l   .��6�   
π x r³6�   5�  '   �� 5�  "   $��9(�6(   .��65   20- π is a special number, that equals about 3.146f   5�     5�     5�     5�     �� 5�     -#   5        $ ConeTab��5�     $y�	Collapsed=�6+   .��5�     �  5�     �� 5�     $
��0.6* �6/   �� 5�     $
��0.3* �6/   .+�5�     �� 
���   �$��0,0,2,0q�65   ._�5�     �  5�  "   �� 5�  &   $��0.05* �64   6E   �� 5�  &   $
��0.5* �64   6D   �� 5�  &   $
��0.1* �64   6D   �� 5�  &   $
��0.1* �64   6D   .+�5�  "   �� -$   5        $ CircleMeasure��5�  (   $��images/measure/cone1.png��6?   $��1��6a   $��Center=�6n   $��Center=�6�   6�   �� 5�  "   $ 
Horizontal=�6-   $��2��6F   $��Center=�6S   $��Center=�6p   $
��10,0q�6�   .+�5�  &   �� $��./Fonts/#Super Mario 256)�60   $
��10,0q�6W   $��20(�6e   	Radius:6|   �� 5�  &   -%   5        $ 
ConeRadius��5�  T   $��./Fonts/#Super Mario 256)�6.   $
��10,0q�6h   $ 2��6v   $��30��6�   $��20(�6�   6�   �� 5�  &   $��./Fonts/#Super Mario 256)�60   $
��10,0q�6W   $��20(�6e   	Height:6|   �� 5�  &   -&   5        $ 
ConeHeight��5�  T   $��./Fonts/#Super Mario 256)�6.   $
��10,0q�6h   $ 2��6v   $��30��6�   $��20(�6�   6�   5�  #   �� 5�  "   $��3��6-   $ 
Horizontal=�6;   $��Center=�6T   $��Center=�6q   .+�5�  &   �� $��./Fonts/#Super Mario 256)�60   $��Center=�6V   $��Center=�6s   $��25(�6�   Volume = 3.146�   �� 5�  &   -'   5        $ ConeLeft��5�  0   $��./Fonts/#Super Mario 256)�6B   $��Center=�6h   $��Center=�6�   $��25(�6�   $��	 x 0² x ��6�   6�   �� 5�  &   $ Vertical=�61   .+�5�  *   �� -(   5        $ ConeTop��5�  0   $��./Fonts/#Super Mario 256)�6B   $��Center=�6h   $��Center=�6�   $��20(�6�   .��6�   06�   �� 5�  *   $��images/line.png��60   $��30��6I   $��8��6T   6a   �� 5�  *   $��./Fonts/#Super Mario 256)�61   $��Center=�6W   $��Center=�6t   $��20(�6�   .��6�   36�   5�  '   �� 5�  &   -)   5        $ ConeOut��5�  P   $��WrapWithOverFlow=�60   $��./Fonts/#Super Mario 256)�6a   $��Center=�6�   $��Center=�6�   $��25(�6�   $
�� = 0��6�   6�   5�  #   5�     5�     � 5�     $��1��6    5�     �� 5�  "   $
��0.1* �60   6@   �� 5�  "   $
��0.4* �60   6@   .+�5�     �� $��0��6$   $��images/toad.png��61   6L   �� 5�     $��1��6)   $��Center=�66   $��Center=�6S   .+�5�  "   �� $��./Fonts/#Super Mario 256)�6(   $��16(�6N   $��Center=�6\   .��6y   A cone is a pyramidal6�   �� 5�  "   $��16(�6(   $��Center=�66   .��6S   
3D shape6]   �� 5�  "   ���	#FF6C994E.��6?   - It has a flat, circle base6]   �� 5�  "   ���	#FFC519E0.��6?   - It has one curved side6Y   �� 5�  "   ���	#FFCD6930.��6?   - Two faces in total6U   �� 5�  "   ���	#FF6BE823.��6?   - Has one corner6Q   �� 5�  "   $��0,5,0,0q�6)   
���   �$��0,5,0,0q�6W   � 5�  "    5�  &   �� 5�  *   $
��0.1* �6;   6J   �� 5�  *   $
��0.3* �6;   6J   �� 5�  *   $
��0.1* �6;   6J   .+�5�  &   �� $��1��6,   $��images/measure/cone.png��6<   6_   5�  #   �� 5�  "   $��0,5,0,0q�6)   
���   �$��0,5,0,0q�6W   5�  #   �� 5�  "   $��15(�6,   ���	#FF2D6EE0$��WrapWithOverflow=�6Q   $��Center=�6q   $��0,5,0,0q�6�   $��Center=�6�   Volume = π x radius²6�   �� 5�  "   $��15(�6,   ���	#FF2D6EE0$��Center=�6Q   $��Center=�6n   x height ÷ 36�   �� 5�  "   $��9(�6(   $��Center=�65   $��Center=�6Y   $��Center=�6{   .��6�   20- π is a special number, that equals about 3.146�   5�     5�     5�     5�     �� 5�     -*   5        $ CylinderTab��5�     $y�	Collapsed=�6/   .��5�     �  5�     �� 5�     $
��0.6* �6/   �� 5�     $
��0.3* �6/   .+�5�     �� 
���   �$��0,0,2,0q�65   ._�5�     �  5�  "   �� 5�  &   $��0.05* �64   6E   �� 5�  &   $
��0.5* �64   6D   �� 5�  &   $
��0.1* �64   6D   �� 5�  &   $
��0.1* �64   6D   .+�5�  "   �� -+   5        $ RhombusMeasure��5�  (   $"��images/measure/cylinder1.png��6@   $��1��6f   $��Center=�6s   $��Center=�6�   6�   �� 5�  "   $ 
Horizontal=�6-   $��2��6F   $��Center=�6S   $��Center=�6p   $
��10,0q�6�   .+�5�  &   �� $��./Fonts/#Super Mario 256)�60   $
��10,0q�6W   $��20(�6e   Radius6{   �� 5�  &   -,   5        $ CylinderRadius��5�  T   $��./Fonts/#Super Mario 256)�6.   $
��10,0q�6l   $ 2��6z   $��30��6�   $��20(�6�   6�   �� 5�  &   $��./Fonts/#Super Mario 256)�60   $
��10,0q�6V   $��20(�6d   Height6z   �� 5�  &   --   5        $ CylinderHeight��5�  T   $��./Fonts/#Super Mario 256)�6.   $
��10,0q�6l   $ 2��6z   $��30��6�   $��20(�6�   6�   5�  #   �� 5�  "   $��3��6-   $ 
Horizontal=�6;   $��Center=�6T   $��Center=�6q   .+�5�  &   �� -.   5        $ CylinderOut��5�  0   $��./Fonts/#Super Mario 256)�6E   $��Center=�6k   $��Center=�6�   $��25(�6�   %#Volume = 3.14 x 0² x 0 = 0 units²6�   5�  #   5�     5�     � 5�     $��1��6    5�     �� 5�  "   $
��0.1* �60   6@   �� 5�  "   $
��0.4* �60   6@   .+�5�     �� $��0��6$   $��images/kamek.png��61   6M   �� 5      $��1��6)   .+�5  "   �� $��./Fonts/#Super Mario 256)�6(   $��15(�6N   $��Center=�6\   .��6y   A cylinder is a 3D6�   �� 5  "   $��16(�6(   $��Center=�66   .��6S   shape6Z   �� 5  "   ���	#FF6C994E.��6?   - The two ends are circles6[   �� 5  "   ���	#FF357A2E.��6?   - there one curved side6X   �� 5  "   ���	#FFC519E0.��6?   - Three sides in total6W   �� 5  "   $��0,5,0,0q�6)   
���   �$��0,5,0,0q�6W   5
  #   � 5  "    5  &   �� 5  *   $
��0.1* �6;   6J   �� 5  *   $
��0.1* �6;   6J   �� 5  *   $
��0.1* �6;   6J   .+�5  '   �� $��1��6-   $!��images/measure/cylinder.png��6=   6d   5  #   �� 5  "   $��0,5,0,0q�6)   
���   �$��0,5,0,0q�6W   5  #   �� 5  "   $��15(�6(   ���	#FF2D6EE0$��Center=�6M   $��Center=�6h   .��6�    Volume = π x radius²x height6�   �� 5  "   $��9(�6(   $��Center=�65   $��Center=�6Y   $��Center=�6{   .��6�   20- π is a special number, that equals about 3.146�   5     5     5     5     5     � 5     $��0��6   $��1��6    � 	Resources 5         MyButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType��%�   &	        �� 5!     " ��62   .�5"     ��  � �� 5#     �� 5$  "   " ��62   .R�5%  &   � #��z��6+   .+�5&  *   �� $��Center=�6;   $��Center=�5'  ?   5(  '   5)  #   5+     5,     5.      5/     �� 50     $
��0.1* �6$   �� 51     $
��0.1* �6$   �� 52     $
��0.1* �6$   �� 53     $
��0.1* �6$   �� 54     $
��0.1* �6$   �� 55     $
��0.1* �6$   .+�58     �� -/   5        $ RectangleButton��58     $	��0,5q�63   $��0��6@   $��5q�6M   $��Center=�6Y   
��� ���
�������$��0q�6�   $��Stretch=�6�   $��Stretch=�6�   $��Center=�6�   .��59     �  5:     �� 5;     $
��0.5* �6,   6<   �� 5<     $��* �6,   69   .+�5?     �� $��./Fonts/#Super Mario 256)�6$   $��12(�6J   $��Center=�6X   $��Center=�6u   $��0q�6�   
���   �Rectanglar Prism5A     �� 5B     $��1��6    $"��images/shapes/rect_prism.png��6-   $��Center=�6S   $��Center=�6p   5C     5D     �� 5F     -0   5        $ TrianglePyButton��5F     $	��0,5q�63   $��1��6@   $��5q�6M   $��Center=�6Y   $��./Fonts/#Super Mario 256)�6}   $��0q�6�   
��� � �.��5G     �  5H     �� 5I     $
��0.5* �6,   6<   �� 5J     $��* �6,   69   .+�5M     �� $��./Fonts/#Super Mario 256)�6$   $��0q�6J   $��Center=�6U   $��Center=�6r   $��13(�6�   Triangular Prism5O     �� 5P     $��1��6    $!��images/shapes/tri_prism.png��6.   $��Center=�6S   $��Center=�6p   5Q     5R     �� 5T     -1   5        $ SquarePyButton��5T     $	��0,5q�61   $��2��6>   $��5q�6K   $��Center=�6W   $��0q�6{   
����� �.��5U     �  5V     �� 5W     $
��0.5* �6,   6<   �� 5X     $��* �6,   69   .+�5Z     �� $��./Fonts/#Super Mario 256)�6$   
���   �$��Center=�6]   $��Center=�6z   Square Pyramid5\     �� 5]     $��1��6    $!��images/shapes/square_py.png��6-   $��Center=�6R   $��Center=�6o   5^     5_     �� 5a     -2   5        $ SphereButton��5a     $	��0,5q�6/   $��3��6<   $��5q�6I   $��Center=�6U   $��0q�6y   
����p��.��5b     �  5c     �� 5d     $
��0.5* �6,   6<   �� 5e     $��* �6,   69   .+�5h     �� $��./Fonts/#Super Mario 256)�6$   
���   �$��Center=�6]   $��Center=�6z   $��16(�6�   Sphere5j     �� 5k     $��1��6    $��images/shapes/sphere.png��6-   $��Center=�6O   $��Center=�6l   5l     5m     �� 5o     -3   5        $ 
ConeButton��5o     $	��0,5q�6-   $��4��6:   $��5q�6G   $��Center=�6S   $��0q�6w   
��� ���.��5p     �  5q     �� 5r     $
��0.5* �6,   6<   �� 5s     $��* �6,   69   .+�5u     �� $��./Fonts/#Super Mario 256)�6$   
���   �$��16(�6]   $��Center=�6k   $��Center=�6�   Cone5w     �� 5x     $��1��6    $��images/shapes/cone.png��6-   $��Center=�6M   $��Center=�6j   5y     5z     �� 5|     -4   5        $ CylinderButton��5|     $	��0,5q�61   $��5��6>   $��5q�6K   
��� E��.��5}     �  5~     �� 5     $
��0.5* �6,   6<   �� 5�     $��* �6,   69   .+�5�     �� $��./Fonts/#Super Mario 256)�6$   $��16(�6J   $��Center=�6X   $��Center=�6u   
Cylinder6�   �� 5�     $��1��6    $ ��images/shapes/cylinder.png��6-   5�     5�     5�     5�     5�     5�     