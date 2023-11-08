namespace Uppgift_5._4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tbxTid = new TextBox();
            label2 = new Label();
            lblSvar = new Label();
            btnKör = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 62);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "Tid (Sekunder)";
            // 
            // tbxTid
            // 
            tbxTid.Location = new Point(176, 59);
            tbxTid.Name = "tbxTid";
            tbxTid.Size = new Size(100, 23);
            tbxTid.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 114);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 2;
            label2.Text = "Tid (HH:MM:SS)";
            // 
            // lblSvar
            // 
            lblSvar.AutoSize = true;
            lblSvar.Location = new Point(192, 114);
            lblSvar.Name = "lblSvar";
            lblSvar.Size = new Size(0, 15);
            lblSvar.TabIndex = 3;
            // 
            // btnKör
            // 
            btnKör.Location = new Point(176, 193);
            btnKör.Name = "btnKör";
            btnKör.Size = new Size(75, 23);
            btnKör.TabIndex = 4;
            btnKör.Text = "Kör";
            btnKör.UseVisualStyleBackColor = true;
            btnKör.Click += btnKör_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 274);
            Controls.Add(btnKör);
            Controls.Add(lblSvar);
            Controls.Add(label2);
            Controls.Add(tbxTid);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbxTid;
        private Label label2;
        private Label lblSvar;
        private Button btnKör;
    }
}