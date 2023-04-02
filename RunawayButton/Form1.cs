namespace RunawayButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я так и думал!");
        }
        private bool top;
        private bool left;
        private void noBtn_MouseMove(object sender, MouseEventArgs e)
        {
            //if(noBtn.Top < 10)
            //    noBtn.Top -= e.Y;
            //else if(noBtn.Top > 520)
            //    noBtn.Top += e.Y;
            //if(noBtn.Left < 10)
            //    noBtn.Left += e.X;
            //else if (noBtn.Left > 880)
            //    noBtn.Left -= e.X;
            //if (noBtn.Top < 10 || noBtn.Top > 520) noBtn.Top = 232;
            //if (noBtn.Left < 10 || noBtn.Left > 880) noBtn.Left = 532;
            //пофиксить исчезание
            if (!top)
            {
                noBtn.Top -= e.Y;
                if (noBtn.Top < 10)
                    top = true;

            }
            else
            {
                noBtn.Top += e.Y;
                if (noBtn.Top > 520)
                    top = false;
            }
            if (!left)
            {
                noBtn.Left -= e.X;
                if (noBtn.Left < 10)
                    left = true;

            }
            else
            {
                noBtn.Left += e.X;
                if (noBtn.Left > 880)
                    left = false;
            }
        }
    }
}