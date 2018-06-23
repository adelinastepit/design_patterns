using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryImageReader
{
  class Program
  {
    static void Main(string[] args)
    {
      ImageReader image_reader = null;
      DecodeImage decode_image = new DecodeImage();
      String image_filename = "test.gif";
      char[] separator = { '.' };
      string [] tokens = image_filename.Split(separator);
      String ext = tokens[1];
      Console.WriteLine(ext);


      if (ext == "gif")
      {
        image_reader = new GifReader();
      }
      else if (ext == "jpeg")
      {
        image_reader = new JpegReader();
      }

      decode_image.Decode(image_reader);

    }
  }
}
