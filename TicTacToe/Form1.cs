using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblKeep.Text = "0";
            lblkeeper.Text = "0";
            load();
           

        }
        void load()

        {
            btnR.Visible = false;
            pic1.Visible = true;
            pic2.Visible = true;
            pic3.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;



            fin1.Visible = false;
            fin2.Visible = false;
            fin3.Visible = false;
            fin4.Visible = false;
            fin5.Visible = false;
            fin6.Visible = false;
            fin7.Visible = false;
            fin8.Visible = false;
            fin9.Visible = false;

            germ1.Visible = false;
            germ2.Visible = false;
            germ3.Visible = false;
            germ4.Visible = false;
            germ5.Visible = false;
            germ6.Visible = false;
            germ7.Visible = false;
            germ8.Visible = false;
            germ9.Visible = false;

            timer2.Stop();
            timer1.Start();
        }

    

        private void pic1_Click(object sender, EventArgs e)
        {
            picOne();
            btnR.Visible = true;
            if (timer1.Enabled)
            {
                timer1.Stop();
                timer2.Start();
                germ1.Show();
            }
            else
            {
                timer2.Stop();
                timer1.Start();
                fin1.Show();
            }

            winner();
        }

        void picOne()
        {
            pic1.Visible = false;
        }
        
        void picTwo()
        {
            pic2.Visible = false;
        }

        void picThree()
        {
            pic3.Visible = false;
        }

        void picFour()
        {
            pictureBox1.Visible = false;
        }

        void picFive()
        {
            pictureBox2.Visible = false;
        }

        void picSix()
        {
            pictureBox6.Visible = false;
        }

        void picSeven()
        {
            pictureBox4.Visible = false;
        }

        void picEight()
        {
            pictureBox5.Visible = false;
        }

        void picNine()
        {
            pictureBox3.Visible = false;
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            btnR.Visible = true;
            picTwo();
            if (timer1.Enabled)
            {
                timer1.Stop();
                timer2.Start();
                germ2.Show();
            }
            else
            {
                timer2.Stop();
                timer1.Start();
                fin2.Show();
            }
            winner();
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            picThree();
            btnR.Visible = true;
            if (timer1.Enabled)
            {
                timer1.Stop();
                timer2.Start();
                germ3.Show();
            }
            else
            {
                timer2.Stop();
                timer1.Start();
                fin3.Show();
            }
            winner();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            picFour();
            btnR.Visible = true;
            if (timer1.Enabled)
            {
                timer1.Stop();
                timer2.Start();
                germ4.Show();
            }
            else
            {
                timer2.Stop();
                timer1.Start();
                fin4.Show();
            }
            winner();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            btnR.Visible = true;
            picFive();
            if (timer1.Enabled)
            {
                timer1.Stop();
                timer2.Start();
                germ5.Show();
            }
            else
            {
                timer2.Stop();
                timer1.Start();
                fin5.Show();
            }
            winner();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            picSix();
            btnR.Visible = true;
            if (timer1.Enabled)
            {
                timer1.Stop();
                timer2.Start();
                germ6.Show();
            }
            else
            {
                timer2.Stop();
                timer1.Start();
                fin6.Show();
            }
            winner();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            picSeven();
            btnR.Visible = true;
            if (timer1.Enabled)
            {
                timer1.Stop();
                timer2.Start();
                germ7.Show();
            }
            else
            {
                timer2.Stop();
                timer1.Start();
                fin7.Show();
            }
            winner();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            picEight();
            btnR.Visible = true;
            if (timer1.Enabled)
            {
                timer1.Stop();
                timer2.Start();
                germ8.Show();
            }
            else
            {
                timer2.Stop();
                timer1.Start();
                fin8.Show();
            }
            winner();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            picNine();
            btnR.Visible = true;
            if (timer1.Enabled)
            {
                timer1.Stop();
                timer2.Start();
                germ9.Show();
            }
            else
            {
                timer2.Stop();
                timer1.Start();
                fin9.Show();
            }
            winner();
        }
             void winner()
        {
            int first = int.Parse(lblkeeper.Text);
            int second = int.Parse(lblKeep.Text);
           
            if (germ1.Visible == true && germ2.Visible == true && germ3.Visible == true)
            {
                first++;
                lblScore.Text = "Score: " + first + " : " + second;
                lblkeeper.Text = first.ToString();
                lblKeep.Text = second.ToString();
                MessageBox.Show("GERMANY WINS!");
                load();


            }
            else if (germ1.Visible == true && germ5.Visible == true && germ9.Visible == true)
            {
                first++;
                lblScore.Text = "Score: " + first + " : " + second;
                lblkeeper.Text = first.ToString();
                lblKeep.Text = second.ToString();
                MessageBox.Show("GERMANY WINS!");
                load();

            }
            else if (germ1.Visible == true && germ4.Visible == true && germ7.Visible == true)
            {
                first++;
                lblScore.Text = "Score: " + first + " : " + second;
                lblkeeper.Text = first.ToString();
                lblKeep.Text = second.ToString();
                MessageBox.Show("GERMANY WINS!");
                load();
            }
            else if (germ2.Visible == true && germ5.Visible == true && germ8.Visible == true)
            {
                first++;
                lblScore.Text = "Score: " + first + " : " + second;
                lblkeeper.Text = first.ToString();
                lblKeep.Text = second.ToString();
                MessageBox.Show("GERMANY WINS!");
                load();
            }
            else if (germ3.Visible == true && germ6.Visible == true && germ9.Visible == true)
            {
                first++;
                lblScore.Text = "Score: " + first + " : " + second;
                lblkeeper.Text = first.ToString();
                lblKeep.Text = second.ToString();
                MessageBox.Show("GERMANY WINS!");
                load();
            }
            else if (germ3.Visible == true && germ5.Visible == true && germ7.Visible == true)
            {
                first++;
                lblScore.Text = "Score: " + first + " : " + second;
                lblkeeper.Text = first.ToString();
                lblKeep.Text = second.ToString();
                MessageBox.Show("GERMANY WINS!");
                load();
            }
            else if (germ4.Visible == true && germ5.Visible == true && germ6.Visible == true)
            {
                first++;
                lblScore.Text = "Score: " + first + " : " + second;
                lblkeeper.Text = first.ToString();
                lblKeep.Text = second.ToString();
                MessageBox.Show("GERMANY WINS!");
                load();
            }
            else if (germ7.Visible == true && germ8.Visible == true && germ9.Visible == true)
            {
                first++;
                lblScore.Text = "Score: " + first + " : " + second;
                lblkeeper.Text = first.ToString();
                lblKeep.Text = second.ToString();
                MessageBox.Show("GERMANY WINS!");
                load();
            }
            else if (fin1.Visible == true && fin2.Visible == true && fin3.Visible == true)
            {
                second++;
                lblScore.Text = "Score: " + first + " : " + second;
                lblkeeper.Text = first.ToString();
                lblKeep.Text = second.ToString();
                MessageBox.Show("FINLAND WINS!");
                load();

            }
            else if (fin1.Visible == true && fin5.Visible == true && fin9.Visible == true)
            {
                second++;
                lblScore.Text = "Score: " + first + " : " + second;
                lblkeeper.Text = first.ToString();
                lblKeep.Text = second.ToString();
                MessageBox.Show("FINLAND WINS!");
                load();
            }
            else if (fin1.Visible == true && fin4.Visible == true && fin7.Visible == true)
            {
                second++;
                lblScore.Text = "Score: " + first + " : " + second;
                lblkeeper.Text = first.ToString();
                lblKeep.Text = second.ToString();
                MessageBox.Show("FINLAND WINS!");
                load();
            }
            else if (fin2.Visible == true && fin5.Visible == true && fin8.Visible == true)
            {
                second++;
                lblScore.Text = "Score: " + first + " : " + second;
                lblkeeper.Text = first.ToString();
                lblKeep.Text = second.ToString();
                MessageBox.Show("FINLAND WINS!");
                load();
            }
            else if (fin3.Visible == true && fin6.Visible == true && fin9.Visible == true)
            {
                second++;
                lblScore.Text = "Score: " + first + " : " + second;
                lblkeeper.Text = first.ToString();
                lblKeep.Text = second.ToString();
                MessageBox.Show("FINLAND WINS!");
                load();
            }
            else if (fin3.Visible == true && fin5.Visible == true && fin7.Visible == true)
            {
                second++;
                lblScore.Text = "Score: " + first + " : " + second;
                lblkeeper.Text = first.ToString();
                lblKeep.Text = second.ToString();
                MessageBox.Show("FINLAND WINS!");
                load();
            }
            else if (fin4.Visible == true && fin5.Visible == true && fin6.Visible == true)
            {
                second++;
                lblScore.Text = "Score: " + first + " : " + second;
                lblkeeper.Text = first.ToString();
                lblKeep.Text = second.ToString();
                MessageBox.Show("FINLAND WINS!");
                load();
            }
            else if (fin7.Visible == true && fin8.Visible == true && fin9.Visible == true)
            {
                second++;
                lblScore.Text = "Score: " + first + " : " + second;
                lblkeeper.Text = first.ToString();
                lblKeep.Text = second.ToString();
                MessageBox.Show("FINLAND WINS!");
                load();
            }
            else if (pic1.Visible == false && pic2.Visible == false && pic3.Visible == false && pictureBox1.Visible == false && pictureBox2.Visible == false && pictureBox3.Visible == false && pictureBox4.Visible == false && pictureBox5.Visible == false && pictureBox6.Visible == false)
            {
                MessageBox.Show("NO WINNER");
                load();
            }
            

        }

        private void btnR_Click(object sender, EventArgs e)
        {
            lblScore.Text = "";
            load();
            lblKeep.Text = "0";
            lblkeeper.Text = "0";
        }
    }
}
