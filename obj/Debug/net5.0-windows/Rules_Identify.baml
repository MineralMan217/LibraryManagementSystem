   M S B A M L   `   `   `  ����B  >MockOne, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MockOneMockOne  5   	       MockOne.Rules_Identify   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:MockOne     5   	   -   5          � Title$!  RULES FOR IDENTIFYING AREAS��5   	   $	��450��6-   $	��800��6:   ��5	      �� 5
   
    �� ImageSource$ /resources/shelf.jpeg��6    �� Opacity$	 0.3Q�69    � 	Resources 5         RoundButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType ��Name	 �� CornerRadius
 �� Padding �� Triggers P� Property P� Value �� 
TargetName��%�  &	        �� 5   
   " ��6)   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $ border��6!   #��z��61   #��z��5   !   $��1q�6M   $	 25��5   !   $
 5q�63   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5       �@J�IsMouseOver$
 True��6=   . �5   "   �� $ border��6)    � �� �#3300006S   �� 5   "   $ border��6)    � �� �#b300006T   5      5      5      5      5       .��5!      � .+�5"   
   �� -   5         ��Name$ 
backButton��5"      $��51��6%   $
��Left=�6I   $��	0,4,0,368q�6d   ��5#      �� 5$      " ��6"   .R�5%      � .+�5&      �� $��Center=�6+   $��Center=�6H   5'      5(      ��5*      �� 5+      -   5         ��Name$ backImg��5+      $ ��\resources\back-button.png��6*   $��Uniform=�6O   $��34��6a   $��42��6m    J� RenderTransformOrigin$ 	0.614,0.5&�6x   5-      �� 5.   
   -   5         ��Name$ 
rulesLabel��5.      $��Instructions:��6$   $
��19px(�6<   
�������$
��Bold"�6_   $
��Left=�6q   $��	56,30,0,0q�6�   $	��Top=�6�   $��36��6�   $	��186��6�   �� 5/   
   -   5        $ 
rule1Label��5/      $)��#1. Press *START* to start the game.��6$   $
��13px(�6R   
�������$
��Bold"�6u   $
��Left=�6�   $��	34,78,0,0q�6�   $	��Top=�6�   $��26��6�   $	��557��6�   �� 50   
   -   5         ��Name$ rule1Description��50      $X��R (this will start the game timer, and make the *MATCH* and *QUIT* buttons visible)��6.   $
��13px(�6�   
����·�$
��Bold"�6�   $
��Left=�6�   $��	34,97,0,0q�6�   $	��Top=�6�   $��19��6  $	��669��6  �� 52   
   -   5        $ 
rule2Label��52      ${��u2. Match the CALL NUMBER to the right DESCRIPTION by clicking on the call number, followed by its correct description��6$   $
��13px(�6�   
�������$
��Bold"�6�   $
��Left=�6�   $��
34,126,0,0q�6�   $	��Top=�6  $��25��6   $	��766��6,  �� 53   
   -   5        $ rule2Description��53      $1��+ (do this for all FOUR call number options)��6.   $
��13px(�6a   
����·�$
��Bold"�6�   $
��Left=�6�   $��
34,151,0,0q�6�   $	��Top=�6�   $��17��6�   $	��681��6�   �� 55   
   -	   5        $ 
rule3Label��55      $<��63. Press *MATCH* to check if your answers are correct.��6$   $
��13px(�6e   
�������$
��Bold"�6�   $
��Left=�6�   $��
34,180,0,0q�6�   $	��Top=�6�   $��25��6�   $	��656��6�   �� 56   
   -
   5        $ rule3Description��56      $p��j (only press after matching ALL FOUR CALL NUMBERS TO THEIR APPRORPIATE DESCRIPTIONS, to check your answer)��6.   $
��13px(�6�   
����·�$
��Bold"�6�   $
��Left=�6�   $��
34,203,0,0q�6�   $	��Top=�6  $��17��6  $	��822��6*  �� 58   
   -   5        $ 
rule4Label��58      $?��94. If you wish to to quit, simply press the *QUIT* button��6$   $
��13px(�6h   
�������$
��Bold"�6�   $
��Left=�6�   $��
34,228,0,0q�6�   $	��Top=�6�   $��25��6�   $	��656��6�   �� 59   
   -   5        $ rule4Description��59      $3��- (this will take you back to the Home Window)��6.   $
��13px(�6c   
����·�$
��Bold"�6�   $
��Left=�6�   $��
34,253,0,0q�6�   $	��Top=�6�   $��22��6�   $	��621��6�   �� 5:   
   -   5        $ rule5Description��5:      $�� (MATCH THE COLUMS GAME)��6.   $
��13px(�6N   
�������$
��Bold"�6q   $
��Left=�6�   $��
294,28,0,0q�6�   $	��Top=�6�   $��28��6�   $	��189��6�   �� 5=   
   -   5        $ generalRule1��5=      $=��7*TIMER (120 SECONDS) STARTS AS SOON AS YOU PRESS START*��6*   $
��12px(�6i   
�������$
��Bold"�6�   $
��Left=�6�   $��	4,315,0,0q�6�   $	��Top=�6�   $��18��6�   $	��384��6�   �� 5>   
   -   5        $ generalRule2��5>      $Z��T*WITH 12 POINTS  POSSIBLE, YOU GET +3 POINTS FOR EACH CALL NUMBER MATCHED CORRECTLY*��6*   $
��12px(�6�   
�������$
��Bold"�6�   $
��Left=�6�   $��	4,333,0,0q�6�   $	��Top=�6�   $��18��6  $	��568��6  �� 5?   
   -   5        $ generalRule3��5?      $J��D*NEXT QUESTION (COLUMN SET) WILL ONLY GENERATE IF ANSWER IS CORRECT*��6*   $
��12px(�6v   
�������$
��Bold"�6�   $
��Left=�6�   $��	4,350,0,0q�6�   $	��Top=�6�   $��18��6�   $	��466��6�   $ 0.5,0.5&�6	  z�5@      V� 5A      .~�5B      �� �� 5C      �� 5D       �� Angle$
 0.03Q�6&   T� 5E      5F      5H      �� 5K   
   -   5        $ 
playNowBtn��5K      $��PLAY NOW��6%   $
��Left=�68   $	��Top=�6S   $	��174��6k   $��55��6w    J� Opacity$ 0Q�5L      
���   �
�������$��16(�6C   #��[  6Q   $��594,324,0,0q�6�   z�5M      T� 5N       � Triggers 5P      :� 5Q       :� RoutedEvent$ Button.Loaded��6   .[�5R      �� .��5S      ��  g� RepeatBehavior$ Forever��6%   .��5T      W�  �� TargetProperty$ Opacity�6.    W� From 06R   	 W� To 16[    g� Duration$ 0:0:1D�6b   W� 5U      $5 /(Button.RenderTransform).(TranslateTransform.Y)�6.    06z    -286�   $ 0:0:0.5D�6�    g� AutoReverse$
 True��6�   5V      5W      5X      5Z      5\      5]      