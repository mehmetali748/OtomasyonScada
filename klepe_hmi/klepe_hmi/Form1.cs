using S7.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace klepe_hmi
{
    public partial class KLEPE : Form
    {
        private Plc plc;
        public KLEPE(Plc P)
            { plc = P; }

        public KLEPE()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;

            
            button8.Enabled = false;
           
            button10.Enabled = false;

            //CpuType cpu=(CpuType)Enum.Parse(typeof(CpuType), cmbCpuType.SelectedValue.ToString());
            plc = new Plc(CpuType.S71200, "192.168.06.27", 0, 1);
            plc.Open();
            string adres10 = "DB1.DBX299.2";

            object yazılandeger10 = false;

            plc.Write(adres10, yazılandeger10);
            string adres14 = "DB1.DBX150.3";

            object yazılandeger14 = false;

            plc.Write(adres14, yazılandeger14);
            string adres15 = "DB1.DBX90.5";

            object yazılandeger15 = false;

            plc.Write(adres15, yazılandeger15);
            string adres16 = "DB1.DBX100.3";

            object yazılandeger16 = false;

            plc.Write(adres16, yazılandeger16);


            string adres17 = "DB1.DBX150.2";

            object yazılandeger17 = false;

            plc.Write(adres17, yazılandeger17);
            string adres18 = "DB1.DBX150.1";

            object yazılandeger18 = false;
            plc.Write(adres18, yazılandeger18);
            timer1.Start();
            timer2.Start();
        }
            
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            plc.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adres = "DB1.DBX6.5";

            object yazılandeger = true;

            plc.Write(adres, yazılandeger);
            string adres10 = "DB1.DBX299.2";

            object yazılandeger10 = false;

            plc.Write(adres10, yazılandeger10);
            string adres14 = "DB1.DBX150.3";

            object yazılandeger14 = false;

            plc.Write(adres14, yazılandeger14);
            string adres15 = "DB1.DBX90.5";

            object yazılandeger15 = false;

            plc.Write(adres15, yazılandeger15);
            string adres16 = "DB1.DBX100.3";

            object yazılandeger16 = false;

            plc.Write(adres16, yazılandeger16);
          

            string adres17 = "DB1.DBX150.2";

            object yazılandeger17 = false;

            plc.Write(adres17, yazılandeger17);
            string adres18= "DB1.DBX150.1";

            object yazılandeger18 = false;

            plc.Write(adres18, yazılandeger18);

            string adres1 = "DB1.DBX6.4";

            object yazılandeger1 = false;

            plc.Write(adres1, yazılandeger1);

            string adres2 = "DB1.DBX0.5";

            object yazılandeger2 = false;

            plc.Write(adres2, yazılandeger2);


            string adres5 = "DB1.DBX6.3";

            object yazılandeger5 = false;

            plc.Write(adres5, yazılandeger5);
            string adres6 = "DB1.DBX0.4";

            object yazılandeger6 = false;

            plc.Write(adres6, yazılandeger6);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string adres10 = "DB1.DBX299.2";

            object yazılandeger10 = false;

            plc.Write(adres10, yazılandeger10);
            string adres14 = "DB1.DBX150.3";

            object yazılandeger14 = false;

            plc.Write(adres14, yazılandeger14);
            string adres15 = "DB1.DBX90.5";

            object yazılandeger15 = false;

            plc.Write(adres15, yazılandeger15);
            string adres16 = "DB1.DBX100.3";

            object yazılandeger16 = false;

            plc.Write(adres16, yazılandeger16);


            string adres17 = "DB1.DBX150.2";

            object yazılandeger17 = false;

            plc.Write(adres17, yazılandeger17);
            string adres18 = "DB1.DBX150.1";

            object yazılandeger18 = false;
            plc.Write(adres18, yazılandeger18);
            string adres = "DB1.DBX6.4";

            object yazılandeger = true;

            plc.Write(adres, yazılandeger);
           
           

            string adres1 = "DB1.DBX6.5";

            object yazılandeger1 = false;

            plc.Write(adres1, yazılandeger1);

            string adres2 = "DB1.DBX0.5";

            object yazılandeger2 = false;

            plc.Write(adres2, yazılandeger2);

            string adres5 = "DB1.DBX6.3";

            object yazılandeger5 = false;

            plc.Write(adres5, yazılandeger5);
            string adres6 = "DB1.DBX0.4";

            object yazılandeger6 = false;

            plc.Write(adres6, yazılandeger6);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string adres = "DB1.DBX0.5";

            object yazılandeger = true;

            plc.Write(adres, yazılandeger);

            string adres10 = "DB1.DBX90.5";

            object yazılandeger10 = false;

            plc.Write(adres10, yazılandeger10);

          
            string adres14 = "DB1.DBX150.3";

            object yazılandeger14 = false;

            plc.Write(adres14, yazılandeger14);
            string adres15 = "DB1.DBX90.5";

            object yazılandeger15 = false;

            plc.Write(adres15, yazılandeger15);
            string adres16 = "DB1.DBX100.3";

            object yazılandeger16 = false;

            plc.Write(adres16, yazılandeger16);


            string adres17 = "DB1.DBX150.2";

            object yazılandeger17 = false;

            plc.Write(adres17, yazılandeger17);
            string adres18 = "DB1.DBX150.1";

            object yazılandeger18 = false;
            plc.Write(adres18, yazılandeger18);


            string adres1 = "DB1.DBX6.5";

            object yazılandeger1 = false;

            plc.Write(adres1, yazılandeger1);
            string adres2 = "DB1.DBX6.4";

            object yazılandeger2 = false;

            plc.Write(adres2, yazılandeger2);

            string adres5 = "DB1.DBX6.3";

            object yazılandeger5 = false;

            plc.Write(adres5, yazılandeger5);
            string adres6 = "DB1.DBX0.4";

            object yazılandeger6 = false;

            plc.Write(adres6, yazılandeger6);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string adres10 = "DB1.DBX299.2";

            object yazılandeger10 = false;

            plc.Write(adres10, yazılandeger10);
            string adres14 = "DB1.DBX150.3";

            object yazılandeger14 = false;

            plc.Write(adres14, yazılandeger14);
            string adres15 = "DB1.DBX90.5";

            object yazılandeger15 = false;

            plc.Write(adres15, yazılandeger15);
            string adres16 = "DB1.DBX100.3";

            object yazılandeger16 = false;

            plc.Write(adres16, yazılandeger16);


            string adres17 = "DB1.DBX150.2";

            object yazılandeger17 = false;

            plc.Write(adres17, yazılandeger17);
            string adres18 = "DB1.DBX150.1";

            object yazılandeger18 = false;
            plc.Write(adres18, yazılandeger18);

            string adres = "DB1.DBX6.3";

            object yazılandeger = true;

            plc.Write(adres, yazılandeger);

        

           

            string adres1 = "DB1.DBX6.5";

            object yazılandeger1 = false;

            plc.Write(adres1, yazılandeger1);
            string adres3 = "DB1.DBX6.4";

            object yazılandeger3 = false;

            plc.Write(adres3, yazılandeger3);
            string adres4 = "DB1.DBX0.5";

            object yazılandeger4 = false;

            plc.Write(adres4, yazılandeger4);
            string adres6 = "DB1.DBX0.4";

            object yazılandeger6 = false;

            plc.Write(adres6, yazılandeger6);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string adres10 = "DB1.DBX299.2";

            object yazılandeger10 = false;

            plc.Write(adres10, yazılandeger10);
            string adres14 = "DB1.DBX150.3";

            object yazılandeger14 = false;

            plc.Write(adres14, yazılandeger14);
            string adres15 = "DB1.DBX90.5";

            object yazılandeger15 = false;

            plc.Write(adres15, yazılandeger15);
            string adres16 = "DB1.DBX100.3";

            object yazılandeger16 = false;

            plc.Write(adres16, yazılandeger16);


            string adres17 = "DB1.DBX150.2";

            object yazılandeger17 = false;

            plc.Write(adres17, yazılandeger17);
            string adres18 = "DB1.DBX150.1";

            object yazılandeger18 = false;
            plc.Write(adres18, yazılandeger18);

            string adres = "DB1.DBX0.4";

            object yazılandeger = true;

            plc.Write(adres, yazılandeger);

           
            string adres11 = "DB1.DBX150.1";

            object yazılandeger11 = false;

            plc.Write(adres11, yazılandeger11);

            string adres1 = "DB1.DBX6.5";

            object yazılandeger1 = false;

            plc.Write(adres1, yazılandeger1);

            string adres7 = "DB1.DBX6.4";

            object yazılandeger7 = false;

            plc.Write(adres7, yazılandeger7);

            string adres2 = "DB1.DBX0.5";

            object yazılandeger2 = false;

            plc.Write(adres2, yazılandeger2);


            string adres5 = "DB1.DBX6.3";

            object yazılandeger5 = false;

            plc.Write(adres5, yazılandeger5);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string adres = "DB1.DBX6.5";
            object okunandegerX = plc.Read(adres);
          
            string adres1 = "DB1.DBX6.4";
            object okunandegerX1= plc.Read(adres1);
            string adres2 = "DB1.DBX0.5";
            object okunandegerX2= plc.Read(adres2);
            string adres3 = "DB1.DBX6.3";

            object okunandegerX3=  plc.Read(adres3);
            string adres4 = "DB1.DBX0.4";
            object okunandegerX4= plc.Read(adres4);
            string adres5 = "DB1.DBX6.2";
            object okunandegerX5 = plc.Read(adres5);
            string adres6 = "DB1.DBX6.7";
            object okunandegerX6 = plc.Read(adres6);
            string adres7 = "DB1.DBX7.0";
            object okunandegerX7 = plc.Read(adres7);


            if (Convert.ToBoolean(okunandegerX) == true)
            {
                panel1.BackColor = Color.Green;
            }
            else
            {
                panel1.BackColor = Color.Red;
            }
            if (Convert.ToBoolean(okunandegerX1) == true)
            {
                panel2.BackColor = Color.Green;
            }
            else
            {
                panel2.BackColor = Color.Red;
            }
            if (Convert.ToBoolean(okunandegerX2) == true)
            {
                panel5.BackColor = Color.Green;
            }
            else
            {
                panel5.BackColor = Color.Red;
            }
            if (Convert.ToBoolean(okunandegerX3) == true)
            {
                panel3.BackColor = Color.Green;
            }
            else
            {
                panel3.BackColor = Color.Red;
            }
            if (Convert.ToBoolean(okunandegerX4) == true)
            {
                panel4.BackColor = Color.Green;
            }
            else
            {
                panel4.BackColor = Color.Red;
            }
            if (Convert.ToBoolean(okunandegerX5) == true)
            {
                button11.BackColor = Color.Green;
                button6.BackColor = Color.Red;
            }
            else
            {
                button6.BackColor = Color.Green;
                button11.BackColor = Color.Red;
            }
            if (Convert.ToBoolean(okunandegerX6) == true && Convert.ToBoolean(okunandegerX5) == false)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                
               
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                
            }
            if (Convert.ToBoolean(okunandegerX6) == true )
            {
                
                panel12.BackColor = Color.Green;

            }
            else
            {
               
                panel12.BackColor = Color.Red;
            }
            if (Convert.ToBoolean(okunandegerX7) == true && Convert.ToBoolean(okunandegerX5) == false)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                
            }
            if (Convert.ToBoolean(okunandegerX7) == true)
            {
                
                panel13.BackColor = Color.Green;

            }
            else
            {
                panel13.BackColor = Color.Red;
            }


        }

        private void button11_Click(object sender, EventArgs e)
        {
            string adres = "DB1.DBX6.2";

            object yazılandeger = true;

            plc.Write(adres, yazılandeger);
            string adres10 = "DB1.DBX6.5";

            object yazılandeger10 = false;

            plc.Write(adres10, yazılandeger10);

            string adres1 = "DB1.DBX6.4";

            object yazılandeger1 = false;

            plc.Write(adres1, yazılandeger1);

            string adres2 = "DB1.DBX0.5";

            object yazılandeger2 = false;

            plc.Write(adres2, yazılandeger2);


            string adres5 = "DB1.DBX6.3";

            object yazılandeger5 = false;

            plc.Write(adres5, yazılandeger5);
            string adres6 = "DB1.DBX0.4";

            object yazılandeger6 = false;

            plc.Write(adres6, yazılandeger6);

            
            button8.Enabled = true;
           
            button10.Enabled = true;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string adres = "DB1.DBX6.2";

            object yazılandeger = false;

            plc.Write(adres, yazılandeger);

           
            button8.Enabled=false;
            
            button10.Enabled=false;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;

        }

        private void button7_MouseDown(object sender, MouseEventArgs e)
        {
            string adres = "DB1.DBX0.0";

            object yazılandeger = true;

            plc.Write(adres, yazılandeger);
        }

        private void button7_MouseUp(object sender, MouseEventArgs e)
        {
            string adres = "DB1.DBX0.0";

            object yazılandeger = false;

            plc.Write(adres, yazılandeger);
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_MouseDown(object sender, MouseEventArgs e)
        {
            string adres = "DB1.DBX0.1";

            object yazılandeger = true;

            plc.Write(adres, yazılandeger);
        }

        private void button8_MouseDown(object sender, MouseEventArgs e)
        {
            string adres = "DB1.DBX0.2";

            object yazılandeger = true;

            plc.Write(adres, yazılandeger);
        }

        private void button8_MouseUp(object sender, MouseEventArgs e)
        {
            string adres = "DB1.DBX0.2";

            object yazılandeger = false;

            plc.Write(adres, yazılandeger);
        }

        private void button9_MouseUp(object sender, MouseEventArgs e)
        {
            string adres = "DB1.DBX0.1";

            object yazılandeger = false;

            plc.Write(adres, yazılandeger);
        }

        private void button10_MouseDown(object sender, MouseEventArgs e)
        {
            string adres = "DB1.DBX0.3";

            object yazılandeger = true;

            plc.Write(adres, yazılandeger);
        }

        private void button10_MouseUp(object sender, MouseEventArgs e)
        {
            string adres = "DB1.DBX0.3";

            object yazılandeger = false;

            plc.Write(adres, yazılandeger);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true && checkBox2.Checked==true)
            {

            }
        }

        private void button12_MouseDown(object sender, MouseEventArgs e)
        {
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                string adres = "DB1.DBX6.6";

                object yazılandeger = true;

                plc.Write(adres, yazılandeger);
            }

           

        }

        private void button12_MouseUp(object sender, MouseEventArgs e)
        {
            string adres = "DB1.DBX6.6";

            object yazılandeger = false;

            plc.Write(adres, yazılandeger);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                string adres3 = "DB2.DBD4";

                object yazılandeger3 = textBox1.Text;

                plc.Write(adres3, yazılandeger3);
            }
            if (textBox2.Enabled == true)
            {
                string adres3 = "DB3.DBD4";

                object yazılandeger3 = textBox2.Text;

                plc.Write(adres3, yazılandeger3);
            }
            timer2.Start();

        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            timer2.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string adres3 = "DB2.DBD4";

            

            object deger= plc.Read(adres3);
            textBox1.Text =Convert.ToString(deger) ;


            string adres4 = "DB3.DBD4";



            object deger1 = plc.Read(adres4);
            textBox2.Text = Convert.ToString(deger1);

            string adres5 = "DB5.DBD4";



            object deger2 = plc.Read(adres5);
            textBox4.Text = Convert.ToString(deger2);


            string adres6 = "DB6.DBD4";



            object deger3 = plc.Read(adres6);
            textBox3.Text = Convert.ToString(deger3);
        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            timer2.Stop();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox4.Enabled == true)
            {
                string adres3 = "DB5.DBD4";

                object yazılandeger3 = textBox4.Text;

                plc.Write(adres3, yazılandeger3);
            }
            if (textBox3.Enabled == true)
            {

                string adres3 = "DB6.DBD4";

                object yazılandeger3 = textBox3.Text;

                plc.Write(adres3, yazılandeger3);
            }
            timer2.Start();
        }

        private void textBox4_MouseDown(object sender, MouseEventArgs e)
        {
            timer2.Stop(); 
        }

        private void textBox3_MouseDown(object sender, MouseEventArgs e)
        {
            timer2.Stop();
        }
    }
}
