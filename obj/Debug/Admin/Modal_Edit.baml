   M S B A M L   `   `   `  ����D  @BaiTapNho, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:BaiTapNho.AdminBaiTapNho.Admin  5   	        BaiTapNho.Admin.Modal_Edit   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   )localclr-namespace:BaiTapNho.Admin  5   	      MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$$ Chỉnh sửa thông tin sách��5   	   $	��500��6*   $	��500��67   .��5      � .+�5   
   �� $��Center=�6   $��Center=�64   $��Cập nhập thông tin��6V   $
��Left=�6s   $��	10,10,0,0q�6�   $	��Top=�6�   $��49��6�   $	��472��6�   $��25(�6�   � 5   
   $��10,99,234,280q�6   .+�5      �� -   5         ��Name$ tbTitle��5      $
��Left=�6'   $��23��6B   $��78,1,0,0q�6N    �� TextWrapping$
 Wrap=�6`   $�� ��6t   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tiêu đề��6|   $	��Top=�6�   $	��120��6�   �� 5      $��Tiêu đề: ��6   $
��Left=�6(   $	��Top=�6C   5      � 5   
   $��10,144,234,242q�6   .+�5      �� -   5        $ tbNSX��5      $
��Left=�6%   $��23��6@   $��78,1,0,0q�6L   $
 Wrap=�6^   $�� ��6r   $ Năm sản xuất��6z   $	��Top=�6�   $	��120��6�   �� 5      $��NSX: ��6   $
��Left=�6$   $	��Top=�6?   5      � 5   
   $��131,208,113,176q�6   $��Center=�6(   .+�5      �� -   5        $ tbNumber��5      $
��Left=�6(   $��23��6C   $��78,1,0,0q�6O   $
 Wrap=�6a   $�� ��6u   $ Số lượng��6}   $	��Top=�6�   $	��120��6�   �� 5      $��Số lượng: ��6   $
��Left=�6)   $	��Top=�6D   5      � 5   
   $��234,144,10,242q�6   .+�5       �� -   5         ��Name$ 	cbbAuthor��5       $
��Left=�6*   $��78,0,0,0q�6E   $ 
Tác giả��6W   $	��Top=�6�   $	��120��6�   �� 5!      $��Tác giả: ��6   $
��Left=�6(   $��0,1,0,0q�6C   $	��Top=�6T   5#      � 5$   
   $��234,99,10,280q�6   .+�5%      �� -   5        $ 	cbbBranch��5%      $
��Left=�6*   $��78,0,0,0q�6E   $ Thể loại��6W   $	��Top=�6�   $	��120��6�   �� 5&      $��Thể loại: ��6   $
��Left=�6)   $��0,1,0,0q�6D   $	��Top=�6U   5(      �� 5)   
   -   5         ��Name$ 	btnUpdate��5)      $��Cập nhập��6$   $��175,301,156,0q�67   $��Center=�6N   $	��Top=�6k   6�   5+      5,      