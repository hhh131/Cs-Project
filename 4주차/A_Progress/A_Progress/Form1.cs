using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Progress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Num = 0;
        string OrgStr = "";
        bool status=false;

        private void btnRun_Click(object sender, EventArgs e)
        {
            Timer.Enabled = true;
            status = true;
        }

        private void pbStatus_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OrgStr=this.lblStatus.Text;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Num++;
            if(Num>100)
            {
                this.Timer.Enabled = false;
              
                return;
            }
            this.pbStatus.Value = Num;
            this.lblStatus.Text = OrgStr + Num.ToString()+"%";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            
            //정지
            Timer.Enabled = false;
            Num = 0;
            this.lblStatus.Text = OrgStr;
            pbStatus.Value = Num;
            status = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

              if(status==true)
            { 
                Timer.Enabled = true;
                Num = 0;

            }
            else
            {
                MessageBox.Show("멈춤상태에서는 리셋이 동작하지 않습니다.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {

            Timer.Enabled = false;
        }
    }
}
