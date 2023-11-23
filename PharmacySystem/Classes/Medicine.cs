using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacySystem.Classes
{
    public class Medicine
    {
        public int Id;
        public string ScientificName;
        public string BrandName;
        public double Price;
        public double Dose;
        public int NumberInStore;
        public string Type;
        public Point RCPoint;
        
        public void setPoint(int x,int y)
        {
            RCPoint = new Point(x,y);
        }

    }
}
