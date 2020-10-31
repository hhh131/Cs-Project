using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        String OrgStr = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            OrgStr = this.lblResult.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(this.txtList.Text!="")
            {
                this.lbView.Items.Add(this.txtList.Text);
                this.txtList.Text = "";

            }
            else
            {
                MessageBox.Show("아이템을 입력하세요", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtList.Focus();
            }
        }

        private void lbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbView.SelectedItems.Count != 0)//코드수정
            {
                this.lblResult.Text = OrgStr + this.lbView.SelectedItem.ToString();

            }
            else
            {
                this.lblResult.Text = OrgStr;
            }
            }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            if(this.lbView.SelectedItems.Count!=0)//코드 수정
            {
                MessageBox.Show("선택한 "+this.lbView.SelectedItem.ToString()+" 아이템 삭제완료", "알림",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
             
                this.lbView.Items.Remove(lbView.SelectedItem);
              
            }
            else
            {
                MessageBox.Show("아이템을 선택하세요", "알림",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                

            }



        }
    }
}
