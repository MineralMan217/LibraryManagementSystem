   M S B A M L   `   `   `  ����B  >MockOne, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MockOneMockOne  5   	       MockOne.IdentifyAreas   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:MockOne     5   	     � Title$  IDENTIFYING AREAS��5   	   $	��450��6#   $	��800��60   ��5	      �� 5
   
    �� ImageSource$ /resources/shelf.jpeg��6    �� Opacity$	 0.5Q�69   .��5      � .+�5   
   �� -   5         ��Name$ 
backButton��5      $��51��6%   $
��Left=�6I   $��-2,20,0,347q�6d   ��5      �� 5       �� 
TargetType" ��6"   .R�5      � .+�5      �� $��Center=�6+   $��Center=�6H   5      5      ��5      �� 5      -   5         ��Name$ backImg��5      $ ��\resources\back-button.png��6*   $��Uniform=�6O   $��44��6a   $��39��6m    J� RenderTransformOrigin$ 	0.614,0.5&�6x   5      �� 5   
   -   5         ��Name$ 
matchLabel��5      $:��4Match the Call Numbers to their correct descriptions��6$   $
��13px(�6c   $y�Hidden=�6s   
�������$
��Left=�6�   $��	94,61,0,0q�6�   $	��Top=�6�   $��26��6�   $	��325��6�   �� 5   
   $��0��6   $��20(�6!   $
��Bold"�6/   $��Center=�6A   $
��0,20q�6^   
�������Identifying Areas6�   �� 5   
   -   5         ��Name$ callNumberListBox��5      $��204,107,398,60q�6-   	 �� SelectionMode$	 Multiple=�6E   $ 0.5,0.5&�6^   
����������	#FFFF006F��5       �� 5!      
 �� EndPoint$
 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5"      �  � Color$ Black��6#   � 5#      $ 	#FF0E4B42��6#    � Offset$ 1Q�65   5$      z�5&      V� 5'      .~�5(      �� �� 5)      �� 5*       �� Angle$ 0.015Q�6&   T� 5+      5,      ��5/      �� 50      .R�51      �� ��6    �� 52      54      �� 56   
   -   5        $ descriptionListBox��56      $��415,109,10,60q�6.   $	 Multiple=�6E   ���	#FFFF8303
���������57      �� 58      $
 0.5,1&�6&   $ 0.5,0&�67   .��59      � $ Black��6#   � 5:      $ 	#FF4B2867��6#   $ 1Q�65   5;      ��5>      �� 5?      .R�5@      �� ��6    �� 5A      5C      �� 5D   
   -   5        $ startButton��5D      $��START��6&   
�������$
��16px(�6N   $
��Bold"�6^   $��Times New Roman)�6p   ���#330000���#b30000$
��Left=�6�   $��
24,109,0,0q�6�   $	��Top=�6�   $��50��6�   $	��120��6  6  �� 5E   
   -   5        $ matchButton��5E      $��MATCH��6&   
�������$
��16px(�6N   $
��Bold"�6^   $��Times New Roman)�6p   ���#092917���#25a35a$
��Left=�6�   $��
24,242,0,0q�6�   $	��Top=�6�   $��50��6�   $	��120��6  $y�Hidden=�61  �� 5F   
   -   5        $ 
quitButton��5F      $
��QUIT��6%   
�������$
��16px(�6L   $
��Bold"�6\   $��Times New Roman)�6n   ���#812953���#2a0010$
��Left=�6�   $��
24,310,0,0q�6�   $	��Top=�6�   $��50��6�   $	��120��6	  $y�Hidden=�6.  �� 5G   
   -	   5        $ 
timerLabel��5G      $��TIME LEFT: 120 seconds��6$   
�������$��	ExtraBold"�6]   $
��Left=�6t   $	��Top=�6�   $��
534,61,0,0q�6�   $	��178��6�   �� 5H   
   -
   5        $ pointsLabel��5H      $��	POINTS: 0��6%   
�������$��	ExtraBold"�6Q   $��Right=�6h   $	��Top=�6�   $��
0,41,174,0q�6�   5K      5L      