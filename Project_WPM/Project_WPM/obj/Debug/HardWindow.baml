   M S B A M L   `   `   `  ����F  BProject_WPM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Project_WPMProject_WPM  5   	       Project_WPM.HardWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Project_WPM     5   	   -   5          �Name$  
hardwindow��5	   	    � Title$ 
HardWindow��5   	   $	��700��6   $
��1000��6)   .��5      ��  �� Orientation$ 
Horizontal=�6   $��
0,20,10,40q�5      .+�5   
   A� -   5         A�Name$ 	gameBoard��5      $��20,0,20,0.4q�5      $
��700 ��6+   5      �� 5   
   $ Vertical=�6   $��0,20,20,20.4q�6,   $	��238��6B   .+�5      �� $��	Hard Mode��6   $��Center=�5      $��0,0,0,30q�5      $��30(�5      �� 5      $ 
Horizontal=�6   $��Center=�5      $��10q�5      
�������.+�5      �� $��남은카드��6   $��25(�5      5      �� 5      $��Center=�5      
�������$��30(�5"      ��5      �� *	Matched+ �� ElementName$ 
hardwindow��5"      �� 5$      -   5         ��Name$ btn_stop��5$      $��일시정지��5%      $	��120��5&      $��40��5'      $��10,100,10,0q�5(      $��20(�5)      5*      �� 5+      -   5        $ btn_exit��5+      $��	나가기��5,      $	��120��5-      $��40��5.      $��
10,10,10,0q�5/      $��20(�50      51      �� 52      $ 
Horizontal=�6   $��Center=�53      $��10,50,10,10q�54      
��� E��.+�57      �� $��Timer :��6   
�������$��30(�59      �� 5:      -   5         ��Name$ label1��5:      $��2q�5<      
�������$��30(�5>      ��5;      ��  �� Path$ Count� �� Mode$ OneWay=�5>      5?      � 5@      -   5        	 �Name$	 progressbar��5@      
 � Minimum$
 0Q�5A       � Maximum$ 50Q�5B      $��30��5C      $��10,10,10,10q�5D      $��Right=�5E   5   $	��218��6Q    � Value 6   �� $ Count�6Q   5G      5H      5K      