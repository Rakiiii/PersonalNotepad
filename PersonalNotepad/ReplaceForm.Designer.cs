namespace PersonalNotepad
{
    partial class ReplaceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxRaplacwWith = new System.Windows.Forms.TextBox();
            this.txtbxReplaceWhat = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.chckbxMatchCase = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Replace what";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Replace With";
            // 
            // txtbxRaplacwWith
            // 
            this.txtbxRaplacwWith.Location = new System.Drawing.Point(144, 99);
            this.txtbxRaplacwWith.Name = "txtbxRaplacwWith";
            this.txtbxRaplacwWith.Size = new System.Drawing.Size(300, 22);
            this.txtbxRaplacwWith.TabIndex = 2;
            // 
            // txtbxReplaceWhat
            // 
            this.txtbxReplaceWhat.Location = new System.Drawing.Point(144, 46);
            this.txtbxReplaceWhat.Name = "txtbxReplaceWhat";
            this.txtbxReplaceWhat.Size = new System.Drawing.Size(300, 22);
            this.txtbxReplaceWhat.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(475, 90);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 40);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(475, 46);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(111, 38);
            this.btnReplace.TabIndex = 5;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // chckbxMatchCase
            // 
            this.chckbxMatchCase.AutoSize = true;
            this.chckbxMatchCase.Location = new System.Drawing.Point(12, 139);
            this.chckbxMatchCase.Name = "chckbxMatchCase";
            this.chckbxMatchCase.Size = new System.Drawing.Size(99, 20);
            this.chckbxMatchCase.TabIndex = 6;
            this.chckbxMatchCase.Text = "Match case";
            this.chckbxMatchCase.UseVisualStyleBackColor = true;
            // 
            // ReplaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 226);
            this.Controls.Add(this.chckbxMatchCase);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtbxReplaceWhat);
            this.Controls.Add(this.txtbxRaplacwWith);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReplaceForm";
            this.Text = "ReplaceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxRaplacwWith;
        private System.Windows.Forms.TextBox txtbxReplaceWhat;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.CheckBox chckbxMatchCase;
    }
}