using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project___Notes.Auth
{
    public partial class Login : Form
    {
        private protected SqlConnection con = new SqlConnection("Data Source=DESKTOP-PS7OKKF;Initial Catalog=ItStepNotes_db;Integrated Security=True");
        private protected DataTable Users;
        public Login()
        {
            InitializeComponent();
            con.Open();
            //get users.
            SqlCommand cmd = new SqlCommand("Select * from User_Tb", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            Users = new DataTable();
            adapter.Fill(Users);
            con.Close();
            UserTb.TextChanged += TextBoxChangeBack;
            PasswordTb.TextChanged += TextBoxChangeBack;
        }

        private void pswShowBtn_Click(object sender, EventArgs e)
        {
            if (PasswordTb.PasswordChar == '*')
            {
                PasswordTb.PasswordChar = '\0';
                pswShowBtn.Text = "Hide";
                pswShowBtn.BackColor = Color.FromArgb(180, 130, 109);
            }
            else
            {
                PasswordTb.PasswordChar = '*';
                pswShowBtn.Text = "Show";
                pswShowBtn.BackColor = Color.FromArgb(200, 110, 109);
            }
        }
        private void TextBoxChange(TextBox tb)
        {
            tb.BackColor = Color.Red;
            if (tb.Name == "UserTb")
            {
                EMailFormatErrorLabel.Visible = true;
            }
            else if (tb.Name == "PasswordTb")
            {
                PasswordErrorLabel.Visible = true;
            }
        }
        private void TextBoxChangeBack(Object Sender, EventArgs e)
        {
            (Sender as TextBox).BackColor = Color.White;
            if ((Sender as TextBox).Name == "UserTb")
            {
                EMailFormatErrorLabel.Visible = false;
            }
            else if ((Sender as TextBox).Name == "PasswordTb")
            {
                PasswordErrorLabel.Visible = false;
            }
        }
        private void SignInBtn_Click(object sender, EventArgs e)
        {
            foreach (DataRow i in Users.Rows)
            {
                if (i["Username"].ToString() == UserTb.Text || i["Gmail"].ToString() == UserTb.Text)
                {
                    if (i["Password"].ToString() == PasswordTb.Text)
                    {
                        NotesMain.UserId = i[0].ToString();
                        NotesMain.LoggedIn = true;
                        NotesMain.check();
                        break;
                    }
                    else
                    {
                        TextBoxChange(PasswordTb);
                    }
                }
                else
                {
                    TextBoxChange(UserTb);
                }
            }
        }

    }
}
