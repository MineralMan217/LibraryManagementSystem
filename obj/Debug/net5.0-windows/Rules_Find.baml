   M S B A M L   `   `   `  ����B  >MockOne, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MockOneMockOne  5   	       MockOne.Rules_Find   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:MockOne     5   	   -   5          � Title$$  RULES FOR FINDING CALL NUMBERS��5   	   $	��450��60   $	��800��6=   ��5	      �� 5
   
    �� ImageSource$  /resources/call_number.jpg��6    �� Opacity$	 0.3Q�6>    � 	Resources 5         RoundButtonStyle �� 
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
��Left=�6q   $��	56,49,0,0q�6�   $	��Top=�6�   $��36��6�   $	��129��6�   �� 50   
   -   5        $ 
playNowBtn��50      $��PLAY NOW��6%   $
��Left=�68   $	��Top=�6S   $	��174��6k   $��55��6w    J� Opacity$ 0Q�51      
���   �
�������$��16(�6C   #��[  6Q   $��594,324,0,0q�6�   z�52      T� 53       � Triggers 55      :� 56       :� RoutedEvent$ Button.Loaded��6   .[�57      �� .��58      ��  g� RepeatBehavior$ Forever��6%   .��59      W�  �� TargetProperty$ Opacity�6.    W� From 06R   	 W� To 16[    g� Duration$ 0:0:1D�6b   W� 5:      $5 /(Button.RenderTransform).(TranslateTransform.Y)�6.    06z    -286�   $ 0:0:0.5D�6�    g� AutoReverse$
 True��6�   5;      5<      5=      5?      �� 5C   
   -   5         ��Name$ rule5Description��5C      $$�� (FIND THE CALL NUMBERS: QUIZ)��6.   $
��13px(�6T   
�������$
��Bold"�6w   $��Center=�6�   $��0,35,0,0q�6�   $	��Top=�6�   $��28��6�   $	��214��6�   �� 5D   
   -   5        $ 
rule1Label��5D      $(��"1. The game starts automatically .��6$   $
��13px(�6Q   
�������$
��Bold"�6t   $
��Left=�6�   $��	34,78,0,0q�6�   $	��Top=�6�   $��26��6�   $	��223��6�   �� 5E   
   -   5        $ rule1Description��5E      $q��k (the loaded window will start the game timer, and make the *Check your answer* and *QUIT* buttons visible)��6.   $
��13px(�6�   
����·�$
��Bold"�6�   $
��Left=�6�   $��	34,97,0,0q�6�   $	��Top=�6  $��19��6  $	��669��6*  �� 5G   
   -	   5        $ 
rule2Label��5G      $z��t2. Click on the correct checkbox option based on the question that will appear in the grey textblock above the table��6$   $
��13px(�6�   
�������$
��Bold"�6�   $
��Left=�6�   $��
34,126,0,0q�6�   $	��Top=�6  $��25��6  $	��766��6+  �� 5H   
   -
   5        $ rule2Description��5H      $'��! (do this until the game is over)��6.   $
��13px(�6W   
����·�$
��Bold"�6|   $
��Left=�6�   $��
34,151,0,0q�6�   $	��Top=�6�   $��17��6�   $	��681��6�   �� 5J   
   -   5        $ 
rule3Label��5J      $H��B3. Press *Check your answer* to check if your answers are correct.��6$   $
��13px(�6q   
�������$
��Bold"�6�   $
��Left=�6�   $��
34,180,0,0q�6�   $	��Top=�6�   $��25��6�   $	��656��6�   �� 5K   
   -   5        $ rule3Description��5K      $6��0 (only press after selecting the correct option)��6.   $
��13px(�6f   
����·�$
��Bold"�6�   $
��Left=�6�   $��
34,203,0,0q�6�   $	��Top=�6�   $��17��6�   $	��822��6�   �� 5M   
   -   5        $ 
rule4Label��5M      $?��94. If you wish to to quit, simply press the *QUIT* button��6$   $
��13px(�6h   
�������$
��Bold"�6�   $
��Left=�6�   $��
34,228,0,0q�6�   $	��Top=�6�   $��25��6�   $	��656��6�   �� 5N   
   -   5        $ rule4Description��5N      $3��- (this will take you back to the Home Window)��6.   $
��13px(�6c   
����·�$
��Bold"�6�   $
��Left=�6�   $��
34,253,0,0q�6�   $	��Top=�6�   $��22��6�   $	��621��6�   �� 5Q   
   -   5        $ generalRule1��5Q      $B��<*TIMER (120 SECONDS) STARTS AS SOON AS THE WINDOW IS LOADED*��6*   $
��12px(�6n   
�������$
��Bold"�6�   $
��Left=�6�   $��	4,315,0,0q�6�   $	��Top=�6�   $��18��6�   $	��434��6�   �� 5R   
   -   5        $ generalRule2��5R      $Z��T*WITH 12 POINTS  POSSIBLE, YOU GET +5 POINTS FOR EACH CALL NUMBER MATCHED CORRECTLY*��6*   $
��12px(�6�   
�������$
��Bold"�6�   $
��Left=�6�   $��	4,333,0,0q�6�   $	��Top=�6�   $��18��6  $	��568��6  5U      5V      