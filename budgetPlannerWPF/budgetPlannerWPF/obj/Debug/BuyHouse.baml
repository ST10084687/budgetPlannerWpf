   M S B A M L   `   `   `  ����K  GbudgetPlannerWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:budgetPlannerWPFbudgetPlannerWPF  5   	       budgetPlannerWPF.BuyHouse   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:budgetPlannerWPF     5   	     � Title$  BuyHouse��5   	   $	��450��6   $	��800��6'   
���   �.��5	      � $��	0,0,0,-16q�6   .+�5   
   � -   5         �Name$ BG��5       J� RenderTransformOrigin$ 0.497,0.662&�6   ��5      �� 5      -   5        _img_bg�� �� ImageSource$  backgrounds/background.jpg��5       j� Stretch$
 Fill=�5      5      �� 5   
   $)��#Please enter the following values :��6   $��18(�6>   $
��Left=�6L   $��
190,89,0,0q�6g   $	��Top=�6{   $ -0.019,-0.309&�6�   
��� ���$��40��6�   $��Arial Black)�6�   � 5   
   $��Center=�6   $	��283��6,   $��0,60,0,0q�69   $	��Top=�6K   $	��632��6c   .+�5       �� $��Purchase price of house :��6   $��15(�68   
����  �$	��Top=�6X   $
��Left=�6p   $��0,72,0,0q�6�   �� 5"      $��Total deposit for house :��6   
����  �$��15(�6J   $��Center=�6X   $
��Left=�6s   �� 5$      $��Interest Rate :��6   
����  �$��15(�6@   $	��Top=�6N   $��	0,184,0,0q�6f   $
��Left=�6y   $ 
0.465,-0.8&�6�   �� 5&      $/��)Number of repayment months (240 or 360) :��6   
����  �$��15(�6Z   $	��Top=�6h   $��	0,231,0,0q�6�   $
��Left=�6�   $	��306��6�   �� 5*      -   5         ��Name$ 	depositTB��5*      $
��Left=�6)    �� TextWrapping$
 Wrap=�6D   $	��252��6X   $��30��6d   $��	324,0,0,0q�6p   $��Center=�6�   �� 5,      -   5        $ 
purchaseTB��5,      $
��Left=�6*   $��
324,72,0,0q�6E   $
 Wrap=�6Y   $	��Top=�6m   $	��252��6�   $��30��6�   $ 0.522,-3.382&�6�   �� 5.      -   5        $ 
interestTB��5.      $
��Left=�6*   $��324,184,0,0q�6E   $
 Wrap=�6Z   $	��Top=�6n   $	��252��6�   $��30��6�   �� 50      -   5        $ monthsTB��50      $
��Left=�6(   $��324,234,0,0q�6C   $
 Wrap=�6X   $	��Top=�6l   $	��252��6�   $��27��6�   52      � 54   
   $��Center=�6   $��45��6,   $��	0,359,0,0q�68   $	��Top=�6K   $	��698��6c   .+�58      �� -   5        $��Enter��58      $
��Left=�6%   $��	257,4,0,5q�6@   $��92��6S   
��� ���6p   5=      5?      5@      