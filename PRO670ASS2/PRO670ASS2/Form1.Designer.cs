namespace PRO670ASS2
{
    partial class frmFirst
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBuild = new System.Windows.Forms.Button();
            this.cmbCBB = new System.Windows.Forms.ComboBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblTransfer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(53, 229);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.Exit);
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(211, 229);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(75, 23);
            this.btnBuild.TabIndex = 1;
            this.btnBuild.Text = "Build";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Visible = false;
            this.btnBuild.Click += new System.EventHandler(this.Build);
            // 
            // cmbCBB
            // 
            this.cmbCBB.FormattingEnabled = true;
            this.cmbCBB.Location = new System.Drawing.Point(193, 87);
            this.cmbCBB.Name = "cmbCBB";
            this.cmbCBB.Size = new System.Drawing.Size(121, 21);
            this.cmbCBB.TabIndex = 2;
            this.cmbCBB.SelectedIndexChanged += new System.EventHandler(this.Check);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(68, 123);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(35, 13);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "label1";
            // 
            // lblTransfer
            // 
            this.lblTransfer.AutoSize = true;
            this.lblTransfer.Location = new System.Drawing.Point(71, 163);
            this.lblTransfer.Name = "lblTransfer";
            this.lblTransfer.Size = new System.Drawing.Size(35, 13);
            this.lblTransfer.TabIndex = 4;
            this.lblTransfer.Text = "label1";
            this.lblTransfer.Visible = false;
            // 
            // frmFirst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTransfer);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.cmbCBB);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.btnExit);
            this.Name = "frmFirst";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.ComboBox cmbCBB;
        private System.Windows.Forms.Label lblWelcome;
        public System.Windows.Forms.Label lblTransfer;
    }
}

