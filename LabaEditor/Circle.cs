using System;
using System.Collections.Generic;
using System.Drawing;

namespace LabaEditor
{
    public interface IFigure
    {
        void Draw(Bitmap bitmap, bool shift);
        Point GetCenterPoint(int x1, int y1, int x2, int y2);
        void UpdateCoordinates(int startX, int startY, int endX, int endY);
    }

    public class Ellipse : IFigure
    {
        private Pen pen;
        private int startX;
        private int startY;
        private int endX;
        private int endY;

        public Ellipse(Pen pen, int startX, int startY, int endX, int endY)
        {
            this.pen = pen;
            this.startX = startX;
            this.startY = startY;
            this.endX = endX;
            this.endY = endY;
        }

        public void Draw(Bitmap bitmap, bool shift)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.DrawEllipse(pen, startX, startY, endX - startX, endY - startY);
            }
        }

        public Point GetCenterPoint()
        {
            int centerX = (startX + endX) / 2;
            int centerY = (startY + endY) / 2;

            return new Point(centerX, centerY);
        }

        public Point GetCenterPoint(int x1, int y1, int x2, int y2)
        {
            throw new NotImplementedException();
        }

        public void UpdateCoordinates(int startX, int startY, int endX, int endY)
        {
            this.startX = startX;
            this.startY = startY;
            this.endX = endX;
            this.endY = endY;
        }
    }


    public class FillEllipse : IFigure
    {
        private Brush brush;
        private int startX;
        private int startY;
        private int endX;
        private int endY;

        public FillEllipse(Color color, int startX, int startY, int endX, int endY)
        {
            this.startX = startX;
            this.startY = startY;
            this.endX = endX;
            this.endY = endY;
            brush = new SolidBrush(color);
        }

        public void Draw(Bitmap bitmap, bool shift)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.FillEllipse(brush, startX, startY, endX - startX, endY - startY);
            }
        }

        public Point GetCenterPoint()
        {
            int centerX = (startX + endX) / 2;
            int centerY = (startY + endY) / 2;

            return new Point(centerX, centerY);
        }

        public Point GetCenterPoint(int x1, int y1, int x2, int y2)
        {
            throw new NotImplementedException();
        }

        public void UpdateCoordinates(int startX, int startY, int endX, int endY)
        {
            this.startX = startX;
            this.startY = startY;
            this.endX = endX;
            this.endY = endY;
        }
    }

    public class Rectangle : IFigure
    {
        private Pen pen;
        private int startX;
        private int startY;
        private int endX;
        private int endY;

        public Rectangle(Color color, int startX, int startY, int endX, int endY)
        {
            this.startX = startX;
            this.startY = startY;
            this.endX = endX;
            this.endY = endY;
            pen = new Pen(color);
        }

        public void Draw(Bitmap bitmap, bool shift)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.DrawRectangle(pen, startX, startY, endX - startX, endY - startY);
            }
        }

        public Point GetCenterPoint()
        {
            int centerX = (startX + endX) / 2;
            int centerY = (startY + endY) / 2;

            return new Point(centerX, centerY);
        }

        public Point GetCenterPoint(int x1, int y1, int x2, int y2)
        {
            throw new NotImplementedException();
        }

        public void UpdateCoordinates(int startX, int startY, int endX, int endY)
        {
            this.startX = startX;
            this.startY = startY;
            this.endX = endX;
            this.endY = endY;
        }
    }

    public class FillRectangle : IFigure
    {
        private Brush brush;
        private int startX;
        private int startY;
        private int endX;
        private int endY;

        public FillRectangle(Color color, int startX, int startY, int endX, int endY)
        {
            this.startX = startX;
            this.startY = startY;
            this.endX = endX;
            this.endY = endY;
            brush = new SolidBrush(color);
        }

        public void Draw(Bitmap bitmap, bool shift)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.FillRectangle(brush, startX, startY, endX - startX, endY - startY);
            }
        }

        public Point GetCenterPoint()
        {
            int centerX = (startX + endX) / 2;
            int centerY = (startY + endY) / 2;

            return new Point(centerX, centerY);
        }

        public Point GetCenterPoint(int x1, int y1, int x2, int y2)
        {
            throw new NotImplementedException();
        }

        public void UpdateCoordinates(int startX, int startY, int endX, int endY)
        {
            this.startX = startX;
            this.startY = startY;
            this.endX = endX;
            this.endY = endY;
        }
    }

    public class Line : IFigure
    {
        private Pen pen;
        private int startX;
        private int startY;
        private int endX;
        private int endY;

        public Line(Color color, int startX, int startY, int endX, int endY)
        {
            this.startX = startX;
            this.startY = startY;
            this.endX = endX;
            this.endY = endY;
            pen = new Pen(color);
        }

        public void Draw(Bitmap bitmap, bool shift)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.DrawLine(pen, startX, startY, endX, endY);
            }
        }

        public Point GetCenterPoint()
        {
            throw new InvalidOperationException("A line doesn't have a center point.");
        }

        public Point GetCenterPoint(int x1, int y1, int x2, int y2)
        {
            throw new NotImplementedException();
        }

        public void UpdateCoordinates(int startX, int startY, int endX, int endY)
        {
            this.startX = startX;
            this.startY = startY;
            this.endX = endX;
            this.endY = endY;
        }
    }

    public class PenTool : IFigure
    {
        private Pen pen;
        private Point? previousPoint;

        public PenTool(Color color, float width)
        {
            pen = new Pen(color, width);
        }

        public void Draw(Bitmap bitmap, bool shift)
        {
            if (previousPoint != null)
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.DrawLine(pen, previousPoint.Value, new Point((int)Convert.ToInt64(previousPoint.Value.X + pen.Width), (int)Convert.ToInt64(previousPoint.Value.Y + pen.Width)));
                }
            }
        }

        public Point GetCenterPoint()
        {
            return previousPoint ?? Point.Empty;
        }

        public Point GetCenterPoint(int x1, int y1, int x2, int y2)
        {
            throw new NotImplementedException();
        }

        public void UpdateCoordinates(int startX, int startY, int endX, int endY)
        {
            Point currentPoint = new Point(endX, endY);
            previousPoint = currentPoint;
        }
    }

    public class EraseTool : IFigure
    {
        private Pen pen;
        private Point? previousPoint;

        public EraseTool(float width)
        {
            pen = new Pen(Color.White, width);
        }

        public void Draw(Bitmap bitmap, bool shift)
        {
        }

        public Point GetCenterPoint()
        {
            return previousPoint ?? Point.Empty;
        }

        public Point GetCenterPoint(int x1, int y1, int x2, int y2)
        {
            throw new NotImplementedException();
        }

        public void UpdateCoordinates(int startX, int startY, int endX, int endY)
        {
        }
    }
    public class FloodFill : IFigure
    {
        public Bitmap tempBitmap;
        private static void Validate(Bitmap bm, Stack<Point> sp, int x, int y, Color Old_Color, Color New_Color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == Old_Color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, New_Color);
            }
        }

        public static void Fill(Bitmap bm, int x, int y, Color New_Clr)
        {
            Color Old_Color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, New_Clr);
            if (Old_Color == New_Clr) { return; }

            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    Validate(bm, pixel, pt.X - 1, pt.Y, Old_Color, New_Clr);
                    Validate(bm, pixel, pt.X, pt.Y - 1, Old_Color, New_Clr);
                    Validate(bm, pixel, pt.X + 1, pt.Y, Old_Color, New_Clr);
                    Validate(bm, pixel, pt.X, pt.Y + 1, Old_Color, New_Clr);
                }
            }
        }

        public void Draw(Bitmap bitmap, bool shift)
        {
            throw new NotImplementedException();
        }

        public Point GetCenterPoint(int x1, int y1, int x2, int y2)
        {
            throw new NotImplementedException();
        }

        public void UpdateCoordinates(int startX, int startY, int endX, int endY)
        {
            throw new NotImplementedException();
        }
    }
}

