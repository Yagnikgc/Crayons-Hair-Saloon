   M S B A M L   `   `   `  ����N  JCrayons Hair Saloon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Crayons_Hair_SaloonCrayons_Hair_Saloon  5   	       Crayons_Hair_Saloon.Home   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Crayons_Hair_Saloon     5   	     � Title$
  Home��5   	   $	��450��6   $
��1080��6#    � 
ResizeMode$ CanMinimize=�60    � 	Resources 5	      %  Crayons_Hair_Saloon.MyConverter   myConverter��%   &	          5
   
   62   5      .��5      � ��5   
   �� 5       �� ImageSource$ b10.jpg��6   .+�5   
   �� -   5        $��btn_Home��5      $
��Home��6!   $
��Left=�60   $	��Top=�6K   $��	10,10,0,0q�6c   6v   �� 5   
   -   5         ��Name$ label��5      $
��Name��6   $
��Left=�6.   $��	52,63,0,0q�6I   $	��Top=�6\   �� 5   
   -   5         ��Name$ txt_name��5      $
��Left=�6$   $��23��6?   $��
143,66,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��120��6�   �� 5   
   -   5        $ label1��5      $��Contact No.��6    $
��Left=�66   $��	52,94,0,0q�6Q   $	��Top=�6d   �� 5   
   -   5        $ txt_contactNum��5      $
��Left=�6*   $��23��6E   $��
143,97,0,0q�6Q   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�   �� 5   
   -   5        $ label2��5      $
��Time��6    $
��Left=�6/   $��	56,31,0,0q�6J   $	��Top=�6]   �� 5   
   -   5         ��Name$ cmb_time��5      $
��Left=�6%   $��
139,29,0,0q�6@   $	��Top=�6T   $	��120��6l   �� 5   
   -   5        $ label3��5      $��Email ID��6    $
��Left=�63   $��
54,134,0,0q�6N   $	��Top=�6b   �� 5   
   -	   5        $ txt_mail��5      $
��Left=�6$   $��23��6?   $��144,134,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 5   
   -
   5        $ label4��5      $��Gender��6    $
��Left=�61   $��
64,227,0,0q�6L   $	��Top=�6`   	� 5   
   -   5         	�Name$ rdb_male��5      	 d� 	IsChecked$
	 TrueY�6(   $
��Male��69   $
��Left=�6H   $��143,224,0,0q�6c   $	��Top=�6x   6�   	� 5   
   -   5        $��
rdb_female��5      $��Female��6(   $
��Left=�69   $��143,247,0,0q�6T   $	��Top=�6i   6�   �� 5   
   
���   �$��1q�6%   $
��Left=�69   $��64��6T   $��
55,211,0,0q�6`   $	��Top=�6t   $	��174��6�   �� 5   
   -   5        $ label5��5      $	��Age��6    $
��Left=�6.   $��
52,170,0,0q�6I   $	��Top=�6]   �� 5   
   -   5        $��cb_task1��5      $��CheckBox��6#   $
��Left=�66   $��257,230,0,0q�6Q   $	��Top=�6f   �� 5   
   -   5        $��cb_task2��5      $��CheckBox��6#   $
��Left=�66   $��257,255,0,0q�6Q   $	��Top=�6f   �� 5    
   -   5        $��cb_task3��5       $��CheckBox��6#   $
��Left=�66   $��257,277,0,0q�6Q   $	��Top=�6f   �� 5!   
   -   5        $��cb_task4��5!      $��CheckBox��6#   $
��Left=�66   $��257,300,0,0q�6Q   $	��Top=�6f   �� 5"   
   
���   �$��1q�6%   $
��Left=�69   $	��124��6T   $��245,209,0,0q�6a   $	��Top=�6v   $	��196��6�   �� 5#   
   -   5        
 ��Name$
 btn_bookApt��5#      $
��Book��6&   $
��Left=�65   $��181,355,0,0q�6P   $	��Top=�6e   $��75��6}   6�   �� 5$   
   -   5        $ txt_age��5$      $
��Left=�6#   $��23��6>   $��143,172,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   &   System.Windows.Controls.DataGrid  5%   
   -   5          Name$ dataGrid��5%      $
��Left=�6M   $	��268��6h   $��
471,33,0,0q�6u   $	��Top=�6�      
IsReadOnly .    AutoGenerateColumns .  ��. $	��556��6�   ��6%   �� *DisplayCustomer+   RowStyle 5&      �� 5'       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6    �� Triggers 5(      �� 5)       �� Binding 6&   �� *Age+ �� 	Converter# [   �� Value true6f   .a�5*      ��  �� Property � �� �� Value
 �  ��6I   5+      5-         Columns 5/      0  *System.Windows.Controls.DataGridTextColumn  50      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 110 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Name+6L     51      $ Contact Number��6%   $	 115 6_    6=   �� *ContactNumber+6_     52      $ Email ID��6%   $	 110 6Q    67   �� *Email+6Q     53      $	 Age��6%   $ 50 6J    62   �� *Age+6J     54      $ Tasks��6%   $	 170 6N    64   �� *Tasks+6N   56      �� 57   
   -   5        $��btn_ConfirmAppointment��57      $��Confirm Appointment��6/   $
��Left=�6M   $��658,374,0,0q�6h   $	��Top=�6}   6�   �� 58   
   -   5        $��Log Out��58      $
��Left=�6#   $��923,374,0,0q�6>   $	��Top=�6S   $��75��6k   6v   59      5:      