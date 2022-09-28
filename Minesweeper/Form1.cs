namespace Minesweeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int mine1 = random.Next(1,12);
            int mine2 = random.Next(13, 18);
            int mine3 = random.Next(19, 24);

            for (int i = 1; i <= 24; i++)
            {
                Button btnTemp = new Button();
                btnTemp.ForeColor = System.Drawing.Color.Gray;
                btnTemp.BackColor = System.Drawing.Color.Pink;

                btnTemp.Name = "btnTemp"+i.ToString();
                btnTemp.Size = new System.Drawing.Size(40, 40);
                btnTemp.Text = i.ToString();
                btnTemp.UseVisualStyleBackColor = true;
                if(mine1 == i || mine2==i || mine3 == i)
              
                    btnTemp.Tag = true;
                else 
                    btnTemp.Tag = false;


                btnTemp.Click += btnTemp_Click;
                flowLayoutPanel1.Controls.Add(btnTemp);


            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTemp_Click(object sender, EventArgs e)
        {
            Button btnTemp=(Button)sender;
            bool tag=(bool)btnTemp.Tag;
            if (tag)
            {
                btnTemp.BackColor=Color.Gray;
                int boom = int.Parse(lbl_boom.Text);
                boom++;
                lbl_boom.Text = boom.ToString();
                btnTemp.Enabled = false;
                if (boom == 1)
                {
                    MessageBox.Show("You are lost","Game Result",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }

                
            }
            else
            {
                btnTemp.BackColor = Color.Pink;
                int score = int.Parse(lbl_Score.Text);
                score++;
                lbl_Score.Text = score.ToString();
                btnTemp.Enabled = false;

            }

        }
    }
}