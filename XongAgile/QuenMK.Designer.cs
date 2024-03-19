namespace XongAgile
{
    partial class QuenMK
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
            txtMail = new TextBox();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtMail
            // 
            txtMail.Location = new Point(208, 107);
            txtMail.Margin = new Padding(3, 4, 3, 4);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(409, 27);
            txtMail.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 111);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 7;
            label1.Text = "Email";
            // 
            // button2
            // 
            button2.Location = new Point(337, 182);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 30);
            button2.TabIndex = 6;
            button2.Text = "Tiếp Tục";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // QuenMK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 418);
            Controls.Add(txtMail);
            Controls.Add(label1);
            Controls.Add(button2);
            Name = "QuenMK";
            Text = "QuenMK";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMail;
        private Label label1;
        private Button button2;
    }
}