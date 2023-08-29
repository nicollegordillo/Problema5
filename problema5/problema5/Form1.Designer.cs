namespace problema5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1=new PictureBox();
            radioButton1=new RadioButton();
            radioButton2=new RadioButton();
            radioButton3=new RadioButton();
            textBox1=new TextBox();
            label1=new Label();
            label2=new Label();
            textBox2=new TextBox();
            textBox3=new TextBox();
            label3=new Label();
            textBox4=new TextBox();
            label4=new Label();
            label5=new Label();
            textBox5=new TextBox();
            label6=new Label();
            button1=new Button();
            textBox6=new TextBox();
            label7=new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location=new Point(12, 12);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(649, 439);
            pictureBox1.TabIndex=0;
            pictureBox1.TabStop=false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize=true;
            radioButton1.Location=new Point(836, 27);
            radioButton1.Name="radioButton1";
            radioButton1.Size=new Size(117, 24);
            radioButton1.TabIndex=1;
            radioButton1.TabStop=true;
            radioButton1.Text="Cono circular";
            radioButton1.UseVisualStyleBackColor=true;
            radioButton1.CheckedChanged+=radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize=true;
            radioButton2.Location=new Point(836, 68);
            radioButton2.Name="radioButton2";
            radioButton2.Size=new Size(133, 24);
            radioButton2.TabIndex=2;
            radioButton2.TabStop=true;
            radioButton2.Text="Tronco de cono";
            radioButton2.UseVisualStyleBackColor=true;
            radioButton2.CheckedChanged+=radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize=true;
            radioButton3.Location=new Point(836, 112);
            radioButton3.Name="radioButton3";
            radioButton3.Size=new Size(103, 24);
            radioButton3.TabIndex=3;
            radioButton3.TabStop=true;
            radioButton3.Text="Hemisferio";
            radioButton3.UseVisualStyleBackColor=true;
            radioButton3.CheckedChanged+=radioButton3_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location=new Point(845, 271);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(125, 27);
            textBox1.TabIndex=4;
            textBox1.Visible=false;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(768, 274);
            label1.Name="label1";
            label1.Size=new Size(71, 20);
            label1.TabIndex=5;
            label1.Text="Radio(m)";
            label1.Visible=false;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(767, 320);
            label2.Name="label2";
            label2.Size=new Size(72, 20);
            label2.TabIndex=6;
            label2.Text="Altura(m)";
            label2.Visible=false;
            // 
            // textBox2
            // 
            textBox2.Location=new Point(845, 317);
            textBox2.Name="textBox2";
            textBox2.Size=new Size(125, 27);
            textBox2.TabIndex=7;
            textBox2.Visible=false;
            // 
            // textBox3
            // 
            textBox3.Location=new Point(845, 365);
            textBox3.Name="textBox3";
            textBox3.Size=new Size(125, 27);
            textBox3.TabIndex=9;
            textBox3.Visible=false;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(717, 368);
            label3.Name="label3";
            label3.Size=new Size(122, 20);
            label3.TabIndex=8;
            label3.Text="Radio menor (m)";
            label3.Visible=false;
            // 
            // textBox4
            // 
            textBox4.Location=new Point(845, 220);
            textBox4.Name="textBox4";
            textBox4.Size=new Size(125, 27);
            textBox4.TabIndex=13;
            textBox4.Visible=false;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(817, 220);
            label4.Name="label4";
            label4.Size=new Size(22, 20);
            label4.TabIndex=12;
            label4.Text="P(";
            label4.Visible=false;
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Location=new Point(807, 177);
            label5.Name="label5";
            label5.Size=new Size(39, 20);
            label5.TabIndex=11;
            label5.Text="Q(C)";
            label5.Visible=false;
            // 
            // textBox5
            // 
            textBox5.Location=new Point(845, 174);
            textBox5.Name="textBox5";
            textBox5.Size=new Size(125, 27);
            textBox5.TabIndex=10;
            textBox5.Visible=false;
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.Location=new Point(976, 223);
            label6.Name="label6";
            label6.Size=new Size(46, 20);
            label6.TabIndex=14;
            label6.Text=", 0) m";
            label6.Visible=false;
            // 
            // button1
            // 
            button1.Location=new Point(859, 422);
            button1.Name="button1";
            button1.Size=new Size(94, 29);
            button1.TabIndex=15;
            button1.Text="Calcular";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // textBox6
            // 
            textBox6.Location=new Point(845, 475);
            textBox6.Name="textBox6";
            textBox6.Size=new Size(125, 27);
            textBox6.TabIndex=17;
            textBox6.Visible=false;
            // 
            // label7
            // 
            label7.AutoSize=true;
            label7.Location=new Point(793, 478);
            label7.Name="label7";
            label7.Size=new Size(53, 20);
            label7.TabIndex=16;
            label7.Text="E(N/C)";
            label7.Visible=false;
            label7.Click+=label7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1098, 676);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(pictureBox1);
            Name="Form1";
            Text="Form1";
            Load+=Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private Button button1;
        private TextBox textBox6;
        private Label label7;
    }
}