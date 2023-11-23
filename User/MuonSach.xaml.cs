using BaiTapNho.DAO;
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

namespace BaiTapNho.User
{
    /// <summary>
    /// Interaction logic for MuonSach.xaml
    /// </summary>
    public partial class MuonSach : Window
    {
        private int userId;
        private string userName;
        private Model1 model;
        public int ID = -1;
        /*DAO.Model1 model = new DAO.Model1();*/
        public MuonSach(int userId, string userName)
        {
            InitializeComponent();
            this.userId = userId;
            this.userName = userName;
            wellcome.Content = "He'sllo " + userName + "!!";
            model = new Model1();

/*            searchAuthors_DS.ItemsSource = model.Authors.ToList();
            searchAuthors_DS.DisplayMemberPath = "FullName";
            searchAuthors_DS.SelectedValuePath = "AuthorID";
            searchTL_DS.ItemsSource = model.LibraryBranches.ToList();
            searchTL_DS.DisplayMemberPath = "BranchName";
            searchTL_DS.SelectedValuePath = "BranchID";*/

            LoadData();
        }
        private void LoadData()
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
                             AuthorName = author.LastName + " " + author.FirstName,
                             /*Genre = book.Genre,*/
                             NumberOfCopy = book.NumberOfCopy,
                             BranchName = branch.BranchName,
                         }).ToList();
            var booksHaveBorrow = (from borrow in model.BookTransactions
                         where borrow.BorrowerID == userId
                         join bookBorrow in model.Books on borrow.BookID equals bookBorrow.BookID
                         join user in model.Borrowers on borrow.BorrowerID equals user.BorrowerID
                         select new
                         {
                             TransactionID = borrow.TransactionID,
                             BookName = bookBorrow.Title,
                             borrowerName = user.LastName + " " + user.FirstName,
                             TransactionDate = borrow.TransactionDate,
                             DueDate = borrow.DueDate,
                             ReturnDate = borrow.ReturnDate,
                         }).ToList();
            haveBorrow.ItemsSource = booksHaveBorrow;
            data.ItemsSource = books;
        }
        private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyName == "TransactionID")
            {
                e.Column.Header = "ID Giao dịch";
            }
            else if (e.PropertyName == "BookID")
            {
                e.Column.Header = "Tên sách";
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
        private void data_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (data.SelectedItem != null)
            {
                var selectData = data.SelectedItem as dynamic;
                if (selectData != null)
                {
                    inputName.Text = selectData.Title;
                    inputAuthors.Text = selectData.AuthorName;
                    inputBranches.Text = selectData.BranchName;
                    inputDate.Text = selectData.PublicationYear.ToString();
                    inputNumber.Text = selectData.NumberOfCopy.ToString();
                    ID = selectData.BookID;
/*                    MessageBox.Show(selectData.BookID.ToString());*/
                }
            }
        }

        private void btnMuon_Click(object sender, RoutedEventArgs e)
        {
            if (ID < 0)
            {
                MessageBox.Show("Hãy chọn sách mà bạn muốn mượn !!");
            }
            else
            {
                var newTransaction = new BookTransactions
                {
                    BookID = ID,
                    BorrowerID = userId,
                    TransactionDate = DateTime.Today,
                    DueDate = DateTime.Today.AddDays(30),
                };
                model.BookTransactions.Add(newTransaction); 
                model.SaveChanges();
                MessageBox.Show("Bạn đã mượn " + inputName.Text.ToString() + "\n"
                    + "Thời gian trả sách " + DateTime.Today.AddDays(30));
                var decreaseBook = model.Books.FirstOrDefault(item => item.BookID == ID);
                if (decreaseBook != null)
                {
                    decreaseBook.NumberOfCopy -= 1;
                    model.SaveChanges();
                    LoadData();
                    ClearForm();
                }
                else
                {
                    Console.WriteLine("Không tìm thấy sách !!");
                }
            }
        }
        private void ClearForm()
        {
            inputName.Text = "";
            inputAuthors.Text = "";
            inputBranches.Text = "";
            inputDate.Text = "";
            inputNumber.Text = "";
            ID = -1;
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            ID = -1;
            this.Close();
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
