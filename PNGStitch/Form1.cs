using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PNGStitch
{
    public partial class MainForm : Form
    {
        List<string> loadedFiles;

        public MainForm()
        {
            InitializeComponent();
            loadedFiles = new List<string>();
        }

        private void radioButtonHoriz_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton that = (RadioButton)sender;
            if (that.Checked)
            {
                radioButtonAnchorTopLeft.Text = "Top";
                groupBoxResSize.Text = "Resulting Width";
                radioButtonResConstant.Text = "Constant (first width times n)";
                radioButtonResSum.Text = "Dynamic (sum of widths)";
            }
        }

        private void radioButtonVert_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton that = (RadioButton)sender;
            if (that.Checked)
            {
                radioButtonAnchorTopLeft.Text = "Left";
                groupBoxResSize.Text = "Resulting Height";
                radioButtonResConstant.Text = "Constant (first height times n)";
                radioButtonResSum.Text = "Dynamic (sum of heights)";
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Title = "PNGStitch";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.Cancel || ofd.FileNames.Length == 0)
                return;

            loadedFiles.Clear();
            loadedFiles.AddRange(ofd.FileNames);

            buttonLoad.Text = "Loaded " + ofd.FileNames.Length + " imgs";
            buttonStitch.Enabled = true;
        }

        private void buttonStitch_Click(object sender, EventArgs e)
        {
            //set options flags
            bool optionsHoriz = radioButtonHoriz.Checked;
            bool optionsAnchorCenter = radioButtonAnchorCenter.Checked;
            bool optionsResultConstant = radioButtonResConstant.Checked;

            //load each image
            Bitmap[] images = new Bitmap[loadedFiles.Count];
            for (int i = 0; i < images.Length; i++)
            {
                images[i] = (Bitmap)Bitmap.FromFile(loadedFiles[i]);
            }

            //create the final canvas
            Bitmap final;
            int finalWidth, finalHeight;

            if (optionsHoriz)
            {
                if (optionsResultConstant) //make the canvas only just as big as we need it
                    finalWidth = images[0].Width * images.Length;
                else
                    finalWidth = images.Sum(img => img.Width); //sum of widths
                finalHeight = images.Max(img => img.Height);
            }
            else
            {
                if (optionsResultConstant)
                    finalHeight = images[0].Height * images.Length;
                else
                    finalHeight = images.Sum(img => img.Height);
                finalWidth = images.Max(img => img.Width);
            }

            final = new Bitmap(finalWidth, finalHeight);

            //canvas is prepared. time to copy over
            Graphics g = Graphics.FromImage(final);
            g.CompositingMode = CompositingMode.SourceOver;

            int activeComponent = 0; //x if horiz; y if vert
            for (int i = 0; i < images.Length; i++)
            {
                int outX;
                int outY;

                if (optionsHoriz)
                {
                    outX = activeComponent;
                    outY = optionsAnchorCenter ? 
                        (final.Height - images[i].Height) / 2 :
                        0;
                    //if "anchor center", then anchor smaller images at center. otherwise, anchor at top/left
                }
                else
                {
                    outX = optionsAnchorCenter ?
                        (final.Width - images[i].Width) / 2 :
                        0;
                    outY = activeComponent;
                }

                g.DrawImageUnscaled(images[i], new Point(outX, outY));

                //increase the active component with respect to the "resulting width/height" option
                if (optionsHoriz)
                    if (optionsResultConstant)
                        activeComponent += images[0].Width;
                    else
                        activeComponent += images[i].Width;
                else
                    if (optionsResultConstant)
                        activeComponent += images[0].Height;
                    else
                        activeComponent += images[i].Height;
            }

            //everything done. prepare and save
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = new FileInfo(loadedFiles.First()).DirectoryName;
            sfd.FileName = "output.png";
            DialogResult drSave = sfd.ShowDialog();
            if (drSave == DialogResult.Cancel)
                return; //retard. making me do all this work for nothing.

            final.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            
            loadedFiles.Clear();
            loadedFiles.AddRange(files);

            buttonLoad.Text = "Loaded " + files.Length + " imgs";
            buttonStitch.Enabled = true;
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
    }
}
