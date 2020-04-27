using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace databaseConnectionNew
{
    public partial class userProfilePage : Form
    {
        public userProfilePage()
        {
            InitializeComponent();
        }

        private void showFriendBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void userProfilePage_Load(object sender, EventArgs e)
        {



            profileUserIDtxt.Text = databaseConnection.sendtext;

            int userID = Convert.ToInt32(databaseConnection.sendtext);
            


            string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";


            using (MySqlConnection connection =
                new MySqlConnection(connectionString))
            {

                connection.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * from users where usersID =" + userID, connection);
               


                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                DataTable userTable = new DataTable();
                sqlDA.Fill(userTable);

                firstNameLbl.Text = userTable.Rows[0]["usersFirstName"].ToString();
                lastNameLbl.Text = userTable.Rows[0]["usersLastName"].ToString();
                genderTxt.Text = userTable.Rows[0]["usersGender"].ToString();
                homeTownTxt.Text = userTable.Rows[0]["usersHomeTown"].ToString();
                cityTxt.Text = userTable.Rows[0]["usersCity"].ToString();
                relationshipTxt.Text = userTable.Rows[0]["usersRelationStatus"].ToString();



                


                MySqlCommand fricmd = new MySqlCommand("SELECT usersFirstName, usersLastName from users inner join users_friends on userID = " + userID + " " + "WHERE usersID = userFriendID", connection);


                MySqlDataAdapter frisqlDA;
                frisqlDA = new MySqlDataAdapter(fricmd);
                DataTable friendTable = new DataTable();
                frisqlDA.Fill(friendTable);
                friendLbl.Text = "User " + userID + " Friend's";
                friendDataGrid.DataSource = friendTable;


                //usersFirstName, usersLastName

                MySqlCommand messagecmd = new MySqlCommand("SELECT* from users_messages where messageUserID = " + userID, connection);


                MySqlDataAdapter messsqlDA = new MySqlDataAdapter(messagecmd);
                DataTable messageTable = new DataTable();
                messsqlDA.Fill(messageTable);

                messageData.DataSource = messageTable;

                MySqlCommand workplacecmd = new MySqlCommand("SELECT workplaceName, workplaceDate from user_workplace where workplaceUserID =" + userID, connection);



                MySqlDataAdapter worksqlDA = new MySqlDataAdapter(workplacecmd);
                DataTable workTable = new DataTable();
                worksqlDA.Fill(workTable);

                workplaceData.DataSource = workTable;

                MySqlCommand universitycmd = new MySqlCommand("SELECT universityName, universityDate from user_university where universityUserID =" + userID, connection);



                MySqlDataAdapter unisqlDA = new MySqlDataAdapter(universitycmd);
                DataTable uniTable = new DataTable();
                unisqlDA.Fill(uniTable);

                universityData.DataSource = uniTable;
            }
        }

        private void showFriendsBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
