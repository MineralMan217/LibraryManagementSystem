   M S B A M L   `   `   `  ����B  >MockOne, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MockOneMockOne  5   	       MockOne.Rules_Replace   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:MockOne     5   	   -   5          � Title$  RULES FOR REPLACING BOOKS��5   	   $	��450��6+   $	��800��68   ��5	      �� 5
   
    �� ImageSource$ /resources/general_bg.jpg��6    �� Opacity$	 0.2Q�6=    � 	Resources 5         RoundButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType ��Name	 �� CornerRadius
 �� Padding �� Triggers P� Property P� Value �� 
TargetName��%�  &	        �� 5   
   " ��6)   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $ border��6!   #��z��61   #��z��5   !   $��1q�6M   $	 25��5   !   $
 5q�63   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5       �@J�IsMouseOver$
 True��6=   . �5   "   �� $ border��6)    � �� �#1203076S   �� 5   "   $ border��6)    � �� �#9417396T   5      5      5      5      5       .��5!      � .+�5"   
   �� -   5         ��Name$ 
backButton��5"      $��51��6%   $
��Left=�6I   $��
0,-6,0,373q�6d   ��5#      �� 5$      " ��6"   .R�5%      � .+�5&      �� $��Center=�6+   $��Center=�6H   5'      5(      ��5*      �� 5+      -   5         ��Name$ backImg��5+      $ ��\resources\back-button.png��6*   $��Uniform=�6O   $��36��6a   $��26��6m    J� RenderTransformOrigin$ 	0.614,0.5&�6x   5-      �� 5.   
   -   5         ��Name$ 
rulesLabel��5.      $��Instructions:��6$   $
��19px(�6<   
�������$
��Bold"�6_   $
��Left=�6q   $��	56,30,0,0q�6�   $	��Top=�6�   $��36��6�   $	��186��6�   �� 5/   
   -   5        $ 
rule1Label��5/      $Y��S1. Press *PLAY* to start the game and populate both tables with random Call Numbers��6$   $
��13px(�6�   
�������$
��Bold"�6�   $
��Left=�6�   $��	34,66,0,0q�6�   $	��Top=�6�   $��36��6�   $	��553��6	  �� 50   
   -   5         ��Name$ rule1Description��50      $u��o (this will populate both tables one table is for unordered call numbers, and the other is for reordering them)��6.   $
��13px(�6�   
����·�$
��Bold"�6�   $
��Left=�6�   $��
48,102,0,0q�6�   $	��Top=�6  $��19��6#  $	��669��6/  �� 52   
   -   5        $ 
rule2Label��52      $n��h2. Press *REORDER* to shuffle/reorder the Call Numbers so that they are in ascending order (numerically)��6$   $
��13px(�6�   
�������$
��Bold"�6�   $
��Left=�6�   $��
34,142,0,0q�6�   $	��Top=�6�   $��30��6  $	��656��6  �� 53   
   -   5        $ rule2Description��53      $w��q (press this button (x) many times until you are satisfied that the call numbers are in order. repeat this cycle)��6.   $
��13px(�6�   
����·�$
��Bold"�6�   $
��Left=�6�   $��
48,172,0,0q�6�   $	��Top=�6  $��24��6%  $	��681��61  �� 55   
   -	   5        $ 
rule3Label��55      $f��`3. After Reordering, press *CHECK* to check if the reordered Call Numbers are in ascending order��6$   $
��13px(�6�   
�������$
��Bold"�6�   $
��Left=�6�   $��
34,217,0,0q�6�   $	��Top=�6�   $��30��6  $	��656��6  �� 56   
   -
   5        $ rule3Description��56      $d��^ (press this button every time you are satisfied that the call numbers are in ascending order)��6.   $
��13px(�6�   
����·�$
��Bold"�6�   $
��Left=�6�   $��
48,247,0,0q�6�   $	��Top=�6�   $��22��6  $	��621��6  �� 57   
   -   5        $ rule4Description��57      $s��m (whether or not your order is correct after *CHECKING*, you must keep *REORDERING* until your time runs out)��6.   $
��13px(�6�   
����·�$
��Bold"�6�   $
��Left=�6�   $��
27,274,0,0q�6�   $	��Top=�6	  $��28��6!  $	��723��6-  �� 58   
   -   5        $ rule5Description��58      $&��  (ARRANGE THE CALL NUMBERS GAME)��6.   $
��13px(�6V   
�������$
��Bold"�6y   $
��Left=�6�   $��
268,30,0,0q�6�   $	��Top=�6�   $��28��6�   $	��251��6�   �� 5;   
   -   5        $ generalRule1��5;      $;��5*TIMER (80 SECONDS) STARTS AS SOON AS YOU PRESS PLAY*��6*   $
��12px(�6g   
�������$
��Bold"�6�   $
��Left=�6�   $��
10,342,0,0q�6�   $	��Top=�6�   $��18��6�   $	��384��6�   �� 5<   
   -   5        $ generalRule2��5<      $:��4*IF CALL NUMBER ORDER IS CORRECT, THAT'S +15 POINTS*��6*   $
��12px(�6f   
�������$
��Bold"�6�   $
��Left=�6�   $��
10,365,0,0q�6�   $	��Top=�6�   $��18��6�   $	��384��6�   �� 5=   
   -   5        $ generalRule3��5=      $;��5*IF CALL NUMBER ORDER IS INCORRECT, THAT'S -4 POINTS*��6*   $
��12px(�6g   
�������$
��Bold"�6�   $
��Left=�6�   $��
10,388,0,0q�6�   $	��Top=�6�   $��18��6�   $	��384��6�   �� 5@   
   -   5        $ 
playNowBtn��5@      $��PLAY NOW��6%   $
��Left=�68   $	��Top=�6S   $	��200��6k   $��50��6w    J� Opacity$ 0Q�5A      
���   �
�������$��16(�6C   #��[  6Q   $��505,342,0,0q�6�   z�5B      T� 5C       � Triggers 5E      :� 5F       :� RoutedEvent$ Button.Loaded��6   .[�5G      �� .��5H      ��  g� RepeatBehavior$ Forever��6%   .��5I      W�  �� TargetProperty$ Opacity�6.    W� From 06R   	 W� To 16[    g� Duration$ 0:0:1D�6b   W� 5J      $5 /(Button.RenderTransform).(TranslateTransform.Y)�6.    06z    -286�   $ 0:0:0.5D�6�    g� AutoReverse$
 True��6�   5K      5L      5M      5O      5Q      5R      