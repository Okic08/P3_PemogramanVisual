using System;
using System.Windows.Forms;
using Quiz_Application.Models;

namespace Quiz_Application.Controllers
{
    public class LoginController
    {
        private readonly Login loginView;
        private readonly UserModel userModel;

        public LoginController(Login view, UserModel model)
        {
            loginView = view;
            userModel = model;

            loginView.LoginButtonClicked += OnLoginButtonClicked;
        }

        private void OnLoginButtonClicked(object? sender, LoginEventArgs e)
        {
            try
            {
                bool isAuthenticated = userModel.AuthenticateUser(e.Username, e.Password);
                if (isAuthenticated)
                {
                    loginView.ShowMessage("Login berhasil!");
                    loginView.Hide();

                    // Buka form admin
                    FormAdmin adminForm = new FormAdmin();
                    AdminController adminController = new AdminController(adminForm); // Pastikan controller sudah ada
                    adminForm.Show();
                }
                else
                {
                    loginView.ShowMessage("Username atau password salah!");
                }
            }
            catch (Exception ex)
            {
                loginView.ShowMessage("Error: " + ex.Message);
            }
        }
    }
}
