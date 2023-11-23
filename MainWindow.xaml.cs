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
using System.Windows.Navigation;
using System.Windows.Shapes;
using BaiTapNho.DAO;

namespace BaiTapNho
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Model1 model;
        public MainWindow()
        {
            InitializeComponent();
            model = new Model1();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string email = txtName.Text;
            string pass = txtPass.Password;
            if(btnLogin.Content.Equals("Đăng nhập"))
            {
                var user = model.Borrowers.FirstOrDefault(b => b.Email == email && b.Password == pass);

                if (user != null)
                {
                    int userId = user.BorrowerID;
                    string userName = user.LastName + " " + user.FirstName;

                    if (user.Role.Equals("Borrower"))
                    {
                        User.MuonSach muonSach = new User.MuonSach(userId, userName);
                        muonSach.Show();
                        this.Close();
                    }
                    else if (user.Role.Equals("Admin"))
                    {
                        Admin.AdminHome adminHome = new Admin.AdminHome();
                        adminHome.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Login failed. Please check your credentials.");
                }
            }
            else
            {
                var newUser = new Borrowers
                {
                    LastName = tbHo.Text,
                    FirstName = tbTen.Text,
                    Email = email,
                    Password = pass,
                    Role = "Borrower",
                };
                model.Borrowers.Add(newUser);
                model.SaveChanges();
                ChangeMainToLogin();
            }
            
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            if(btnLogin.Content.Equals("Đăng nhập"))
            {
                ChangeMainToResign();
            }
            else
            {
                ChangeMainToLogin();
            }

        }
        public void ChangeMainToLogin()
        {
            lbLogin.Content = "ĐĂNG NHẬP";
            btnLogin.Content = "Đăng nhập";
            lbHoTen.Visibility = Visibility.Hidden;
            tbHo.Visibility = Visibility.Hidden;
            tbTen.Visibility = Visibility.Hidden;
            run.Text = "Chưa có tài khoản? ";
            hyper.Text = "Đăng ký ngay !!";
        }
        public void ChangeMainToResign()
        {
            lbLogin.Content = "ĐĂNG KÝ";
            btnLogin.Content = "Đăng ký";
            lbHoTen.Visibility = Visibility.Visible;
            tbHo.Visibility = Visibility.Visible;
            tbTen.Visibility = Visibility.Visible;
            run.Text = "Đã có tài khoản ??";
            hyper.Text = "Đăng nhập !!";
        }
    }
}
