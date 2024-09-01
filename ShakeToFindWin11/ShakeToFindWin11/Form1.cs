

namespace ShakeToFindWin11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.SizeChanged += Form1_Resize;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.BalloonTipTitle = "Shake to Find";
                notifyIcon1.BalloonTipText = "Shake to Find is still running";
                notifyIcon1.ShowBalloonTip(1000);
            }
            FindCursor();

        }
        private void subMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            notifyIcon1.ContextMenuStrip.Visible = false;
            notifyIcon1.ContextMenuStrip.Close();
            this.Close();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            if (e.Button == MouseButtons.Left)
            {
                notifyIcon1.Visible = false;
                Show();
            }
            else if (e.Button == MouseButtons.Right)
            {
                notifyIcon1.ContextMenuStrip.Show(new Point(Cursor.Position.X + 1, Cursor.Position.Y));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            //notifyIcon1.Icon = SystemIcons.Application;
            //notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
        }

        private void FindCursor()
        {
            int x, y;
            x = Cursor.Position.X;
            y = Cursor.Position.Y;
            //Console.WriteLine("X Position: {0}, Y Position: {1}", x, y);

        }
    }
}
