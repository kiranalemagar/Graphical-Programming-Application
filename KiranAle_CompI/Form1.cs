using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiranAle_CompI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// variable to create triangle side
        /// </summary>
        public int _size1, _size2, _size3, _size4, _size5, _size6, _size7, _size8, _size9, _size10, _size11, _size12;

        private void txt_cmd_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This function will load the text file from desired location
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // txt_cmd.Text = File.ReadAllText(OpenFileDialog.);
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Text Document(*.txt) | *.txt";
            if (of.ShowDialog() == DialogResult.OK)
            {
                txt_cmd.Text = File.ReadAllText(of.FileName);
            }
        }


        /// <summary>
        /// to save running program to textfile. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if(sv.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(sv.FileName, txt_cmd.Text);
            }
        }

        /// <summary>
        /// On clicking drawing panel, it displays x and y axis value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pnl_Draw_MouseClick(object sender, MouseEventArgs e)
        {
            lbl_StartPosX.Text = (e.X).ToString();
            lbl_StartPosY.Text = (e.Y).ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

      
        ///  Triangle sides
       
        public int xi1, yi1, xi2, yi2, xii1, yii1, xii2, yii2, xiii1, yiii1, xiii2, yiii2;
        Color paintcolor = Color.Blue;
        Brush bb = new HatchBrush(HatchStyle.Wave, Color.Red, Color.FromArgb(255, 128, 255, 255));
        int texturestyle = 5;
        Graphics g;

        ///  logic to run command in application
      
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_run_Click(object sender, EventArgs e)
        {
            Regex regexDrRect = new Regex(@"drawto (.*[\d])([,])(.*[\d]) rectangle (.*[\d])([,])(.*[\d])");
            Regex regexDrCircle = new Regex(@"drawto (.*[\d])([,])(.*[\d]) circle (.*[\d])");
            Regex regexDrTri = new Regex(@"drawto (.*[\d])([,])(.*[\d]) triangle (.*[\d])([,])(.*[\d])([,])(.*[\d])");


            Regex regexClear = new Regex(@"clear");
            Regex regexReset = new Regex(@"reset");
            Regex regexMT = new Regex(@"moveto (.*[\d])([,])(.*[\d])");

            Regex regexR = new Regex(@"rectangle (.*[\d])([,])(.*[\d])");
            Regex regexC = new Regex(@"circle (.*[\d])");
            Regex regexT = new Regex(@"triangle (.*[\d])([,])(.*[\d])([,])(.*[\d])");


           
            Match matchDrRect = regexDrRect.Match(txt_cmd.Text.ToLower());
            Match matchDrCircle = regexDrCircle.Match(txt_cmd.Text.ToLower());
            Match matchDrTri = regexDrTri.Match(txt_cmd.Text.ToLower());

            Match matchClear = regexClear.Match(txt_cmd.Text.ToLower());
            Match matchReset = regexReset.Match(txt_cmd.Text.ToLower());
            Match matchMT = regexMT.Match(txt_cmd.Text.ToLower());

            Match matchR = regexR.Match(txt_cmd.Text.ToLower());
            Match matchC = regexC.Match(txt_cmd.Text.ToLower());
            Match matchT = regexT.Match(txt_cmd.Text.ToLower());


            
            if (matchDrRect.Success || matchDrCircle.Success || matchDrTri.Success || matchClear.Success ||
                matchReset.Success || matchMT.Success || matchR.Success || matchC.Success || matchT.Success)
            {


                //---------------- DrawTo Triangle-----------------------//
                if (matchDrRect.Success)
                {
                    try
                    {
                        g = Pnl_Draw.CreateGraphics();
                        _size1 = int.Parse(matchDrRect.Groups[1].Value);
                        _size2 = int.Parse(matchDrRect.Groups[3].Value);
                        _size3 = int.Parse(matchDrRect.Groups[4].Value);
                        _size4 = int.Parse(matchDrRect.Groups[6].Value);



                        ShapeFactory shapeFactory = new ShapeFactory();
                        Shape c = shapeFactory.GetShape("rectangle");

                        c.set(texturestyle, bb, paintcolor, _size1, _size2, _size3, _size4);
                        c.Draw(g);

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }

                //----------------RECTANGLE-----------------------//


                else if (matchR.Success)
                {
                    try
                    {
                        g = Pnl_Draw.CreateGraphics();
                        _size1 = int.Parse(lbl_StartPosX.Text);
                        _size2 = int.Parse(lbl_StartPosY.Text);
                        _size3 = int.Parse(matchR.Groups[1].Value);
                        _size4 = int.Parse(matchR.Groups[3].Value);

                        ShapeFactory shapeFactory = new ShapeFactory();
                        Shape c = shapeFactory.GetShape("rectangle");
                        c.set(texturestyle, bb, paintcolor, _size1, _size2, _size3, _size4);

                        c.Draw(g);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("wrong parameter: should be like this \"rectangle width, height\"");
                    }
                }

                //----------------CIRCLE-----------------------//
                else if (matchC.Success)
                {
                    try
                    {
                        g = Pnl_Draw.CreateGraphics();
                        _size1 = int.Parse(lbl_StartPosX.Text);
                        _size2 = int.Parse(lbl_StartPosY.Text);
                        _size3 = int.Parse(matchC.Groups[1].Value);


                        ShapeFactory shapeFactory = new ShapeFactory();
                        Shape c = shapeFactory.GetShape("circle");
                        c.set(texturestyle, bb, paintcolor, _size1, _size2, _size3 * 2, _size3 * 2);
                        //c.draw(set);
                        c.Draw(g);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("wrong parameter: should be like this \"circle radius\"");
                    }
                }

                // ---------------- DrawTo Triangle---------------------- -//
                else if (matchDrTri.Success)
                {
                    try
                    {
                        g = Pnl_Draw.CreateGraphics();
                        _size1 = int.Parse(matchDrTri.Groups[1].Value);
                        _size2 = int.Parse(matchDrTri.Groups[3].Value);

                        _size3 = int.Parse(matchDrTri.Groups[4].Value);
                        _size4 = int.Parse(matchDrTri.Groups[6].Value);
                        _size5 = int.Parse(matchDrTri.Groups[8].Value);


                        xi1 = _size1;
                        yi1 = _size2;
                        xi2 = Math.Abs(_size3);
                        yi2 = _size2;

                        xii1 = _size1;
                        yii1 = _size2;
                        xii2 = _size1;
                        yii2 = Math.Abs(_size4);

                        xiii1 = Math.Abs(_size3);
                        yiii1 = _size2;
                        xiii2 = _size1;
                        yiii2 = Math.Abs(_size4);

                        ShapeFactory shapeFactory = new ShapeFactory();
                        Shape c = shapeFactory.GetShape("triangle");
                        c.set(texturestyle, bb, paintcolor, xi1, yi1, xi2, yi2, xii1, yii1, xii2, yii2, xiii1, yiii1, xiii2, yiii2);
                     
                        c.Draw(g);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                // ----------------TRIANGLE---------------------- -//

                else if (matchT.Success)
                {
                    try
                    {
                        g = Pnl_Draw.CreateGraphics();
                        _size1 = int.Parse(lbl_StartPosX.Text);
                        _size2 = int.Parse(lbl_StartPosY.Text);

                        _size3 = int.Parse(matchT.Groups[1].Value);
                        _size4 = int.Parse(matchT.Groups[3].Value);
                        _size5 = int.Parse(matchT.Groups[5].Value);


                        xi1 = _size1;
                        yi1 = _size2;
                        xi2 = Math.Abs(_size3);
                        yi2 = _size2;

                        xii1 = _size1;
                        yii1 = _size2;
                        xii2 = _size1;
                        yii2 = Math.Abs(_size4);

                        xiii1 = Math.Abs(_size3);
                        yiii1 = _size2;
                        xiii2 = _size1;
                        yiii2 = Math.Abs(_size4);

                        ShapeFactory shapeFactory = new ShapeFactory();
                        Shape c = shapeFactory.GetShape("triangle"); // rectangle;
                        c.set(texturestyle, bb, paintcolor, xi1, yi1, xi2, yi2, xii1, yii1, xii2, yii2, xiii1, yiii1, xiii2, yiii2);
                        c.Draw(g);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("wrong parameter: should be like this \"triangle side, side, side\"");
                    }
                }

                // ----------------CLEAR------------------------//

                else if (matchClear.Success)
                {
                    Pnl_Draw.Refresh();
                    this.Pnl_Draw.BackgroundImage = null;
                }


                // ----------------RESET------------------------//
                else if (matchReset.Success)
                {
                    _size1 = 0;
                    _size2 = 0;
                    lbl_StartPosX.Text = _size1.ToString();
                    lbl_StartPosY.Text = _size2.ToString();
                }

                // ----------------MOVETO------------------------//

                else if (matchMT.Success)
                {
                    try
                    {
                        _size1 = int.Parse(matchMT.Groups[1].Value);
                        _size2 = int.Parse(matchMT.Groups[3].Value);

                        lbl_StartPosX.Text = _size1.ToString();
                        lbl_StartPosY.Text = _size2.ToString();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }

            }
            else
            {
                MessageBox.Show("Command doesnot exist");
            }
        }
    }
}
