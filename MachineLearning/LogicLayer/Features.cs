using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class Features
    {
        public Bitmap Img;
        public double DifferentColors { get; set; }
        public double MaxPercentage { get; set; }
        public Boolean Transparency { get; set; }

        public event Action<int> PartProcessed;

        public Type T;

        public Features(Bitmap img, Type t)
        {
            this.Img = new Bitmap(img);
            this.T = t;
            Analyze();
        }

        public Features()
        {
        }

        public void Analyze()
        {
            Dictionary<Color, int> colors = new Dictionary<Color, int>();
            for (int x = 0; x < Img.Width; x++)
            {
                for (int y = 0; y < Img.Height; y++)
                {
                    Color p = Img.GetPixel(x, y);
                    if (!colors.ContainsKey(p))
                    {
                        colors.Add(p, 1);
                    }
                    else
                    {
                        colors[p]++;
                    }

                    if (p.A < 255)
                    {
                        Transparency = true;
                    }
                }
                if (PartProcessed != null)
                {
                    int prog = (int)(((x + 1.0) / Img.Width) * 100.0);
                    PartProcessed(prog);
                }

            }
            if (PartProcessed != null)
            {
                PartProcessed(100);
                PartProcessed(0);
            }
            

            int tot = 0;
            int max = 0;

            foreach (var pair in colors)
            {
                if (pair.Value > max) max = pair.Value;
                tot += pair.Value;
            }


            MaxPercentage = ((max + 0.0) / tot) * 100.0;
            DifferentColors = ((colors.Count * 1.0) / (Img.Width * Img.Height)) * 100.0;
        }
    }
}
