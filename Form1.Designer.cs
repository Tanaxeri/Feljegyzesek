namespace Feljegyzesek
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FajlnevText = new System.Windows.Forms.TextBox();
            this.FajlszovegBox = new System.Windows.Forms.RichTextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.DatumPick = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.FileSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.FileOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.EditButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(391, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Feljegyzések";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fájl neve:";
            // 
            // FajlnevText
            // 
            this.FajlnevText.Location = new System.Drawing.Point(93, 148);
            this.FajlnevText.Name = "FajlnevText";
            this.FajlnevText.Size = new System.Drawing.Size(212, 26);
            this.FajlnevText.TabIndex = 2;
            // 
            // FajlszovegBox
            // 
            this.FajlszovegBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FajlszovegBox.Location = new System.Drawing.Point(0, 297);
            this.FajlszovegBox.Name = "FajlszovegBox";
            this.FajlszovegBox.Size = new System.Drawing.Size(1200, 361);
            this.FajlszovegBox.TabIndex = 3;
            this.FajlszovegBox.Text = "";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(16, 216);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(115, 51);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Mentés";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(198, 216);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(121, 51);
            this.OpenButton.TabIndex = 5;
            this.OpenButton.Text = "Megnyitás";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // DatumPick
            // 
            this.DatumPick.Location = new System.Drawing.Point(517, 145);
            this.DatumPick.Name = "DatumPick";
            this.DatumPick.Size = new System.Drawing.Size(259, 26);
            this.DatumPick.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dátum:";
            // 
            // FileOpenDialog
            // 
            this.FileOpenDialog.FileName = "openFileDialog1";
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(367, 216);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(136, 51);
            this.EditButton.TabIndex = 8;
            this.EditButton.Text = "Módosítás";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DatumPick);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.FajlszovegBox);
            this.Controls.Add(this.FajlnevText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FajlnevText;
        private System.Windows.Forms.RichTextBox FajlszovegBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.DateTimePicker DatumPick;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog FileSaveDialog;
        private System.Windows.Forms.OpenFileDialog FileOpenDialog;
        private System.Windows.Forms.Button EditButton;
    }
}

