﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pipe_Cutting
{
    public partial class Form1 : Form
    {
        const string prg_int = "G91 ";
        const string prg_end = "M30 ";
        const string torch_on = "M3 ";
        const string torch_off = "M5 ";
        const string delay = "G4 P";
        const string movement = "G0 ";
        const string new_line = "\r\n";
        const string full_cut = "G0 Y330 ";
        const string line_number = "N";

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Output_Click(object sender, EventArgs e)
        {
            //taking values from all the text boxes.
            int val_total_pipe_length   = Convert.ToInt32(tb_total_pipe_length.Text);
            int val_pipe_diameter       = Convert.ToInt32(tb_pipe_diameter.Text);
            int val_delay               = Convert.ToInt32(tb_delay.Text);
            int val_mid_space           = Convert.ToInt32(tb_mid_space.Text);
            int val_pre_space           = Convert.ToInt32(tb_pre_space.Text);
            int val_post_space          = Convert.ToInt32(tb_post_space.Text);
            int val_length              = Convert.ToInt32(tb_section_length.Text);
            int val_width               = Convert.ToInt32(tb_section_width.Text);
            int val_total_section       = Convert.ToInt32(tb_total_section.Text);

            //length of the cut pipe
            int val_length_cut_pipe = (val_pre_space + val_post_space + (val_total_section * val_length) + ((val_total_section - 1) * val_mid_space));
            //to be considered only after calculation of length of single pipe 
            int val_total_pipes = val_total_pipe_length/val_length_cut_pipe;
            tb_total_pipes.Text = val_total_pipes.ToString();

            //generating the processed value for all the parameters according to the 2PIR
            int processed_width = processed_value(val_width, val_pipe_diameter);

            string text_val_delay = tb_delay.Text;
            //string text_val_total_pipe_length = tb_total_pipe_length.Text;
            //string text_val_mid_space = tb_mid_space.Text;
            //string text_val_pre_space = tb_pre_space.Text;
            //string text_val_post_space = tb_post_space.Text;
            //string text_val_length = tb_section_length.Text;
            //string text_val_width = tb_section_width.Text;
            //string text_val_total_pipes = tb_total_pipes.Text;
            //string text_val_total_section = tb_total_section.Text;

            int line_counter = 1;   //for counting the lines generated.
            int pipe_counter = 0;
            int section_counter = 0;

            //string for the initialization of the pipe cutting;
            output_box.Text = Line_text(line_counter++) + prg_int + new_line;
            output_box.Text += Line_text(line_counter++) + torch_on + new_line;
            output_box.Text += Line_text(line_counter++) + delay + text_val_delay + new_line;
            output_box.Text += Line_text(line_counter++) + full_cut + new_line;
            output_box.Text += Line_text(line_counter++) + torch_off + new_line;

            output_box.Text += new_line;

            for (pipe_counter = 0; pipe_counter < val_total_pipes; pipe_counter++)
            {
                output_box.Text += Line_text(line_counter++) + movementXY(-val_pre_space,0) + new_line;
                output_box.Text += new_line;

                for (section_counter = 0; section_counter < val_total_section; section_counter++)
                {
                    output_box.Text += Line_text(line_counter++) + torch_on + new_line;
                    output_box.Text += Line_text(line_counter++) + delay + text_val_delay + new_line;
                    output_box.Text += Line_text(line_counter++) + movementXY(0,processed_width) + new_line;
                    output_box.Text += Line_text(line_counter++) + movementXY(-val_length,0) + new_line;
                    output_box.Text += Line_text(line_counter++) + movementXY(0, -processed_width) + new_line;
                    output_box.Text += Line_text(line_counter++) + movementXY(val_length, 0) + new_line;
                    output_box.Text += Line_text(line_counter++) + torch_off + new_line;
                    output_box.Text += new_line;

                    //write code to move the laser cutting machine to the next section over here.
                    if (section_counter != (val_total_section - 1))
                    {
                        output_box.Text += Line_text(line_counter++) + movementXY(-val_mid_space, 0) + new_line;
                        output_box.Text += new_line;
                    }
                }

                output_box.Text += Line_text(line_counter++) + movementXY(-val_post_space, 0) + new_line;

                if (pipe_counter != (val_total_pipes - 1))
                {
                    output_box.Text += Line_text(line_counter++) + torch_on + new_line;
                    output_box.Text += Line_text(line_counter++) + delay + text_val_delay + new_line;
                    output_box.Text += Line_text(line_counter++) + full_cut + new_line;
                    output_box.Text += Line_text(line_counter++) + torch_off + new_line;
                }
                else
                {
                    output_box.Text += Line_text(line_counter++) + prg_end + new_line;
                }

                output_box.Text += new_line;
            }

            
        }

        string Line_text(int val)
        {
            return (line_number + val.ToString() + " ");
        }

        string movementXY(int x,int y)
        {
            return(movement + "X" + x.ToString() + " " + "Y" + y.ToString());
        }

        int processed_value(int value,int diameter)
        {
            int val_chuck_circumference = Convert.ToInt32(tb_chuck_circumference);
            return((value*val_chuck_circumference)/(int)(diameter*Math.PI));
        }

        private void tb_length_TextChanged(object sender, EventArgs e)
        {
            int val_total_pipe_length   = 0;
            int val_pipe_diameter       = 0;
            int val_delay               = 0;
            int val_mid_space           = 0;
            int val_pre_space           = 0;
            int val_post_space          = 0;
            int val_length              = 0;
            int val_width               = 0;
            int val_total_section       = 0;
            int val_length_cut_pipe     = 0;

            if (tb_total_pipe_length.Text == "" || tb_section_length.Text == "" || tb_mid_space.Text == "" || tb_post_space.Text == "" || tb_pre_space.Text == "")
            {
                button_Output.Enabled = false;
                return;
            }

            if (tb_total_pipe_length.Text == "0" || tb_section_length.Text == "0" || tb_mid_space.Text == "0" || tb_post_space.Text == "0" || tb_pre_space.Text == "0")
            {
                button_Output.Enabled = false;
                return;
            }

            button_Output.Enabled = true;

            try
            {
                val_total_pipe_length   = Convert.ToInt32(tb_total_pipe_length.Text);
                val_pipe_diameter       = Convert.ToInt32(tb_pipe_diameter.Text);
                val_delay               = Convert.ToInt32(tb_delay.Text);
                val_mid_space           = Convert.ToInt32(tb_mid_space.Text);
                val_pre_space           = Convert.ToInt32(tb_pre_space.Text);
                val_post_space          = Convert.ToInt32(tb_post_space.Text);
                val_length              = Convert.ToInt32(tb_section_length.Text);
                val_width               = Convert.ToInt32(tb_section_width.Text);
                val_total_section       = Convert.ToInt32(tb_total_section.Text);

                //length of the cut pipe
                val_length_cut_pipe = (val_pre_space + val_post_space + (val_total_section * val_length) + ((val_total_section - 1) * val_mid_space));
                if(val_length_cut_pipe > val_total_pipe_length)
                {
                    MessageBox.Show("Invalid Inputs");
                }
            }
            catch(OverflowException)
            {
                button_Output.Enabled = true;
                ((TextBox)sender).Text = "0";
                return;
            }
            //to be considered only after calculation of length of single pipe 
            int val_total_pipes = val_total_pipe_length / val_length_cut_pipe;
            tb_total_pipes.Text = val_total_pipes.ToString();
        }

        //private void tb_total_section_TextChanged(object sender, EventArgs e)
        //{
        //    int val_total_section = 0;
        //    if (tb_total_section.Text == "")
        //    {
        //        val_total_section = Convert.ToInt32(tb_total_section.Text);
        //        if(val_total_section >= 1)
        //        {
        //            tb_mid_space.Enabled = true;
        //        }
        //        else
        //        {
        //            tb_mid_space.Text = "1";
        //            tb_mid_space.Enabled = false;
        //        }

        //    }
        //}
    }
}
