using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficSignalManagementAndControllingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Startbtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer5.Start();
            timer6.Start();
            timer7.Start();
            timer8.Start();

        }
        int counter1 = 0;
        int counter2 = 0;
        int counter3 = 0;
        int counter4 = 0;
        int counter11 = 0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "1")
            {
                pictureBox1.Visible = true;
                pictureBox11.Visible = true;
                pictureBox39.Visible = true;
                counter1 = 5;
                label1.Text = counter1.ToString();
            }
            else if (comboBox1.Text == "2")
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox38.Visible = true;
                pictureBox39.Visible = true;
                counter1 = 10;
                label1.Text = counter1.ToString();
            }
            else if (comboBox1.Text == "3")
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox14.Visible = true;
                pictureBox37.Visible = true;
                pictureBox38.Visible = true;
                pictureBox39.Visible = true;
                counter1 = 15;
                label1.Text = counter1.ToString();
            }
            else if (comboBox1.Text == "4")
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox14.Visible = true;
                pictureBox13.Visible = true;
                pictureBox37.Visible = true;
                pictureBox38.Visible = true;
                pictureBox39.Visible = true;
                counter1 = 20;
                label1.Text = counter1.ToString();
                }
            }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter1 = counter1 - 1;
            counter11 = counter11 + 1;
            label1.Text = counter1.ToString();
            if (counter11 >= 1 && counter11 <= 1)
            {
                this.ovalShape1.BackColor = Color.Yellow;
            }
            else if (counter11 >= 2 && counter1 >= 2)
            {
                this.ovalShape1.BackColor = Color.Green;
                if(pictureBox1.Visible == true && pictureBox11.Visible == true && pictureBox39.Visible == true)
                {
                    pictureBox1.Left += 60;
                    pictureBox11.Left += 60;
                    pictureBox39.Left += 60;
                }
                if (pictureBox2.Visible == true && pictureBox12.Visible == true && pictureBox38.Visible == true)
                {
                    pictureBox2.Left += 60;
                    pictureBox12.Left += 60;
                    pictureBox38.Left += 60;
                }
                if (pictureBox3.Visible == true && pictureBox14.Visible == true && pictureBox37.Visible == true)
                {
                    pictureBox3.Left += 60;
                    pictureBox14.Left += 60;
                    pictureBox37.Left += 60;
                }
                if (pictureBox13.Visible == true)
                {
                    pictureBox13.Left += 60;
                }
            }
            else if (label1.Text == "0")
            {
                this.ovalShape1.BackColor = Color.Red;
                timer1.Stop();
                counter11 = 0;
                if(counter2 != 0)
                {
                    timer2.Start();
                }
                else if (counter3 != 0)
                {
                    timer3.Start();
                }
                else if (counter4 != 0)
                {
                    timer4.Start();
                }
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Left >= 300 && pictureBox11.Left >= 300 && pictureBox39.Left >= 300)
            {
                pictureBox1.Left += 60;
                pictureBox11.Left += 60;
                pictureBox39.Left += 60;
            }         
            if (pictureBox2.Left >= 300 && pictureBox12.Left >= 300 && pictureBox38.Left >= 300 )
            {
                pictureBox2.Left += 60;
                pictureBox12.Left += 60;
                pictureBox38.Left += 60;
            }
            if (pictureBox3.Left >= 300 && pictureBox14.Left >= 300 && pictureBox37.Left >= 300 )
            {
                pictureBox3.Left += 60;
                pictureBox14.Left += 60;
                pictureBox37.Left += 60;
            } 
            if (pictureBox13.Left >= 300)
            {
                pictureBox13.Left += 60;
            }
            if(pictureBox27.Visible == true && pictureBox27.Left>=580)
            {
                pictureBox27.Left += 60;
            }
            if (pictureBox26.Visible == true && pictureBox26.Left >= 580)
            {
                pictureBox26.Left += 60;
            }
            if (pictureBox31.Visible == true && pictureBox31.Left >=580)
            {
                pictureBox31.Left += 60;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "1")
            {
                pictureBox9.Visible = true;
                pictureBox19.Visible = true;
                pictureBox25.Visible = true;
                counter2 = 5;
                label2.Text = counter2.ToString();
            }
            else if (comboBox2.Text == "2")
            {
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox19.Visible = true;
                pictureBox20.Visible = true;
                pictureBox25.Visible = true;
                pictureBox36.Visible = true;
                counter2 = 10;
                label2.Text = counter2.ToString();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            counter2 = counter2 - 1;
            counter11 = counter11 + 1;
            label2.Text = counter2.ToString();
            if (counter11 >= 1 && counter11 <= 1)
            {
                this.ovalShape2.BackColor = Color.Yellow;
            }
            else if (counter11 >= 2 && counter2 >= 2)
            {
                this.ovalShape2.BackColor = Color.Green;
                if (pictureBox9.Visible == true && pictureBox19.Visible == true && pictureBox25.Visible == true)
                {
                    pictureBox9.Top -= 60;
                    pictureBox19.Top -= 60;
                    pictureBox25.Top -= 60;
                }
                if (pictureBox10.Visible == true && pictureBox20.Visible == true && pictureBox36.Visible == true)
                {
                    pictureBox10.Top -= 60;
                    pictureBox20.Top -= 60;
                    pictureBox36.Top -= 60;
                }
            }
            else if (label2.Text == "0")
            {
                this.ovalShape2.BackColor = Color.Red;
                if (label5.Text == "1")
                { 
                    timer1.Enabled = true;
                    timer2.Stop();
                    counter11 = 2;
                }
                else if (label5.Text == "3")
                {  
                    timer3.Enabled = true;
                    timer2.Stop();
                    counter11 = 2;
                }

                else
                {
                    timer2.Stop();
                    counter11 = 0;
                    if (counter3!= 0)
                    {
                        timer3.Start();
                    }
                    else if(counter4 != 0)
                    {
                        timer4.Start();
                    }
                }
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (pictureBox9.Top <= 533 && pictureBox19.Top <= 533 && pictureBox25.Top <= 533)
            { 
                pictureBox9.Top -= 60;
               pictureBox19.Top -= 60;
                pictureBox25.Top -= 60;
            }
            
            if (pictureBox10.Top <= 533 && pictureBox20.Top <= 533 && pictureBox36.Top <= 533)
            {
                pictureBox10.Top -= 60;
                pictureBox20.Top -= 60;
                pictureBox36.Top -= 60;
            }
            //if (pictureBox10.Top <= 370 && pictureBox20.Top <= 370)
            //{
            //    pictureBox10.Top -= 40;
            //    pictureBox20.Top -= 40;
            //}
            if (pictureBox30.Visible==true && pictureBox29.Visible == true)
            {
                pictureBox30.Top -= 60;
                pictureBox29.Top -= 60;
            } 
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "1")
            {
                pictureBox4.Visible = true;
                pictureBox15.Visible = true;
                pictureBox40.Visible = true;
                counter3 = 5;
                label3.Text = counter3.ToString();
            }
            else if (comboBox3.Text == "2")
            {
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox15.Visible = true;
                pictureBox16.Visible = true;
                pictureBox40.Visible = true;
                pictureBox41.Visible = true;
                counter3 = 10;
                label3.Text = counter3.ToString();
            }
            else if (comboBox3.Text == "3")
            {
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox15.Visible = true;
                pictureBox16.Visible = true;
                pictureBox17.Visible = true;
                pictureBox40.Visible = true;
                pictureBox41.Visible = true;
                pictureBox42.Visible = true;
                counter3 = 15;
                label3.Text = counter3.ToString();
            }
            else if (comboBox3.Text == "4")
            {
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox15.Visible = true;
                pictureBox16.Visible = true;
                pictureBox17.Visible = true;
                pictureBox18.Visible = true;
                pictureBox40.Visible = true;
                pictureBox41.Visible = true;
                pictureBox42.Visible = true;
                counter3 = 20;
                label3.Text = counter3.ToString();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            counter3 = counter3 - 1;
            counter11 = counter11 + 1;
            label3.Text = counter3.ToString();
            if (counter11 >= 1 && counter11 <= 1)
            {
                this.ovalShape3.BackColor = Color.Yellow;
            }
            else if (counter11 >= 2 && counter3 >= 2)
            {
                this.ovalShape3.BackColor = Color.Green;
                
                    if (pictureBox4.Visible == true && pictureBox15.Visible == true && pictureBox40.Visible == true)
                    {
                        pictureBox4.Left -= 60;
                        pictureBox15.Left -= 60;
                        pictureBox40.Left -= 60;
                    }
                    if (pictureBox5.Visible == true && pictureBox16.Visible == true && pictureBox41.Visible == true)
                    {
                        pictureBox5.Left -= 60;
                        pictureBox16.Left -= 60;
                        pictureBox41.Left -= 60;
                    }
                    if (pictureBox6.Visible == true && pictureBox17.Visible == true && pictureBox42.Visible == true)
                    {
                        pictureBox6.Left -= 60;
                        pictureBox17.Left -= 60;
                        pictureBox42.Left -= 60;
                    }
                    if (pictureBox18.Visible == true)
                    {
                        pictureBox18.Left -= 60;
                    }
                
                
            }
            else if (label3.Text == "0")
            {
                this.ovalShape3.BackColor = Color.Red;
                if (label5.Text == "2")
                {
                    timer2.Enabled = true;
                    timer3.Stop();
                    counter11 = 2;
                }
                else if (label5.Text == "4")
                {
                    timer4.Enabled = true;
                    timer3.Stop();
                    counter11 = 2;
                }

                else
                {
                    timer3.Stop();
                    counter11 = 0;
                    if (counter4 != 0)
                    {
                        timer4.Start();
                    }

                }               
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            
            if (pictureBox35.Visible == true && pictureBox28.Visible == true)
            {
                pictureBox35.Left -= 60;
                pictureBox28.Left -= 60;
            }
            if (pictureBox4.Left <= 697 && pictureBox15.Left <= 697 && pictureBox40.Left <= 697)
            {
                pictureBox4.Left -= 60;
                pictureBox15.Left -= 60;
                pictureBox40.Left -= 60;
            }
            if (pictureBox5.Left <= 697 && pictureBox16.Left <= 697 && pictureBox41.Left <= 697)
            {
                pictureBox5.Left -= 60;
                pictureBox16.Left -= 60;
                pictureBox41.Left -= 60;
            }
            if (pictureBox6.Left <= 697 && pictureBox17.Left <= 697 && pictureBox42.Left <= 697)
            {
                pictureBox6.Left -= 60;
                pictureBox17.Left -= 60;
                pictureBox42.Left -= 60;
            }
            if (pictureBox18.Left <= 697)
            {
                pictureBox18.Left -= 60;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == "1")
            {
                pictureBox7.Visible = true;
                pictureBox21.Visible = true;
                pictureBox43.Visible = true;
                counter4 = 5;
                label4.Text = counter4.ToString();
            }
            else if (comboBox4.Text == "2")
            {
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox21.Visible = true;
                pictureBox22.Visible = true;
                pictureBox43.Visible = true;
                pictureBox44.Visible = true;
                counter4 = 10;
                label4.Text = counter4.ToString();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            counter4 = counter4 - 1;
            counter11 = counter11 + 1;
            label4.Text = counter4.ToString();
            if (counter11 >= 1 && counter11 <= 1)
            {
                this.ovalShape4.BackColor = Color.Yellow;
            }
            else if (counter11 >= 2 && counter4 >= 2)
            {
                this.ovalShape4.BackColor = Color.Green;
                if (pictureBox7.Visible == true && pictureBox21.Visible == true && pictureBox43.Visible == true)
                {
                    pictureBox7.Top += 60;
                    pictureBox21.Top += 60;
                    pictureBox43.Top += 60;
                }
                if (pictureBox8.Visible == true && pictureBox22.Visible == true && pictureBox44.Visible == true)
                {
                    pictureBox8.Top += 60;
                    pictureBox22.Top += 60;
                    pictureBox44.Top += 60;
                }
            }
            else if (label4.Text == "0")
            {
                this.ovalShape4.BackColor = Color.Red;
                if (label5.Text == "1")
                {
                    timer1.Enabled = true;
                    timer4.Stop();
                    counter11 = 2;
                }
                else if (label5.Text == "3")
                {
                    timer3.Enabled = true;
                    timer4.Stop();
                    counter11 = 2;
                }

                else
                {
                    timer4.Stop();
                    counter11 = 0;
                    
                    //timer3.Start();
                }
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            if (pictureBox7.Top >= 128 && pictureBox21.Top >= 128 && pictureBox43.Top >= 128)
            {
                pictureBox7.Top += 60;
                pictureBox21.Top += 60;
                pictureBox43.Top += 60;
            }
            if (pictureBox8.Top >= 128 && pictureBox22.Top >= 128 && pictureBox44.Top >= 128)
            {
                pictureBox8.Top += 60;
                pictureBox22.Top += 60;
                pictureBox44.Top += 60;
            }
            if(pictureBox32.Visible == true)
            {
                pictureBox32.Top += 60;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox27.Visible = true;
            pictureBox26.Visible = true;
            pictureBox31.Visible = true;
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox30.Visible = true;
            pictureBox29.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox35.Visible = true;
            pictureBox28.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox32.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox27.Visible = true;
            pictureBox26.Visible = true;
            pictureBox31.Visible = true;
            timer9.Start();
            if(timer2.Enabled == true)
            {
                label5.Text = "2";
                timer2.Enabled = false;
            }
            else if (timer4.Enabled == true)
            {
                label5.Text = "4";
                timer4.Enabled = false;
            }
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            if(pictureBox27.Visible == true && pictureBox26.Visible == true && pictureBox31.Visible == true)
            {
                ovalShape1.BackColor = Color.Green;
                pictureBox27.Left += 60;
                pictureBox26.Left += 60;
                pictureBox31.Left += 60;
            }
            if(pictureBox27.Left>=580 && pictureBox26.Left >= 580 && pictureBox31.Left >= 580)
            {
                ovalShape1.BackColor = Color.Red;
                if(label5.Text == "2")
                {
                    timer2.Enabled = true;
                    timer9.Stop();
                }
                else if (label5.Text == "4")
                {
                    timer4.Enabled = true;
                    timer9.Stop();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox30.Visible = true;
            pictureBox29.Visible = true;
            if (timer1.Enabled == true)
            {
                label5.Text = "1";
                timer1.Enabled = false;
                counter11 = 2;
                counter2 = 12;
                timer2.Start();

            }
            else if (timer3.Enabled == true)
            {
                label5.Text = "3";
                timer3.Enabled = false;
                counter11 = 2;
                counter2 = 8;
                timer2.Start();
            }
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            pictureBox35.Visible = true;
            pictureBox28.Visible = true;
            if (timer2.Enabled == true)
            {
                label5.Text = "2";
                timer2.Enabled = false;
                counter11 = 2;
                counter3 = 12;
                timer3.Start();

            }
            else if (timer4.Enabled == true)
            {
                label5.Text = "4";
                timer4.Enabled = false;
                counter11 = 2;
                counter3 = 8;
                timer3.Start();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox32.Visible = true;
            if (timer1.Enabled == true)
            {
                label5.Text = "1";
                timer1.Enabled = false;
                counter11 = 2;
                counter4 = 12;
                timer4.Start();

            }
            else if (timer3.Enabled == true)
            {
                label5.Text = "3";
                timer3.Enabled = false;
                counter11 = 2;
                counter4 = 8;
                timer4.Start();
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }

        //private void timer10_Tick(object sender, EventArgs e)
        //{
        //    if(pictureBox11.Left==360)
        //    {
        //        Image img = pictureBox11.BackgroundImage;
        //        img.RotateFlip(RotateFlipType.Rotate270FlipNone);
        //        pictureBox11.Image = img;
        //        this.pictureBox11.Size = new System.Drawing.Size(25,73);
        //        int pictureBox11LocationX = 425;
        //        int pictureBox11LocationY = 214;
        //        this.pictureBox11.Location = new System.Drawing.Point(pictureBox11LocationX, pictureBox11LocationY);
        //    }
        //    else if(pictureBox11.Left >= 425)
        //    {
        //        this.pictureBox11.Location = new System.Drawing.Point(425, pictureBox11.Top);
        //        pictureBox11.Top -= 60;
        //    }

        //    if (pictureBox39.Left == 550)
        //    {
        //        Image img = pictureBox39.BackgroundImage;
        //        img.RotateFlip(RotateFlipType.Rotate90FlipNone);
        //        pictureBox39.Image = img;
        //        this.pictureBox39.Size = new System.Drawing.Size(30, 95);
        //        int pictureBox39LocationX = 632;
        //        int pictureBox39LocationY = 275;
        //        this.pictureBox39.Location = new System.Drawing.Point(pictureBox39LocationX, pictureBox39LocationY);
        //    }
        //    else if (pictureBox39.Left >= 632)
        //    {
        //        this.pictureBox39.Location = new System.Drawing.Point(632, pictureBox39.Top);
        //        pictureBox39.Top += 60;
        //    }
        //}
    }
}
