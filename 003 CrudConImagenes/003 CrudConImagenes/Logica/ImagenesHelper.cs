using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;

namespace _003_CrudConImagenes.Logica
{
    public static class ImagenesHelper
    {
        public static Image obtenerImagenDeBytes(byte[] arr)
        {
            Image img=null;
            using (MemoryStream ms = new MemoryStream(arr))
            {

                img=Image.FromStream(ms);

            }
            return img;
        }

        public static byte[] ObtenerBytesDeImagen(Image img)
        {


            byte[] arr=null;

            Bitmap bit=(Bitmap)img.Clone();
            //Bitmap bit = new Bitmap((Image)img.Clone());

            using(MemoryStream ms = new MemoryStream())
            {
                bit.Save(ms, ImageFormat.Jpeg);
                //img.Save(ms, img.RawFormat);

                arr = ms.GetBuffer();
            }

            return arr;
        }
        public static Image ObtenerImageDeRuta(string ruta)
        {
            if (!File.Exists(ruta))
            {
                throw new ArgumentException("El archivo no existe");
            }

            //Image img = null;

            //byte[] bytesimg=File.ReadAllBytes(ruta);
            //using(MemoryStream ms = new MemoryStream(bytesimg))
            //{
            //    img = Image.FromStream(ms);
            //}


            //return img;

            Image img;
            using(Bitmap bitmap = new Bitmap(ruta))
            {
                MemoryStream ms = new MemoryStream();
                bitmap.Save(ms, bitmap.RawFormat);
                img = Image.FromStream(ms);
                ms.Close();
            }


            return img;

        }
        public static byte[] ObtieneBytesDeRuta(string ruta)
        {
            return File.ReadAllBytes(ruta);
        }
    }
}
