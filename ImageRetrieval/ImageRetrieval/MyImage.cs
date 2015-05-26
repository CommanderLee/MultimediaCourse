using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;

namespace ImageRetrieval
{
    // Euclidean(L2), Histogram Intersection(HI), Bhattacharyya(Bh)
    enum DistanceMetrics { L2, HI, Bh };

    class MyImage
    {
        string                  fullFileName, imgName;
        public Image<Bgr, byte> image;
        int                     width, height;
        int[]                   hashValue;

        public MyImage (string fName, string iName, int _width, int _height)
        {
            fullFileName = fName;
            imgName = iName;

            image = new Image<Bgr, byte>(fName);

            if (image.Height == _height && image.Width == _width)
            {
                width = _width;
                height = _height;
            }
            else
            {
                Console.WriteLine("Wrong image parameter");
                width = image.Width;
                height = image.Height;
            }

            //Console.WriteLine("Load Image: " + imgName);
        }

        public void hash(int colorB, int colorG, int colorR)
        {
            int[] colorPartition = new int[3] { colorB, colorG, colorR };
            int colorValue = 256;

            hashValue = new int[colorB + colorG + colorR];
            hashValue.Initialize();
            // currVecPos: is 2:4:2, then currVecPos = 0, 2, 6
            int[] currVecPos = new int[3] { 0, colorB, colorB + colorG };

            // For color B, G, R
            for (var k = 0; k < 3; ++k)
            {
                for (var r = 0; r < height; ++r)
                    for (var c = 0; c < width; ++c)
                    {
                        ++hashValue[currVecPos[k] + (int)(image.Data[r, c, k]) / (colorValue / colorPartition[k])];
                    }
            }

            foreach (int v in hashValue)
                Console.Write(v + " , ");
            Console.WriteLine(". ");
        }

        public double getDistance(int[] hashValue2, DistanceMetrics currMetric)
        {
            if (hashValue.Length != hashValue2.Length)
            {
                Console.WriteLine("Error. Hash Value Vector does not match.");
                return -1;
            }

            double distance = 0.0;
            switch (currMetric)
            {
                case DistanceMetrics.L2:
                    for (var i = 0; i < hashValue.Length; ++i)
                    {
                        distance += Math.Pow(hashValue[i] - hashValue2[i], 2);
                    }
                    distance = Math.Sqrt(distance);
                    break;
                case DistanceMetrics.HI:
                    for (var i = 0; i < hashValue.Length; ++i)
                    {
                        distance += Math.Min(hashValue[i], hashValue2[i]);
                    }
                    // TODO: another version
                    break;
                case DistanceMetrics.Bh:
                    int[] normHashValue = new int[hashValue.Length];
                    int[] normHashValue2 = new int[hashValue2.Length];

                    double sum = 0.0;
                    double sum2 = 0.0;

                    foreach (int v in hashValue)
                    {
                        sum += v;
                    }
                    foreach (int v2 in hashValue2)
                    {
                        sum2 += v2;
                    }

                    for (var i = 0; i < hashValue.Length; ++i)
                    {
                        distance += Math.Sqrt((hashValue[i] / sum) * (hashValue2[i] / sum2));
                    }
                    distance = Math.Sqrt(1 - distance);
                    break;

            }
            return distance;
        }
    }
}
