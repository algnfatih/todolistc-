namespace TodoList
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(86, 385);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(108, 38);
            button1.TabIndex = 9;
            button1.Text = "Giriş Yap";
            button1.TextImageRelation = TextImageRelation.TextAboveImage;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(67, 148);
            label1.Name = "label1";
            label1.Size = new Size(151, 28);
            label1.TabIndex = 10;
            label1.Text = "Kullanıcı adınız ;";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(67, 259);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 11;
            label2.Text = "Parolanız ;";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(62, 188);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 43);
            textBox1.TabIndex = 12;
            textBox1.Text = "admin";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20F);
            textBox2.Location = new Point(62, 299);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '·';
            textBox2.PlaceholderText = "Lütfen Parolanızı girin..";
            textBox2.Size = new Size(299, 43);
            textBox2.TabIndex = 13;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(225, 385);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(108, 38);
            button2.TabIndex = 14;
            button2.Text = "Çıkış Yap";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(175, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Crimson;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(425, 466);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            ForeColor = Color.Snow;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "FA ToDoList | Login";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private PictureBox pictureBox1;
    }
}