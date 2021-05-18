
namespace coursework
{
    partial class FilmPage
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
            this.title = new System.Windows.Forms.Label();
            this.poster = new System.Windows.Forms.PictureBox();
            this.descriptionField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.castField = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.Label();
            this.director = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.age_limit = new System.Windows.Forms.Label();
            this.link = new System.Windows.Forms.LinkLabel();
            this.DeleteFilm = new System.Windows.Forms.Button();
            this.ChangeInfo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.poster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.title.Location = new System.Drawing.Point(23, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(156, 45);
            this.title.TabIndex = 0;
            this.title.Text = "Film title";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // poster
            // 
            this.poster.Location = new System.Drawing.Point(23, 69);
            this.poster.Name = "poster";
            this.poster.Size = new System.Drawing.Size(220, 264);
            this.poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.poster.TabIndex = 1;
            this.poster.TabStop = false;
            this.poster.Click += new System.EventHandler(this.poster_Click);
            // 
            // descriptionField
            // 
            this.descriptionField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(13)))), ((int)(((byte)(15)))));
            this.descriptionField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionField.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionField.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.descriptionField.HideSelection = false;
            this.descriptionField.Location = new System.Drawing.Point(23, 350);
            this.descriptionField.Multiline = true;
            this.descriptionField.Name = "descriptionField";
            this.descriptionField.Size = new System.Drawing.Size(456, 196);
            this.descriptionField.TabIndex = 2;
            this.descriptionField.Text = "description";
            this.descriptionField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(265, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Release year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(265, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Country:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(266, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Director:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label.Location = new System.Drawing.Point(265, 172);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(58, 21);
            this.label.TabIndex = 6;
            this.label.Text = "Genre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(269, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cast:";
            // 
            // castField
            // 
            this.castField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(13)))), ((int)(((byte)(15)))));
            this.castField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.castField.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.castField.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.castField.Location = new System.Drawing.Point(269, 269);
            this.castField.Multiline = true;
            this.castField.Name = "castField";
            this.castField.Size = new System.Drawing.Size(210, 64);
            this.castField.TabIndex = 8;
            this.castField.Text = "cast";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.year.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.year.Location = new System.Drawing.Point(410, 68);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(41, 21);
            this.year.TabIndex = 9;
            this.year.Text = "year";
            // 
            // country
            // 
            this.country.AutoSize = true;
            this.country.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.country.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.country.Location = new System.Drawing.Point(410, 103);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(66, 21);
            this.country.TabIndex = 10;
            this.country.Text = "country";
            // 
            // director
            // 
            this.director.AutoSize = true;
            this.director.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.director.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.director.Location = new System.Drawing.Point(407, 140);
            this.director.Name = "director";
            this.director.Size = new System.Drawing.Size(69, 21);
            this.director.TabIndex = 11;
            this.director.Text = "director";
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.genre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.genre.Location = new System.Drawing.Point(410, 172);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(53, 21);
            this.genre.TabIndex = 12;
            this.genre.Text = "genre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(265, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "age limit:";
            // 
            // age_limit
            // 
            this.age_limit.AutoSize = true;
            this.age_limit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.age_limit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.age_limit.Location = new System.Drawing.Point(410, 205);
            this.age_limit.Name = "age_limit";
            this.age_limit.Size = new System.Drawing.Size(100, 21);
            this.age_limit.TabIndex = 14;
            this.age_limit.Text = "18+ or none";
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.link.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.link.Location = new System.Drawing.Point(566, 68);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(159, 25);
            this.link.TabIndex = 15;
            this.link.TabStop = true;
            this.link.Text = "Watch film now!";
            // 
            // DeleteFilm
            // 
            this.DeleteFilm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.DeleteFilm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteFilm.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteFilm.FlatAppearance.BorderSize = 0;
            this.DeleteFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteFilm.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteFilm.ForeColor = System.Drawing.Color.White;
            this.DeleteFilm.Location = new System.Drawing.Point(0, 38);
            this.DeleteFilm.Name = "DeleteFilm";
            this.DeleteFilm.Size = new System.Drawing.Size(148, 33);
            this.DeleteFilm.TabIndex = 49;
            this.DeleteFilm.Text = "Delete film";
            this.DeleteFilm.UseVisualStyleBackColor = false;
            // 
            // ChangeInfo
            // 
            this.ChangeInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.ChangeInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChangeInfo.FlatAppearance.BorderSize = 0;
            this.ChangeInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChangeInfo.ForeColor = System.Drawing.Color.White;
            this.ChangeInfo.Location = new System.Drawing.Point(0, 0);
            this.ChangeInfo.Name = "ChangeInfo";
            this.ChangeInfo.Size = new System.Drawing.Size(148, 38);
            this.ChangeInfo.TabIndex = 50;
            this.ChangeInfo.Text = "Change info";
            this.ChangeInfo.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::coursework.Properties.Resources.pngfind_com_popcorn_clipart_png_6615607;
            this.pictureBox1.Location = new System.Drawing.Point(538, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 315);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.panel1.Controls.Add(this.title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 45);
            this.panel1.TabIndex = 52;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Back);
            this.panel2.Controls.Add(this.DeleteFilm);
            this.panel2.Controls.Add(this.ChangeInfo);
            this.panel2.Location = new System.Drawing.Point(566, 435);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 111);
            this.panel2.TabIndex = 53;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.Dock = System.Windows.Forms.DockStyle.Top;
            this.Back.FlatAppearance.BorderSize = 0;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(0, 71);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(148, 40);
            this.Back.TabIndex = 54;
            this.Back.Text = "Back to catalog";
            this.Back.UseVisualStyleBackColor = false;
            // 
            // FilmPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(13)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(807, 564);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.link);
            this.Controls.Add(this.age_limit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.director);
            this.Controls.Add(this.country);
            this.Controls.Add(this.year);
            this.Controls.Add(this.castField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descriptionField);
            this.Controls.Add(this.poster);
            this.Name = "FilmPage";
            this.Text = "FilmPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FilmPage_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.poster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox poster;
        private System.Windows.Forms.TextBox descriptionField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox castField;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label country;
        private System.Windows.Forms.Label director;
        private System.Windows.Forms.Label genre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label age_limit;
        private System.Windows.Forms.LinkLabel link;
        private System.Windows.Forms.Button DeleteFilm;
        private System.Windows.Forms.Button ChangeInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Back;
    }
}