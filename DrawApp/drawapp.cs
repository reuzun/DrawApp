using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawApp
{
    public partial class drawapp_stage : Form
    {


        Curve curve = new Curve();
        Color pointColor = Color.Red;
        Color curveColor = Color.Green;


        public drawapp_stage()
        {
            InitializeComponent();
            combobox_curveColor.SelectedIndex = 1;
            combobox_pointColor.SelectedIndex = 0;
            combobox_curveColor.SelectionChangeCommitted += redrawAll;
            combobox_pointColor.SelectionChangeCommitted += redrawAll;
        }

        private void redrawAll(object sender, EventArgs e)
        {
            this.pointColor = convertStringToColor(combobox_pointColor.SelectedItem.ToString());
            this.curveColor = convertStringToColor(combobox_curveColor.SelectedItem.ToString());
            draw_pane.CreateGraphics().Clear(draw_pane.BackColor);
            Graphics g;
            g = draw_pane.CreateGraphics();

            Rectangle rectangle = new Rectangle();
            PaintEventArgs arg = new PaintEventArgs(g, rectangle);
            reset(arg);

        }


        private Color convertStringToColor(String s)
        {
            switch (s)
            {
                case "Red": return Color.Red;
                case "Green": return Color.Green;
                case "Black": return Color.Black;
                case "Blue": return Color.Blue;
            }
            return Color.Yellow;
        }




        double global_mouse_location_x = 0;
        double global_mouse_location_y = 0;

        private void draw_pane_Paint(object sender, PaintEventArgs e)
        {
            draw_pane.MouseMove += mouseMoving;
            draw_pane.MouseLeave += mouseLeft;
            draw_pane.MouseDown += mouseDownEvent;

        }

        private void mouseDownEvent(object sender, MouseEventArgs e)
        {



            if (e.Button == MouseButtons.Left)
            {

                int x = e.X;
                int y = e.Y;

                Graphics g;
                g = draw_pane.CreateGraphics();

                Rectangle rectangle = new Rectangle();
                PaintEventArgs arg = new PaintEventArgs(g, rectangle);

                DrawPoints(arg);
                adjustCurveLines(arg);
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (curve.pointList.Count < 1) return;

                Graphics g;
                g = draw_pane.CreateGraphics();
                Rectangle rectangle = new Rectangle();
                PaintEventArgs arg = new PaintEventArgs(g, rectangle);

                Point clickedPoint = new Point(global_mouse_location_x, global_mouse_location_y);
                for (int i = 0; i < curve.pointList.Count; i++)
                {
                    if (clickedPoint - curve.pointList[i] < 15)
                    {
                        curve.RemovePoint(i);
                        draw_pane.CreateGraphics().Clear(draw_pane.BackColor);
                        // Mevcutları bir daha çiz
                        reset(arg);
                        return;
                    }
                }

                
                curve.RemovePoint(curve.pointList.Count - 1);
                draw_pane.CreateGraphics().Clear(draw_pane.BackColor);
                // Mevcutları bir daha çiz
                reset(arg);

            }


        }

        private void reset(PaintEventArgs e)
        {
            for (int i = 0; i < curve.pointList.Count; i++)
            {
                DrawPoints(e, curve.pointList[i]);
            }
            adjustCurveLines(e);
        }

        private void DrawPoints(PaintEventArgs e)
        {
            Pen pen = new Pen(this.pointColor, 3);
            Rectangle rec = new Rectangle((int)global_mouse_location_x, (int)global_mouse_location_y, 1, 1);
            Point point = new Point((int)global_mouse_location_x, (int)global_mouse_location_y);
            curve.AddPoint(point);
            e.Graphics.DrawRectangle(pen, rec);
        }

        private void DrawPoints(PaintEventArgs e, Point p1)
        {
            Pen pen = new Pen(this.pointColor, 3);
            Rectangle rec = new Rectangle((int)p1.x, (int)p1.y, 1, 1);

            e.Graphics.DrawRectangle(pen, rec);
        }

        private void adjustCurveLines(PaintEventArgs e)
        {
            Pen pen = new Pen(this.curveColor, 3);
            List<Point> pList = curve.pointList;
            for (int i = 0; i < pList.Count - 1; i++)
            {
                e.Graphics.DrawLine(pen, (int)pList[i].x, (int)pList[i].y, (int)pList[i + 1].x, (int)pList[i + 1].y);
            }
        }

        private void mouseMoving(object sender, MouseEventArgs e)
        {
            global_mouse_location_x = e.Location.X;
            global_mouse_location_y = e.Location.Y;
            this.txt_loc_mouse_x.Text = e.Location.X.ToString();
            this.txt_loc_mouse_y.Text = e.Location.Y.ToString();
        }

        private void mouseLeft(object sender, EventArgs e)
        {
            this.txt_loc_mouse_x.Text = "";
            this.txt_loc_mouse_y.Text = "";
        }

        private void btn_calculate_curveLength_Click(object sender, EventArgs e)
        {
            this.curveLength_txt.Text = curve.CurveLength().ToString();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}