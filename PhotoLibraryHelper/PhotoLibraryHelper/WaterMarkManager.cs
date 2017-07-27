using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing.Drawing2D;
using ImageProcessor;
using ImageProcessor.Imaging;

namespace PhotoLibraryHelper
{
    public class WaterMarkManager
    {
        

        public static bool AddWaterMark(Image inputImage,string markText,out Image outputImage)
        {
            ImageFactory factory = new ImageFactory();
            factory.Load(inputImage);
            TextLayer tl = new TextLayer { Text = "WATERMARK", FontColor = Color.Red };
            MemoryStream outputStream = new MemoryStream();
            factory.Watermark(tl).Save(outputStream);
            outputImage = new Bitmap(outputStream);
            outputImage.Save(@"d:\after.jpg", ImageFormat.Jpeg);
            return true;
           
        }



    }
}
