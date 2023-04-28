/*
* This file is part of PngtoFsh, a tool for converting images to FSH.
*
* Copyright (C) 2009, 2023 Nicholas Hayes
*
* This program is free software: you can redistribute it and/or modify
* it under the terms of the GNU General Public License as published by
* the Free Software Foundation, either version 3 of the License, or
* (at your option) any later version.
*
* This program is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU General Public License for more details.
*
* You should have received a copy of the GNU General Public License
* along with this program.  If not, see <http://www.gnu.org/licenses/>.
*
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using FSHLib;

namespace PngtoFsh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newcompfsh_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void newfshbtn_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        
        private void newfshbtn_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string fshname = null;
            string bitmapfn = null;
            string alphafn = null;
            bool imageloaded = false;

            FSHImage curimage  = new FSHImage();
            BitmapItem bmpitem = new BitmapItem();

            foreach (string file in files)
            {
                FileInfo fi = new FileInfo(file);
                if (fi.Exists)
                {
                    if (fi.Extension.Equals(".png") || fi.Extension.Equals(".bmp"))
                    {
                        string dirpath = Path.GetDirectoryName(fi.FullName);
                        string filename = Path.GetFileNameWithoutExtension(fi.FullName);
                        bitmapfn = fi.FullName;
                        string alphapath = Path.Combine(dirpath + "\\", filename + "_a" + Path.GetExtension(fi.FullName));
                        fshname = Path.Combine(dirpath + "\\", filename + ".fsh");
                        bmpfnlbl.Text = Path.GetFileName(fi.FullName);
                        if (File.Exists(alphapath))
                        {
                            alphafn = alphapath;
                        }
                        else
                        {
                            alphafn = null;
                        }
                        imageloaded = true;
                   }
                   else
                   {
                      MessageBox.Show(this, "Files must be only png or bmp", "Png to Fsh");
                      bmptype.Text = null;
                   }
                }
            }
            Bitmap bmp = null;
            if (imageloaded == true)
            {
                if (File.Exists(bitmapfn))
                {
                    bmp = new Bitmap(bitmapfn);
                    bmpitem.Bitmap = bmp;
                }
                if (File.Exists(alphafn))
                {
                    // alphafn = alphapath;
                    alphafnlbl.Text = Path.GetFileName(alphafn);
                    bmpitem.Alpha = new Bitmap(alphafn);
                    bmpitem.BmpType = FSHBmpType.DXT3;
                    bmptype.Text = bmpitem.BmpType.ToString();
                }
                else
                {
                    if (bmp != null)
                    {
                        Bitmap genalpha = new Bitmap(bmp.Width, bmp.Height);
                        for (int i = 0; i < genalpha.Height; i++)
                        {
                            for (int j = 0; j < genalpha.Width; j++)
                            {
                                genalpha.SetPixel(j, i, Color.White);
                            }
                        }
                        alphafnlbl.Text = "Generated Alpha";
                        bmpitem.Alpha = genalpha;
                    }
                    bmpitem.BmpType = FSHBmpType.DXT1;
                    bmptype.Text = bmpitem.BmpType.ToString();
                }
                curimage.Bitmaps.Add(bmpitem);
                curimage.UpdateDirty();
                if (File.Exists(fshname))
                {
                    if (MessageBox.Show(this, "This file already exists. Do you want to overwrite it?", "Overwrite file?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        FileStream fs = new FileStream(fshname, FileMode.Open, FileAccess.Write);
                        curimage.Save(fs);
                        fs.Close();
                    }
                }
                else
                {
                    FileStream fs = new FileStream(fshname, FileMode.Create, FileAccess.Write);
                    curimage.Save(fs);
                    fs.Close();
                }
            }
        }
        
        private void newcompfshbtn_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string fshname = null;
            string bitmapfn = null;
            string alphafn = null;
            bool imageloaded = false;
            FSHImage curimage = new FSHImage();
            BitmapItem bmpitem = new BitmapItem();

            foreach (string file in files)
            {
                FileInfo fi = new FileInfo(file);
                if (fi.Exists)
                {
                    if (fi.Extension.Equals(".png") || fi.Extension.Equals(".bmp"))
                    {
                        string dirpath = Path.GetDirectoryName(fi.FullName);
                        string filename = Path.GetFileNameWithoutExtension(fi.FullName);
                        bitmapfn = fi.FullName;
                        string alphapath = Path.Combine(dirpath + "\\", filename + "_a" + Path.GetExtension(fi.FullName));
                        fshname = Path.Combine(dirpath + "\\", filename + ".qfs");
                        bmpfnlbl.Text = Path.GetFileName(fi.FullName);
                        if (File.Exists(alphapath))
                        {
                            alphafn = alphapath;
                        }
                        else
                        {
                            alphafn = null;
                        }
                        imageloaded = true;
                    }
                    else 
                    {
                        MessageBox.Show(this, "Files must be only png or bmp", "Png to Fsh");
                    }
                }
            }
            Bitmap bmp = null;
            if (imageloaded == true)
            {
                if (File.Exists(bitmapfn))
                {
                    bmp = new Bitmap(bitmapfn);
                    bmpitem.Bitmap = bmp;
                }
                if (File.Exists(alphafn))
                {
                    // alphafn = alphapath;
                    alphafnlbl.Text = Path.GetFileName(alphafn);
                    bmpitem.Alpha = new Bitmap(alphafn);
                    bmpitem.BmpType = FSHBmpType.DXT3;
                    bmptype.Text = bmpitem.BmpType.ToString();
                }
                else
                {
                    if (bmp != null)
                    {
                        Bitmap genalpha = new Bitmap(bmp.Width, bmp.Height);
                        for (int i = 0; i < genalpha.Height; i++)
                        {
                            for (int j = 0; j < genalpha.Width; j++)
                            {
                                genalpha.SetPixel(j, i, Color.White);
                            }
                        }
                        alphafnlbl.Text = "Generated Alpha";
                        bmpitem.Alpha = genalpha;
                    }
                    bmpitem.BmpType = FSHBmpType.DXT1;
                    bmptype.Text = bmpitem.BmpType.ToString();
                }
                curimage.Bitmaps.Add(bmpitem);
                curimage.IsCompressed = true;
                curimage.UpdateDirty();
                if (File.Exists(fshname))
                {
                    if (MessageBox.Show(this, "This file already exists. Do you want to overwrite it?", "Overwrite file?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        FileStream fs = new FileStream(fshname, FileMode.Open, FileAccess.Write);
                        curimage.Save(fs);
                        fs.Close();
                    }
                }
                else
                {
                    FileStream fs = new FileStream(fshname, FileMode.Create, FileAccess.Write);
                    curimage.Save(fs);
                    fs.Close();
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
