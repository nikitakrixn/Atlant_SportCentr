using System;
using System.Data;
using System.Data.Sql;
using System.Windows.Forms;
using Atlant_Project.Class;
using System.Data.SqlClient;
using Atlant_Project.EntityFramework;

namespace Atlant_Project.Forms
{
    public partial class AuthForm : Form
    {
        public bool connect;

        public AuthForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);
        }

        //Подключение к БД
        private void btnAccess_Click(object sender, EventArgs e)
        {
            //Имя базы данных
            var database = "Atlant";

            //Мой домашний сервер
            var homeserver = string.Format(@"{0}\SQLEXPRESS", Environment.MachineName);

            
            //Сервер в колледже
            var server = Environment.MachineName;


            if (txtLogin.Text.Length >= 2 && txtPassword.Text.Length >= 2)
            {
                try
                {
                    if(Settings.SettingsConnect.Enabled == true)
                    {
                        Settings.SettingsConnect.UserName = txtLogin.Text;
                        Settings.SettingsConnect.Password = txtPassword.Text;
                    }
                    else
                    {
                        Settings.SettingsConnect.DataBase = database;
                        Settings.SettingsConnect.Server = server;
                        Settings.SettingsConnect.UserName = txtLogin.Text;
                        Settings.SettingsConnect.Password = txtPassword.Text;
                    }

                    //Заносим данные в строку подключения
                    Settings.SettingsConnect.ConnectionString = string.Format("data source={0};initial catalog={1};persist security info=True;User Id={2};password={3}",
                        Settings.SettingsConnect.Server, Settings.SettingsConnect.DataBase, Settings.SettingsConnect.UserName, Settings.SettingsConnect.Password);

                    // Инициализируем класс
                    SQLRoles SQLhelp = new SQLRoles();

                    // Проверка подключения
                    SQLhelp.sqlConnect();
                    if (SQLhelp.IsConnection)
                    {
                        MessageBox.Show("Ваша строка подключения успешно сохранена.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connect = true;
                        SQLhelp.ConnectClose();
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else MessageBox.Show("Поля не должны быть пустыми.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void ChkPass_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (chkPass.Checked == true) txtPassword.UseSystemPasswordChar = false;
            else txtPassword.UseSystemPasswordChar = true;
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SecondForm sc = new SecondForm();
            sc.ShowDialog();
            this.Show();
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            txtLogin.Clear();
            txtPassword.Clear();
        }
    }
}
