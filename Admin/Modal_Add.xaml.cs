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
    /// Interaction logic for Modal_Add.xaml
    /// </summary>
    public partial class Modal_Add : Window
    {
        private Model1 model;
        public Modal_Add()
        {
            InitializeComponent();
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

        private void btnAccept_Click(object sender, RoutedEventArgs e)
        {
            if(CheckForm() == true)
            {
                var newBook = new Books
                {
                    Title = tbTitle.Text.ToString(),
                    PublicationYear = int.Parse(tbNSX.Text.ToString()),
                    NumberOfCopy = int.Parse(tbNumber.Text.ToString()),
                    AuthorID = int.Parse(cbbAuthor.SelectedValue.ToString()),
                    BranchID = int.Parse(cbbBranch.SelectedValue.ToString()),
                };
                model.Books.Add(newBook);
                model.SaveChanges();
                CallMethodInOtherWindow();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hãy nhập đủ thông tin của sách !!");
            }
        }
    }
}
