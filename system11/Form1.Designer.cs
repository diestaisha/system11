namespace system11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-5, -14);
            panel1.Name = "panel1";
            panel1.Size = new Size(1290, 629);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.SaddleBrown;
            button4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(280, 435);
            button4.Name = "button4";
            button4.Size = new Size(247, 54);
            button4.TabIndex = 5;
            button4.Text = "ORDER";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SaddleBrown;
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(280, 350);
            button3.Name = "button3";
            button3.Size = new Size(247, 54);
            button3.TabIndex = 4;
            button3.Text = "HISTORY OF TRANSACTION";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SaddleBrown;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(280, 267);
            button1.Name = "button1";
            button1.Size = new Size(247, 54);
            button1.TabIndex = 2;
            button1.Text = "MENU";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(200, 180);
            label2.Name = "label2";
            label2.Size = new Size(357, 26);
            label2.TabIndex = 1;
            label2.Text = "SKIP THE LINE. SAVOR THE TIME";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(52, 113);
            label1.Name = "label1";
            label1.Size = new Size(699, 51);
            label1.TabIndex = 0;
            label1.Text = "ORDER PROCCESSING SYSTEM";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1267, 600);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private Label label2;
        private Button button4;
        private Button button3;
    }
}
