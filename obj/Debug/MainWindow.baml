   M S B A M L   `   `   `  ����D  @BaiTapNho, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:BaiTapNho	BaiTapNho  5   	       BaiTapNho.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:BaiTapNho     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ Quản lý thư viện��5   	   $
��1024��5   	   $
��1440��5   	    � WindowState$ 	Maximized=�5   	   .��5      � ���#FFFADD.+�5   
   �� $F��@D:\1_Work\University\LTTQ\BaiTapNho\BaiTapNho\Item\backgroud.jpg��6   $
��Fill=�5      �� 5   
   ���#FFCC70$
��Left=�5      $	��993��5      
���   �$	��Top=�5      $	��424��5      �� 5   
   -   5         ��Name$ txtName��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Email��5      $��25(�5      $
��Left=�5       $��43��5!      $��
66,195,0,0q�5"       �� TextWrapping$
 Wrap=�5#      $�� ��5$      $	��Top=�5%      $	��296��5&      �� 5'   
   $��Email��6   $
��Left=�5(      $��
66,154,0,0q�5)      $	��Top=�5*      $��36��5+      $	��134��5,      $��20(�5-      �� 5.   
   $��Mật khẩu��6   $
��Left=�5/      $��
66,272,0,0q�50      $	��Top=�51      $��36��52      $	��134��53      $��20(�54      G� 55   
   -   5         G�Name$ txtPass��55      $ Mật khẩu��56      .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton . $��25(�58      $
��Left=�59      $��43��5:      $��
66,313,0,0q�5;      $	��Top=�5<      $	��296��5=      �� 5>   
   -   5        	 ��Name$	 btnLogin��5>      $��Đăng nhập��5?      $��20(�5@      $
��Left=�5A      $��131,482,0,0q�5B      $	��Top=�5C      $	��127��5D      $��44��5E      5F      �� 5G   
   $��
36,561,0,0q�6   $
��Wrap=�5H      $	��Top=�5I      $��49��5J      $��20(�5K      $
��Left=�5L      $	��358��5M      �� 5N      -   5        
 ��Name$	
 run��5N      $�Chưa có tài khoản? ��5O       �� 5P      -   5        .�5P   -   .�5Q      �� -   5         ��Name$ hyper��5Q      $��Đăng ký ngay!!��5R      
����d�$��	Underline{�5T       � Cursor$
 Hand��5U      5V      5W      �� 5X   
   -   5         ��Name$ lbLogin��5Y      $��ĐĂNG NHẬP��5X      $��Center=�5Z      $��Center=�5[      $
��Left=�5\      $��	10,10,0,0q�5]      $	��Top=�5^      $��92��5_      $	��414��5`      $��25(�5a      �� 5b   
   -   5        $
 tbHo��5c      $
��Left=�5b      $y�Hidden=�5d      $
 Họ��5e      $��38��5f      $��
66,411,0,0q�5g      $
 Wrap=�5h      $�� ��5i      $	��Top=�5j      $	��134��5k      $��20(�5l      �� 5m   
   -	   5        $ tbTen��5n      $
��Left=�5m      $y�Hidden=�5o      $
 Tên��5p      $��38��5q      $��221,411,0,0q�5r      $
 Wrap=�5s      $�� ��5t      $	��Top=�5u      $	��135��5v      $��20(�5w      �� 5x   
   -
   5        $ lbHoTen��5x      $��	Họ tên��5y      $y�Hidden=�5z      $��Bottom=�5{      $
��Left=�5|      $��
66,356,0,0q�5}      $	��Top=�5~      $��50��5      $��76��5�      $��20(�5�      5�      5�      