using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace LabaEditor
{
    public partial class Form1 : Form
    {
        private Color selectedColor = Color.Black;
        Bitmap picture1;
        private Bitmap drawingBitmap;
        private Bitmap cache;
        private Graphics graphics;
        private IFigure currentFigure;

        bool fillMode = false;

        private Holst holst;
        private string selectedTool;

        private int startX;
        private int startY;

        private int endX;
        private int endY;

        IFigure lastFigure;

        private List<IFigure> deletedFigures = new List<IFigure>();

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            drawingBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(drawingBitmap);
            graphics.Clear(Color.White);

            pictureBox1.Image = drawingBitmap;

            holst = new Holst(drawingBitmap);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && selectedTool == "FloodFill")
            {
                FloodFill.Fill(drawingBitmap, e.X, e.Y, selectedColor);
                holst.setBitmap(drawingBitmap);
                pictureBox1.Image = drawingBitmap;
                pictureBox1.Invalidate();
            }
            else if (e.Button == MouseButtons.Left)
            {
                startX = e.X;
                startY = e.Y;

                switch (selectedTool)
                {
                    case "Ellipse":
                        currentFigure = new Ellipse(new Pen(selectedColor, 1), startX, startY, startX, startY);
                        break;
                    case "FillEllipse":
                        currentFigure = new FillEllipse(selectedColor, startX, startY, startX, startY);
                        break;
                    case "Rectangle":
                        currentFigure = new Rectangle(selectedColor, startX, startY, startX, startY);
                        break;
                    case "FillRectangle":
                        currentFigure = new FillRectangle(selectedColor, startX, startY, startX, startY);
                        break;
                    case "Line":
                        currentFigure = new Line(selectedColor, startX, startY, startX, startY);
                        break;
                    case "PenTool":
                        currentFigure = new PenTool(selectedColor, 2f);
                        break;
                    case "EraseTool":
                        currentFigure = new EraseTool(10f);
                        break;
                    default:
                        currentFigure = null;
                        break;
                }

            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && selectedTool == "PenTool")
            {
                int endX = e.X;
                int endY = e.Y;
                PenTool pen = new PenTool(selectedColor, 2f);
                pen.UpdateCoordinates(startX, startY, endX, endY);

                holst.AddFigure(pen);

                graphics.Clear(Color.White);
                pictureBox1.Image = holst.DrawAll(drawingBitmap, false);
                currentFigure.Draw(drawingBitmap, false);
                pictureBox1.Invalidate();

                startX = endX;
                startY = endY;
            }
            else if (e.Button == MouseButtons.Left && selectedTool == "cute")
            {
                int endX = e.X;
                int endY = e.Y;
                var pen = new Pen(Color.Black);
                float[] val = { 5, 2, 15, 4 };
                var bit = (Bitmap)drawingBitmap.Clone();
                var gr = Graphics.FromImage(bit);

                pen.DashPattern = val; 
                gr.DrawRectangle(pen, startX, startY, endX, endY);

                pictureBox1.Image = bit;
                pictureBox1.Invalidate();
                
            }
            else if (e.Button == MouseButtons.Left && currentFigure != null)
            {
                int endX = e.X;
                int endY = e.Y;

                currentFigure.UpdateCoordinates(startX, startY, endX, endY);
                var bit = (Bitmap)drawingBitmap.Clone();
                var gr = Graphics.FromImage(bit);

                //graphics.Clear(Color.White);
                currentFigure.Draw(bit, false);
                pictureBox1.Image = bit;
                pictureBox1.Invalidate();
            }
        } 

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && currentFigure != null)
            {
                endX = e.X;
                endY = e.Y;

                currentFigure.UpdateCoordinates(startX, startY, endX, endY);

                holst.AddFigure(currentFigure);
                lastFigure = currentFigure;

                currentFigure = null;
                //pictureBox1.Image = holst.DrawAll(drawingBitmap, false);
                pictureBox1.Invalidate();
            }
            if(selectedTool == "cute")
            {
                endX = e.X;
                endY = e.Y;
                cache = Cute(drawingBitmap,startX,startY,endX,endY);
            }
            else if(selectedTool == "cursor")
            {
                startX = e.X; startY = e.Y;
                Paste(cache, startX, startY);
            }
        }

        private void PenTool_Click(object sender, EventArgs e)
        {
            selectedTool = "PenTool";
        }

        private void Color1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (lastFigure != null)
            {
                switch (e.KeyCode)
                {
                    case Keys.W:
                        startY += -1;
                        endY += -1;
                        break;
                    case Keys.S:
                        startY += 1;
                        endY += 1;
                        break;
                    case Keys.A:
                        startX += -1;
                        endX += -1;
                        break;
                    case Keys.D:
                        startX += 1;
                        endX += 1;
                        break;
                    default:
                        break;
                }
                holst.DeleteLast();
                lastFigure.UpdateCoordinates(startX, startY, endX, endY);
                holst.AddFigure(lastFigure);
                graphics.Clear(Color.White);
                holst.DrawAll(drawingBitmap, false);
                pictureBox1.Invalidate();
            }
        }

        private void Color1_Click_1(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Button clickedButton = sender as Button;
                if (clickedButton != null)
                {
                    clickedButton.BackColor = colorDialog.Color;
                }

                selectedColor = colorDialog.Color;
            }
        }

        private void fillEllipseToolButton_Click_1(object sender, EventArgs e)
        {
            selectedTool = "FillEllipse";
            fillMode = false;
        }

        private void rectangleToolButton_Click(object sender, EventArgs e)
        {
            selectedTool = "Rectangle";
        }

        private void ellipseToolButton_Click(object sender, EventArgs e)
        {
            selectedTool = "Ellipse";
        }

        private void fillRectangleToolButton_Click(object sender, EventArgs e)
        {
            selectedTool = "FloodFill";
            fillMode = false;
        }

        private void lineToolButton_Click(object sender, EventArgs e)
        {
            selectedTool = "Line";
        }

        private void eraserToolButton_Click(object sender, EventArgs e)
        {
            selectedColor = Color.White; 
            selectedTool = "PenTool";
        }


        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                picture1 = (Bitmap)Image.FromFile(openFileDialog.FileName);
                pictureBox1.Image = picture1;
            }
        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                picture1.Save(saveFileDialog.FileName);
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                picture1.Save(saveFileDialog.FileName);
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                picture1 = (Bitmap)Image.FromFile(openFileDialog.FileName);
                pictureBox1.Image = picture1;
            }
        }

        private bool isMaximized = false;
        private void увеличитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isMaximized)
            {
                this.WindowState = FormWindowState.Maximized;
                isMaximized = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                isMaximized = false;
            }
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            IFigure curItem = holst.DeleteLast();
            deletedFigures.Add(curItem);
            holst.DrawAll(drawingBitmap, false);
            pictureBox1.Invalidate();
        }

        private void redoButton_Click(object sender, EventArgs e)
        {
            if (deletedFigures.Count > 0)
            {
                holst.AddFigure(deletedFigures[0]);
                deletedFigures.RemoveAt(0);
                holst.DrawAll(drawingBitmap, false);
                pictureBox1.Invalidate();
            }
        }

        
        private void FullScreen_Click(object sender, EventArgs e)
        {
            if (!isMaximized)
            {
                this.WindowState = FormWindowState.Maximized;
                isMaximized = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                isMaximized = false;
            }
        }

        private void создатьToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Хотите сохранить текущий рисунок?", "Внимание", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.ShowDialog();
                    if (saveFileDialog.FileName != "")
                    {
                        picture1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                        picture1.Save(saveFileDialog.FileName);
                    }
                    break;
                case DialogResult.No:
                    picture1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    pictureBox1.Image = picture1;
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        private void открытьToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                picture1 = (Bitmap)Image.FromFile(openFileDialog.FileName);
                drawingBitmap = picture1;
                pictureBox1.Image = picture1;
            }
        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                drawingBitmap.Save(saveFileDialog.FileName);
            }
        }

        private void TurnButton_Click(object sender, EventArgs e)
        {
            Bitmap rotatedImg = (Bitmap)pictureBox1.Image.Clone();
            rotatedImg.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = rotatedImg;
            pictureBox1.Invalidate();
        }

        public void Paste(Bitmap bit, int x, int y)
        {
            int p1 = 0;
            int xEnd = 0;
            if (x + cache.Width <= drawingBitmap.Width) xEnd = x + cache.Width;
            else xEnd = drawingBitmap.Width;
            int yEnd = 0;
            if (y + cache.Height <= drawingBitmap.Height) yEnd = y + cache.Height;
            else yEnd = drawingBitmap.Height;
            for (int i = x; i < xEnd; i++)
            {
                int p2 = 0;
                for (int j = y; j < yEnd; j++)
                {
                    drawingBitmap.SetPixel(i, j, cache.GetPixel(p1, p2));
                    p2++;
                }
                p1++;
            }
            pictureBox1.Image = drawingBitmap;
            pictureBox1.Invalidate();
        }

        public Bitmap Cute(Bitmap bit, int startX, int startY, int endX, int endY)
        {
            int w = endX - startX + 1; 
            int h = endY - startY + 1; 
            int x = 0;
            Bitmap cache = new Bitmap(w, h);
            for (int i = startX; i <= endX; i++)
            {
                int y = 0;
                for (int j = startY; j <= endY; j++)
                {
                    cache.SetPixel(x, y, bit.GetPixel(i, j));
                    bit.SetPixel(i, j, Color.White);
                    y++;
                }
                x++;
            }
            pictureBox1.Image = bit;
            pictureBox1.Invalidate();
            return cache;
        }


        private void CutButton_Click(object sender, EventArgs e)
        {
            selectedTool = "cute";
        }

        private void LassoButton_Click(object sender, EventArgs e)
        {

        }

        private void CoursorButton_Click(object sender, EventArgs e)
        {
            selectedTool = "cursor";
        }

        private void toolStripBtnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Хотите сохранить текущий рисунок?", "Внимание", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.ShowDialog();
                    if (saveFileDialog.FileName != "")
                    {
                        picture1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                        picture1.Save(saveFileDialog.FileName);
                    }
                    break;
                case DialogResult.No:
                    picture1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    pictureBox1.Image = picture1;
                    break;
                case DialogResult.Cancel:
                    break;
            }
            Application.Exit();
        }
    }
}
