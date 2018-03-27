namespace LabWork1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.canv = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Tools = new System.Windows.Forms.GroupBox();
            this.RegularTriangle = new System.Windows.Forms.Button();
            this.RightTriangle = new System.Windows.Forms.Button();
            this.Triangle = new System.Windows.Forms.Button();
            this.YLable = new System.Windows.Forms.Label();
            this.XLable = new System.Windows.Forms.Label();
            this.choseColor = new System.Windows.Forms.PictureBox();
            this.Back = new System.Windows.Forms.Button();
            this.Line = new System.Windows.Forms.Button();
            this.Rhombus = new System.Windows.Forms.Button();
            this.Circle = new System.Windows.Forms.Button();
            this.Ellipse = new System.Windows.Forms.Button();
            this.Square = new System.Windows.Forms.Button();
            this.Rectangle = new System.Windows.Forms.Button();
            this.ChooseColor = new System.Windows.Forms.ColorDialog();
            this.Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.canv)).BeginInit();
            this.Tools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.choseColor)).BeginInit();
            this.SuspendLayout();
            // 
            // canv
            // 
            this.canv.BackColor = System.Drawing.SystemColors.Window;
            this.canv.Location = new System.Drawing.Point(12, 12);
            this.canv.Name = "canv";
            this.canv.Size = new System.Drawing.Size(1233, 572);
            this.canv.TabIndex = 0;
            this.canv.TabStop = false;
            this.canv.Paint += new System.Windows.Forms.PaintEventHandler(this.canv_Paint);
            this.canv.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canv_MouseDown);
            this.canv.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canv_MouseMove);
            this.canv.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canv_MouseUp);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 599);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 161);
            this.button1.TabIndex = 1;
            this.button1.Text = "Lab1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tools
            // 
            this.Tools.Controls.Add(this.Clear);
            this.Tools.Controls.Add(this.RegularTriangle);
            this.Tools.Controls.Add(this.RightTriangle);
            this.Tools.Controls.Add(this.Triangle);
            this.Tools.Controls.Add(this.YLable);
            this.Tools.Controls.Add(this.XLable);
            this.Tools.Controls.Add(this.choseColor);
            this.Tools.Controls.Add(this.Back);
            this.Tools.Controls.Add(this.Line);
            this.Tools.Controls.Add(this.Rhombus);
            this.Tools.Controls.Add(this.Circle);
            this.Tools.Controls.Add(this.Ellipse);
            this.Tools.Controls.Add(this.Square);
            this.Tools.Controls.Add(this.Rectangle);
            this.Tools.Location = new System.Drawing.Point(274, 599);
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(971, 160);
            this.Tools.TabIndex = 2;
            this.Tools.TabStop = false;
            this.Tools.Text = "Tools";
            // 
            // RegularTriangle
            // 
            this.RegularTriangle.Location = new System.Drawing.Point(515, 29);
            this.RegularTriangle.Name = "RegularTriangle";
            this.RegularTriangle.Size = new System.Drawing.Size(124, 54);
            this.RegularTriangle.TabIndex = 11;
            this.RegularTriangle.Text = "RegularTriangle";
            this.RegularTriangle.UseVisualStyleBackColor = true;
            this.RegularTriangle.Click += new System.EventHandler(this.RegularTriangle_Click);
            // 
            // RightTriangle
            // 
            this.RightTriangle.Location = new System.Drawing.Point(385, 88);
            this.RightTriangle.Name = "RightTriangle";
            this.RightTriangle.Size = new System.Drawing.Size(124, 53);
            this.RightTriangle.TabIndex = 10;
            this.RightTriangle.Text = "RightTriangle";
            this.RightTriangle.UseVisualStyleBackColor = true;
            this.RightTriangle.Click += new System.EventHandler(this.RightTriangle_Click);
            // 
            // Triangle
            // 
            this.Triangle.Location = new System.Drawing.Point(385, 29);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(124, 53);
            this.Triangle.TabIndex = 9;
            this.Triangle.Text = "Triangle";
            this.Triangle.UseVisualStyleBackColor = true;
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // YLable
            // 
            this.YLable.AutoSize = true;
            this.YLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YLable.Location = new System.Drawing.Point(614, 110);
            this.YLable.Name = "YLable";
            this.YLable.Size = new System.Drawing.Size(55, 29);
            this.YLable.TabIndex = 8;
            this.YLable.Text = "Y = ";
            // 
            // XLable
            // 
            this.XLable.AutoSize = true;
            this.XLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XLable.Location = new System.Drawing.Point(516, 110);
            this.XLable.Name = "XLable";
            this.XLable.Size = new System.Drawing.Size(62, 29);
            this.XLable.TabIndex = 7;
            this.XLable.Text = "X =  \r";
            // 
            // choseColor
            // 
            this.choseColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.choseColor.Location = new System.Drawing.Point(645, 29);
            this.choseColor.Name = "choseColor";
            this.choseColor.Size = new System.Drawing.Size(56, 53);
            this.choseColor.TabIndex = 4;
            this.choseColor.TabStop = false;
            this.choseColor.Click += new System.EventHandler(this.choseColor_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(878, 31);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 112);
            this.Back.TabIndex = 6;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Line
            // 
            this.Line.Location = new System.Drawing.Point(261, 29);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(118, 53);
            this.Line.TabIndex = 5;
            this.Line.Text = "Line";
            this.Line.UseVisualStyleBackColor = true;
            this.Line.Click += new System.EventHandler(this.Line_Click);
            // 
            // Rhombus
            // 
            this.Rhombus.Location = new System.Drawing.Point(261, 88);
            this.Rhombus.Name = "Rhombus";
            this.Rhombus.Size = new System.Drawing.Size(118, 53);
            this.Rhombus.TabIndex = 4;
            this.Rhombus.Text = "Rhombus";
            this.Rhombus.UseVisualStyleBackColor = true;
            this.Rhombus.Click += new System.EventHandler(this.Rhombus_Click);
            // 
            // Circle
            // 
            this.Circle.Location = new System.Drawing.Point(137, 88);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(118, 53);
            this.Circle.TabIndex = 3;
            this.Circle.Text = "Circle";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // Ellipse
            // 
            this.Ellipse.Location = new System.Drawing.Point(137, 29);
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(118, 53);
            this.Ellipse.TabIndex = 2;
            this.Ellipse.Text = "Ellipse";
            this.Ellipse.UseVisualStyleBackColor = true;
            this.Ellipse.Click += new System.EventHandler(this.Ellipse_Click);
            // 
            // Square
            // 
            this.Square.Location = new System.Drawing.Point(13, 88);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(118, 53);
            this.Square.TabIndex = 1;
            this.Square.Text = "Square";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.Click += new System.EventHandler(this.Square_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.Location = new System.Drawing.Point(13, 29);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(118, 53);
            this.Rectangle.TabIndex = 0;
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.UseVisualStyleBackColor = true;
            this.Rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(725, 29);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 112);
            this.Clear.TabIndex = 12;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1257, 772);
            this.Controls.Add(this.Tools);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.canv);
            this.Name = "Form1";
            this.Text = "VPaint";
            ((System.ComponentModel.ISupportInitialize)(this.canv)).EndInit();
            this.Tools.ResumeLayout(false);
            this.Tools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.choseColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox canv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox Tools;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Line;
        private System.Windows.Forms.Button Rhombus;
        private System.Windows.Forms.Button Circle;
        private System.Windows.Forms.Button Ellipse;
        private System.Windows.Forms.Button Square;
        private System.Windows.Forms.Button Rectangle;
        private System.Windows.Forms.ColorDialog ChooseColor;
        private System.Windows.Forms.PictureBox choseColor;
        private System.Windows.Forms.Label YLable;
        private System.Windows.Forms.Label XLable;
        private System.Windows.Forms.Button Triangle;
        private System.Windows.Forms.Button RightTriangle;
        private System.Windows.Forms.Button RegularTriangle;
        private System.Windows.Forms.Button Clear;
    }
}

