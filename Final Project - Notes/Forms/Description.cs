using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project___Notes.Forms
{
    public partial class Description : Form
    {
        string description;
        DataTable dttt = new DataTable();
        public Description(DataTable dt)
        {
            InitializeComponent();
            description = dt.Rows[0]["Description"].ToString();
            dttt = dt;
        }
        public Description(string desc, string title, string creatorid)
        {
            InitializeComponent();
            description = desc;
        }

        private void Description_Load(object sender, EventArgs e)
        {
            DescLabel.Text = description;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NoteEditor f = new NoteEditor(dttt);
            NotesMain.LoadPanel(f, NotesMain.MP);
        }
    }
}
