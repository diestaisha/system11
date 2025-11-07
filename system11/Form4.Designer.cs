namespace system11
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(-11, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1299, 623);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(161, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(215, 204);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(470, 88);
            panel3.Name = "panel3";
            panel3.Size = new Size(215, 204);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(783, 88);
            panel4.Name = "panel4";
            panel4.Size = new Size(215, 204);
            panel4.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(470, 362);
            panel5.Name = "panel5";
            panel5.Size = new Size(215, 204);
            panel5.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(783, 362);
            panel6.Name = "panel6";
            panel6.Size = new Size(215, 204);
            panel6.TabIndex = 2;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1267, 600);
            Controls.Add(panel1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
    }
}