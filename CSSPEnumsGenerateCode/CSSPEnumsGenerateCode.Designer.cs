namespace CSSPEnumsGenerateCode
{
    partial class CSSPEnumsGenerateCode
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.butGenerateEnumWithHelp = new System.Windows.Forms.Button();
            this.butGenerateAllCodeFiles = new System.Windows.Forms.Button();
            this.richTextBoxStatus = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.lblNote);
            this.splitContainer1.Panel1.Controls.Add(this.butGenerateEnumWithHelp);
            this.splitContainer1.Panel1.Controls.Add(this.butGenerateAllCodeFiles);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBoxStatus);
            this.splitContainer1.Size = new System.Drawing.Size(827, 477);
            this.splitContainer1.SplitterDistance = 106;
            this.splitContainer1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(827, 31);
            this.panel2.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(66, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 4;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(12, 38);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(492, 24);
            this.lblNote.TabIndex = 26;
            this.lblNote.Text = "Note: You will have to recompile the CSSPEnums project.";
            // 
            // butGenerateEnumWithHelp
            // 
            this.butGenerateEnumWithHelp.Location = new System.Drawing.Point(181, 12);
            this.butGenerateEnumWithHelp.Name = "butGenerateEnumWithHelp";
            this.butGenerateEnumWithHelp.Size = new System.Drawing.Size(183, 23);
            this.butGenerateEnumWithHelp.TabIndex = 11;
            this.butGenerateEnumWithHelp.Text = "Generate EnumsWithHelp.cs";
            this.butGenerateEnumWithHelp.UseVisualStyleBackColor = true;
            this.butGenerateEnumWithHelp.Click += new System.EventHandler(this.butGenerateEnumsWithHelp_Click);
            // 
            // butGenerateAllCodeFiles
            // 
            this.butGenerateAllCodeFiles.Location = new System.Drawing.Point(12, 12);
            this.butGenerateAllCodeFiles.Name = "butGenerateAllCodeFiles";
            this.butGenerateAllCodeFiles.Size = new System.Drawing.Size(163, 23);
            this.butGenerateAllCodeFiles.TabIndex = 11;
            this.butGenerateAllCodeFiles.Text = "Generate all code files";
            this.butGenerateAllCodeFiles.UseVisualStyleBackColor = true;
            this.butGenerateAllCodeFiles.Click += new System.EventHandler(this.butGenerateAllCodeFiles_Click);
            // 
            // richTextBoxStatus
            // 
            this.richTextBoxStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxStatus.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxStatus.Name = "richTextBoxStatus";
            this.richTextBoxStatus.Size = new System.Drawing.Size(827, 367);
            this.richTextBoxStatus.TabIndex = 0;
            this.richTextBoxStatus.Text = "";
            // 
            // CSSPEnumsGenerateCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 477);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CSSPEnumsGenerateCode";
            this.Text = "CSSP Enums Generate Code";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button butGenerateAllCodeFiles;
        private System.Windows.Forms.RichTextBox richTextBoxStatus;
        private System.Windows.Forms.Button butGenerateEnumWithHelp;
    }
}

