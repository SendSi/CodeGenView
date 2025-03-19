namespace CodeGenView
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnGenView = new System.Windows.Forms.Button();
            this.inputViewTxt = new System.Windows.Forms.TextBox();
            this.genTargetTxt = new System.Windows.Forms.RichTextBox();
            this.btnGenViewDesktop = new System.Windows.Forms.Button();
            this.globalTip = new System.Windows.Forms.ToolTip(this.components);
            this.inputMgrTxt = new System.Windows.Forms.TextBox();
            this.btnGenMgr = new System.Windows.Forms.Button();
            this.btnGenMgrDesktop = new System.Windows.Forms.Button();
            this.btnGenAllDesktop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenView
            // 
            this.btnGenView.Location = new System.Drawing.Point(315, 12);
            this.btnGenView.Name = "btnGenView";
            this.btnGenView.Size = new System.Drawing.Size(80, 23);
            this.btnGenView.TabIndex = 0;
            this.btnGenView.Text = "查看字符串";
            this.btnGenView.UseVisualStyleBackColor = true;
            this.btnGenView.Click += new System.EventHandler(this.btnGenView_Click);
            // 
            // inputViewTxt
            // 
            this.inputViewTxt.Location = new System.Drawing.Point(18, 14);
            this.inputViewTxt.Name = "inputViewTxt";
            this.inputViewTxt.Size = new System.Drawing.Size(291, 21);
            this.inputViewTxt.TabIndex = 1;
            this.inputViewTxt.Text = "League;LeagueMainView";
            // 
            // genTargetTxt
            // 
            this.genTargetTxt.Location = new System.Drawing.Point(486, 12);
            this.genTargetTxt.Name = "genTargetTxt";
            this.genTargetTxt.Size = new System.Drawing.Size(632, 718);
            this.genTargetTxt.TabIndex = 2;
            this.genTargetTxt.Text = "";
            // 
            // btnGenViewDesktop
            // 
            this.btnGenViewDesktop.Location = new System.Drawing.Point(401, 12);
            this.btnGenViewDesktop.Name = "btnGenViewDesktop";
            this.btnGenViewDesktop.Size = new System.Drawing.Size(75, 23);
            this.btnGenViewDesktop.TabIndex = 3;
            this.btnGenViewDesktop.Text = "生成在桌面";
            this.btnGenViewDesktop.UseVisualStyleBackColor = true;
            this.btnGenViewDesktop.Click += new System.EventHandler(this.btnGenViewDesktop_Click);
            // 
            // inputMgrTxt
            // 
            this.inputMgrTxt.Location = new System.Drawing.Point(18, 51);
            this.inputMgrTxt.Name = "inputMgrTxt";
            this.inputMgrTxt.Size = new System.Drawing.Size(291, 21);
            this.inputMgrTxt.TabIndex = 4;
            this.inputMgrTxt.Text = "League";
            // 
            // btnGenMgr
            // 
            this.btnGenMgr.Location = new System.Drawing.Point(315, 51);
            this.btnGenMgr.Name = "btnGenMgr";
            this.btnGenMgr.Size = new System.Drawing.Size(80, 23);
            this.btnGenMgr.TabIndex = 5;
            this.btnGenMgr.Text = "查看字符串";
            this.btnGenMgr.UseVisualStyleBackColor = true;
            this.btnGenMgr.Click += new System.EventHandler(this.btnGenMgr_Click);
            // 
            // btnGenMgrDesktop
            // 
            this.btnGenMgrDesktop.Location = new System.Drawing.Point(405, 51);
            this.btnGenMgrDesktop.Name = "btnGenMgrDesktop";
            this.btnGenMgrDesktop.Size = new System.Drawing.Size(75, 23);
            this.btnGenMgrDesktop.TabIndex = 6;
            this.btnGenMgrDesktop.Text = "生成在桌面";
            this.btnGenMgrDesktop.UseVisualStyleBackColor = true;
            this.btnGenMgrDesktop.Click += new System.EventHandler(this.btnGenMgrDesktop_Click);
            // 
            // btnGenAllDesktop
            // 
            this.btnGenAllDesktop.Font = new System.Drawing.Font("宋体", 13F);
            this.btnGenAllDesktop.Location = new System.Drawing.Point(315, 687);
            this.btnGenAllDesktop.Name = "btnGenAllDesktop";
            this.btnGenAllDesktop.Size = new System.Drawing.Size(161, 43);
            this.btnGenAllDesktop.TabIndex = 7;
            this.btnGenAllDesktop.Text = "全_生成在桌面";
            this.btnGenAllDesktop.UseVisualStyleBackColor = true;
            this.btnGenAllDesktop.Click += new System.EventHandler(this.btnGenAllDesktop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 742);
            this.Controls.Add(this.btnGenAllDesktop);
            this.Controls.Add(this.btnGenMgrDesktop);
            this.Controls.Add(this.btnGenMgr);
            this.Controls.Add(this.inputMgrTxt);
            this.Controls.Add(this.btnGenViewDesktop);
            this.Controls.Add(this.genTargetTxt);
            this.Controls.Add(this.inputViewTxt);
            this.Controls.Add(this.btnGenView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button btnGenView;
        private System.Windows.Forms.TextBox inputViewTxt;
        private System.Windows.Forms.RichTextBox genTargetTxt;
        private System.Windows.Forms.Button btnGenViewDesktop;
        private System.Windows.Forms.ToolTip globalTip;
        private System.Windows.Forms.TextBox inputMgrTxt;
        private System.Windows.Forms.Button btnGenMgr;
        private System.Windows.Forms.Button btnGenMgrDesktop;
        private System.Windows.Forms.Button btnGenAllDesktop;
    }
}