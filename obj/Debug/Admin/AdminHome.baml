   M S B A M L   `   `   `  ����D  @BaiTapNho, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:BaiTapNho.AdminBaiTapNho.Admin  5   	       BaiTapNho.Admin.AdminHome   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   )localclr-namespace:BaiTapNho.Admin  5   	      MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ Quản lý thư viện��5   	   $
��1024��5   	   $
��1440��5   	    � WindowState$ 	Maximized=�5   	   .��5      � .+�5   
   �� .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ 
PrimaryMid=�6    " MaterialDesignFilledTabControl#��[ 5      $
��Left=�5      $	��914��5      $	��Top=�5      $
��1432��5      $��0,79,0,0q�5      .@�5      �� $��Sách hiện có��6   .��5      � ���	#FFE5E5E5.+�5      � $��44,24,10,883q�6    � ColumnDefinitions 5      �� 5       $
��146* �6/   �� 5!      $
��543* �6/   .+�5#      �� -   5         ��Name$ searchTL_DS��5#   "   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Thể loại��5$   "   $
��Left=�5%   "   $��140,4,0,-39q�5&   "   $	��Top=�5'   "   $	��198��5(   "   $��35��5)   "   $��1��5*   "   �� 5+      -   5         ��Name$ 	search_DS��5+   !   $��Tìm kiếm��5,   !   $
��Left=�5-   !   $��388,4,0,-36q�5.   !   $	��Top=�5/   !   $	��103��50   !   $��1��52   !   �� 53      -   5        $ clearSearch��53   !   $��
Bỏ lọc��54   !   $
��Left=�55   !   $��529,4,0,-36q�56   !   $	��Top=�57   !   $	��103��58   !   $��1��59   !   5:   !   �� 5;      -   5        $ searchName_DS��5;   "   $
��Left=�5<   "   $��32��5=   "   $��	0,4,0,-36q�5>   "   	 �� TextWrapping$
	 Wrap=�5?   "   $�� ��5@   "   $ 
Tên sách��5A   "   $	��Top=�5B   "   $	��194��5C   "   �� 5D      -   5        $ searchAuthors_DS��5D   "   $ 
Tác giả��5E   "   $
��Left=�5F   "   $��36��5G   "   $��224,0,0,-36q�5H   "   $�� ��5I   "   $	��Top=�5J   "   $	��180��5K   "   $��2��5L   "   5M      &   System.Windows.Controls.DataGrid  5N      -   5        
  Name$

 data��5P         SelectionMode$ Single=�5O      $
��Left=�5Q      $	��792��5R      $��0,74,0,0q�5S      $	��Top=�5T      $
��1432��5U      5V      5W      5X      �� 5Y      $��Sách chưa trả��6   .��5Z      � ���	#FFE5E5E5.+�5[        -   5        $
 
haveBorrow��5\      $ Single=�5[      $y�Hidden=�5]      $
��Left=�5_      $	��792��5`      $��0,74,0,0q�5a      $	��Top=�5b      $
��1432��5c         Columns 5d      4  .System.Windows.Controls.DataGridTemplateColumn  5e      ,  &System.Windows.Controls.DataGridColumn   Header$ Action��65      CellTemplate 5f   "   �� 5g   &   .R�5h   *   �� $ 
returnDate��5i   1   -   5        $��Đã trả sách��5h   1   5j   1   5k   '   5m      5o      �� 5p      -	   5         ��Name$* $cbbSearch_Book_isBorrowed_byBookName��5q      $
��Left=�5p      $ 
Tên sách��5r      $��	81,28,0,0q�5s      $	��Top=�5t      $	��210��5u      5v      �� 5w      -
   5        $* $cbbSearch_Book_isBorrowed_byUserName��5y      $
��Left=�5w      $ Tên người mượn��5z      $��
409,28,0,0q�5{      $	��Top=�5|      $	��210��5}      �� 5~      -   5        $ btnClear��5      $��
Bỏ lọc��5~      $
��Left=�5�      $��
678,21,0,0q�5�      $	��Top=�5�      $	��131��5�      5�      5�      5�      5�      #  MaterialDesignThemes.Wpf.Card  5�   
   $
��Left=�6   $��1046,10,0,0q�5�      $	��Top=�5�      $��64��5�      $	��300��5�      .��5�      � $��10q�6   $��Center=�5�      .+�5�      �� $��Center=�6   $��Admin��5�      $
��Left=�5�      $	��Top=�5�      $��35��5�      $��88��5�      �� 5�      -   5        $ logout��5�      $��Đăng xuất��5�      $
��Left=�5�      $��	113,0,0,0q�5�      $	��Top=�5�      $	��133��5�      5�      5�      5�      �� 5�   
   -   5        $ btnAdd��5�      $��Thêm sách mới��5�      $
��Left=�5�      $��	72,24,0,0q�5�      $	��Top=�5�      $	��223��5�      5�      �� 5�   
   -   5        $ btnEdit��5�      $$��Chỉnh sửa thông tin sách��5�      $
��Left=�5�      $��
358,24,0,0q�5�      $	��Top=�5�      $	��223��5�      5�      �� 5�   
   -   5        $ 	btnDelete��5�      $��Xóa sách hiện có��5�      $
��Left=�5�      $��
644,24,0,0q�5�      $	��Top=�5�      $	��223��5�      5�      5�      5�      