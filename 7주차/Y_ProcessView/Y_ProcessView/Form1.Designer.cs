namespace Y_ProcessView
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvView = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMemory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnKill = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.tsslProcess = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCpu = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslMem = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvView
            // 
            this.lvView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chPid,
            this.chTime,
            this.chMemory});
            this.lvView.FullRowSelect = true;
            this.lvView.GridLines = true;
            this.lvView.HideSelection = false;
            this.lvView.Location = new System.Drawing.Point(92, 39);
            this.lvView.Name = "lvView";
            this.lvView.Size = new System.Drawing.Size(594, 328);
            this.lvView.TabIndex = 0;
            this.lvView.UseCompatibleStateImageBehavior = false;
            this.lvView.View = System.Windows.Forms.View.Details;
          
            // 
            // chName
            // 
            this.chName.Text = "프로세스 이름";
            this.chName.Width = 108;
            // 
            // chPid
            // 
            this.chPid.Text = "PID";
            this.chPid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chTime
            // 
            this.chTime.Text = "Time";
            this.chTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chTime.Width = 90;
            // 
            // chMemory
            // 
            this.chMemory.Text = "메모리 사용";
            this.chMemory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chMemory.Width = 100;
            // 
            // btnKill
            // 
            this.btnKill.Location = new System.Drawing.Point(315, 373);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(144, 23);
            this.btnKill.TabIndex = 1;
            this.btnKill.Text = "프로세스 끝내기";
            this.btnKill.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslProcess,
            this.tsslCpu,
            this.tsslMem});
            this.statusStrip2.Location = new System.Drawing.Point(0, 406);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(800, 22);
            this.statusStrip2.TabIndex = 4;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // tsslProcess
            // 
            this.tsslProcess.Name = "tsslProcess";
            this.tsslProcess.Size = new System.Drawing.Size(85, 17);
            this.tsslProcess.Text = "프로세스 : 0개";
            // 
            // tsslCpu
            // 
            this.tsslCpu.Name = "tsslCpu";
            this.tsslCpu.Size = new System.Drawing.Size(82, 17);
            this.tsslCpu.Text = "CPU사용 : 0%";
            // 
            // tsslMem
            // 
            this.tsslMem.Name = "tsslMem";
            this.tsslMem.Size = new System.Drawing.Size(96, 17);
            this.tsslMem.Text = "실제 메모리 0 %";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnKill);
            this.Controls.Add(this.lvView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvView;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chPid;
        private System.Windows.Forms.ColumnHeader chTime;
        private System.Windows.Forms.ColumnHeader chMemory;
        private System.Windows.Forms.Button btnKill;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel tsslProcess;
        private System.Windows.Forms.ToolStripStatusLabel tsslCpu;
        private System.Windows.Forms.ToolStripStatusLabel tsslMem;
    }
}

