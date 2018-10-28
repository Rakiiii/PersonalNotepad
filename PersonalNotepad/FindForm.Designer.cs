namespace PersonalNotepad
{
    partial class FindForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFindMatch = new System.Windows.Forms.Button();
            this.rdbtnDown = new System.Windows.Forms.RadioButton();
            this.rdbtnUp = new System.Windows.Forms.RadioButton();
            this.txtbxStringToFind = new System.Windows.Forms.TextBox();
            this.chckbxMatchCase = new System.Windows.Forms.CheckBox();
            this.lblFind = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(470, 94);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 45);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFindMatch
            // 
            this.btnFindMatch.Location = new System.Drawing.Point(470, 45);
            this.btnFindMatch.Name = "btnFindMatch";
            this.btnFindMatch.Size = new System.Drawing.Size(124, 43);
            this.btnFindMatch.TabIndex = 1;
            this.btnFindMatch.Text = "Find match";
            this.btnFindMatch.UseVisualStyleBackColor = true;
            this.btnFindMatch.Click += new System.EventHandler(this.btnFindMatch_Click);
            // 
            // rdbtnDown
            // 
            this.rdbtnDown.AutoSize = true;
            this.rdbtnDown.Checked = true;
            this.rdbtnDown.Location = new System.Drawing.Point(255, 94);
            this.rdbtnDown.Name = "rdbtnDown";
            this.rdbtnDown.Size = new System.Drawing.Size(63, 20);
            this.rdbtnDown.TabIndex = 2;
            this.rdbtnDown.TabStop = true;
            this.rdbtnDown.Text = "Down";
            this.rdbtnDown.UseVisualStyleBackColor = true;
            // 
            // rdbtnUp
            // 
            this.rdbtnUp.AutoSize = true;
            this.rdbtnUp.Location = new System.Drawing.Point(336, 94);
            this.rdbtnUp.Name = "rdbtnUp";
            this.rdbtnUp.Size = new System.Drawing.Size(47, 20);
            this.rdbtnUp.TabIndex = 3;
            this.rdbtnUp.Text = "Up";
            this.rdbtnUp.UseVisualStyleBackColor = true;
            // 
            // txtbxStringToFind
            // 
            this.txtbxStringToFind.Location = new System.Drawing.Point(99, 45);
            this.txtbxStringToFind.Name = "txtbxStringToFind";
            this.txtbxStringToFind.Size = new System.Drawing.Size(341, 22);
            this.txtbxStringToFind.TabIndex = 4;
            // 
            // chckbxMatchCase
            // 
            this.chckbxMatchCase.AutoSize = true;
            this.chckbxMatchCase.Location = new System.Drawing.Point(99, 95);
            this.chckbxMatchCase.Name = "chckbxMatchCase";
            this.chckbxMatchCase.Size = new System.Drawing.Size(99, 20);
            this.chckbxMatchCase.TabIndex = 5;
            this.chckbxMatchCase.Text = "Match case";
            this.chckbxMatchCase.UseVisualStyleBackColor = true;
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Location = new System.Drawing.Point(29, 45);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(64, 16);
            this.lblFind.TabIndex = 6;
            this.lblFind.Text = "Find what";
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 158);
            this.Controls.Add(this.lblFind);
            this.Controls.Add(this.chckbxMatchCase);
            this.Controls.Add(this.txtbxStringToFind);
            this.Controls.Add(this.rdbtnUp);
            this.Controls.Add(this.rdbtnDown);
            this.Controls.Add(this.btnFindMatch);
            this.Controls.Add(this.btnCancel);
            this.Name = "FindForm";
            this.Text = "FindForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFindMatch;
        private System.Windows.Forms.RadioButton rdbtnDown;
        private System.Windows.Forms.RadioButton rdbtnUp;
        private System.Windows.Forms.TextBox txtbxStringToFind;
        private System.Windows.Forms.CheckBox chckbxMatchCase;
        private System.Windows.Forms.Label lblFind;
    }
}