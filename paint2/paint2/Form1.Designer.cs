namespace paint2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.main_panel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.colorDialog = new System.Windows.Forms.Button();
            this.button_color7 = new System.Windows.Forms.Button();
            this.button_color16 = new System.Windows.Forms.Button();
            this.button_color8 = new System.Windows.Forms.Button();
            this.button_color15 = new System.Windows.Forms.Button();
            this.button_color5 = new System.Windows.Forms.Button();
            this.button_color14 = new System.Windows.Forms.Button();
            this.button_color6 = new System.Windows.Forms.Button();
            this.button_color13 = new System.Windows.Forms.Button();
            this.button_color3 = new System.Windows.Forms.Button();
            this.button_color12 = new System.Windows.Forms.Button();
            this.button_color4 = new System.Windows.Forms.Button();
            this.button_color11 = new System.Windows.Forms.Button();
            this.button_color1 = new System.Windows.Forms.Button();
            this.button_color10 = new System.Windows.Forms.Button();
            this.button_color2 = new System.Windows.Forms.Button();
            this.button_color9 = new System.Windows.Forms.Button();
            this.current_color = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.line = new System.Windows.Forms.Button();
            this.triangle = new System.Windows.Forms.Button();
            this.rectangle = new System.Windows.Forms.Button();
            this.circle = new System.Windows.Forms.Button();
            this.button_tool_palette = new System.Windows.Forms.Button();
            this.button_tool_erase = new System.Windows.Forms.Button();
            this.button_tool_fill = new System.Windows.Forms.Button();
            this.button_tool_pencil = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.main_panel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 151);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1461, 492);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picturebox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picturebox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picturebox1_MouseUp);
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.button_tool_palette);
            this.main_panel.Controls.Add(this.panel3);
            this.main_panel.Controls.Add(this.comboBox1);
            this.main_panel.Controls.Add(this.button_tool_erase);
            this.main_panel.Controls.Add(this.panel2);
            this.main_panel.Controls.Add(this.button_tool_pencil);
            this.main_panel.Controls.Add(this.button_tool_fill);
            this.main_panel.Location = new System.Drawing.Point(0, 33);
            this.main_panel.Margin = new System.Windows.Forms.Padding(4);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1461, 116);
            this.main_panel.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.colorDialog);
            this.panel3.Controls.Add(this.button_color7);
            this.panel3.Controls.Add(this.button_color16);
            this.panel3.Controls.Add(this.button_color8);
            this.panel3.Controls.Add(this.button_color15);
            this.panel3.Controls.Add(this.button_color5);
            this.panel3.Controls.Add(this.button_color14);
            this.panel3.Controls.Add(this.button_color6);
            this.panel3.Controls.Add(this.button_color13);
            this.panel3.Controls.Add(this.button_color3);
            this.panel3.Controls.Add(this.button_color12);
            this.panel3.Controls.Add(this.button_color4);
            this.panel3.Controls.Add(this.button_color11);
            this.panel3.Controls.Add(this.button_color1);
            this.panel3.Controls.Add(this.button_color10);
            this.panel3.Controls.Add(this.button_color2);
            this.panel3.Controls.Add(this.button_color9);
            this.panel3.Controls.Add(this.current_color);
            this.panel3.Location = new System.Drawing.Point(431, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(504, 103);
            this.panel3.TabIndex = 3;
            // 
            // colorDialog
            // 
            this.colorDialog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.colorDialog.FlatAppearance.BorderSize = 0;
            this.colorDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorDialog.Location = new System.Drawing.Point(377, 10);
            this.colorDialog.Margin = new System.Windows.Forms.Padding(4);
            this.colorDialog.Name = "colorDialog";
            this.colorDialog.Size = new System.Drawing.Size(68, 69);
            this.colorDialog.TabIndex = 33;
            this.colorDialog.Text = "ChooseColor";
            this.colorDialog.UseVisualStyleBackColor = true;
            this.colorDialog.Click += new System.EventHandler(this.colorDialog_Click);
            // 
            // button_color7
            // 
            this.button_color7.BackColor = System.Drawing.Color.Green;
            this.button_color7.FlatAppearance.BorderSize = 0;
            this.button_color7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color7.Location = new System.Drawing.Point(292, 10);
            this.button_color7.Margin = new System.Windows.Forms.Padding(4);
            this.button_color7.Name = "button_color7";
            this.button_color7.Size = new System.Drawing.Size(25, 31);
            this.button_color7.TabIndex = 29;
            this.button_color7.UseVisualStyleBackColor = false;
            this.button_color7.Click += new System.EventHandler(this.color_button_Click);
            // 
            // button_color16
            // 
            this.button_color16.BackColor = System.Drawing.Color.Lime;
            this.button_color16.FlatAppearance.BorderSize = 0;
            this.button_color16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color16.Location = new System.Drawing.Point(320, 42);
            this.button_color16.Margin = new System.Windows.Forms.Padding(4);
            this.button_color16.Name = "button_color16";
            this.button_color16.Size = new System.Drawing.Size(25, 31);
            this.button_color16.TabIndex = 32;
            this.button_color16.UseVisualStyleBackColor = false;
            this.button_color16.Click += new System.EventHandler(this.color_button_Click);
            // 
            // button_color8
            // 
            this.button_color8.BackColor = System.Drawing.Color.Blue;
            this.button_color8.FlatAppearance.BorderSize = 0;
            this.button_color8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color8.Location = new System.Drawing.Point(320, 10);
            this.button_color8.Margin = new System.Windows.Forms.Padding(4);
            this.button_color8.Name = "button_color8";
            this.button_color8.Size = new System.Drawing.Size(25, 31);
            this.button_color8.TabIndex = 30;
            this.button_color8.UseVisualStyleBackColor = false;
            this.button_color8.Click += new System.EventHandler(this.color_button_Click);
            // 
            // button_color15
            // 
            this.button_color15.BackColor = System.Drawing.Color.LightGreen;
            this.button_color15.FlatAppearance.BorderSize = 0;
            this.button_color15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color15.Location = new System.Drawing.Point(292, 42);
            this.button_color15.Margin = new System.Windows.Forms.Padding(4);
            this.button_color15.Name = "button_color15";
            this.button_color15.Size = new System.Drawing.Size(25, 31);
            this.button_color15.TabIndex = 31;
            this.button_color15.UseVisualStyleBackColor = false;
            this.button_color15.Click += new System.EventHandler(this.color_button_Click);
            // 
            // button_color5
            // 
            this.button_color5.BackColor = System.Drawing.Color.Orange;
            this.button_color5.FlatAppearance.BorderSize = 0;
            this.button_color5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color5.Location = new System.Drawing.Point(235, 10);
            this.button_color5.Margin = new System.Windows.Forms.Padding(4);
            this.button_color5.Name = "button_color5";
            this.button_color5.Size = new System.Drawing.Size(25, 31);
            this.button_color5.TabIndex = 25;
            this.button_color5.UseVisualStyleBackColor = false;
            this.button_color5.Click += new System.EventHandler(this.color_button_Click);
            // 
            // button_color14
            // 
            this.button_color14.BackColor = System.Drawing.Color.Pink;
            this.button_color14.FlatAppearance.BorderSize = 0;
            this.button_color14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color14.Location = new System.Drawing.Point(263, 42);
            this.button_color14.Margin = new System.Windows.Forms.Padding(4);
            this.button_color14.Name = "button_color14";
            this.button_color14.Size = new System.Drawing.Size(25, 31);
            this.button_color14.TabIndex = 28;
            this.button_color14.UseVisualStyleBackColor = false;
            this.button_color14.Click += new System.EventHandler(this.color_button_Click);
            // 
            // button_color6
            // 
            this.button_color6.BackColor = System.Drawing.Color.Yellow;
            this.button_color6.FlatAppearance.BorderSize = 0;
            this.button_color6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color6.Location = new System.Drawing.Point(263, 10);
            this.button_color6.Margin = new System.Windows.Forms.Padding(4);
            this.button_color6.Name = "button_color6";
            this.button_color6.Size = new System.Drawing.Size(25, 31);
            this.button_color6.TabIndex = 26;
            this.button_color6.UseVisualStyleBackColor = false;
            this.button_color6.Click += new System.EventHandler(this.color_button_Click);
            // 
            // button_color13
            // 
            this.button_color13.BackColor = System.Drawing.Color.Purple;
            this.button_color13.FlatAppearance.BorderSize = 0;
            this.button_color13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color13.Location = new System.Drawing.Point(235, 42);
            this.button_color13.Margin = new System.Windows.Forms.Padding(4);
            this.button_color13.Name = "button_color13";
            this.button_color13.Size = new System.Drawing.Size(25, 31);
            this.button_color13.TabIndex = 27;
            this.button_color13.UseVisualStyleBackColor = false;
            this.button_color13.Click += new System.EventHandler(this.color_button_Click);
            // 
            // button_color3
            // 
            this.button_color3.BackColor = System.Drawing.Color.DarkRed;
            this.button_color3.FlatAppearance.BorderSize = 0;
            this.button_color3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color3.Location = new System.Drawing.Point(179, 10);
            this.button_color3.Margin = new System.Windows.Forms.Padding(4);
            this.button_color3.Name = "button_color3";
            this.button_color3.Size = new System.Drawing.Size(25, 31);
            this.button_color3.TabIndex = 21;
            this.button_color3.UseVisualStyleBackColor = false;
            this.button_color3.Click += new System.EventHandler(this.color_button_Click);
            // 
            // button_color12
            // 
            this.button_color12.BackColor = System.Drawing.Color.LightGray;
            this.button_color12.FlatAppearance.BorderSize = 0;
            this.button_color12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color12.Location = new System.Drawing.Point(207, 42);
            this.button_color12.Margin = new System.Windows.Forms.Padding(4);
            this.button_color12.Name = "button_color12";
            this.button_color12.Size = new System.Drawing.Size(25, 31);
            this.button_color12.TabIndex = 24;
            this.button_color12.UseVisualStyleBackColor = false;
            this.button_color12.Click += new System.EventHandler(this.color_button_Click);
            // 
            // button_color4
            // 
            this.button_color4.BackColor = System.Drawing.Color.Red;
            this.button_color4.FlatAppearance.BorderSize = 0;
            this.button_color4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color4.Location = new System.Drawing.Point(207, 10);
            this.button_color4.Margin = new System.Windows.Forms.Padding(4);
            this.button_color4.Name = "button_color4";
            this.button_color4.Size = new System.Drawing.Size(25, 31);
            this.button_color4.TabIndex = 22;
            this.button_color4.UseVisualStyleBackColor = false;
            this.button_color4.Click += new System.EventHandler(this.color_button_Click);
            // 
            // button_color11
            // 
            this.button_color11.BackColor = System.Drawing.Color.White;
            this.button_color11.FlatAppearance.BorderSize = 0;
            this.button_color11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color11.Location = new System.Drawing.Point(179, 42);
            this.button_color11.Margin = new System.Windows.Forms.Padding(4);
            this.button_color11.Name = "button_color11";
            this.button_color11.Size = new System.Drawing.Size(25, 31);
            this.button_color11.TabIndex = 23;
            this.button_color11.UseVisualStyleBackColor = false;
            this.button_color11.Click += new System.EventHandler(this.color_button_Click);
            // 
            // button_color1
            // 
            this.button_color1.BackColor = System.Drawing.Color.Black;
            this.button_color1.FlatAppearance.BorderSize = 0;
            this.button_color1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color1.Location = new System.Drawing.Point(121, 10);
            this.button_color1.Margin = new System.Windows.Forms.Padding(4);
            this.button_color1.Name = "button_color1";
            this.button_color1.Size = new System.Drawing.Size(25, 31);
            this.button_color1.TabIndex = 16;
            this.button_color1.UseVisualStyleBackColor = false;
            this.button_color1.Click += new System.EventHandler(this.color_button_Click);
            // 
            // button_color10
            // 
            this.button_color10.BackColor = System.Drawing.Color.Violet;
            this.button_color10.FlatAppearance.BorderSize = 0;
            this.button_color10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color10.Location = new System.Drawing.Point(149, 42);
            this.button_color10.Margin = new System.Windows.Forms.Padding(4);
            this.button_color10.Name = "button_color10";
            this.button_color10.Size = new System.Drawing.Size(25, 31);
            this.button_color10.TabIndex = 20;
            this.button_color10.UseVisualStyleBackColor = false;
            this.button_color10.Click += new System.EventHandler(this.color_button_Click);
            // 
            // button_color2
            // 
            this.button_color2.BackColor = System.Drawing.Color.SlateGray;
            this.button_color2.FlatAppearance.BorderSize = 0;
            this.button_color2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color2.Location = new System.Drawing.Point(149, 10);
            this.button_color2.Margin = new System.Windows.Forms.Padding(4);
            this.button_color2.Name = "button_color2";
            this.button_color2.Size = new System.Drawing.Size(25, 31);
            this.button_color2.TabIndex = 17;
            this.button_color2.UseVisualStyleBackColor = false;
            this.button_color2.Click += new System.EventHandler(this.color_button_Click);
            // 
            // button_color9
            // 
            this.button_color9.BackColor = System.Drawing.Color.DarkBlue;
            this.button_color9.FlatAppearance.BorderSize = 0;
            this.button_color9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color9.Location = new System.Drawing.Point(121, 42);
            this.button_color9.Margin = new System.Windows.Forms.Padding(4);
            this.button_color9.Name = "button_color9";
            this.button_color9.Size = new System.Drawing.Size(25, 31);
            this.button_color9.TabIndex = 19;
            this.button_color9.UseVisualStyleBackColor = false;
            this.button_color9.Click += new System.EventHandler(this.color_button_Click);
            // 
            // current_color
            // 
            this.current_color.Location = new System.Drawing.Point(16, 9);
            this.current_color.Margin = new System.Windows.Forms.Padding(4);
            this.current_color.Name = "current_color";
            this.current_color.Size = new System.Drawing.Size(59, 69);
            this.current_color.TabIndex = 3;
            this.current_color.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8",
            "10",
            "12"});
            this.comboBox1.Location = new System.Drawing.Point(292, 7);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Thickness";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.line);
            this.panel2.Controls.Add(this.triangle);
            this.panel2.Controls.Add(this.rectangle);
            this.panel2.Controls.Add(this.circle);
            this.panel2.Location = new System.Drawing.Point(13, 7);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 82);
            this.panel2.TabIndex = 3;
            // 
            // line
            // 
            this.line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.line.FlatAppearance.BorderSize = 0;
            this.line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.line.Location = new System.Drawing.Point(16, 7);
            this.line.Margin = new System.Windows.Forms.Padding(4);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(54, 31);
            this.line.TabIndex = 9;
            this.line.Text = "Line";
            this.line.UseVisualStyleBackColor = true;
            this.line.Click += new System.EventHandler(this.tools_Clicked);
            // 
            // triangle
            // 
            this.triangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.triangle.FlatAppearance.BorderSize = 0;
            this.triangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.triangle.Location = new System.Drawing.Point(89, 47);
            this.triangle.Margin = new System.Windows.Forms.Padding(4);
            this.triangle.Name = "triangle";
            this.triangle.Size = new System.Drawing.Size(76, 31);
            this.triangle.TabIndex = 13;
            this.triangle.Text = "Triangle";
            this.triangle.UseVisualStyleBackColor = true;
            this.triangle.Click += new System.EventHandler(this.tools_Clicked);
            // 
            // rectangle
            // 
            this.rectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rectangle.FlatAppearance.BorderSize = 0;
            this.rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectangle.Location = new System.Drawing.Point(163, 8);
            this.rectangle.Margin = new System.Windows.Forms.Padding(4);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(95, 31);
            this.rectangle.TabIndex = 12;
            this.rectangle.Text = "Rectangle";
            this.rectangle.UseVisualStyleBackColor = true;
            this.rectangle.Click += new System.EventHandler(this.tools_Clicked);
            // 
            // circle
            // 
            this.circle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.circle.FlatAppearance.BorderSize = 0;
            this.circle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circle.Location = new System.Drawing.Point(78, 8);
            this.circle.Margin = new System.Windows.Forms.Padding(4);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(77, 31);
            this.circle.TabIndex = 11;
            this.circle.Text = "Ellipse";
            this.circle.UseVisualStyleBackColor = true;
            this.circle.Click += new System.EventHandler(this.tools_Clicked);
            // 
            // button_tool_palette
            // 
            this.button_tool_palette.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_tool_palette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_tool_palette.FlatAppearance.BorderSize = 0;
            this.button_tool_palette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tool_palette.Location = new System.Drawing.Point(348, 76);
            this.button_tool_palette.Margin = new System.Windows.Forms.Padding(4);
            this.button_tool_palette.Name = "button_tool_palette";
            this.button_tool_palette.Size = new System.Drawing.Size(75, 31);
            this.button_tool_palette.TabIndex = 7;
            this.button_tool_palette.Text = "Palette";
            this.button_tool_palette.UseVisualStyleBackColor = false;
            this.button_tool_palette.Click += new System.EventHandler(this.tools_Clicked);
            // 
            // button_tool_erase
            // 
            this.button_tool_erase.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_tool_erase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_tool_erase.FlatAppearance.BorderSize = 0;
            this.button_tool_erase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tool_erase.Location = new System.Drawing.Point(348, 39);
            this.button_tool_erase.Margin = new System.Windows.Forms.Padding(4);
            this.button_tool_erase.Name = "button_tool_erase";
            this.button_tool_erase.Size = new System.Drawing.Size(75, 31);
            this.button_tool_erase.TabIndex = 6;
            this.button_tool_erase.Text = "Eraser";
            this.button_tool_erase.UseVisualStyleBackColor = false;
            this.button_tool_erase.Click += new System.EventHandler(this.tools_Clicked);
            // 
            // button_tool_fill
            // 
            this.button_tool_fill.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_tool_fill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_tool_fill.FlatAppearance.BorderSize = 0;
            this.button_tool_fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tool_fill.Location = new System.Drawing.Point(292, 76);
            this.button_tool_fill.Margin = new System.Windows.Forms.Padding(4);
            this.button_tool_fill.Name = "button_tool_fill";
            this.button_tool_fill.Size = new System.Drawing.Size(48, 31);
            this.button_tool_fill.TabIndex = 4;
            this.button_tool_fill.Text = "Fill";
            this.button_tool_fill.UseVisualStyleBackColor = false;
            this.button_tool_fill.Click += new System.EventHandler(this.tools_Clicked);
            // 
            // button_tool_pencil
            // 
            this.button_tool_pencil.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_tool_pencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_tool_pencil.FlatAppearance.BorderSize = 0;
            this.button_tool_pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tool_pencil.Location = new System.Drawing.Point(292, 39);
            this.button_tool_pencil.Margin = new System.Windows.Forms.Padding(4);
            this.button_tool_pencil.Name = "button_tool_pencil";
            this.button_tool_pencil.Size = new System.Drawing.Size(48, 31);
            this.button_tool_pencil.TabIndex = 3;
            this.button_tool_pencil.Text = "Pen";
            this.button_tool_pencil.UseVisualStyleBackColor = false;
            this.button_tool_pencil.Click += new System.EventHandler(this.tools_Clicked);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1456, 28);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem5});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 24);
            this.toolStripMenuItem1.Text = "File";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(142, 26);
            this.toolStripMenuItem3.Text = "Open";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(142, 26);
            this.toolStripMenuItem5.Text = "Save as...";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 644);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.main_panel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button line;
        private System.Windows.Forms.Button triangle;
        private System.Windows.Forms.Button rectangle;
        private System.Windows.Forms.Button circle;
        private System.Windows.Forms.Button button_tool_pencil;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button colorDialog;
        private System.Windows.Forms.Button button_color7;
        private System.Windows.Forms.Button button_color16;
        private System.Windows.Forms.Button button_color8;
        private System.Windows.Forms.Button button_color15;
        private System.Windows.Forms.Button button_color5;
        private System.Windows.Forms.Button button_color14;
        private System.Windows.Forms.Button button_color6;
        private System.Windows.Forms.Button button_color13;
        private System.Windows.Forms.Button button_color3;
        private System.Windows.Forms.Button button_color12;
        private System.Windows.Forms.Button button_color4;
        private System.Windows.Forms.Button button_color11;
        private System.Windows.Forms.Button button_color1;
        private System.Windows.Forms.Button button_color10;
        private System.Windows.Forms.Button button_color2;
        private System.Windows.Forms.Button button_color9;
        private System.Windows.Forms.Button current_color;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button_tool_palette;
        private System.Windows.Forms.Button button_tool_erase;
        private System.Windows.Forms.Button button_tool_fill;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

