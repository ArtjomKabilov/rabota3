
namespace WindowsFormsApp1
{
    partial class My_form
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
            this.Run_Bottun = new System.Windows.Forms.Button();
            this.TXTA = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Поле = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Значение = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TXTH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTB = new System.Windows.Forms.TextBox();
            this.TXTC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Run_Bottun
            // 
            this.Run_Bottun.BackColor = System.Drawing.Color.Red;
            this.Run_Bottun.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.Run_Bottun.FlatAppearance.BorderSize = 5;
            this.Run_Bottun.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Run_Bottun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Run_Bottun.ForeColor = System.Drawing.Color.Black;
            this.Run_Bottun.Location = new System.Drawing.Point(772, 58);
            this.Run_Bottun.Name = "Run_Bottun";
            this.Run_Bottun.Size = new System.Drawing.Size(218, 140);
            this.Run_Bottun.TabIndex = 0;
            this.Run_Bottun.Text = "ПУСК";
            this.Run_Bottun.UseVisualStyleBackColor = false;
            this.Run_Bottun.Click += new System.EventHandler(this.Run_Bottun_Click);
            // 
            // TXTA
            // 
            this.TXTA.Location = new System.Drawing.Point(531, 321);
            this.TXTA.Name = "TXTA";
            this.TXTA.Size = new System.Drawing.Size(100, 20);
            this.TXTA.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Red;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Поле,
            this.Значение});
            this.listView1.ForeColor = System.Drawing.SystemColors.Control;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(436, 566);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Поле
            // 
            this.Поле.Text = "Поле";
            this.Поле.Width = 198;
            // 
            // Значение
            // 
            this.Значение.Text = "Значение";
            this.Значение.Width = 184;
            // 
            // TXTH
            // 
            this.TXTH.Location = new System.Drawing.Point(531, 399);
            this.TXTH.Name = "TXTH";
            this.TXTH.Size = new System.Drawing.Size(100, 20);
            this.TXTH.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Сторона A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Высота h";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(731, 244);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 280);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Сторона C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Сторона B";
            // 
            // TXTB
            // 
            this.TXTB.Location = new System.Drawing.Point(531, 347);
            this.TXTB.Name = "TXTB";
            this.TXTB.Size = new System.Drawing.Size(100, 20);
            this.TXTB.TabIndex = 3;
            // 
            // TXTC
            // 
            this.TXTC.Location = new System.Drawing.Point(531, 373);
            this.TXTC.Name = "TXTC";
            this.TXTC.Size = new System.Drawing.Size(100, 20);
            this.TXTC.TabIndex = 2;
            // 
            // My_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1099, 716);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TXTH);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.TXTB);
            this.Controls.Add(this.TXTC);
            this.Controls.Add(this.TXTA);
            this.Controls.Add(this.Run_Bottun);
            this.Name = "My_form";
            this.Text = "My_form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Run_Bottun;
        private System.Windows.Forms.TextBox TXTA;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Поле;
        private System.Windows.Forms.ColumnHeader Значение;
        private System.Windows.Forms.TextBox TXTH;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTB;
        private System.Windows.Forms.TextBox TXTC;
    }
}