using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BaiTapNho.DAO;
namespace BaiTapNho.Admin
{
    /// <summary>
    /// Interaction logic for Modal_Edit.xaml
    /// </summary>
    public partial class Modal_Edit : Window
    {
        private Model1 model;
        private int bookID;
        public Modal_Edit(int BookID)
        {
            InitializeComponent();
            this.bookID = BookID;
            model = new Model1();
            LoadData();
        }
        public void LoadData()
        {
            /* Thêm dữ liệu tác giả vào cbb */
            cbbAuthor.ItemsSource = model.Authors.ToList();
            cbbAuthor.DisplayMemberPath = "FullName";
            cbbAuthor.SelectedValuePath = "AuthorID";
            /* Thêm dữ liệu thể loại vào cbb */
            cbbBranch.ItemsSource = model.LibraryBranches.ToList();
            cbbBranch.DisplayMemberPath = "BranchName";
            cbbBranch.SelectedValuePath = "BranchID";
        }
        public bool CheckForm()
        {
            TextBox[] textBoxes = { tbTitle, tbNSX, tbNumber };
            ComboBox[] comboBoxes = { cbbAuthor, cbbBranch };

            foreach (var textBox in textBoxes)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    // TextBox is empty or null, show an error message if needed
                    return false;
                }
            }

            foreach (var comboBox in comboBoxes)
            {
                if (comboBox.SelectedItem == null)
                {
                    // ComboBox has no selection, show an error message if needed
                    return false;
                }
            }

            return true;
        }
        public void CallMethodInOtherWindow()
        {
            if (Owner is AdminHome adminHome)
            {
                adminHome.LoadData();
            }
        }
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if(CheckForm() == true)
            {
                var bookSelected = model.Books.FirstOrDefault(item => item.BookID == bookID);
                if (bookSelected != null)
                {
                    bookSelected.Title = tbTitle.Text;
                    bookSelected.PublicationYear = int.Parse(tbNSX.Text);
                    bookSelected.AuthorID = int.Parse(cbbAuthor.SelectedValue.ToString());
                    bookSelected.BranchID = int.Parse(cbbBranch.SelectedValue.ToString());
                    bookSelected.NumberOfCopy = int.Parse(tbNumber.Text);
                    model.SaveChanges();
                    MessageBox.Show("Đã cập nhập thông tin thành công !!");
                    CallMethodInOtherWindow();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sách !!");
                }
            }
        }
    }
}
