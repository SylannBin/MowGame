using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace MowGame.Main
{
    /// <summary>
    /// Permet la création d'un Losange (Diamond) à partir de 2 propriétés, la largeur et la hauteur
    /// </summary>
    public class Diamond : Shape
    {
        private double largeur;
        private double hauteur;

        public static readonly DependencyProperty LargeurProperty = DependencyProperty.Register("Largeur", typeof(Double), typeof(Diamond));
        public static readonly DependencyProperty HauteurProperty = DependencyProperty.Register("Hauteur", typeof(Double), typeof(Diamond));

        public Diamond()
        {
        }

        public double Largeur
        {
            get { return (double)this.GetValue(LargeurProperty); }
            set { this.SetValue(LargeurProperty, value); }
        }

        public double Hauteur
        {
            get { return (double)this.GetValue(HauteurProperty); }
            set { this.SetValue(HauteurProperty, value); }
        }

        protected override Geometry DefiningGeometry
        {
            get
            {
                Point p1 = new Point(this.Largeur / 2, 0.0d);
                Point p2 = new Point(this.Largeur, this.Hauteur / 2);
                Point p3 = new Point(this.Largeur / 2, this.Hauteur);
                Point p4 = new Point(0.0d, this.Hauteur / 2);

                List<PathSegment> segments = new List<PathSegment>(3);
                segments.Add(new LineSegment(p1, true));
                segments.Add(new LineSegment(p2, true));
                segments.Add(new LineSegment(p3, true));
                segments.Add(new LineSegment(p4, true));

                List<PathFigure> figures = new List<PathFigure>(1);
                PathFigure pf = new PathFigure(p1, segments, true);
                figures.Add(pf);

                Geometry g = new PathGeometry(figures, FillRule.EvenOdd, null);

                return g;
            }
        }

    }
}
