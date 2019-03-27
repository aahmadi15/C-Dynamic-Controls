namespace PRO670ASS2
{
    partial class frmBuilded
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblShowOption = new System.Windows.Forms.Label();
            this.lblErr = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblShowOption
            // 
            this.lblShowOption.AutoSize = true;
            this.lblShowOption.Location = new System.Drawing.Point(56, 70);
            this.lblShowOption.Name = "lblShowOption";
            this.lblShowOption.Size = new System.Drawing.Size(84, 13);
            this.lblShowOption.TabIndex = 0;
            this.lblShowOption.Text = "Enter your Data:";
            // 
            // lblErr
            // 
            this.lblErr.AutoSize = true;
            this.lblErr.ForeColor = System.Drawing.Color.Red;
            this.lblErr.Location = new System.Drawing.Point(59, 104);
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(75, 13);
            this.lblErr.TabIndex = 1;
            this.lblErr.Text = "Enter data first";
            this.lblErr.Visible = false;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(59, 188);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 3;
            this.btnDone.Text = "Quit";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.Close);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Transfer);
            // 
            // frmBuilded
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblErr);
            this.Controls.Add(this.lblShowOption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmBuilded";
            this.Text = "Builded";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblShowOption;
        private System.Windows.Forms.Label lblErr;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button button1;
    }
}