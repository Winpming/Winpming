   M S B A M L   `   `   `  ����F  BProject_WPM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Project_WPMProject_WPM  5   	       Project_WPM.MenuWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Project_WPM     5   	     � Title$  
MenuWindow��5   	   $	��700��6   $
��1000��6)   .��5	      � ��5
   
   �� 5       �� ImageSource$/ )/Resources/background/background_cake.jpg��6    j� 
AlignmentY$	 Top=�6R    j� 
AlignmentX$ Center=�6c   .+�5   
   �� .+�5      � $	��251��6   $��
0,0,-0.4,0q�6    ��5      �� 5       j� Stretch$
 Fill=�6!   $( "/Resources/background/text_one.png��60   $	 Top=�6a   $ Center=�6r   5      �� 5      -   5         ��Name$ btn_easy��5      $��	Easy Mode��5      $��center=�5      $	��230��63   $��58��6?   $��30(�5       J� SnapsToDevicePixels . $��0q�6U   ��5      �� 5       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5      � 	 � Color$	 	#FF6186F0��6'   
 � Offset$
 0Q�69   � 5      $	 	#FF7FEDEB��6'   $
 1Q�69   5       � ContextMenu 5      �� 5      5!      �� 5"      -   5        $ 
btn_normal��5"      $��Normal Mode��5#      $��
0,50,0.2,0q�5$      $��Center=�6)   $	��230��6F   $��58��6R   $��30(�5%      ��5&      �� 5'      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5(      � $	 	#FF72FF56��6'   $
 0Q�69   � 5)      $	 	#FFF1C438��6'   $
 0.994Q�69   5*      5,      �� 5-       �� Orientation$ 
Horizontal=�6   $��Center=�5.      $	��696��66   $��160,20,137.6,0q�6B   .+�5/      �� -   5        $ btn_hard��5/      $��220,30,50,50q�50      $��Center=�6,   $	��230��6I   $��58��6U   $��30(�51      $��	Hard Mode��52      ��53      �� 54      $ 0.5,1&�6.   $ 0.5,0&�6?   .��55      � $	 	#FFEB9260��6+   $
 0Q�6=   � 56      $	 	#FFF62626��6+   $
 1Q�6=   57      59      �� 5:      -   5        $ btn_back��5:      $��뒤로가기��5;      $��50��6(   $	��100��6L   $��20(�5<      $��50,0,0,0q�5=      ���	#FFC6BBC86+   5>      5?      5@      5A      