using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //new
using System.Configuration; //new

namespace DBConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //обработчик события StateChange объекта connection
            this.connection.StateChange += new
                System.Data.StateChangeEventHandler(
                this.connection_StateChange);
        }

        //Ex5.2 Извлечение строки соединения по имени
        //статический метод, возвращающий значение строки соединения по ее имени
        static string GetConnectionStringByName(string name)
        {
            string returnValue = null;
            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings[name];
            if (settings != null)
                returnValue = settings.ConnectionString;
            return returnValue;
        }

        //объявите переменную testConnect и присвойте ей значение, возвращаемое из метода
        string testConnect = GetConnectionStringByName("DBConnect.northwindConnectionString"); //тоже из Ex5.2

        //Объявите объект класса
        OleDbConnection connection = new OleDbConnection();

        //Объявите переменную, хранящую строку подключения к базе данных (коммент для ex5)
        /*
            string testConnect = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;
            Persist Security Info=False;Initial Catalog=northwnd;Data Source=DESKTOP-ILCCTBA\SQLEXPRESS";
        */
    

        private void connect_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = testConnect;
                    connection.Open();
                    MessageBox.Show("Соединение с базой данных выполнено успешно");
                }
                else
                    MessageBox.Show("Соединение с базой данных уже установлено");
            }
            //Ex2 универсальный обработчик без параметров  
            /*
             catch 
            {
               MessageBox.Show("Ошибка соединения с базой данных");
            }
            */

            //Ex3
            //блок catch для перехвата OleDbException 
            catch (OleDbException XcpSQL)
            {
                foreach (OleDbError se in XcpSQL.Errors)
                {
                    MessageBox.Show(se.Message,
                    "SQL Error code " + se.NativeError,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }

            //обработчик код для перехвата всех других типов исключений вместо универсального обработчика
            catch (Exception Xcp)
            {
                MessageBox.Show(Xcp.Message, "Unexpected Exception",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void disconnect_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Соединение с базой данных закрыто");
            }
            else
                MessageBox.Show("Соединение с базой данных уже закрыто");
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Ex4
        //обработчик события StateChange объекта connection проверяет текущее состояние соединения
        //и делает доступными/недоступными соответствующие пункты меню
        private void connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            connect.Enabled =
                (e.CurrentState == ConnectionState.Closed);
            disconnect.Enabled =
                (e.CurrentState == ConnectionState.Open);
        }

        //Ex5.1 Получение строк соединения во время выполнения
        private void connectionList_Click(object sender, EventArgs e)
        {
            //Создайте экземпляр коллекции ConnectionStringSettings
            //и укажите ему свойство ConnectionStrings класса ConfigurationManager
            ConnectionStringSettingsCollection settings =
            ConfigurationManager.ConnectionStrings;


            //просмотрите коллекцию ConnectionStringSettings и выведете значения свойств Name,
            //ProviderName и ConnectionString в окна сообщения
            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    MessageBox.Show("name = " + cs.Name);
                    MessageBox.Show("providerName = " + cs.ProviderName);
                    MessageBox.Show("connectionString = " + cs.ConnectionString);
                }
            }
        }
    }
}
