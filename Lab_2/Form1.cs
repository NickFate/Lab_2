using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Window : Form
    {

        private Point? last_point;

        private Pen pencil = new Pen(Brushes.Black);

        public Window()
        {
            InitializeComponent();
            pencil.Width = 11;
            pencil.DashPattern = new float[] { 11, 11 };
            pencil.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pencil.EndCap = System.Drawing.Drawing2D.LineCap.Round;

        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            file.Filter = "bmp files (*.bmp)|*.bmp";
            file.Title = "Выберите изображение";

            if (file.ShowDialog() == DialogResult.Cancel) return;

            Canvas.SizeMode = PictureBoxSizeMode.AutoSize;
            Canvas.ImageLocation = file.FileName;
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (Canvas.Image == null) return;
            last_point = e.Location;
            Canvas_MouseMove(sender, e);
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (Canvas.Image == null) return;
            if (last_point == null) return;
            using (Graphics g = Graphics.FromImage(Canvas.Image))
            {
                g.DrawLine(pencil, last_point.Value.X, last_point.Value.Y, e.Location.X, e.Location.Y);
            }
            Canvas.Invalidate();
            last_point = e.Location;
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            last_point = null;
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            pencil.Color = ((Button)sender).BackColor;
        }

        private void PencilSize_Scroll(object sender, EventArgs e)
        {
            pencil.Width = PencilSize.Value;
            PenSize.Text = PencilSize.Value.ToString();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "bmp files (*.bmp)|*.bmp|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp1 = new Bitmap(Canvas.Image);
                // Save the image as a GIF.
                bmp1.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
            }
        }
    }
}
