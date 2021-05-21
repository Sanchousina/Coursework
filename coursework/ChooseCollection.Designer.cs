
namespace coursework
{
    partial class ChooseCollection
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddToFav = new System.Windows.Forms.Button();
            this.AddToLater = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add movie to ..";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddToLater);
            this.panel1.Controls.Add(this.AddToFav);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 50);
            this.panel1.TabIndex = 1;
            // 
            // AddToFav
            // 
            this.AddToFav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.AddToFav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddToFav.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddToFav.FlatAppearance.BorderSize = 0;
            this.AddToFav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToFav.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddToFav.ForeColor = System.Drawing.Color.White;
            this.AddToFav.Location = new System.Drawing.Point(0, 0);
            this.AddToFav.Name = "AddToFav";
            this.AddToFav.Size = new System.Drawing.Size(184, 50);
            this.AddToFav.TabIndex = 51;
            this.AddToFav.Text = "to My favorites";
            this.AddToFav.UseVisualStyleBackColor = false;
            this.AddToFav.Click += new System.EventHandler(this.AddToFav_Click);
            // 
            // AddToLater
            // 
            this.AddToLater.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.AddToLater.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddToLater.Dock = System.Windows.Forms.DockStyle.Right;
            this.AddToLater.FlatAppearance.BorderSize = 0;
            this.AddToLater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToLater.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddToLater.ForeColor = System.Drawing.Color.White;
            this.AddToLater.Location = new System.Drawing.Point(188, 0);
            this.AddToLater.Name = "AddToLater";
            this.AddToLater.Size = new System.Drawing.Size(179, 50);
            this.AddToLater.TabIndex = 52;
            this.AddToLater.Text = "to Will watch later";
            this.AddToLater.UseVisualStyleBackColor = false;
            this.AddToLater.Click += new System.EventHandler(this.AddToLater_Click);
            // 
            // ChooseCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(13)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(367, 95);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "ChooseCollection";
            this.Text = "ChooseCollection";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddToLater;
        private System.Windows.Forms.Button AddToFav;
    }
}