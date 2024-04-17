using LabaEditor;
using System.Collections.Generic;
using System.Drawing;

namespace LabaEditor
{
    public class Holst
    {
        private List<IFigure> figures;
        private Bitmap bitmap;

        public Holst(Bitmap bitmap)
        {
            figures = new List<IFigure>();
            this.bitmap = bitmap;
        }

        public void setBitmap(Bitmap bitmap)
        {
            this.bitmap = bitmap;
        }

        public Bitmap DrawAll(Bitmap bitmap, bool shift)
        {
            foreach (IFigure figure in figures)
            {
                figure.Draw(bitmap, shift);
            }
            return this.bitmap;
        }

        public void AddFigure(IFigure figure)
        {
            figures.Add(figure);
            figure.Draw(bitmap,false);
        }

        public IFigure DeleteLast()
        {
            if (figures.Count == 0)
            {
                return null;
            }

            int lastIndex = figures.Count - 1;
            IFigure lastFigure = figures[lastIndex];
            figures.RemoveAt(lastIndex);
            return lastFigure;
        }

        public void Clear()
        {
            figures.Clear();
        }
    }
}
