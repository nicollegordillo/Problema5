using Microsoft.VisualBasic.Devices;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


//Programa de Paula Barillas y Nicolle Gordillo
namespace problema5
{
    public partial class Form1 : Form
    {

        //private Point[] dotPositions = new Point[0];
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Paint += pictureBoxCampo_Paint;
            pictureBox1.Width = 601; // Adjust this value as needed
            pictureBox1.Height = 601; // Adjust this value as needed
                                      // dotPositions = new Point[0];
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate(); // Redraw the PictureBox
            label7.Visible=false;
            textBox6.Visible=false;
            label4.Visible=true;
            label5.Visible=true;
            label6.Visible=true;
            textBox4.Visible=true;
            textBox5.Visible=true;
            label1.Visible=true;
            label2.Visible=true;
            label3.Visible=false;
            textBox1.Visible=true;
            textBox2.Visible=true; ;
            textBox3.Visible=false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate(); // Redraw the PictureBox
            label7.Visible=false;
            textBox6.Visible=false;
            label4.Visible=true;
            label5.Visible=true;
            label6.Visible=true;
            textBox4.Visible=true;
            textBox5.Visible=true;
            label1.Visible=true;
            label2.Visible=true;
            label3.Visible=true;
            textBox1.Visible=true;
            textBox2.Visible=true;
            textBox3.Visible=true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate(); // Redraw the PictureBox
            label7.Visible=false;
            textBox6.Visible=false;
            label4.Visible=true;
            label5.Visible=true;
            label6.Visible=true;
            textBox4.Visible=true;
            textBox5.Visible=true;
            label1.Visible=true;
            label2.Visible=false;
            label3.Visible=false;
            textBox1.Visible=true;
            textBox2.Visible=false;
            textBox3.Visible=false;
        }

        private void pictureBoxCampo_Paint(object sender, PaintEventArgs e)
        {
            // Dibuja la cuadrícula en el PictureBox
            DrawGrid(e.Graphics);

            // Determine which radio button is checked and call the corresponding drawing method
            /*
            if (radioButton1.Checked)
            {
                DrawCone(e.Graphics, pictureBox1.Width, pictureBox1.Height);
            }
            else if (radioButton2.Checked)
            {
                DrawTruncatedCone(e.Graphics, pictureBox1.Width, pictureBox1.Height);
            }
            else if (radioButton3.Checked)
            {
                DrawHemisphere(e.Graphics, pictureBox1.Width, pictureBox1.Height);
            }*/
        }


        private void DrawGrid(Graphics g)
        {
            int gridSize = 20; // Tamaño de cada celda de la cuadrícula

            // Obtiene el tamaño del PictureBox
            int pictureBoxWidth = 600;
            int pictureBoxHeight = 600;

            // Dibuja las líneas verticales de la cuadrícula
            for (int x = 0; x <= pictureBoxWidth; x += gridSize)
            {
                g.DrawLine(Pens.DarkGray, x, 0, x, pictureBoxHeight);
            }

            // Dibuja las líneas horizontales de la cuadrícula
            for (int y = 0; y <= pictureBoxHeight; y += gridSize)
            {
                g.DrawLine(Pens.DarkGray, 0, y, pictureBoxWidth, y);
            }

            // Dibuja el eje X (horizontal) en el centro del PictureBox
            g.DrawLine(Pens.Black, 0, pictureBoxHeight / 2, pictureBoxWidth, pictureBoxHeight / 2);

            // Dibuja el eje Y (vertical) en el centro del PictureBox
            g.DrawLine(Pens.Black, pictureBoxWidth / 2, 0, pictureBoxWidth / 2, pictureBoxHeight);
            /*
            // Determine which radio button is checked
            if (radioButton1.Checked)
            {
                DrawCone(g, pictureBoxWidth, pictureBoxHeight);
            }
            else if (radioButton2.Checked)
            {
                DrawTruncatedCone(g, pictureBoxWidth, pictureBoxHeight);
            }
            else if (radioButton3.Checked)
            {
                DrawHemisphere(g, pictureBoxWidth, pictureBoxHeight);
            }*/
        }

