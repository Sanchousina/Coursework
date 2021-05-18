
namespace coursework
{
    partial class Add_film
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.onloadPoster = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.descriptionField = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.age_limit_none = new System.Windows.Forms.RadioButton();
            this.age_limit18 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.releaseYear = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.castField = new System.Windows.Forms.TextBox();
            this.genreField = new System.Windows.Forms.TextBox();
            this.directorField = new System.Windows.Forms.TextBox();
            this.countryField = new System.Windows.Forms.TextBox();
            this.filmNameField = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.add_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.releaseYear)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(13)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.onloadPoster);
            this.panel1.Controls.Add(this.picture);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.descriptionField);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.age_limit_none);
            this.panel1.Controls.Add(this.age_limit18);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.releaseYear);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.castField);
            this.panel1.Controls.Add(this.genreField);
            this.panel1.Controls.Add(this.directorField);
            this.panel1.Controls.Add(this.countryField);
            this.panel1.Controls.Add(this.filmNameField);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 514);
            this.panel1.TabIndex = 0;
            // 
            // onloadPoster
            // 
            this.onloadPoster.AutoSize = true;
            this.onloadPoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.onloadPoster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.onloadPoster.FlatAppearance.BorderSize = 0;
            this.onloadPoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onloadPoster.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.onloadPoster.ForeColor = System.Drawing.Color.White;
            this.onloadPoster.Location = new System.Drawing.Point(609, 275);
            this.onloadPoster.Name = "onloadPoster";
            this.onloadPoster.Size = new System.Drawing.Size(111, 29);
            this.onloadPoster.TabIndex = 5;
            this.onloadPoster.Text = "onload poster";
            this.onloadPoster.UseVisualStyleBackColor = false;
            this.onloadPoster.Click += new System.EventHandler(this.onloadPoster_Click);
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(516, 70);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(204, 194);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 18;
            this.picture.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(421, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "description";
            // 
            // descriptionField
            // 
            this.descriptionField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.descriptionField.Location = new System.Drawing.Point(421, 312);
            this.descriptionField.Multiline = true;
            this.descriptionField.Name = "descriptionField";
            this.descriptionField.Size = new System.Drawing.Size(299, 159);
            this.descriptionField.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(30, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "cast";
            // 
            // age_limit_none
            // 
            this.age_limit_none.AutoSize = true;
            this.age_limit_none.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.age_limit_none.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.age_limit_none.Location = new System.Drawing.Point(245, 312);
            this.age_limit_none.Name = "age_limit_none";
            this.age_limit_none.Size = new System.Drawing.Size(51, 19);
            this.age_limit_none.TabIndex = 14;
            this.age_limit_none.TabStop = true;
            this.age_limit_none.Text = "none";
            this.age_limit_none.UseVisualStyleBackColor = true;
            // 
            // age_limit18
            // 
            this.age_limit18.AutoSize = true;
            this.age_limit18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.age_limit18.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.age_limit18.Location = new System.Drawing.Point(167, 312);
            this.age_limit18.Name = "age_limit18";
            this.age_limit18.Size = new System.Drawing.Size(44, 19);
            this.age_limit18.TabIndex = 13;
            this.age_limit18.TabStop = true;
            this.age_limit18.Text = "18+";
            this.age_limit18.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(30, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "age limit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(30, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "genre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(30, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "director";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(30, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "country";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(30, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "release year";
            // 
            // releaseYear
            // 
            this.releaseYear.Location = new System.Drawing.Point(167, 115);
            this.releaseYear.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.releaseYear.Minimum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.releaseYear.Name = "releaseYear";
            this.releaseYear.Size = new System.Drawing.Size(53, 23);
            this.releaseYear.TabIndex = 7;
            this.releaseYear.Value = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "movie title";
            // 
            // castField
            // 
            this.castField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.castField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.castField.Location = new System.Drawing.Point(167, 353);
            this.castField.Multiline = true;
            this.castField.Name = "castField";
            this.castField.Size = new System.Drawing.Size(161, 69);
            this.castField.TabIndex = 5;
            // 
            // genreField
            // 
            this.genreField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.genreField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.genreField.Location = new System.Drawing.Point(167, 265);
            this.genreField.Name = "genreField";
            this.genreField.Size = new System.Drawing.Size(161, 23);
            this.genreField.TabIndex = 4;
            this.genreField.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // directorField
            // 
            this.directorField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.directorField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.directorField.Location = new System.Drawing.Point(167, 210);
            this.directorField.Name = "directorField";
            this.directorField.Size = new System.Drawing.Size(161, 23);
            this.directorField.TabIndex = 3;
            this.directorField.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // countryField
            // 
            this.countryField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.countryField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countryField.Location = new System.Drawing.Point(167, 160);
            this.countryField.Name = "countryField";
            this.countryField.Size = new System.Drawing.Size(161, 23);
            this.countryField.TabIndex = 2;
            // 
            // filmNameField
            // 
            this.filmNameField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.filmNameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filmNameField.Location = new System.Drawing.Point(167, 70);
            this.filmNameField.Name = "filmNameField";
            this.filmNameField.Size = new System.Drawing.Size(161, 23);
            this.filmNameField.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.panel2.Controls.Add(this.add_button);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(752, 50);
            this.panel2.TabIndex = 0;
            // 
            // add_button
            // 
            this.add_button.AutoSize = true;
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.add_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_button.FlatAppearance.BorderSize = 0;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(594, 9);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(126, 31);
            this.add_button.TabIndex = 4;
            this.add_button.Text = "add new film";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin panel";
            // 
            // Add_film
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 514);
            this.Controls.Add(this.panel1);
            this.Name = "Add_film";
            this.Text = "Add_film";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.releaseYear)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox countryField;
        private System.Windows.Forms.TextBox filmNameField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox directorField;
        private System.Windows.Forms.TextBox genreField;
        private System.Windows.Forms.TextBox castField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown releaseYear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton age_limit_none;
        private System.Windows.Forms.RadioButton age_limit18;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox descriptionField;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button onloadPoster;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picture;
    }
}