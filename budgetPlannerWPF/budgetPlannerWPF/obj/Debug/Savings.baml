   M S B A M L   `   `   `  ����K  GbudgetPlannerWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:budgetPlannerWPFbudgetPlannerWPF  5   	       budgetPlannerWPF.Savings   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:budgetPlannerWPF     5   	     � Title$  Savings��5   	   $	��450��6   $	��800��6&   
���   �.��5	      � $��	0,0,0,-16q�6   .+�5   
   � -   5         �Name$ BG��5       J� RenderTransformOrigin$ 0.497,0.662&�6   ��5      �� 5      -   5        _img_bg�� �� ImageSource$  backgrounds/background.jpg��5       j� Stretch$
 Fill=�5      .+�5      �� $G��APlease enter the following values based on your savings account: ��6   $
��Left=�6`   $	��Top=�6{   $	��651��6�   
��� ���$��17(�6�   $��32��6�   $��	10,84,0,0q�6�   $��Arial Black)�6�   5      � 5   
   $��Center=�6   $��30��6,   $	��Top=�68   $	��521��6P   $��0,10,0,0q�6\   � 5   
   $��Center=�6   $	��271��6,   $��	0,133,0,0q�69   $	��Top=�6L   $	��698��6d    � ColumnDefinitions 5      �� 5      $
��323* �6#   �� 5      $
��375* �6#   .+�5#      �� $��Reason: ��6   
����  �$��15(�69   $��29��6G   $	��101��6S   $��	0,0,0,242q�6_   $
��Left=�6r   �� 5%      $��Specified Ammount: ��6   $��15(�62   
����  �$	��Top=�6R   $
��Left=�6j   $��0,45,0,0q�6�   �� 5'      $��Interest Rate: ��6   $��15(�6.   
����  �$	��Top=�6N   $
��Left=�6f   $ 0.468,1.196&�6�   $��0,95,0,0q�6�   �� 5)      $N��HPlease specify in how many months you would like to withdraw the funds: ��6   
����  �$��15(�6y   $	��Top=�6�   $��	0,135,0,0q�6�   $
��Left=�6�   $��2��6�   �� 5.      -   5         ��Name$ userReasonTB��5.      $
��Left=�6,   $��74,0,0,0q�6G    �� TextWrapping$
 Wrap=�6Y   $	��Top=�6m   $	��290��6�   $��29��6�   $��2��6�   �� 50      -   5        $ userAmountTB��50      $
��Left=�6,   $��
157,45,0,0q�6G   $
 Wrap=�6[   $	��Top=�6o   $	��207��6�   $��30��6�   $��2��6�   �� 52      -   5        $ 
interestTB��52      $
��Left=�6*   $
 Wrap=�6E   $	��258��6Y   $��30��6e   $��
106,95,0,0q�6q   $	��Top=�6�   $��2��6�   �� 54      -   5        $ monthsTB��54      $
��Left=�6(   $��183,135,0,0q�6C   $
 Wrap=�6X   $	��Top=�6l   $	��175��6�   $��30��6�   $��1��6�   59      � 5;   
   $��Center=�6   $	��125��6,   $��	0,291,0,0q�69   $	��Top=�6L   $	��698��6d   .+�5=      �� $]��WPlease select the 'Enter' button below when you are happy with your choices and amounts��6   $��16(�6v   $��Center=�6�   $	��Top=�6�   
�������$��0,40,0,0q�6�   �� 5?      -   5        $��Enter��5?      $
��Left=�6%   $��
212,79,0,0q�6@   $��80��6T   
��� ���$��36��6�   $	��Top=�6�   �� 5A      -   5        $��Buy Car��5A      $��Center=�6'   $��0,79,0,0q�6D   $	��Top=�6V   $��80��6n   $��36��6y   
��� � �6�   5G      5H      5I      