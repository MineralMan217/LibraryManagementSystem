   M S B A M L   `   `   `  ����B  >MockOne, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MockOneMockOne  5   	       MockOne.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:MockOne     5   	   -   5          � Title$  	BOOK DUES��5   	   $	��450��6   $	��800��6(   ��5	      �� 5
   
    �� ImageSource$ /resources/main2.jpg��6    �� Opacity$	 0.8Q�68    � 	Resources 5         RoundButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType ��Name	 �� CornerRadius
 �� Padding �� Triggers P� Property P� Value �� 
TargetName��%�  &	        �� 5   
   " ��6)   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $ border��6!   #��z��61   #��z��5   !   $��1q�6M   $	 25��5   !   $
 5q�63   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5       �@J�IsMouseOver$
 True��6=   . �5   "   �� $ border��6)    � �� �#05140b6S   �� 5   "   $ border��6)    � �� �#25a35a6T   5      5      5      5      5       .��5!      � $��0,10,0,0q�6   .+�5"   
   �� -   5         ��Name$ startButton��5"      $��Get Started��6&   $��Center=�6<   $	��Top=�6Y   $	��200��6q   $��50��6}    J� Opacity$ 0Q�5#      ���#33001a
�������$��16(�6E   #��[  6S   $��	0,290,0,0q�6�   z�5$      T� 5%       � Triggers 5'      :� 5(       :� RoutedEvent$ Button.Loaded��6   .[�5)      �� .��5*      ��  g� RepeatBehavior$ Forever��6%   .��5+      W�  �� TargetProperty$ Opacity�6.    W� From 06R   	 W� To 16[    g� Duration$ 0:0:3D�6b   W� 5,      $5 /(Button.RenderTransform).(TranslateTransform.Y)�6.    06z    -206�   $ 0:0:1D�6�    g� AutoReverse$
 True��6�   5-      5.      5/      51      �� 52   
   $��1q�6   ���#33001a$��Center=�6;   $��81��6X   $	��Top=�6d   $	��800��6|   $	 0.9Q�6�   ._�53      �� -   5         ��Name$ 	HeaderLbl��53      $%��BOOK DUES: DEWEY DECIMAL SYSTEM��6'   
�������$
��26px(�6d   $��	ExtraBold"�6t   $��Times New Roman)�6�   $��	9,0,-1,-1q�6�   54      �� 55   
   $
��Left=�6   $	��100��6+   $��
660,40,0,0q�68   $	��Top=�6L   $	��100��6d   $!��\resources\library-icon.png��6p   $	 0.8Q�6�   �� 57   
   $��1q�6   ���#03254c$��Center=�6:   $��8��6W   $��	0,416,0,0q�6b   $	��Top=�6u   $	��800��6�   58      5:      