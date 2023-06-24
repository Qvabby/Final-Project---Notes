using Final_Project___Notes.Auth;
using Final_Project___Notes.Forms;
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

namespace Final_Project___Notes
{
    public partial class NotesMain : Form
    {
        private static protected SqlConnection con = new SqlConnection("Data Source=DESKTOP-PS7OKKF;Initial Catalog=ItStepNotes_db;Integrated Security=True");
        public static bool LoggedIn = false;
        public static Panel MP;
        public static string UserId;
        public static Button Register;
        public static Button Login;
        public static Label UserShow;
        public static Panel MePanel;
        public NotesMain()
        {
            InitializeComponent();
            MePanel = MenuPanel;
            UserShow = UserShowLabel;
            Login = LoginBtn;
            Register = RegisterBtn;
            MP = MainPanel;
            if (LoggedIn)
            {
                LoadPanel(new MainWindow(), MainPanel);
            }
            else
            {
                LoadPanel(new Login(), MainPanel);
            }
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void AppNameL_MouseDown(object sender, MouseEventArgs e)
        {
            panel1_MouseDown(sender, e);
        }
        public static void LoadPanel(Form f, Panel p)
        {
            if (p.Controls.Count > 0)
            {
                p.Controls.RemoveAt(0);
            }
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            p.Controls.Add(f);
            f.Show();
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (LoggedIn)
            {
                Register.Visible = true;
                Login.Text = "Log In";
                UserId = "";
                LoggedIn = false;
                check();
            }
            else
            {
                LoadPanel(new Login(), MainPanel);
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            LoadPanel(new Register(), MainPanel);
        }
        public static void check()
        {
            if (LoggedIn)
            {
                LoadPanel(new MainWindow(), MP);
                Register.Visible = false;
                Login.Text = "Log Out";
                con.Open();
                SqlCommand cmd = new SqlCommand($"SELECT Username FROM User_Tb where Id = {UserId}", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                string Username = dt.Rows[0][0].ToString();
                UserShow.Text = $"User : {Username}";
                UserShow.Visible = true;

                con.Close();
            }
            else
            {
                UserShow.Visible = false;
                LoadPanel(new Login(), MP);
            }
        }
    }
}
