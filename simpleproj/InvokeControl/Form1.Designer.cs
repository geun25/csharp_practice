
namespace InvokeControl
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.lbox_process = new System.Windows.Forms.ListBox();
            this.lbox_inv_ele = new System.Windows.Forms.ListBox();
            this.lbox_history = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbox_history);
            this.splitContainer1.Size = new System.Drawing.Size(1489, 657);
            this.splitContainer1.SplitterDistance = 1002;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lbox_inv_ele);
            this.splitContainer2.Size = new System.Drawing.Size(1002, 657);
            this.splitContainer2.SplitterDistance = 452;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.btn_refresh);
            this.splitContainer3.Panel1.Controls.Add(this.button1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.lbox_process);
            this.splitContainer3.Size = new System.Drawing.Size(452, 657);
            this.splitContainer3.SplitterDistance = 121;
            this.splitContainer3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1242, 275);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(40, 12);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(377, 99);
            this.btn_refresh.TabIndex = 1;
            this.btn_refresh.Text = "프로세스 목록 새로고침";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // lbox_process
            // 
            this.lbox_process.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbox_process.FormattingEnabled = true;
            this.lbox_process.ItemHeight = 18;
            this.lbox_process.Location = new System.Drawing.Point(0, 0);
            this.lbox_process.Name = "lbox_process";
            this.lbox_process.Size = new System.Drawing.Size(452, 532);
            this.lbox_process.TabIndex = 0;
            this.lbox_process.SelectedIndexChanged += new System.EventHandler(this.lbox_process_SelectedIndexChanged);
            // 
            // lbox_inv_ele
            // 
            this.lbox_inv_ele.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbox_inv_ele.FormattingEnabled = true;
            this.lbox_inv_ele.ItemHeight = 18;
            this.lbox_inv_ele.Location = new System.Drawing.Point(0, 0);
            this.lbox_inv_ele.Name = "lbox_inv_ele";
            this.lbox_inv_ele.Size = new System.Drawing.Size(546, 657);
            this.lbox_inv_ele.TabIndex = 0;
            this.lbox_inv_ele.SelectedIndexChanged += new System.EventHandler(this.lbox_inv_ele_SelectedIndexChanged);
            // 
            // lbox_history
            // 
            this.lbox_history.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbox_history.FormattingEnabled = true;
            this.lbox_history.ItemHeight = 18;
            this.lbox_history.Location = new System.Drawing.Point(0, 0);
            this.lbox_history.Name = "lbox_history";
            this.lbox_history.Size = new System.Drawing.Size(483, 657);
            this.lbox_history.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 657);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbox_process;
        private System.Windows.Forms.ListBox lbox_inv_ele;
        private System.Windows.Forms.ListBox lbox_history;
    }
}

