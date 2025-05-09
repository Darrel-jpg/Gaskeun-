namespace Gaskeun_
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            label5 = new Label();
            button2 = new Button();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, -7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(404, 651);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(157, 319);
            label5.Name = "label5";
            label5.Size = new Size(136, 27);
            label5.TabIndex = 14;
            label5.Text = "GASKEUN!";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(33, 52, 72);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 114, 184);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 114, 184);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Rounded MT Bold", 13F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(57, 566);
            button2.Name = "button2";
            button2.Size = new Size(336, 53);
            button2.TabIndex = 12;
            button2.Text = "SIGN UP";
            button2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(127, 525);
            label4.Name = "label4";
            label4.Size = new Size(194, 23);
            label4.TabIndex = 11;
            label4.Text = "Register your Account";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(24, 44);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(404, 254);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(537, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(440, 680);
            panel1.TabIndex = 15;
            panel1.Paint += panel1_Paint;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 680);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label5;
        private Button button2;
        private Label label4;
        private PictureBox pictureBox2;
        private Panel panel1;
    }
}