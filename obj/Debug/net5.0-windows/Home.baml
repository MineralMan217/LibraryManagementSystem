   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   B >MockOne, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MockOneMockOne 5	   	      MockOne.Home   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   Hei9http://schemas.microsoft.com/expression/2010/interactions     5   	   Cee4http://schemas.microsoft.com/expression/2010/effects     5   	   'localclr-namespace:MockOne     5	   	   -   5          � Title$
  Home��5   	   $	��450��6   $	��800��6#   ��5      �� 5   
    �� ImageSource$ /resources/home2.jpeg��6    �� Opacity$	 0.7Q�69    � 	Resources 5         RoundButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType ��Name	 �� CornerRadius
 �� Padding �� Triggers P� Property P� Value �� 
TargetName��%�  &	        �� 5   
   " ��6)   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $ border��6!   #��z��61   #��z��5   !   $��1q�6M   $	 25��5   !   $
 5q�63   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5       �@J�IsMouseOver$
 True��6=   . �5   "   �� $ border��6)    � ��
 �  ��6S   �� 5   "   $ border��6)    � ��
 � ���6T   5      5      5!      5"      5#      .��5$      � .+�5'   
   �� $��1q�6   ���#33001a$��Center=�6;   $��89��6X   $	��Top=�6d   $	��800��6|    J� Opacity$	 0.9Q�6�   $��0,21,0,0q�6�   ._�5(      �� -   5         ��Name$ 	HeaderLbl��5(      $%��BOOK DUES: DEWEY DECIMAL SYSTEM��6'   
�������$
��26px(�6d   $��	ExtraBold"�6t   $��Times New Roman)�6�   $��	0,0,212,0q�6�   5)      �� 5+   
   -   5         ��Name$ replaceButton��5+      $	��163��6(   $
��Left=�6P   $��81,184,0,105q�6k   #��[  6�   ��5,      �� 5-      " ��6"   .R�5.      � .+�5/      �� $��Center=�6+   $��Center=�6H   50      51      ��53      �� 54      -   5         ��Name$ 
replaceImg��54      $!��resources\replace-books.png��6.   $��Uniform=�6S   $	��132��6e   $	��159��6r    � Triggers 56      :� 57       :� RoutedEvent$ Button.Loaded��6   .[�58      �� .��59      ��  g� RepeatBehavior$ Forever��6%   .��5:      W�  �� TargetProperty$5 /(Button.RenderTransform).(TranslateTransform.Y)�5;       W� From 05<      	 W� To -106"    g� Duration$ 0:0:1D�6+    g� AutoReverse$
 True��6<   5=      5>      5?      z�5A      T� 5B      5D      �� 5E   
   -   5        $ replaceBooksLbl��5E      $��REPLACING BOOKS��6)   $
��15px(�6C   
�������$��Italic$�6f   $��DemiBold"�6y   $
��Left=�6�   $��
93,325,0,0q�6�   $	��Top=�6�   $	��151��6�   �� 5G   
   -   5        $ identifyButton��5G      $	��148��6)   $��Center=�6R   $��
0,196,0,58q�6o   #��[  6�   ��5H      �� 5I      " ��6"   .R�5J      � .+�5K      �� $��Center=�6+   $��Center=�6H   5L      5M      ��5O      �� 5P      -   5        $ identifyImg��5P      $#��\resources\identify-areas.png��6.   $��Uniform=�6U   $	��147��6g   $	��138��6t    5R      :� 5S      $ Button.Loaded��6   .[�5T      �� .��5U      �� $ Forever��6%   .��5V      W� $5 /(Button.RenderTransform).(TranslateTransform.Y)�5W       05X       -106"   $ 0:0:1D�6+   $
 True��6<   5Y      5Z      5[      z�5]      T� 5^      5`      �� 5a   
   -   5        $ identifyAreasLbl��5a      $��IDENTIFYING AREAS��6*   $
��15px(�6F   
�������$��Italic$�6i   $��DemiBold"�6|   $��Center=�6�   $��	0,361,0,0q�6�   $	��Top=�6�   �� 5d   
   $
��Left=�6   $	��100��6+   $��
669,66,0,0q�68   $	��Top=�6L   $	��100��6d   $ ��resources\library-icon.png��6p   $	 0.8Q�6�   �� 5e   
   -	   5        $ findCallButton��5e      $	��182��6)   $
��Left=�6R   $��556,179,0,100q�6m   #��[  6�   ��5f      �� 5g      " ��6"   .R�5h      � .+�5i      �� $��Center=�6+   $��Center=�6H   5j      5k      ��5m      �� 5n      -
   5        $ findCallImg��5n      $&�� \resources\find-call-numbers.png��6.   $��Uniform=�6X   $	��151��6j   $	��156��6w    5p      :� 5q      $ Button.Loaded��6   .[�5r      �� .��5s      �� $ Forever��6%   .��5t      W� $5 /(Button.RenderTransform).(TranslateTransform.Y)�5u       05v       -106"   $ 0:0:1D�6+   $
 True��6<   5w      5x      5y      z�5{      T� 5|      5~      �� 5   
   -   5        $ findCallLbl��5      $��FINDING CALL NUMBERS��6%   $
��15px(�6D   
�������$��Italic$�6g   $��DemiBold"�6z   $
��Left=�6�   $��556,325,0,0q�6�   $	��Top=�6�   5�      5�      