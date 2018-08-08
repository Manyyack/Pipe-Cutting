namespace Pipe_Cutting
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.output_box = new System.Windows.Forms.RichTextBox();
            this.tb_delay = new System.Windows.Forms.TextBox();
            this.tb_total_pipes = new System.Windows.Forms.TextBox();
            this.tb_total_section = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_mid_space = new System.Windows.Forms.TextBox();
            this.tb_section_width = new System.Windows.Forms.TextBox();
            this.tb_section_length = new System.Windows.Forms.TextBox();
            this.button_Output = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_pre_space = new System.Windows.Forms.TextBox();
            this.tb_post_space = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_total_pipe_length = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_pipe_diameter = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_chuck_circumference = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // output_box
            // 
            this.output_box.Location = new System.Drawing.Point(286, 12);
            this.output_box.Name = "output_box";
            this.output_box.Size = new System.Drawing.Size(176, 301);
            this.output_box.TabIndex = 0;
            this.output_box.TabStop = false;
            this.output_box.Text = "";
            // 
            // tb_delay
            // 
            this.tb_delay.Location = new System.Drawing.Point(229, 12);
            this.tb_delay.Name = "tb_delay";
            this.tb_delay.Size = new System.Drawing.Size(42, 20);
            this.tb_delay.TabIndex = 1;
            this.tb_delay.Text = "0";
            // 
            // tb_total_pipes
            // 
            this.tb_total_pipes.Location = new System.Drawing.Point(228, 280);
            this.tb_total_pipes.Name = "tb_total_pipes";
            this.tb_total_pipes.Size = new System.Drawing.Size(42, 20);
            this.tb_total_pipes.TabIndex = 10;
            this.tb_total_pipes.Text = "0";
            // 
            // tb_total_section
            // 
            this.tb_total_section.Location = new System.Drawing.Point(228, 122);
            this.tb_total_section.Name = "tb_total_section";
            this.tb_total_section.Size = new System.Drawing.Size(42, 20);
            this.tb_total_section.TabIndex = 4;
            this.tb_total_section.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Delay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of Pipes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Number Of Sections in Pipe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Space Between 2 Sections";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Section Width";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Section Length ";
            // 
            // tb_mid_space
            // 
            this.tb_mid_space.Location = new System.Drawing.Point(228, 200);
            this.tb_mid_space.Name = "tb_mid_space";
            this.tb_mid_space.Size = new System.Drawing.Size(42, 20);
            this.tb_mid_space.TabIndex = 7;
            this.tb_mid_space.Text = "0";
            this.tb_mid_space.TextChanged += new System.EventHandler(this.tb_length_TextChanged);
            // 
            // tb_section_width
            // 
            this.tb_section_width.Location = new System.Drawing.Point(228, 174);
            this.tb_section_width.Name = "tb_section_width";
            this.tb_section_width.Size = new System.Drawing.Size(42, 20);
            this.tb_section_width.TabIndex = 6;
            this.tb_section_width.Text = "0";
            // 
            // tb_section_length
            // 
            this.tb_section_length.Location = new System.Drawing.Point(228, 148);
            this.tb_section_length.Name = "tb_section_length";
            this.tb_section_length.Size = new System.Drawing.Size(42, 20);
            this.tb_section_length.TabIndex = 5;
            this.tb_section_length.Text = "0";
            this.tb_section_length.TextChanged += new System.EventHandler(this.tb_length_TextChanged);
            // 
            // button_Output
            // 
            this.button_Output.Enabled = false;
            this.button_Output.Location = new System.Drawing.Point(195, 305);
            this.button_Output.Name = "button_Output";
            this.button_Output.Size = new System.Drawing.Size(75, 36);
            this.button_Output.TabIndex = 11;
            this.button_Output.Text = "Generate Text File";
            this.button_Output.UseVisualStyleBackColor = true;
            this.button_Output.Click += new System.EventHandler(this.button_Output_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Space between Pipe Cut and New Section";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Space Between Last Section and New Pipe";
            // 
            // tb_pre_space
            // 
            this.tb_pre_space.Location = new System.Drawing.Point(228, 253);
            this.tb_pre_space.Name = "tb_pre_space";
            this.tb_pre_space.Size = new System.Drawing.Size(42, 20);
            this.tb_pre_space.TabIndex = 9;
            this.tb_pre_space.Text = "0";
            this.tb_pre_space.TextChanged += new System.EventHandler(this.tb_length_TextChanged);
            // 
            // tb_post_space
            // 
            this.tb_post_space.Location = new System.Drawing.Point(228, 227);
            this.tb_post_space.Name = "tb_post_space";
            this.tb_post_space.Size = new System.Drawing.Size(42, 20);
            this.tb_post_space.TabIndex = 8;
            this.tb_post_space.Text = "0";
            this.tb_post_space.TextChanged += new System.EventHandler(this.tb_length_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(118, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Total Length Of Pipe";
            // 
            // tb_total_pipe_length
            // 
            this.tb_total_pipe_length.Location = new System.Drawing.Point(229, 38);
            this.tb_total_pipe_length.Name = "tb_total_pipe_length";
            this.tb_total_pipe_length.Size = new System.Drawing.Size(42, 20);
            this.tb_total_pipe_length.TabIndex = 2;
            this.tb_total_pipe_length.Text = "0";
            this.tb_total_pipe_length.TextChanged += new System.EventHandler(this.tb_length_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(147, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Pipe Diameter";
            // 
            // tb_pipe_diameter
            // 
            this.tb_pipe_diameter.Location = new System.Drawing.Point(228, 67);
            this.tb_pipe_diameter.Name = "tb_pipe_diameter";
            this.tb_pipe_diameter.Size = new System.Drawing.Size(42, 20);
            this.tb_pipe_diameter.TabIndex = 3;
            this.tb_pipe_diameter.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(97, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Circumference Of Chuck";
            // 
            // tb_chuck_circumference
            // 
            this.tb_chuck_circumference.Location = new System.Drawing.Point(228, 95);
            this.tb_chuck_circumference.Name = "tb_chuck_circumference";
            this.tb_chuck_circumference.Size = new System.Drawing.Size(42, 20);
            this.tb_chuck_circumference.TabIndex = 22;
            this.tb_chuck_circumference.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 353);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_chuck_circumference);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_pipe_diameter);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_total_pipe_length);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_pre_space);
            this.Controls.Add(this.tb_post_space);
            this.Controls.Add(this.button_Output);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_mid_space);
            this.Controls.Add(this.tb_section_width);
            this.Controls.Add(this.tb_section_length);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_total_section);
            this.Controls.Add(this.tb_total_pipes);
            this.Controls.Add(this.tb_delay);
            this.Controls.Add(this.output_box);
            this.Name = "Form1";
            this.Text = "Pipe Cutting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox output_box;
        private System.Windows.Forms.TextBox tb_delay;
        private System.Windows.Forms.TextBox tb_total_pipes;
        private System.Windows.Forms.TextBox tb_total_section;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_mid_space;
        private System.Windows.Forms.TextBox tb_section_width;
        private System.Windows.Forms.TextBox tb_section_length;
        private System.Windows.Forms.Button button_Output;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_pre_space;
        private System.Windows.Forms.TextBox tb_post_space;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_total_pipe_length;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_pipe_diameter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_chuck_circumference;
    }
}