        private void DrawCone(Graphics g, int pictureBoxWidth, int pictureBoxHeight)
        {
            int centerX = pictureBoxWidth / 2;
            int centerY = pictureBoxHeight / 2;
            double altura = Convert.ToDouble(textBox2.Text)*20;
            double radio = Convert.ToDouble(textBox1.Text)*20;
            // Draw the cone using lines
            Point[] coneVertices = new Point[]
            {

                new Point(centerX , centerY -(int)radio),
                new Point(centerX+(int)altura, centerY),
                new Point(centerX, centerY +(int)radio)
            };
            g.DrawPolygon(Pens.Blue, coneVertices);
        }

        private void DrawTruncatedCone(Graphics g, int pictureBoxWidth, int pictureBoxHeight)
        {
            int centerX = pictureBoxWidth / 2;
            int centerY = pictureBoxHeight / 2;
            double altura = Convert.ToDouble(textBox2.Text)*20;
            double radio = Convert.ToDouble(textBox1.Text)*20;
            double radiom = Convert.ToDouble(textBox3.Text)*20;
            // Draw the truncated cone using lines
            Point[] truncatedConeVertices = new Point[]
            {
                new Point(centerX , centerY -(int)radio),
                new Point(centerX+(int)altura, centerY-(int)radiom),
                new Point(centerX+(int)altura, centerY+(int)radiom),
                new Point(centerX, centerY +(int)radio)
            };
            g.DrawPolygon(Pens.Red, truncatedConeVertices);
        }

