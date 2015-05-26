using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;

namespace ImageRetrieval
{
    class MyImage
    {
        string                  fullFileName, imgName;
        public Image<Bgr, byte> image;
        int                     width, height;

        public MyImage (string fName, string iName, int _width, int _height)
        {
            fullFileName = fName;
            imgName = iName;

            image = new Image<Bgr, byte>(fName);

            width = _width;
            height = _height;

            //Console.WriteLine("Load Image: " + imgName);
        }

        public void hash(int colorB, int colorG, int colorR)
        {

        }
    }
}
