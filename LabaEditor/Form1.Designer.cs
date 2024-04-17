namespace LabaEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.увеличитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoButton = new System.Windows.Forms.Button();
            this.redoButton = new System.Windows.Forms.Button();
            this.toolStripBtnGreen = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnExit = new System.Windows.Forms.ToolStripButton();
            this.сохранитьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.открытьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.создатьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.TurnButton = new System.Windows.Forms.ToolStripButton();
            this.LassoButton = new System.Windows.Forms.ToolStripButton();
            this.CutButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PenTool = new System.Windows.Forms.ToolStripButton();
            this.lineToolButton = new System.Windows.Forms.ToolStripButton();
            this.rectangleToolButton = new System.Windows.Forms.ToolStripButton();
            this.ellipseToolButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Color1 = new System.Windows.Forms.ToolStripButton();
            this.eraserToolButton = new System.Windows.Forms.ToolStripButton();
            this.FillingButton = new System.Windows.Forms.ToolStripButton();
            this.CoursorButton = new System.Windows.Forms.ToolStripButton();
            this.FullScreen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStripBtnGreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(891, 457);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(903, 30);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.увеличитьToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.fileToolStripMenuItem.Text = "Меню";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // увеличитьToolStripMenuItem
            // 
            this.увеличитьToolStripMenuItem.Name = "увеличитьToolStripMenuItem";
            this.увеличитьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.увеличитьToolStripMenuItem.Text = "Увеличить";
            this.увеличитьToolStripMenuItem.Click += new System.EventHandler(this.увеличитьToolStripMenuItem_Click);
            // 
            // undoButton
            // 
            this.undoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.undoButton.Location = new System.Drawing.Point(783, 0);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(56, 30);
            this.undoButton.TabIndex = 11;
            this.undoButton.Text = "↪️";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // redoButton
            // 
            this.redoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redoButton.Location = new System.Drawing.Point(836, 0);
            this.redoButton.Name = "redoButton";
            this.redoButton.Size = new System.Drawing.Size(55, 30);
            this.redoButton.TabIndex = 12;
            this.redoButton.Text = "↩️";
            this.redoButton.UseVisualStyleBackColor = true;
            this.redoButton.Click += new System.EventHandler(this.redoButton_Click);
            // 
            // toolStripBtnGreen
            // 
            this.toolStripBtnGreen.BackColor = System.Drawing.Color.White;
            this.toolStripBtnGreen.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripBtnGreen.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripBtnGreen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnExit,
            this.сохранитьToolStripButton,
            this.открытьToolStripButton,
            this.создатьToolStripButton,
            this.toolStripSeparator4,
            this.TurnButton,
            this.LassoButton,
            this.CutButton,
            this.toolStripSeparator1,
            this.PenTool,
            this.lineToolButton,
            this.rectangleToolButton,
            this.ellipseToolButton,
            this.toolStripSeparator5,
            this.Color1,
            this.eraserToolButton,
            this.FillingButton,
            this.CoursorButton,
            this.FullScreen,
            this.toolStripSeparator7,
            this.toolStripSeparator});
            this.toolStripBtnGreen.Location = new System.Drawing.Point(0, 30);
            this.toolStripBtnGreen.Name = "toolStripBtnGreen";
            this.toolStripBtnGreen.Size = new System.Drawing.Size(903, 31);
            this.toolStripBtnGreen.TabIndex = 13;
            this.toolStripBtnGreen.Text = "toolStrip2";
            // 
            // toolStripBtnExit
            // 
            this.toolStripBtnExit.BackColor = System.Drawing.Color.White;
            this.toolStripBtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnExit.Image")));
            this.toolStripBtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnExit.Name = "toolStripBtnExit";
            this.toolStripBtnExit.Size = new System.Drawing.Size(29, 28);
            this.toolStripBtnExit.Text = "Выход";
            this.toolStripBtnExit.Click += new System.EventHandler(this.toolStripBtnExit_Click);
            // 
            // сохранитьToolStripButton
            // 
            this.сохранитьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.сохранитьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripButton.Image")));
            this.сохранитьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.сохранитьToolStripButton.Name = "сохранитьToolStripButton";
            this.сохранитьToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.сохранитьToolStripButton.Text = "&Сохранить";
            this.сохранитьToolStripButton.Click += new System.EventHandler(this.сохранитьToolStripButton_Click);
            // 
            // открытьToolStripButton
            // 
            this.открытьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.открытьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("открытьToolStripButton.Image")));
            this.открытьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.открытьToolStripButton.Name = "открытьToolStripButton";
            this.открытьToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.открытьToolStripButton.Text = "&Открыть";
            this.открытьToolStripButton.Click += new System.EventHandler(this.открытьToolStripButton_Click);
            // 
            // создатьToolStripButton
            // 
            this.создатьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.создатьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("создатьToolStripButton.Image")));
            this.создатьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.создатьToolStripButton.Name = "создатьToolStripButton";
            this.создатьToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.создатьToolStripButton.Text = "&Создать";
            this.создатьToolStripButton.Click += new System.EventHandler(this.создатьToolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            this.toolStripSeparator4.Visible = false;
            // 
            // TurnButton
            // 
            this.TurnButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TurnButton.Image = ((System.Drawing.Image)(resources.GetObject("TurnButton.Image")));
            this.TurnButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TurnButton.Name = "TurnButton";
            this.TurnButton.Size = new System.Drawing.Size(29, 28);
            this.TurnButton.Text = "Повороты";
            this.TurnButton.Click += new System.EventHandler(this.TurnButton_Click);
            // 
            // LassoButton
            // 
            this.LassoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LassoButton.Image = ((System.Drawing.Image)(resources.GetObject("LassoButton.Image")));
            this.LassoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LassoButton.Name = "LassoButton";
            this.LassoButton.Size = new System.Drawing.Size(29, 28);
            this.LassoButton.Text = "Лассо";
            this.LassoButton.Click += new System.EventHandler(this.LassoButton_Click);
            // 
            // CutButton
            // 
            this.CutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CutButton.Image = ((System.Drawing.Image)(resources.GetObject("CutButton.Image")));
            this.CutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CutButton.Name = "CutButton";
            this.CutButton.Size = new System.Drawing.Size(29, 28);
            this.CutButton.Click += new System.EventHandler(this.CutButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // PenTool
            // 
            this.PenTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PenTool.Image = ((System.Drawing.Image)(resources.GetObject("PenTool.Image")));
            this.PenTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PenTool.Name = "PenTool";
            this.PenTool.Size = new System.Drawing.Size(29, 28);
            this.PenTool.Text = "Круг";
            this.PenTool.Click += new System.EventHandler(this.PenTool_Click);
            // 
            // lineToolButton
            // 
            this.lineToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lineToolButton.Image = ((System.Drawing.Image)(resources.GetObject("lineToolButton.Image")));
            this.lineToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineToolButton.Name = "lineToolButton";
            this.lineToolButton.Size = new System.Drawing.Size(29, 28);
            this.lineToolButton.Text = "Линия";
            this.lineToolButton.Click += new System.EventHandler(this.lineToolButton_Click);
            // 
            // rectangleToolButton
            // 
            this.rectangleToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rectangleToolButton.Image = ((System.Drawing.Image)(resources.GetObject("rectangleToolButton.Image")));
            this.rectangleToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rectangleToolButton.Name = "rectangleToolButton";
            this.rectangleToolButton.Size = new System.Drawing.Size(29, 28);
            this.rectangleToolButton.Text = "Прямоугольник";
            this.rectangleToolButton.Click += new System.EventHandler(this.rectangleToolButton_Click);
            // 
            // ellipseToolButton
            // 
            this.ellipseToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ellipseToolButton.Image = ((System.Drawing.Image)(resources.GetObject("ellipseToolButton.Image")));
            this.ellipseToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ellipseToolButton.Name = "ellipseToolButton";
            this.ellipseToolButton.Size = new System.Drawing.Size(29, 28);
            this.ellipseToolButton.Text = "Круг";
            this.ellipseToolButton.Click += new System.EventHandler(this.ellipseToolButton_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // Color1
            // 
            this.Color1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Color1.Image = ((System.Drawing.Image)(resources.GetObject("Color1.Image")));
            this.Color1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Color1.Name = "Color1";
            this.Color1.Size = new System.Drawing.Size(29, 28);
            this.Color1.Text = "Палитра";
            this.Color1.Click += new System.EventHandler(this.Color1_Click_1);
            // 
            // eraserToolButton
            // 
            this.eraserToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eraserToolButton.Image = ((System.Drawing.Image)(resources.GetObject("eraserToolButton.Image")));
            this.eraserToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eraserToolButton.Name = "eraserToolButton";
            this.eraserToolButton.Size = new System.Drawing.Size(29, 28);
            this.eraserToolButton.Text = "Затирачка";
            this.eraserToolButton.Click += new System.EventHandler(this.eraserToolButton_Click);
            // 
            // FillingButton
            // 
            this.FillingButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FillingButton.Image = ((System.Drawing.Image)(resources.GetObject("FillingButton.Image")));
            this.FillingButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FillingButton.Name = "FillingButton";
            this.FillingButton.Size = new System.Drawing.Size(29, 28);
            this.FillingButton.Text = "Заливка";
            this.FillingButton.Click += new System.EventHandler(this.fillRectangleToolButton_Click);
            // 
            // CoursorButton
            // 
            this.CoursorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CoursorButton.Image = ((System.Drawing.Image)(resources.GetObject("CoursorButton.Image")));
            this.CoursorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CoursorButton.Name = "CoursorButton";
            this.CoursorButton.Size = new System.Drawing.Size(29, 28);
            this.CoursorButton.Text = "Курсор";
            this.CoursorButton.Click += new System.EventHandler(this.CoursorButton_Click);
            // 
            // FullScreen
            // 
            this.FullScreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FullScreen.Image = ((System.Drawing.Image)(resources.GetObject("FullScreen.Image")));
            this.FullScreen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FullScreen.Name = "FullScreen";
            this.FullScreen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FullScreen.Size = new System.Drawing.Size(29, 28);
            this.FullScreen.Text = "Увеличить";
            this.FullScreen.Click += new System.EventHandler(this.FullScreen_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 535);
            this.Controls.Add(this.toolStripBtnGreen);
            this.Controls.Add(this.redoButton);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripBtnGreen.ResumeLayout(false);
            this.toolStripBtnGreen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem увеличитьToolStripMenuItem;
        private System.Windows.Forms.Button redoButton;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.ToolStrip toolStripBtnGreen;
        private System.Windows.Forms.ToolStripButton toolStripBtnExit;
        private System.Windows.Forms.ToolStripButton сохранитьToolStripButton;
        private System.Windows.Forms.ToolStripButton открытьToolStripButton;
        private System.Windows.Forms.ToolStripButton создатьToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton TurnButton;
        private System.Windows.Forms.ToolStripButton LassoButton;
        private System.Windows.Forms.ToolStripButton CutButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton lineToolButton;
        private System.Windows.Forms.ToolStripButton rectangleToolButton;
        private System.Windows.Forms.ToolStripButton PenTool;
        private System.Windows.Forms.ToolStripButton ellipseToolButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton Color1;
        private System.Windows.Forms.ToolStripButton eraserToolButton;
        private System.Windows.Forms.ToolStripButton FillingButton;
        private System.Windows.Forms.ToolStripButton CoursorButton;
        private System.Windows.Forms.ToolStripButton FullScreen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    }
}

