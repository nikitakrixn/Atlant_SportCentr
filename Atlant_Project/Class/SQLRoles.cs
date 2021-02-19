using System.Data;
using System.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace Atlant_Project.Class
{
    public partial class SQLRoles
    {
        #region Переменные
        public string query; //Строка запроса
        public static SqlConnection connect = null;
        #endregion

        #region SQL
        //Метод для подключения
        public void sqlConnect()
        {
            connect = new SqlConnection(Settings.SettingsConnect.ConnectionString);
        }

        //Метод закрытия подключения
        public void ConnectClose()
        {
            connect.Close();
        }

        //Проверка есть ли подключение к бд
        public bool IsConnection
        {
            get
            {
                if (connect.State == System.Data.ConnectionState.Closed) connect.Open();
                return true;
            }
        }

        #endregion

        #region ПРОСМОТР,УДАЛЕНИЕ,РЕДАКТИРОВАНИЕ
        //Просмотр с таблицы из бд, с помощью строки запроса
        public DataTable Select()
        {
            DataTable dt = new DataTable();

            try
            {
                SqlCommand cmd = new SqlCommand(query, connect);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                connect.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                connect.Close();
            }
            return dt;
        }

        #endregion


        #region CHECK ROLES SQL

        //Проверка на Админа
        public bool Check_Admin()
        {
            bool IsAdmin = false;
            try
            {
                //Выполняем подключение
                connect.Open();

                //Выполняем запрос на распознавание роли db_owner
                using (SqlCommand cmd = new SqlCommand("SELECT IS_MEMBER ('db_owner')", connect))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            //Вносим данные в переменную
                            int Admin = dr.GetInt32(0);
                            if (Admin == 1) IsAdmin = true;
                            else IsAdmin = false;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Закрываем подключение
                connect.Close();
            }
            return IsAdmin;
        }

        //Проверка на Админа
        public bool Check_Admin_New()
        {
            bool IsAdmin = false;
            try
            {
                //Выполняем подключение
                connect.Open();

                //Выполняем запрос на распознавание роли db_owner
                using (SqlCommand cmd = new SqlCommand("SELECT IS_MEMBER ('Admin')", connect))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            //Вносим данные в переменную
                            int Admin = dr.GetInt32(0);
                            if (Admin == 1) IsAdmin = true;
                            else IsAdmin = false;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Закрываем подключение
                connect.Close();
            }
            return IsAdmin;
        }

        //Проверка на Гостя(Нового пользователя)
        public bool Check_Guest()
        {
            bool IsNewUser = false;
            try
            {
                //Выполняем подключение
                connect.Open();

                //Выполняем запрос на распознавание роли db_owner
                using (SqlCommand cmd = new SqlCommand("SELECT IS_MEMBER ('New_User')", connect))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            //Вносим данные в переменную
                            int NewUser = dr.GetInt32(0);
                            if (NewUser == 1) IsNewUser = true;
                            else IsNewUser = false;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Закрываем подключение
                connect.Close();
            }
            return IsNewUser;
        }

        //Проверка на Менеджера Клиентов
        public bool Check_ManagerClient()
        {
            bool IsManagerTeams = false;
            try
            {
                //Выполняем подключение
                connect.Open();

                //Выполняем запрос на распознавание роли db_owner
                using (SqlCommand cmd = new SqlCommand("SELECT IS_MEMBER ('Manager_Clientov')", connect))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            //Вносим данные в переменную
                            int NewUser = dr.GetInt32(0);
                            if (NewUser == 1) IsManagerTeams = true;
                            else IsManagerTeams = false;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Закрываем подключение
                connect.Close();
            }
            return IsManagerTeams;
        }

        //Проверка на Менеджера Игр
        public bool Check_ManagerTrainer()
        {
            bool IsManagerGames = false;
            try
            {
                //Выполняем подключение
                connect.Open();

                //Выполняем запрос на распознавание роли db_owner
                using (SqlCommand cmd = new SqlCommand("SELECT IS_MEMBER ('Manager_Trainer')", connect))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            //Вносим данные в переменную
                            int NewUser = dr.GetInt32(0);
                            if (NewUser == 1) IsManagerGames = true;
                            else IsManagerGames = false;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Закрываем подключение
                connect.Close();
            }
            return IsManagerGames;
        }
        #endregion
    }
}
