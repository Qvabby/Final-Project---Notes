using Final_Project___Notes.rgx;
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
    public partial class Register : Form
    {
        private protected SqlConnection con = new SqlConnection("Data Source=DESKTOP-PS7OKKF;Initial Catalog=ItStepNotes_db;Integrated Security=True");
        private protected DataTable Users;
        public Register()
        { 
            InitializeComponent();
            //Subscribe events to text boxes
            GmailTb.TextChanged += TextBoxChangeBack;
            UsernameTb.TextChanged += TextBoxChangeBack;
            PasswordTb.TextChanged += TextBoxChangeBack;
            //Get Users
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from User_Tb", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            Users = new DataTable();
            adapter.Fill(Users);
            con.Close();
        }
        private void TextBoxChange(TextBox tb)
        {
            tb.BackColor = Color.Red;
            if (tb.Name == "UsernameTb")
            {
                UsernameTakenLabel.Visible = true;
            }
            else if (tb.Name == "GmailTb")
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
            if ((Sender as TextBox).Name == "UsernameTb")
            {
                UsernameTakenLabel.Visible = false;
            }
            else if ((Sender as TextBox).Name == "GmailTb")
            {
                EMailFormatErrorLabel.Visible = false;
                EMailFormatErrorLabel.Text = "(E - mail is incorrect format)";
            }
            else if ((Sender as TextBox).Name == "PasswordTb")
            {
                PasswordErrorLabel.Visible = false;
            }
        }
        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            bool can = true;
            foreach (DataRow i in Users.Rows)
            {
                if (i["Username"].ToString().ToLower() == UsernameTb.Text.ToLower())
                {
                    TextBoxChange(UsernameTb);
                    can = false;
                }
                if (i["Gmail"].ToString().ToLower() == GmailTb.Text.ToLower())
                {
                    EMailFormatErrorLabel.Text = "Gmail Already Used.";
                    TextBoxChange(UsernameTb);
                    can = false;
                }
            }
            if (!rgxes.EmailRegex.IsMatch(GmailTb.Text))
            {
                TextBoxChange(GmailTb);
                can = false;
            }
            if (PasswordTb.Text.Length < 8)
            {
                TextBoxChange(GmailTb);
                can = false;
            }
            if (can)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"Insert into User_Tb (Username, Gmail, Password)" +
                    $" values ('{UsernameTb.Text}', '{GmailTb.Text}', '{PasswordTb.Text}')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                NotesMain.LoadPanel(new Register(), NotesMain.MP);
            }
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
    }
}
