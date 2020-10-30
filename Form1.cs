﻿using System;
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
        Bitmap OutputBitmap = new Bitmap(640, 480); //change these dimentions to x instead of specific pixels
        DrawingSystem DrawingCanvasOutput;

        public Form1()
        {
            InitializeComponent();
            DrawingCanvasOutput = new DrawingSystem(Graphics.FromImage(OutputBitmap));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
                if (Command.Equals("line") == true)
                {
                    DrawingCanvasOutput.DrawLine(160, 120);
                    Console.WriteLine("LINE");
                }

                else if (Command.Equals("square") == true)
                {
                    DrawingCanvasOutput.SquareDrawing(25);
                    Console.WriteLine("LINE");
                }

                CommandLineTextBox.Text = "";
                Refresh();

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
    }
}
