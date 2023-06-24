using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project___Notes.Forms
{
    public partial class NoteEditor : Form
    {
        private static protected SqlConnection con = new SqlConnection("Data Source=DESKTOP-PS7OKKF;Initial Catalog=ItStepNotes_db;Integrated Security=True");
        private string Title { get; set; }
        private string _Description { get; set; }
        private string CreatorId { get; set; }
        private string WindowFont { get; set; }
        private string Rtf { get; set; }
        private string NoteId { get; set; }
        private DataTable _dt { get; set; }

        //Load Note
        public NoteEditor(DataTable dt)
        {
            Title = dt.Rows[0]["Title"].ToString();
            _Description = dt.Rows[0]["Description"].ToString();
            CreatorId = dt.Rows[0]["CreatorId"].ToString();
            WindowFont = dt.Rows[0]["WindowFont"].ToString();
            Rtf = dt.Rows[0]["Rtf"].ToString();
            NoteId = dt.Rows[0][0].ToString();
            _dt = dt;
            InitializeComponent();
            //load db
            LoadNote(true);
        }
        //Create Note
        public NoteEditor(string title, string description, string creatorId)
        {
            Title = title;
            _Description = description;
            CreatorId = creatorId;
            InitializeComponent();
            //load new
            LoadNote(false);
        }
        private void LoadNote(bool db)
        {
            if (db)
            {
                //Title
                TitleLabel.Text += " " + Title;
                //WindowFont
                var fc = new FontConverter();
                Font = (Font)fc.ConvertFromInvariantString(WindowFont);
                //RtfFont
                LoadRTF();

            }//load from db
            else
            {
                TitleLabel.Text += " " + Title;

            }// load new
            
        }
        private void LoadRTF()
        {
            MemoryStream stream = new MemoryStream(ASCIIEncoding.Default.GetBytes(Rtf));
            ContentRTF.LoadFile(stream, RichTextBoxStreamType.RichText);
        }
        private void SavePB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NoteId))
            {
                //Note is new
                SaveContent(false);
            }
            else
            {
                //Note exists.
                SaveContent(true);
            }
        }

        private void SaveContent(bool exists)
        {
            con.Open();
            //save WindowFont
            var fc = new FontConverter();
            string fontstring = fc.ConvertToInvariantString(Font);
            //save rtf
            string RichText = ContentRTF.Rtf;
            //Command
            if (exists)
            {
                //If Note Exists
                SqlCommand Save = new SqlCommand($"Update Notes_Tb " +
                    $"SET Title = '{Title}',Description = '{_Description}',WindowFont = '{fontstring}',Rtf = '{RichText}',CreatorId = '{int.Parse(CreatorId)}' " +
                    $"where Id = {int.Parse(NoteId)}",con);
                Save.ExecuteNonQuery();
            }
            else
            {
                //If Note is new
                SqlCommand Save = new SqlCommand("Insert Into Notes_Tb (Title,Description,WindowFont,Rtf,CreatorId)" +
                $" Values ('{Title}','{_Description}','{fontstring}','{RichText}',{int.Parse(CreatorId)})", con);
                Save.ExecuteNonQuery();
            }
            
            con.Close();
        }
        private void ClosePB_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Do you want to save Progress", "Close", MessageBoxButtons.YesNoCancel);
            if (dg == DialogResult.Yes)
            {
                SavePB_Click(sender, e);
                NotesMain.LoadPanel(new MainWindow(), NotesMain.MP);
            }else if (dg == DialogResult.No)
            {
                NotesMain.LoadPanel(new MainWindow(), NotesMain.MP);
            }
        }

        private void DescriptionPB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Rtf))
            {
                Description d = new Description(_Description, Title, CreatorId);
                NotesMain.LoadPanel(d, NotesMain.MP);
            }
            else
            {
                Description d = new Description(_dt);
                NotesMain.LoadPanel(d, NotesMain.MP);
            }
            
        }

        private void TextColorPB_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();

            if (string.IsNullOrWhiteSpace(ContentRTF.SelectedText))
            {
                ContentRTF.ForeColor = cd.Color;
            }
            else
            {
                ContentRTF.SelectionColor = cd.Color;
            }
        }

        private void FillColorPB_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();

            if (string.IsNullOrWhiteSpace(ContentRTF.SelectedText))
            {
                ContentRTF.BackColor = cd.Color;
            }
            else
            {
                ContentRTF.SelectionBackColor = cd.Color;
            }
        }

        private void FontPB_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.ShowDialog();

            if (string.IsNullOrWhiteSpace(ContentRTF.SelectedText))
            {
                ContentRTF.Font = font.Font;
            }
            else
            {
                ContentRTF.SelectionFont = font.Font;
            }
        }
    }
}