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
        public bool mouseClicked;
        public int OrigposX;
        public int OrigposY;
        public int OrigWinPosX;
        public int OrigWinPosY;
        private void Mouse_Border_Event(object sender, EventArgs e)
        {
            if (mouseClicked == true)
            {

                var Posraw = ((int)Cursor.Position.X);
                var Posraw2 = ((int)Cursor.Position.Y);
                var Posraw3 = Cursor.Position.ToString();
                var Pos = Posraw;
                var Pos2 = Posraw2;
                var hiX = OrigposX - OrigWinPosX;
                var hiX2 = Posraw - hiX;
                var hiY = OrigposY - OrigWinPosY;
                var hiY2 = Posraw2 - hiY;
                this.Left = hiX2;
                this.Top = hiY2;
            }
        }

        private void Mouse_Border_Drag(object sender, MouseEventArgs e)
        {
            mouseClicked = true;
            OrigposX = Cursor.Position.X;
            OrigposY = Cursor.Position.Y;
            OrigWinPosY = this.Top;
            OrigWinPosX = this.Left;
            label2.Text = mouseClicked.ToString();
        }

        private void Mouse_Border_UnDrag(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
            label2.Text = mouseClicked.ToString();
        }
    }
}