   M S B A M L   `   `   `  ����F  BMarioShapes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WPF_Shapes
WPF_Shapes  5   	       WPF_Shapes.SelectorScreen   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WPF_Shapes     5   	   -   5          � Title$  Choose your activity!��5   	   $	��600��6'   $	��600��64    � Icon$ images/icon.ico��6W   ��5	      �� 5
   
    �� ImageSource$ images/images.jpg��6   .��5      �  � RowDefinitions 5   
   �� 5      $
��0.1* �6   �� 5      $
��0.3* �6   �� 5      $
��0.1* �6   �� 5      $
��0.2* �6   �� 5      $
��0.2* �6   �� 5      $
��0.2* �6   �� 5      $
��0.1* �6    � ColumnDefinitions 5   
   �� 5      $
��195* �6   �� 5      $	��71* �6   �� 5      $	��83* �6   �� 5      $
��243* �6   .+�5   
   �� -   5         ��Name$ 
quizButton��5      $��./Fonts/#Super Mario 256)�6%   $
��Quiz��6K   $��1��6Z   $��3��6g   $��36,12,44,10q�6w   $��30(�6�   ��6�   Z� �� 5    
   -   5        $ threeDimButton��5       $��./Fonts/#Super Mario 256)�6)   $��	3D Shapes��6O   $��3��6c   $��22,65,194,10q�6p   $��30(�6�   $��3��6�   $��1��6�   $��2��6�   ��5!      �� 5"      $ images/arrow_down.png��6   5$      �� 5&   
   -   5        $ twoDimButton��5&   8   $��./Fonts/#Super Mario 256)�6   $��	2D Shapes��6N   $��5��6b   $��3��6o   $��	46,15,0,0q�6   $��30(�6�   ��5'      �� 5(      $ images/arrow_right.png��6    j� Stretch$ Uniform=�6B   5*      �� 5+   
   -   5         ��Name$ 	VineImage��5+      $��3��6#   $
��Left=�63   $	��225��6N   $��	141,0,0,0q�6[   $	��Top=�6n   $	��100��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��images/vine.png��6�   $��3��6�   z�5,      V� 5-      .~�5.      �� �� 5/      �� 50      	 �� Angle$		 180Q�6&   T� 51      52      54      �� 55   
   -   5        $ 
ExitButton��55      $��Exit?��6%   $
��Left=�65   $��./Fonts/#Super Mario 256)�6P   $	��Top=�6v   $	��116��6�   $��84��6�   $��2��6�   $��5��6�   $��0,15,0,0q�6�   $��24(�6�   ��56      �� 57      $ images/arrow_left.png��6   59      �� 5;   
   -   5        $ 
MuteButton��5;      $
��Left=�6%   $	��Top=�6@   $��64��6X   $��48��6c   ��6o   Z� .��5=      �� -   5        $ 	MuteImage��5=      $��images/no_mute.png��6'   5>      5?      5@      