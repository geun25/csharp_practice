
namespace CrossThread
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
            this.lbox_src = new System.Windows.Forms.ListBox();
            this.lbox_dst = new System.Windows.Forms.ListBox();
            this.btn_move = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbox_src
            // 
            this.lbox_src.FormattingEnabled = true;
            this.lbox_src.ItemHeight = 18;
            this.lbox_src.Location = new System.Drawing.Point(35, 28);
            this.lbox_src.Name = "lbox_src";
            this.lbox_src.Size = new System.Drawing.Size(431, 580);
            this.lbox_src.TabIndex = 0;
            // 
            // lbox_dst
            // 
            this.lbox_dst.FormattingEnabled = true;
            this.lbox_dst.ItemHeight = 18;
            this.lbox_dst.Location = new System.Drawing.Point(718, 28);
            this.lbox_dst.Name = "lbox_dst";
            this.lbox_dst.Size = new System.Drawing.Size(431, 580);
            this.lbox_dst.TabIndex = 1;
            // 
            // btn_move
            // 
            this.btn_move.Location = new System.Drawing.Point(529, 295);
            this.btn_move.Name = "btn_move";
            this.btn_move.Size = new System.Drawing.Size(126, 60);
            this.btn_move.TabIndex = 2;
            this.btn_move.Text = ">>>>";
            this.btn_move.UseVisualStyleBackColor = true;
            this.btn_move.Click += new System.EventHandler(this.btn_move_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 676);
            this.Controls.Add(this.btn_move);
            this.Controls.Add(this.lbox_dst);
            this.Controls.Add(this.lbox_src);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbox_src;
        private System.Windows.Forms.ListBox lbox_dst;
        private System.Windows.Forms.Button btn_move;
    }
}

