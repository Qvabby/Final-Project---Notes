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
    public partial class NoteAdder : Form
    {
        public NoteAdder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TitleTB.Text.Length > 0)
            {
                NoteEditor F = new NoteEditor(TitleTB.Text, DescriptionTb.Text, NotesMain.UserId);
                NotesMain.LoadPanel(F, NotesMain.MP);
            }
        }
    }
}
