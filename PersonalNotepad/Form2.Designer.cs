namespace PersonalNotepad
{
    partial class frmAskForSaving
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
            this.lblAsk = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAsk
            // 
            this.lblAsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.98507F);
            this.lblAsk.Location = new System.Drawing.Point(66, 67);
            this.lblAsk.Name = "lblAsk";
            this.lblAsk.Size = new System.Drawing.Size(333, 69);
            this.lblAsk.TabIndex = 0;
            this.lblAsk.Text = "Do you want to save yor text befor?";
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(71, 139);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(120, 30);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(284, 139);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(115, 30);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // frmAskForSaving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 274);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblAsk);
            this.Name = "frmAskForSaving";
            this.Text = "Saving";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAsk;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
    }
}