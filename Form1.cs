using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualSoftwareSystem
{
    public partial class Form1 : Form
    {
        static int xSize = 480;
        static int ySize = 640;

        Bitmap OutputBitmap = new Bitmap(xSize, ySize); //change these dimentions to x instead of specific pixels
        DrawingSystem DrawingCanvasOutput;

        public Form1()
        {
            InitializeComponent();
            DrawingCanvasOutput = new DrawingSystem(Graphics.FromImage(OutputBitmap));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //nothing here yet
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //nothing here yet
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  var formPopup = new Form();
            // formPopup.Show(this); // if you need non-modal window
            MessageBox.Show("An application used to simulate a programming language for educational purposes. Written by Dominic Stenton");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //nothing here yet
        }

        private void commandLine_TextChanged(object sender, EventArgs e)
        {
        //needs to be deleted
        }

        private void commandLine_KeyDown(object sender, KeyEventArgs e)
        {
          
            if (e.KeyCode == Keys.Enter)
            {
                String Command = CommandLineTextBox.Text.Trim().ToLower();

                String[] Commands = Command.Split(' ', ',');

                try
                {
                    String Instruct = Commands[0];
                    int Var1 = int.Parse(Commands[1]);
                    int Var2 = int.Parse(Commands[2]);


                    if (Commands[0].Equals("drawline") == true)
                    {
                        DrawingCanvasOutput.DrawLine(Var1, Var2);
                        Console.WriteLine("LINE");
                    }

                    else if (Commands[0].Equals("moveline") == true)
                    {
                        DrawingCanvasOutput.MoveLine(Var1, Var2);
                        Console.WriteLine("LINE");
                    }

                    else if (Commands[0].Equals("square") == true)
                    {
                        DrawingCanvasOutput.SquareDrawing(Var1, Var2);
                        Console.WriteLine("SQUARE");
                    }

                    else if (Commands[0].Equals("circle") == true)
                    {
                        DrawingCanvasOutput.CircleDrawing(Var1, Var2);
                        Console.WriteLine("CIRCLE");
                    }

                    else if (Commands[0].Equals("triangle") == true)
                    {
                        DrawingCanvasOutput.TriangleDrawing(Var2, Var2);
                        Console.WriteLine("TRIANGLE");
                    }

                    else if (Command.Equals("clear") == true)
                    {
                        //   DrawingCanvasOutput.Image.Dispose();
                        Console.WriteLine("CLEARED TEXT BOX");
                    }


                    CommandLineTextBox.Text = "";
                    Refresh();
                }
                catch (FormatException i)
                {
                    Console.WriteLine("ExampleFILLHERE");
                }
                catch (IndexOutOfRangeException i)
                {
                    Console.WriteLine("ExampleFILLHERE");
                }

            }
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
      //need to be deleted
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //can be deleted
            Console.WriteLine("Key Down");
            if (e.KeyCode == Keys.Enter)
            {
                //can be deleted
                Console.WriteLine("Return Pressed");
            }
        }


        //pictureBox1_Paint
        private void DrawingOutput_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(OutputBitmap, 0, 0);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //nothing here yet
        }
    }
}
