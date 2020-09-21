namespace Apartament3
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.cover = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.ConnectionError = new System.Windows.Forms.Label();
            this.Connected = new System.Windows.Forms.Label();
            this.szczegW1 = new Apartament3.SzczegW();
            this.wydatki1 = new Apartament3.Wydatki();
            this.rezList1 = new Apartament3.RezList();
            this.szczegolyR1 = new Apartament3.SzczegolyR();
            this.nowa1 = new Apartament3.Nowa();
            this.rezerwacje1 = new Apartament3.Rezerwacje();
            this.finanse1 = new Apartament3.UserControl1();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.cover.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 682);
            this.panel1.TabIndex = 0;
            // 
            // button8
            // 
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Location = new System.Drawing.Point(12, 378);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(261, 69);
            this.button8.TabIndex = 6;
            this.button8.Text = "Dokumenty";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Location = new System.Drawing.Point(12, 303);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(261, 69);
            this.button7.TabIndex = 5;
            this.button7.Text = "Finanse";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(12, 228);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(261, 69);
            this.button4.TabIndex = 4;
            this.button4.Text = "Wydatki";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(12, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(261, 69);
            this.button2.TabIndex = 3;
            this.button2.Text = "Rezerwacje";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Firebrick;
            this.SidePanel.Location = new System.Drawing.Point(0, 90);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 69);
            this.SidePanel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(12, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(302, 90);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(895, 110);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(273, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(927, 15);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseUp);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Firebrick;
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Location = new System.Drawing.Point(1113, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(87, 22);
            this.panel3.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(16, -5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(25, 25);
            this.button6.TabIndex = 6;
            this.button6.Text = "_";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(45, -5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 25);
            this.button5.TabIndex = 5;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // cover
            // 
            this.cover.Controls.Add(this.finanse1);
            this.cover.Controls.Add(this.szczegW1);
            this.cover.Controls.Add(this.wydatki1);
            this.cover.Controls.Add(this.rezList1);
            this.cover.Controls.Add(this.szczegolyR1);
            this.cover.Controls.Add(this.nowa1);
            this.cover.Controls.Add(this.button3);
            this.cover.Controls.Add(this.ConnectionError);
            this.cover.Location = new System.Drawing.Point(302, 40);
            this.cover.Name = "cover";
            this.cover.Size = new System.Drawing.Size(870, 600);
            this.cover.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Firebrick;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Image = global::Apartament3.Properties.Resources.refresh_5122;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(260, 276);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(318, 66);
            this.button3.TabIndex = 1;
            this.button3.Text = "Spróbuj ponownie";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // ConnectionError
            // 
            this.ConnectionError.AutoSize = true;
            this.ConnectionError.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConnectionError.Location = new System.Drawing.Point(194, 225);
            this.ConnectionError.Name = "ConnectionError";
            this.ConnectionError.Size = new System.Drawing.Size(449, 32);
            this.ConnectionError.TabIndex = 0;
            this.ConnectionError.Text = "Nie udało się połączyć z serwerem";
            this.ConnectionError.Visible = false;
            // 
            // Connected
            // 
            this.Connected.AutoSize = true;
            this.Connected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Connected.Image = global::Apartament3.Properties.Resources.green_dot5;
            this.Connected.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Connected.Location = new System.Drawing.Point(1004, 16);
            this.Connected.Name = "Connected";
            this.Connected.Size = new System.Drawing.Size(100, 18);
            this.Connected.TabIndex = 5;
            this.Connected.Text = "     Połączono";
            this.Connected.Visible = false;
            this.Connected.Click += new System.EventHandler(this.Connected_Click);
            // 
            // szczegW1
            // 
            this.szczegW1.Location = new System.Drawing.Point(38, 65);
            this.szczegW1.Name = "szczegW1";
            this.szczegW1.Size = new System.Drawing.Size(735, 366);
            this.szczegW1.TabIndex = 6;
            // 
            // wydatki1
            // 
            this.wydatki1.Location = new System.Drawing.Point(16, 14);
            this.wydatki1.Name = "wydatki1";
            this.wydatki1.Size = new System.Drawing.Size(854, 536);
            this.wydatki1.TabIndex = 5;
            // 
            // rezList1
            // 
            this.rezList1.Location = new System.Drawing.Point(-23, 0);
            this.rezList1.Name = "rezList1";
            this.rezList1.Size = new System.Drawing.Size(918, 550);
            this.rezList1.TabIndex = 4;
            this.rezList1.Visible = false;
            // 
            // szczegolyR1
            // 
            this.szczegolyR1.Location = new System.Drawing.Point(25, 18);
            this.szczegolyR1.Name = "szczegolyR1";
            this.szczegolyR1.Size = new System.Drawing.Size(861, 488);
            this.szczegolyR1.TabIndex = 3;
            this.szczegolyR1.Load += new System.EventHandler(this.SzczegolyR1_Load);
            // 
            // nowa1
            // 
            this.nowa1.Location = new System.Drawing.Point(25, 50);
            this.nowa1.Name = "nowa1";
            this.nowa1.Size = new System.Drawing.Size(813, 456);
            this.nowa1.TabIndex = 2;
            // 
            // rezerwacje1
            // 
            this.rezerwacje1.Location = new System.Drawing.Point(302, 60);
            this.rezerwacje1.Name = "rezerwacje1";
            this.rezerwacje1.Size = new System.Drawing.Size(870, 580);
            this.rezerwacje1.TabIndex = 2;
            // 
            // finanse1
            // 
            this.finanse1.Location = new System.Drawing.Point(47, 32);
            this.finanse1.Name = "finanse1";
            this.finanse1.Size = new System.Drawing.Size(726, 452);
            this.finanse1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 682);
            this.Controls.Add(this.cover);
            this.Controls.Add(this.Connected);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.rezerwacje1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.cover.ResumeLayout(false);
            this.cover.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private Rezerwacje rezerwacje1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel cover;
        private System.Windows.Forms.Label Connected;
        private Nowa nowa1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label ConnectionError;
        private SzczegolyR szczegolyR1;
        private RezList rezList1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private Wydatki wydatki1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private SzczegW szczegW1;
        private UserControl1 finanse1;
    }
}

