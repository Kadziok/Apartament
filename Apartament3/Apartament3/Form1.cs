using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartament3
{
    public partial class Form1 : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public Form1()
        {
            InitializeComponent();
            cover.BringToFront();
            Connection.form = this;
            if (Connection.Connect())
            {
                Connected.Visible = true;
                cover.BringToFront();
                rezerwacje1.BringToFront();
                rezerwacje1.LoadData();
            }
            else
            {
                ConnectionError.Visible = true;
                nowa1.Visible = false;
                cover.BringToFront();
                ConnectionError.BringToFront();
                button3.BringToFront();
                button3.Visible = true;
            }
            Connection.Disconnect();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            rezList1.Visible = false;
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            cover.BringToFront();
            rezerwacje1.BringToFront();
            rezerwacje1.LoadData();
            rezerwacje1.Visible = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            cover.BringToFront();
            nowa1.Visible = false;
            rezList1.LoadData();
            rezList1.BringToFront();
            rezList1.Visible = true;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Connected_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (Connection.Connect())
            {
                Connected.Visible = true;
                ConnectionError.Visible = false;
                button3.Visible = false;
                rezerwacje1.BringToFront();
            }
            else
            {
                ConnectionError.Visible = true;
                Connected.Visible = false;
            }
        }
        public void NowaRezerwacja()
        {
            HideAll();
            cover.BringToFront();
            nowa1.LoadData();
            nowa1.BringToFront();
            nowa1.Visible = true;
        }
        public void ErrorMessage(string error, string title)
        {
            MessageBox.Show(error, title,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void LoadNowa()
        {
            nowa1.LoadData();
        }

        private void SzczegolyR1_Load(object sender, EventArgs e)
        {

        }
        public void Szczegoly(string id)
        {
            HideAll();
            cover.BringToFront();
            szczegolyR1.LoadData(id);
            szczegolyR1.BringToFront();
            szczegolyR1.Visible = true;
        }
        public void ShowStart()
        {
            HideAll();
            cover.BringToFront();
            rezerwacje1.LoadData();
            rezerwacje1.BringToFront();
            rezerwacje1.Visible = true;
        }
        private void HideAll()
        {
            rezList1.Visible = false;
            nowa1.Visible = false;
            rezerwacje1.Visible = false;
            szczegolyR1.Visible = false;
            wydatki1.Visible = false;
            szczegW1.Visible = false;
            finanse1.Visible = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            cover.BringToFront();
            HideAll();
            wydatki1.LoadData();
            wydatki1.BringToFront();
            wydatki1.Visible = true;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Panel2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        public void ShowSzczegW(string id)
        {
            HideAll();
            cover.BringToFront();
            szczegW1.LoadData(id);
            szczegW1.BringToFront();
            szczegW1.Visible = true;
        }
        public void ShowWydatki()
        {
            cover.BringToFront();
            HideAll();
            wydatki1.LoadData();
            wydatki1.BringToFront();
            wydatki1.Visible = true;
        }
        public void ShowRezerwacje()
        {
            Button2_Click(null, null);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button7.Height;
            SidePanel.Top = button7.Top;
            cover.BringToFront();
            HideAll();
            finanse1.BringToFront();
            finanse1.Visible = true;
        }
    }
}
