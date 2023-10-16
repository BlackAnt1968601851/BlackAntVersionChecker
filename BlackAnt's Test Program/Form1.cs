using System.Diagnostics;

namespace BlackAnt_s_Test_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text1.Text = WinVer.Main();
            version.Text = WinVer.Version;
            progressBar1.Value = WinVer.Progress;
            label2.Text = mouseClicked.ToString();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(WinVer.about, "About");
        }

        private void Close_Button(object sender, EventArgs e)
        {
            this.Close();
        }
        public int Pos;
        public int Pos2;
        public int Pos3;
        public int Posraw;
        public int Posraw2;
        public string Posraw3;
        public bool mouseClicked;
        private void Mouse_Border_Event(object sender, EventArgs e)
        {
            if (mouseClicked == true)
            {

                Posraw = ((int)Cursor.Position.X);
                Posraw2 = ((int)Cursor.Position.Y);
                Posraw3 = Cursor.Position.ToString();
                Pos = Posraw;
                Pos2 = Posraw2;
                this.Left = Posraw;
                this.Top = Posraw2;
                //label2.Text = Posraw3;
            }
        }

        private void Mouse_Border_Drag(object sender, MouseEventArgs e)
        {
            mouseClicked = true;
            label2.Text = mouseClicked.ToString();
        }

        private void Mouse_Border_UnDrag(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
            label2.Text = mouseClicked.ToString();
        }
    }
}