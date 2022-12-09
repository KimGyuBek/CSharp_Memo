namespace Memo
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_member = new System.Windows.Forms.ListBox();
            this.btn_addMemo = new System.Windows.Forms.Button();
            this.listBox_memo = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "사용자목록";
            // 
            // listBox_member
            // 
            this.listBox_member.FormattingEnabled = true;
            this.listBox_member.ItemHeight = 24;
            this.listBox_member.Location = new System.Drawing.Point(32, 59);
            this.listBox_member.Name = "listBox_member";
            this.listBox_member.Size = new System.Drawing.Size(205, 364);
            this.listBox_member.TabIndex = 1;
            this.listBox_member.SelectedIndexChanged += new System.EventHandler(this.listBox_member_SelectedIndexChanged);
            // 
            // btn_addMemo
            // 
            this.btn_addMemo.Location = new System.Drawing.Point(254, 59);
            this.btn_addMemo.Name = "btn_addMemo";
            this.btn_addMemo.Size = new System.Drawing.Size(143, 57);
            this.btn_addMemo.TabIndex = 2;
            this.btn_addMemo.Text = "메모추가";
            this.btn_addMemo.UseVisualStyleBackColor = true;
            this.btn_addMemo.Click += new System.EventHandler(this.btn_addMemo_Click);
            // 
            // listBox_memo
            // 
            this.listBox_memo.FormattingEnabled = true;
            this.listBox_memo.ItemHeight = 24;
            this.listBox_memo.Location = new System.Drawing.Point(408, 59);
            this.listBox_memo.Name = "listBox_memo";
            this.listBox_memo.Size = new System.Drawing.Size(349, 364);
            this.listBox_memo.TabIndex = 4;
            this.listBox_memo.SelectedIndexChanged += new System.EventHandler(this.listBox_memo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "메모";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(768, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "메모상세";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(774, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(445, 35);
            this.textBox1.TabIndex = 6;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(1076, 119);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(143, 57);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "메모수정";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 450);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox_memo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_addMemo);
            this.Controls.Add(this.listBox_member);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_member;
        private System.Windows.Forms.Button btn_addMemo;
        private System.Windows.Forms.ListBox listBox_memo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_update;
    }
}

