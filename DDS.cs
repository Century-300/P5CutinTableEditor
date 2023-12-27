using System;
using System.IO;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;
using System.Windows;
using System.Windows.Input;
using Microsoft.WindowsAPICodePack;
using Microsoft.WindowsAPICodePack.Core;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Amicitia.IO;
using Pfim;

namespace CutinTableEditor
{
    class DDS
    {

        private static GCHandle handle;
        public string fileName;
        public bool p5;
        public bool p54k;
        public bool p5r;
        public bool p5rpc;

        public DDS(String aFName)   //Constructor takes in file name from the open file dialogue
        {
            fileName = aFName;
        }

        public void setGame(bool ps3, bool nx, bool pc, bool fourK) //Once again, kinda redundant and the p5 bool isn't used for anything yet but TRUST
        {
            p5 = ps3;
            p5r = nx;
            p5rpc = pc;
            p54k = fourK;
        }

        public int DDSWidth()   //Manages width based on game mode to return to the main class
        {
            var frameTex = Pfimage.FromFile(fileName);
            
            if (p5r == true)
            {
                return Convert.ToInt32(frameTex.Width*0.6667);
            }
            else if (p5rpc == true)
            {
                return Convert.ToInt32(frameTex.Width/3);
            }
            else if (p54k == true)
            {
                return Convert.ToInt32(frameTex.Width / 3);
            }
            else
            {
                return frameTex.Width;
            }
        }

        public int DDSHeight()  //Manages height based on game mode to return to the main class
        {
            var frameTex = Pfimage.FromFile(fileName);
            if (p5r == true)
            {
                return Convert.ToInt32(frameTex.Height * 0.6667);
            }
            else if (p5rpc == true)
            {
                return Convert.ToInt32(frameTex.Height / 3);
            }
            else if (p54k == true)
            {
                return Convert.ToInt32(frameTex.Height / 3);
            }
            else
            {
                return frameTex.Height;
            }
        }

        public Bitmap DDSReader()   //Reading method. Returns Bitmap to be displayed in the PictureBox
                                    //This is all copied from the Pfim winforms demo lmaooo
        {
            var frameTex = Pfimage.FromFile(fileName);

            PixelFormat format;
            switch (frameTex.Format)
            {
                case Pfim.ImageFormat.Rgb24:
                    format = PixelFormat.Format24bppRgb;
                    break;

                case Pfim.ImageFormat.Rgba32:
                    format = PixelFormat.Format32bppArgb;
                    break;

                case Pfim.ImageFormat.R5g5b5:
                    format = PixelFormat.Format16bppRgb555;
                    break;

                case Pfim.ImageFormat.R5g6b5:
                    format = PixelFormat.Format16bppRgb565;
                    break;

                case Pfim.ImageFormat.R5g5b5a1:
                    format = PixelFormat.Format16bppArgb1555;
                    break;

                case Pfim.ImageFormat.Rgb8:
                    format = PixelFormat.Format8bppIndexed;
                    break;

                default:
                    format = PixelFormat.Undefined;
                    break;
            }

            if (handle.IsAllocated)
            {
                handle.Free();
            }

            // Pin image data as the picture box can outlive the Pfim Image
            // object, which, unless pinned, will garbage collect the data
            // array causing image corruption.
            handle = GCHandle.Alloc(frameTex.Data, GCHandleType.Pinned);
            var ptr = Marshal.UnsafeAddrOfPinnedArrayElement(frameTex.Data, 0);

            var bitmap = new Bitmap(frameTex.Width, frameTex.Height, frameTex.Stride, format, ptr);

            // While frameworks like WPF and ImageSharp natively understand 8bit gray values.
            // WinForms can only work with an 8bit palette that we construct of gray values.
            if (format == PixelFormat.Format8bppIndexed)
            {
                var palette = bitmap.Palette;
                for (int i = 0; i < 256; i++)
                {
                    palette.Entries[i] = Color.FromArgb((byte)i, (byte)i, (byte)i);
                }
                bitmap.Palette = palette;
            }

            //Before returning the bitmap, we check for the game mode to scale frames properly
            if (p5r == true)
            {
                return new Bitmap(bitmap, new Size(Convert.ToInt32(frameTex.Width * 0.6667), Convert.ToInt32(frameTex.Height * 0.6667)));  //Returns Bitmap with smaller scale :)
            }else if (p5rpc == true)
            {
                return new Bitmap(bitmap, new Size(Convert.ToInt32(frameTex.Width/3), Convert.ToInt32(frameTex.Height/3)));
            }
            else if (p54k == true)
            {
                return new Bitmap(bitmap, new Size(Convert.ToInt32(frameTex.Width / 3), Convert.ToInt32(frameTex.Height / 3)));
            }
            else
            {
                return new Bitmap(bitmap, new Size(frameTex.Width, frameTex.Height));
            }


        }

        //And so pfim has read the dds, unlike me who doesn't know how to read :0)

    }
}
