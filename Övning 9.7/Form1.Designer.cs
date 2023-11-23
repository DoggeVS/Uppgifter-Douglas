namespace Övning_9._7
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
            tbxNivå = new TextBox();
            lblNivå = new Label();
            btnKör = new Button();
            tbxUtdata = new TextBox();
            SuspendLayout();
            // 
            // tbxNivå
            // 
            tbxNivå.Location = new Point(336, 68);
            tbxNivå.Name = "tbxNivå";
            tbxNivå.Size = new Size(53, 23);
            tbxNivå.TabIndex = 0;
            // 
            // lblNivå
            // 
            lblNivå.AutoSize = true;
            lblNivå.Location = new Point(336, 50);
            lblNivå.Name = "lblNivå";
            lblNivå.Size = new Size(31, 15);
            lblNivå.TabIndex = 1;
            lblNivå.Text = "Nivå";
            // 
            // btnKör
            // 
            btnKör.Location = new Point(336, 221);
            btnKör.Name = "btnKör";
            btnKör.Size = new Size(53, 23);
            btnKör.TabIndex = 2;
            btnKör.Text = "Visa";
            btnKör.UseVisualStyleBackColor = true;
            btnKör.Click += btnKör_Click;
            // 
            // tbxUtdata
            // 
            tbxUtdata.Location = new Point(10, 47);
            tbxUtdata.Multiline = true;
            tbxUtdata.Name = "tbxUtdata";
            tbxUtdata.ScrollBars = ScrollBars.Both;
            tbxUtdata.Size = new Size(320, 198);
            tbxUtdata.TabIndex = 3;
            tbxUtdata.WordWrap = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 256);
            Controls.Add(tbxUtdata);
            Controls.Add(btnKör);
            Controls.Add(lblNivå);
            Controls.Add(tbxNivå);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxNivå;
        private Label lblNivå;
        private Button btnKör;
        private TextBox tbxUtdata;
    }
}