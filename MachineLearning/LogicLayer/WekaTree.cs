using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLayer;

namespace LogicLayer
{
    public class WekaTree
    {
       
        public LogicLayer.Type stepOne(Features temp)
        {
            if(temp.MaxPercentage > 3.015988)
            {
                return stepTwo(temp);
            }
            else
            {
                return Type.Picture;
            }
        }

        public LogicLayer.Type stepTwo(Features temp)
        {
            if (temp.MaxPercentage > 6.305878)
            {
                return Type.Clipart;
            }
            else
            {
                return stepThree(temp);
            }
        }

       

        public LogicLayer.Type stepThree(Features temp)
        {
            if (temp.DifferentColors > 0.356812)
            {
                return stepFour(temp);
            }
            else
            {
                return Type.Clipart;
            }
        }


        public LogicLayer.Type stepFour(Features temp)
        {
            if (temp.DifferentColors > 0.428223)
            {
                return Type.Clipart;
            }
            else
            {
                return Type.Picture;
            }
        }

    }
}
