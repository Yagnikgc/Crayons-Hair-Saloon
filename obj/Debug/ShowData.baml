   M S B A M L   `   `   `  ����N  JCrayons Hair Saloon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Crayons_Hair_SaloonCrayons_Hair_Saloon  5   	   "    Crayons_Hair_Saloon.ShowData   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Crayons_Hair_Saloon     5   	     � Title$  ShowData��5   	   $	��450��6   $	��800��6'    � 	Resources 5	      %  Crayons_Hair_Saloon.MyConverter   myConverter��%   &	          5
   
   62   5      .��5      � ��5   
   �� 5       �� ImageSource$ b9.jpg��6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5      $
��Left=�6M   $	��280��6h   $��
37,111,0,0q�6u   $	��Top=�6�      
IsReadOnly .    AutoGenerateColumns .  ��. $	��720��6�   ��6%   �� *DisplayCustomer+   RowStyle 5      �� 5       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6    �� Triggers 5      �� 5      	 �� Binding	 6&   �� *Age+
 �� 	Converter#
 [   �� Value true6f   .a�5      ��  �� Property � �� �� Value
 �  ��6I   5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 110 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Name+6L     5      $ Contact Number��6%   $	 115 6_    6=   �� *ContactNumber+6_     5      $ Email ID��6%   $	 110 6Q    67   �� *Email+6Q     5      $	 Age��6%   $ 50 6J    62   �� *Age+6J     5      $ Tasks��6%   $	 170 6N    64   �� *Tasks+6N   5!      �� 5"   
   -   5        $��txt_findCustomer��5"      $
��Left=�6*   $��28��6E   $��
271,61,0,0q�6Q    �� TextWrapping$
 Wrap=�6e   $	��Top=�6y   $	��155��6�   �� 5#   
   -   5        $��btn_findCustomer��5#      $��Find Customer��6)   $
��Left=�6A   $��
459,60,0,0q�6\   $	��Top=�6p   $	��113��6�   $��28��6�   6�   �� 5$   
   $��Customer Name :��6   $
��Left=�6*   $��
142,61,0,0q�6E   $	��Top=�6Y   ���	#FF8017BC$
��Bold"�6�   �� 5%   
   -   5        $
��Home��5%      $
��Left=�6    $��	37,27,0,0q�6;   $	��Top=�6N   $��75��6f   6q   �� 5&   
   -   5        $��Log Out��5&      $
��Left=�6#   $��
682,27,0,0q�6>   $	��Top=�6R   $��75��6j   6u   5'      5(      