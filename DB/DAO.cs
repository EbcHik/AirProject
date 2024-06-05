using AirProject.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirProject.DB
{
    internal class DAO{
        public DAO() { }
        public static MySqlConnection connection = DBconnection.getConnection();

        public static void dbSaveUser(string name, string lastName,string login,string password)
        {
            try
            {
                connection.Open();
                string saveQuery = "INSERT INTO users(name, last_name, login, password, theme) VALUES(@name, @last_name, @login, @password, 'white')";
                MySqlCommand cmd = new MySqlCommand(saveQuery, connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@last_name", lastName);
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@password", password);

                cmd.ExecuteNonQuery();
                Console.WriteLine("Пользователь сохранен");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка сохранения пользователя!");
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

        }
        public static bool IsUserExists(string login)
        {
            try
            {
                connection.Open();
                string checkQuery = "SELECT COUNT(*) FROM users WHERE login = @login";
                MySqlCommand cmd = new MySqlCommand(checkQuery, connection);
                cmd.Parameters.AddWithValue("@login", login);

                // ExecuteScalar возвращает первое значение первой строки результата запроса
                int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                return userCount > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка проверки пользователя!");
                Console.WriteLine(ex.ToString());
                return false;  // В случае ошибки возвращаем false
            }
            finally
            {
                connection.Close();
            }
        }


        public static User GetUserByLogin(string login)
        {
            User user = null;

            try
            {
                connection.Open();
                string selectQuery = "SELECT name, last_name, login, password, theme FROM users WHERE login = @login";
                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                cmd.Parameters.AddWithValue("@login", login);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new User
                        {
                            Name = reader["name"].ToString(),
                            LastName = reader["last_name"].ToString(),
                            Login = reader["login"].ToString(),
                            Password = reader["password"].ToString(),
                            Theme = reader["theme"].ToString()
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка поиска пользователя!");
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            return user;
        }

    }
}