        private void DrawHemisphere(Graphics g, int pictureBoxWidth, int pictureBoxHeight)
        {
            int centerX = pictureBoxWidth / 2;
            int centerY = pictureBoxHeight / 2;
            double radius = Convert.ToDouble(textBox1.Text)*20;

            // Draw the hemisphere using an ellipse and a chord
            g.DrawPie(Pens.Purple, centerX -(int)radius, centerY - (int)radius, 2 *(int)radius, (int)radius*2, 90, 180);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Visible=true;
            textBox6.Visible=true;
            // Get the center point of the X-axis
            int centerX = pictureBox1.Width / 2;
            int centerY = pictureBox1.Height / 2;

            // Draw a small ellipse (dot) at the center of the X-axis
            int dotRadius = 5; // Adjust this value as needed
            int dotX = centerX - dotRadius;
            int dotY = centerY - dotRadius;
            int dotDiameter = 2 * dotRadius;
            /*
            foreach (Point dotPosition in dotPositions)
            {
                pictureBox1.CreateGraphics().FillEllipse(Brushes.HotPink, dotPosition.X - dotRadius, dotPosition.Y - dotRadius, 2 * dotRadius, 2 * dotRadius);
            }*/

            double x = Convert.ToDouble(textBox4.Text)*20;
            if (radioButton1.Checked)
            {
                DrawCone(pictureBox1.CreateGraphics(), 601, 601);

                double Q = Convert.ToDouble(textBox5.Text);
                double R = Convert.ToDouble(textBox1.Text);
                double H = Convert.ToDouble(textBox2.Text);
                double d = Convert.ToDouble(textBox4.Text);
                double electricField = Math.Round((((3*Q)/(2*Math.PI*(8.85*Math.Pow(10, -1*12))*Math.Pow(R, 3)))*(H-Math.Log(R+(Math.Sqrt(Math.Pow(d+H, 2)+Math.Pow(R, 2))/(d+H))))), 2);
                // Calculate the end point of the arrow
                int arrowEndX = (int)d;
                textBox6.Text=electricField.ToString();
                // Draw the arrow with magnitude-based length
                DrawArrow(pictureBox1.CreateGraphics(), centerX, centerY, arrowEndX, electricField);
            }
            else if (radioButton2.Checked)
            {
                DrawTruncatedCone(pictureBox1.CreateGraphics(), 601, 601);
                double Q = Convert.ToDouble(textBox5.Text);
                double r = Convert.ToDouble(textBox1.Text);
                double H = Convert.ToDouble(textBox2.Text);
                double d = Convert.ToDouble(textBox4.Text);
                double R = Convert.ToDouble(textBox3.Text);

                //double electricField = Math.Round((-1*Math.Pow(H,2)*Math.Sqrt((d*d*(r-R)*(r-R)-2*d*(r-R)*(H*R+d*(r-R))+H*H*(R*R-d*d)+2*H*R*d*(r-R)+d*d*(r-R)*(r-R))/(H*H))/(H*H+(r-R)*(r-R)))+((H*(r-R)*(d*(R-r)+H*R))/(Math.Sqrt(Math.Pow((H*H+(r-R)*(r-R)),3))))*(Math.Atanh(((-1*d*(r-R)*(r-R)+H*H*d+H*R*(r-R+d*(r-R*R)))/(H*Math.Sqrt(H*H+(r-R)*(r-R)*((1/(H*H))*(d*d*(r-R)*(r-R))-2*d*(r-R)*(H*R+d*(r-R))+H*H*(R*R+d*d)+2*H*R*d*(r-R)+d*d*(r-R)*(r-R)))))))-1*(-1*Math.Pow(H, 2)*Math.Sqrt((d*d*(r-R)*(r-R)-2*d*(r-R)*(H*R+(d+H)*(r-R))+H*H*(R*R-(d+H)*(d*H))+2*H*R*(d+H)*(r-R)+(d+H)*(d+H)*(r-R)*(r-R))/(H*H))/(H*H+(r-R)*(r-R)))+((H*(r-R)*(d*(R-r)+H*R))/(Math.Sqrt(Math.Pow((H*H+(r-R)*(r-R)), 3))))*(Math.Atanh(((-1*d*(r-R)*(r-R)+H*H*(d+H)+H*R*(r-R+(d+H)*(r-R*R)))/(H*Math.Sqrt(H*H+(r-R)*(r-R)*((1/(H*H))*(d*d*(r-R)*(r-R))-2*d*(r-R)*(H*R+(d+H)*(r-R))+H*H*(R*R+(d+H)*(d+H))+2*H*R*(d+H)*(r-R)+(d+H)*(d+H)*(r-R)*(r-R))))))), 2);
                // Calculate the end point of the arrow
                double electricField = Math.Round((((3*Q)/(2*Math.PI*(8.85*Math.Pow(10, -1*12))*Math.Pow(R, 3)))*(H-Math.Log(R+(Math.Sqrt(Math.Pow(d+H, 2)+Math.Pow(R, 2))/(d+H))))), 2);
                int arrowEndX = (int)d;
                textBox6.Text=electricField.ToString();
                // Draw the arrow with magnitude-based length
                DrawArrow(pictureBox1.CreateGraphics(), centerX, centerY, arrowEndX, electricField);
            }
            else if (radioButton3.Checked)
            {
                DrawHemisphere(pictureBox1.CreateGraphics(), 601, 601);
                double Q = Convert.ToDouble(textBox5.Text);
                double R = Convert.ToDouble(textBox1.Text);
                double d = Convert.ToDouble(textBox4.Text);
                double electricField = Math.Round((Q/(6*Math.PI*Math.Pow(10, -1*12)*Math.Pow(R, 2)))*(R-(Math.Sqrt(Math.Pow(d, 2)+Math.Pow(R, 2))*(-1*2*Math.Pow(d, 2)+Math.Pow(R, 2))-(d-R)*(-2*d*d+d*R+R*R))/(3*d*d)), 2);
                // Calculate the end point of the arrow
                int arrowEndX = (int)d;
                textBox6.Text=electricField.ToString();
                // Draw the arrow with magnitude-based length
                DrawArrow(pictureBox1.CreateGraphics(), centerX, centerY, arrowEndX, electricField);
            }
            pictureBox1.CreateGraphics().FillPie(Brushes.HotPink, centerX- dotRadius+(int)x, centerY- dotRadius, 2 * dotRadius, dotRadius*2, 0, 360);
            /*
            Array.Resize(ref dotPositions, dotPositions.Length + 1);
            dotPositions[dotPositions.Length - 1] = new Point(centerX  + (int)x, centerY);*/
        }
        private void DrawArrow(Graphics g, int startX, int startY, int endX, double magnitude)
        {
            Pen arrowPen = new Pen(Color.CornflowerBlue, 2);
            double tamaño = magnitude/500000000;
            int dir;
            if (endX<0)
            {
                dir = -1;
            }
            else
            {
                dir = 1;
            }
            // Draw the arrow body as a line
            g.DrawLine(arrowPen, startX, startY, startX+20*(int)tamaño*dir, startY);

            // Draw the arrowhead
            Point[] coneVertices = new Point[]
            {
                new Point(startX+20*(int)tamaño*dir, startY+5),
                new Point(startX+25*(int)tamaño*dir, startY),
                new Point(startX+20*(int)tamaño*dir, startY-5)
            };
            g.DrawPolygon(arrowPen, coneVertices);
        }
        private void label7_Click(object sender, EventArgs e)
        {
        }
    }
}