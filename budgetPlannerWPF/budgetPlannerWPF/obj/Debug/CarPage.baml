   M S B A M L   `   `   `  ����K  GbudgetPlannerWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:budgetPlannerWPFbudgetPlannerWPF  5   	       budgetPlannerWPF.CarPage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:budgetPlannerWPF     5   	     � Title$  CarPage��5   	   $	��450��6   $	��800��6&   .��5	      � $��	0,0,0,-16q�6   .+�5   
   � -   5         �Name$ BG��5       J� RenderTransformOrigin$ 0.497,0.662&�6   ��5      �� 5      -   5        _img_bg�� �� ImageSource$  backgrounds/background.jpg��5       j� Stretch$
 Fill=�5      5      �� 5   
   $)��#Please enter the following values :��6   $��18(�6>   $
��Left=�6L   $��
207,75,0,0q�6g   $	��Top=�6{   $ -0.019,-0.309&�6�   
��� ���$��40��6�   $��Arial Black)�6�   � 5   
   $��Center=�6   $	��268��6,   $��0,75,0,0q�69   $	��Top=�6K   $	��632��6c    � ColumnDefinitions 5      �� 5      .+�5"      �� $��Make and Model :��6   $��15(�6/   
����  �$	��Top=�6O   $
��Left=�6g   $��	56,42,0,0q�6�   �� 5$      $��Purchase Price :��6   $��15(�6/   
����  �$	��Top=�6O   $
��Left=�6g   $��	56,89,0,0q�6�   �� 5&      $��Initial Deposit :��6   
����  �$��15(�6B   $	��Top=�6P   $��
56,137,0,0q�6h   $
��Left=�6|   �� 5(      $��Interest Rate :��6   
����  �$��15(�6@   $	��Top=�6N   $��
54,183,0,0q�6f   $
��Left=�6z   $ 
0.465,-0.8&�6�   �� 5*      $!��Estimated Monthly Premium :��6   
����  �$��15(�6L   $	��Top=�6Z   $��
56,233,0,0q�6r   $
��Left=�6�   $	��306��6�   �� 5-      -   5         ��Name$ makeTb��5-      $
��Left=�6&    �� TextWrapping$
 Wrap=�6A   $	��252��6U   $��30��6a   $��
324,42,0,0q�6m   $	��Top=�6�   �� 5/      -   5        $ 
purchaseTB��5/      $
��Left=�6*   $
 Wrap=�6E   $	��252��6Y   $��30��6e   $��
324,89,0,0q�6q   $	��Top=�6�   �� 51      -   5        $ 	depositTB��51      $
��Left=�6)   $��324,137,0,0q�6D   $
 Wrap=�6Y   $	��Top=�6m   $	��252��6�   $��30��6�   $ 0.522,-3.382&�6�   �� 53      -   5        $ 
interestTB��53      $
��Left=�6*   $��324,183,0,0q�6E   $
 Wrap=�6Z   $	��Top=�6n   $	��252��6�   $��30��6�   �� 55      -   5        $ insuranceTB��55      $
��Left=�6+   $��324,233,0,0q�6F   $
 Wrap=�6[   $	��Top=�6o   $	��252��6�   $��27��6�   57      � 59   
   $��Center=�6   $��99��6,   $��	0,305,0,0q�68   $	��Top=�6K   $	��698��6c   .+�5=      �� -   5        $��Enter��5=      $
��Left=�6%   $	��Top=�6@   $��92��6X   $��36��6c   $��
257,53,0,0q�6o   
��� ���6�   5B      5D      5E      