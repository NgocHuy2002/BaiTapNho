   M S B A M L   `   `   `  ����D  @BaiTapNho, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:BaiTapNho.UserBaiTapNho.User  5   	       BaiTapNho.User.MuonSach   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:BaiTapNho.User     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ MuonSach��5   	   $
��1024��5   	   $
��1440��5   	    � WindowState$ 	Maximized=�5   	   .��5      � .+�5   
   �� .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ 
PrimaryMid=�5       " MaterialDesignFilledTabControl#��[ 5      $
��Left=�5      $
��1024��5      $	��Top=�5      $
��1027��5      $��	0,0,0,-31q�5      .@�5      �� $��Danh sách sách ��6   .��5      � ���	#FFE5E5E5$��0,0,0,30q�5      .+�5       &   System.Windows.Controls.DataGrid  -   5          Name$
 data��5"         AutoGenerateColumns . $��0,68,0,0q�5%      � 5&      $��44,24,10,883q�6   .+�5'      �� -   5         ��Name$ searchTL_DS��5'   "   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Thể loại��67   $
��Left=�6a   $��	432,4,0,0q�6|   $	��Top=�6�   $	��198��6�   $��35��6�   �� 5(      -   5        	 ��Name$	 	search_DS��5(   !   $��Tìm kiếm��64   $
��Left=�6G   $��	680,4,0,0q�6b   $	��Top=�6u   $	��103��6�   6�   �� 5)      -   5        $	 clearSearch��5*      $��
Bỏ lọc��5+      $
��Left=�5,      $��	821,4,0,0q�5-      $	��Top=�5.      $	��103��5/      6)   �� 51      -   5        $ searchName_DS��51   "   $
��Left=�69   $��32��6T   $��0,4,0,0q�6`   
 �� TextWrapping$

 Wrap=�6q   $�� ��6�   $ 
Tên sách��6�   $	��Top=�6�   $	��194��6�   �� 52      -   5        $ searchAuthors_DS��52   "   $ 
Tác giả��6<   $
��Left=�6e   $��36��6�   $��	224,0,0,0q�6�   $�� ��6�   $	��Top=�6�   $	��180��6�   53      55      56      �� 57      $��Sách đang mượn��6   .��58      � ���	#FFE5E5E5.+�59        -   5        $ 
haveBorrow��59      $
��Left=�6h   $	��941��6�   $	��Top=�6�   $
��1027��6�   5:      5;      5<      #  MaterialDesignThemes.Wpf.Card  5=   
   $
��Left=�6   $��
1032,0,0,0q�5>      $	��Top=�5?      $	��983��5@      $	��400��5A      .��5B      � .+�5C      � $��10,139,25,817q�6   .+�5D      �� $��Tiêu đề: ��6   $
��Left=�60   $	��Top=�6K   $��16(�6c   �� 5E      -   5        $ 	inputName��5E      $
��Left=�61   $��23��6L   $��73,0,0,0q�6X   $

 Wrap=�6j   $�� ��6~    �� 
IsReadOnly . $	��Top=�6�   $	��243��6�   5F      � 5G      $��10,310,25,646q�6   .+�5H      �� $��Tác giả: ��6   $
��Left=�60   $	��Top=�6K   $��16(�6c   �� 5I      -	   5        $ inputAuthors��5I      $
��Left=�64   $��23��6O   $��73,0,0,0q�6[   $

 Wrap=�6m   $�� ��6�    . $	��Top=�6�   $	��243��6�   5J      � 5K      $��10,252,25,705q�6   .+�5L      �� $��NSX: ��6   $
��Left=�6,   $	��Top=�6G   $��16(�6_   �� 5M      -
   5        $ 	inputDate��5M      $
��Left=�61    . $��73,0,0,0q�6^   $	��Top=�6p   $��26��6�   $	��243��6�   5N      � 5O      $��10,194,25,761q�6   .+�5P      �� $��Thể loại: ��6   $
��Left=�61   $	��Top=�6L   $��16(�6d   �� 5Q      -   5        $ inputBranches��5Q      $
��Left=�65   $��23��6P   $��73,0,0,0q�6\   $

 Wrap=�6n   $�� ��6�    . $	��Top=�6�   $	��243��6�   5R      � 5S      $��10,362,25,593q�6   .+�5T      �� $ ��Số lượng còn lại: ��6   $
��Left=�69   $	��Top=�6T   $��16(�6l   �� 5U      -   5        $ inputNumber��5U      $
��Left=�63   $��23��6N   $��	135,0,0,0q�6Z   $

 Wrap=�6m   $�� ��6�    . $	��Top=�6�   $	��181��6�   5V      �� 5W      -   5        $	 btnMuon��5X      $��Mượn sách��5Y      $��Center=�5Z      $��Center=�5[      $��98,471,200,0q�5\      $	��Top=�5]      $��30��5^       % !MaterialDesignOutlinedLightButton#��[ 5`      {�5_      �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType$ WindowL�5`   P   �� 5b      $��Thông tin sách��6   $��Center=�61   $��Center=�6S   $
��Left=�6w   $��	52,89,0,0q�6�   $	��Top=�6�   $��45��6�   $	��272��6�   $��25(�6�   �� 5c      -   5        $��wellcome��5c      
�������$��Stretch=�6;   $��Center=�6`   $��He'sllo��6�   $
��Left=�6�   $	��Top=�6�   $��51��6�   $	��218��6�   $��20(�6�   ���	#FF27A7E26�   �� 5d      -   5        $	 	btnLogout��5e      #��[ 5g      $��Đăng xuất��5h      $
��Left=�5i      $��	223,0,0,0q�5j      $	��Top=�5k      $	��101��5l      $��51��5m      {�5f      �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL�5m   !   5n      5o      5q      5r      