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
    /// Interaction logic for AdminHome.xaml
    /// </summary>
    public partial class AdminHome : Window
    {
        private Model1 model;
        public AdminHome()
        {
            InitializeComponent();
            model = new Model1();
            LoadData();
        }
        public void LoadData()
        {
            var books = (from book in model.Books
                         join author in model.Authors on book.AuthorID equals author.AuthorID
                         join branch in model.LibraryBranches on book.BranchID equals branch.BranchID
                         select new
                         {
                             BookID = book.BookID,
                             Title = book.Title,
                             /*ISBN = book.ISBN,*/
                             PublicationYear = book.PublicationYear,
                             AuthorID = book.AuthorID,
                             AuthorName = author.LastName + " " + author.FirstName,
                             /*Genre = book.Genre,*/
                             NumberOfCopy = book.NumberOfCopy,
                             BranchID = book.BranchID,
                             BranchName = branch.BranchName,
                         }).ToList();
            var booksHaveBorrow = (from borrow in model.BookTransactions
                                   where borrow.ReturnDate == null
                                   join bookBorrow in model.Books on borrow.BookID equals bookBorrow.BookID
                                   join user in model.Borrowers on borrow.BorrowerID equals user.BorrowerID
                                   select new
                                   {
                                       TransactionID = borrow.TransactionID,
                                       BookID = borrow.BookID,
                                       BookName = bookBorrow.Title,
                                       borrowerName = user.LastName + " " + user.FirstName,
                                       TransactionDate = borrow.TransactionDate,
                                       DueDate = borrow.DueDate,
                                       ReturnDate = borrow.ReturnDate,
                                   }).ToList();
            haveBorrow.ItemsSource = booksHaveBorrow;
            data.ItemsSource = books;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Modal_Add modal_Add = new Modal_Add();
            modal_Add.Owner = this;
            modal_Add.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            modal_Add.ShowDialog();
        }

        private void data_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (data.SelectedItem != null)
            {
                var selectData = data.SelectedItem as dynamic;
                if (selectData != null)
                {
                    int BookID = selectData.BookID;
                    Modal_Edit modal_Edit = new Modal_Edit(BookID);
                    modal_Edit.tbTitle.Text = selectData.Title;
                    modal_Edit.cbbAuthor.SelectedValue = selectData.AuthorID;
                    modal_Edit.cbbBranch.SelectedValue = selectData.BranchID;
                    modal_Edit.tbNSX.Text = selectData.PublicationYear.ToString();
                    modal_Edit.tbNumber.Text = selectData.NumberOfCopy.ToString();
                    modal_Edit.Owner = this;
                    modal_Edit.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                    modal_Edit.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Chọn sách muốn cập nhập !!");
            }
        }

        private void logout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (data.SelectedItem != null)
            {
                MessageBoxResult result = MessageBox.Show("Bạn có chắn muốn xóa quyển sách này ??", "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
                var selectData = data.SelectedItem as dynamic;
                int id = selectData.BookID;
                if (result == MessageBoxResult.Yes)
                {
                    if(selectData != null)
                    {
                        var itemToDelete = model.Books.Find(selectData.BookID);
                        var stillBorrower = model.BookTransactions.FirstOrDefault(item => item.BookID == id);
                        if(stillBorrower == null)
                        {
                            model.Books.Remove(itemToDelete);
                        }
                        else
                        {
                            MessageBox.Show("Quyển sách này vẫn đang có người mượn, bạn không thể xóa nó !!", "Cảnh báo");
                        }
                        model.SaveChanges();
                        LoadData();
                    }
                }
                else
                {
                    
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn quyển sách mà bạn muốn xóa !!", "Thông báo");
            }

        }
        private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyName == "TransactionID")
            {
                e.Column.Header = "ID Giao dịch";
            }
            else if (e.PropertyName == "BookID")
            {
                e.Column.Header = "ID sách";
            }
            else if (e.PropertyName == "BookName")
            {
                e.Column.Header = "Tên sách";
            }
            else if (e.PropertyName == "Title")
            {
                e.Column.Header = "Tên sách";
            }
            else if (e.PropertyName == "borrowerName")
            {
                e.Column.Header = "Tên người mượn";
            }
            else if (e.PropertyName == "TransactionDate")
            {
                e.Column.Header = "Ngày giao dịch";
            }
            else if (e.PropertyName == "DueDate")
            {
                e.Column.Header = "Hạn trả";
            }
            else if (e.PropertyName == "ReturnDate")
            {
                e.Column.Header = "Ngày trả";
            }
            else if (e.PropertyName == "PublicationYear")
            {
                e.Column.Header = "Năm sản xuất";
            }
            else if (e.PropertyName == "AuthorID")
            {
                e.Column.Header = "ID Tác giả";
            }
            else if (e.PropertyName == "AuthorName")
            {
                e.Column.Header = "Tên tác giả";
            }
            else if (e.PropertyName == "NumberOfCopy")
            {
                e.Column.Header = "Số lượng";
            }
            else if (e.PropertyName == "BranchID")
            {
                e.Column.Header = "ID Thể loại";
            }
            else if (e.PropertyName == "BranchName")
            {
                e.Column.Header = "Tên thể loại";
            }
        }

        private void returnDate_Click(object sender, RoutedEventArgs e)
        {
            if (haveBorrow.SelectedItem != null)
            {
                var selectData = haveBorrow.SelectedItem as dynamic;
                int id = selectData.TransactionID;
                int bookID = selectData.BookID;
                var transactionSelected = model.BookTransactions.FirstOrDefault(item => item.TransactionID == id);
                var bookSelected = model.Books.FirstOrDefault(item => item.BookID == bookID);
                if (transactionSelected != null && bookSelected != null)
                {
                    transactionSelected.ReturnDate = DateTime.Now;
                    bookSelected.NumberOfCopy += 1;
                    model.SaveChanges();
                    MessageBox.Show("Đã xác nhận " + selectData.borrowerName + " trả " + selectData.BookName + "\n"
                        + "Ngày trả : " + DateTime.Now);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sách !!");
                }
            }
        }

        private void search_DS_Click(object sender, RoutedEventArgs e)
        {
            string searchTermName = searchName_DS.Text.ToLower();
            string searchTermAuthors = searchAuthors_DS.Text.ToLower();
            string selectedCategory = searchTL_DS.Text.ToLower();

            var books = (from book in model.Books
                         join author in model.Authors on book.AuthorID equals author.AuthorID
                         join branch in model.LibraryBranches on book.BranchID equals branch.BranchID
                         select new
                         {
                             BookID = book.BookID,
                             Title = book.Title,
                             /*ISBN = book.ISBN,*/
                             PublicationYear = book.PublicationYear,
                             AuthorName = author.LastName + " " + author.FirstName,
                             /*Genre = book.Genre,*/
                             NumberOfCopy = book.NumberOfCopy,
                             BranchName = branch.BranchName,
                         }).ToList();
            var filteredData = books.Where(item =>
                (string.IsNullOrEmpty(searchTermName) || item.Title.ToLower().Contains(searchTermName)) &&
                (string.IsNullOrEmpty(searchTermAuthors) || item.AuthorName.ToLower().Contains(searchTermAuthors)) &&
                (string.IsNullOrEmpty(selectedCategory) || item.BranchName.ToLower().Contains(selectedCategory)))
                .ToList();

            data.ItemsSource = filteredData;
        }

        private void clearSearch_Click(object sender, RoutedEventArgs e)
        {
            LoadData();
        }
    }
}
