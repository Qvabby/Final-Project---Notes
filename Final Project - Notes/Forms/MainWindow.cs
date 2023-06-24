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

namespace Final_Project___Notes.Forms
{
    public partial class MainWindow : Form
    {
        private static protected SqlConnection con = new SqlConnection("Data Source=DESKTOP-PS7OKKF;Initial Catalog=ItStepNotes_db;Integrated Security=True");
        private DataTable Notes = new DataTable();
        private List<Panel> ps = new List<Panel>();
        public MainWindow()
        {
            LoadUserNotes();
            InitializeComponent();
            LoadNotesView(Notes);
        }

        private void LoadUserNotes()
        {
            con.Open();
            SqlCommand LoadNotes = new SqlCommand($"Select * from Notes_Tb where CreatorId = {int.Parse(NotesMain.UserId)}",con);
            SqlDataAdapter NotesAdapter = new SqlDataAdapter(LoadNotes);
            DataTable notes = new DataTable();
            NotesAdapter.Fill(notes);
            Notes = notes;
            con.Close();
        }
        private void LoadNotesView(DataTable notes)
        {
            //max x = 342
            //X differance = 165
            //Y differance = 147
            //size = 130, 130
            Point fp = AddNotePB.Location;
            foreach (DataRow note in notes.Rows)
            {
                if (fp.X == 342)
                {
                    fp.X = 12;
                    fp.Y += 147;
                }
                else
                {
                    fp.X = fp.X + 165;
                }
                Point loc = fp;
                Panel n = new Panel()
                {
                    Size = new Size(130, 130),
                    Location = loc,
                    BackColor = Color.DarkRed,
                    Name = note["Id"].ToString(),
                };
                Point bloc = loc;
                bloc.Y = bloc.Y - 15;
                Button b = new Button()
                {
                    Location = bloc,
                    Dock = DockStyle.Top,
                    BackColor = Color.Red,
                    Text = "X",
                    Font = new Font("Arial", 12),
                    FlatStyle = FlatStyle.Flat,
                };
                Point lloc = new Point(); //= bloc;
                lloc.Y = lloc.Y + 30;
                Label l = new Label()
                {
                    ForeColor = Color.White,
                    Text = note["Title"].ToString(),
                    Font = new Font("Arial", 12),
                    Location = lloc,
                    Size = new Size(130, 30),
                };
                Point Soc = new Point(); //= fp;
                Soc.X = Soc.X + 112;
                Soc.Y = Soc.Y + 112;
                Button S = new Button()
                {
                    BackColor = Color.White,
                    Size = new Size(20, 20),
                    Location = Soc,
                };
                n.Controls.Add(S);
                S.Click += Select;
                b.Click += DeleteNote;
                b.FlatAppearance.BorderSize = 0;
                n.Controls.Add(l);
                n.Controls.Add(b);
                n.Click += LoadNote;
                Controls.Add(n);
            }
        }
        private void LoadNote(object sender, EventArgs e)
        {
            ps.Clear();
            Select();
            int id = int.Parse((sender as Panel).Name);
            con.Open();
            SqlCommand getNote = new SqlCommand($"Select * from Notes_Tb where Id = {id}",con);
            SqlDataAdapter nadapter = new SqlDataAdapter(getNote);
            DataTable NoteData = new DataTable();
            nadapter.Fill(NoteData);

            NoteEditor F = new NoteEditor(NoteData);
            NotesMain.LoadPanel(F, NotesMain.MP);

            con.Close();
        }
        private void DeleteNote(object sender, EventArgs e)
        {
            int id = int.Parse((sender as Button).Parent.Name);
            con.Open();
            SqlCommand deletecommand = new SqlCommand($"Delete from Notes_Tb where Id = {id}", con);
            deletecommand.ExecuteNonQuery();
            con.Close();
            NotesMain.LoadPanel(new MainWindow(), NotesMain.MP);
        }

        private void Select(object Sender, EventArgs e)
        {
            if ((Sender as Button).BackColor == Color.White)
            {
                (Sender as Button).BackColor = Color.Green;
                ps.Add((Panel)(Sender as Button).Parent);
            }
            else if ((Sender as Button).BackColor == Color.Green)
            {
                (Sender as Button).BackColor = Color.White;
                ps.Remove((Panel)(Sender as Button).Parent);
            }
            Button del = new Button()
            {
                BackColor = Color.Red,
                Text = "delete all",
                Location = new Point(225, 30),
                Name = "delselect",
                FlatStyle = FlatStyle.Flat,
            };
            del.FlatAppearance.BorderSize = 0;
            del.Click += DeleteAll;
            if (ps.Count == 2)
            {
                bool can = true;
                foreach (Control item in NotesMain.MePanel.Controls)
                {
                    if (item.Name == "delselect")
                    {
                        can = false;
                    }
                }
                if (can)
                {
                    NotesMain.MePanel.Controls.Add(del);
                }
            }
            if (ps.Count < 2)
            {
                foreach (Control item in NotesMain.MePanel.Controls)
                {
                    if (item.Name == "delselect")
                    {
                        NotesMain.MePanel.Controls.Remove(item);
                    }
                }
            }
        }
        private void DeleteAll(object sender, EventArgs e)
        {
            con.Open();
            foreach (var item in ps)
            {
                SqlCommand cmd = new SqlCommand($"Delete from Notes_tb where Id = '{item.Name}'", con);
                cmd.ExecuteNonQuery();
            }
            foreach (var item in ps)
            {
                foreach (Control c in Controls)
                {
                    if (item.Name == c.Name)
                    {
                        Controls.Remove(c);
                    }
                }
            }
            ps.Clear();
            con.Close();
            foreach (Control item in NotesMain.MePanel.Controls)
            {
                if (item.Name == "delselect")
                {
                    NotesMain.MePanel.Controls.Remove(item);
                }
            }
            NotesMain.LoadPanel(new MainWindow(), NotesMain.MP);
        }
        private void AddNotePB_Click(object sender, EventArgs e)
        {
            NoteAdder F = new NoteAdder();
            NotesMain.LoadPanel(F, NotesMain.MP);
        }
    }
}
