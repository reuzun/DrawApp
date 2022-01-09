
namespace DrawApp
{
    partial class drawapp_stage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_exit = new System.Windows.Forms.Button();
            this.txt_loc_mouse_x = new System.Windows.Forms.TextBox();
            this.txt_loc_mouse_y = new System.Windows.Forms.TextBox();
            this.label_loc_mouse_x = new System.Windows.Forms.Label();
            this.label_loc_mouse_y = new System.Windows.Forms.Label();
            this.curveLength_txt = new System.Windows.Forms.TextBox();
            this.btn_calculate_curveLength = new System.Windows.Forms.Button();
            this.combobox_pointColor = new System.Windows.Forms.ComboBox();
            this.label_settings = new System.Windows.Forms.Label();
            this.label_pointColor = new System.Windows.Forms.Label();
            this.label_curveColor = new System.Windows.Forms.Label();
            this.combobox_curveColor = new System.Windows.Forms.ComboBox();
            this.draw_pane = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(881, 418);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(157, 84);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txt_loc_mouse_x
            // 
            this.txt_loc_mouse_x.Location = new System.Drawing.Point(938, 27);
            this.txt_loc_mouse_x.Name = "txt_loc_mouse_x";
            this.txt_loc_mouse_x.ReadOnly = true;
            this.txt_loc_mouse_x.Size = new System.Drawing.Size(100, 23);
            this.txt_loc_mouse_x.TabIndex = 1;
            // 
            // txt_loc_mouse_y
            // 
            this.txt_loc_mouse_y.Location = new System.Drawing.Point(938, 73);
            this.txt_loc_mouse_y.Name = "txt_loc_mouse_y";
            this.txt_loc_mouse_y.ReadOnly = true;
            this.txt_loc_mouse_y.Size = new System.Drawing.Size(100, 23);
            this.txt_loc_mouse_y.TabIndex = 2;
            // 
            // label_loc_mouse_x
            // 
            this.label_loc_mouse_x.AutoSize = true;
            this.label_loc_mouse_x.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_loc_mouse_x.Location = new System.Drawing.Point(893, 25);
            this.label_loc_mouse_x.Name = "label_loc_mouse_x";
            this.label_loc_mouse_x.Size = new System.Drawing.Size(34, 21);
            this.label_loc_mouse_x.TabIndex = 3;
            this.label_loc_mouse_x.Text = "X =";
            // 
            // label_loc_mouse_y
            // 
            this.label_loc_mouse_y.AutoSize = true;
            this.label_loc_mouse_y.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_loc_mouse_y.Location = new System.Drawing.Point(893, 73);
            this.label_loc_mouse_y.Name = "label_loc_mouse_y";
            this.label_loc_mouse_y.Size = new System.Drawing.Size(34, 21);
            this.label_loc_mouse_y.TabIndex = 4;
            this.label_loc_mouse_y.Text = "Y =";
            // 
            // curveLength_txt
            // 
            this.curveLength_txt.Location = new System.Drawing.Point(893, 124);
            this.curveLength_txt.Name = "curveLength_txt";
            this.curveLength_txt.ReadOnly = true;
            this.curveLength_txt.Size = new System.Drawing.Size(145, 23);
            this.curveLength_txt.TabIndex = 5;
            // 
            // btn_calculate_curveLength
            // 
            this.btn_calculate_curveLength.Location = new System.Drawing.Point(893, 163);
            this.btn_calculate_curveLength.Name = "btn_calculate_curveLength";
            this.btn_calculate_curveLength.Size = new System.Drawing.Size(145, 31);
            this.btn_calculate_curveLength.TabIndex = 6;
            this.btn_calculate_curveLength.Text = "Calculate Curve Length";
            this.btn_calculate_curveLength.UseVisualStyleBackColor = true;
            this.btn_calculate_curveLength.Click += new System.EventHandler(this.btn_calculate_curveLength_Click);
            // 
            // combobox_pointColor
            // 
            this.combobox_pointColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_pointColor.FormattingEnabled = true;
            this.combobox_pointColor.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Black",
            "Blue"});
            this.combobox_pointColor.Location = new System.Drawing.Point(925, 231);
            this.combobox_pointColor.Name = "combobox_pointColor";
            this.combobox_pointColor.Size = new System.Drawing.Size(121, 23);
            this.combobox_pointColor.TabIndex = 7;
            // 
            // label_settings
            // 
            this.label_settings.AutoSize = true;
            this.label_settings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_settings.Location = new System.Drawing.Point(925, 207);
            this.label_settings.Name = "label_settings";
            this.label_settings.Size = new System.Drawing.Size(72, 21);
            this.label_settings.TabIndex = 8;
            this.label_settings.Text = "Settings";
            // 
            // label_pointColor
            // 
            this.label_pointColor.AutoSize = true;
            this.label_pointColor.Location = new System.Drawing.Point(841, 234);
            this.label_pointColor.Name = "label_pointColor";
            this.label_pointColor.Size = new System.Drawing.Size(78, 15);
            this.label_pointColor.TabIndex = 9;
            this.label_pointColor.Text = "Point Color =";
            // 
            // label_curveColor
            // 
            this.label_curveColor.AutoSize = true;
            this.label_curveColor.Location = new System.Drawing.Point(841, 267);
            this.label_curveColor.Name = "label_curveColor";
            this.label_curveColor.Size = new System.Drawing.Size(81, 15);
            this.label_curveColor.TabIndex = 10;
            this.label_curveColor.Text = "Curve Color =";
            // 
            // combobox_curveColor
            // 
            this.combobox_curveColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_curveColor.FormattingEnabled = true;
            this.combobox_curveColor.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Black",
            "Blue"});
            this.combobox_curveColor.Location = new System.Drawing.Point(925, 264);
            this.combobox_curveColor.Name = "combobox_curveColor";
            this.combobox_curveColor.Size = new System.Drawing.Size(121, 23);
            this.combobox_curveColor.TabIndex = 11;
            // 
            // draw_pane
            // 
            this.draw_pane.BackColor = System.Drawing.Color.Silver;
            this.draw_pane.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.draw_pane.Location = new System.Drawing.Point(24, 27);
            this.draw_pane.Name = "draw_pane";
            this.draw_pane.Size = new System.Drawing.Size(773, 475);
            this.draw_pane.TabIndex = 12;
            this.draw_pane.Paint += new System.Windows.Forms.PaintEventHandler(this.draw_pane_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(841, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "How to Use?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(841, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 60);
            this.label2.TabIndex = 14;
            this.label2.Text = "Left click - Append point\r\nRight click - Delete point if a point\r\nexist under the" +
    " cursor otherwise\r\ndelete last added point";
            // 
            // drawapp_stage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 533);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.draw_pane);
            this.Controls.Add(this.combobox_curveColor);
            this.Controls.Add(this.label_curveColor);
            this.Controls.Add(this.label_pointColor);
            this.Controls.Add(this.label_settings);
            this.Controls.Add(this.combobox_pointColor);
            this.Controls.Add(this.btn_calculate_curveLength);
            this.Controls.Add(this.curveLength_txt);
            this.Controls.Add(this.label_loc_mouse_y);
            this.Controls.Add(this.label_loc_mouse_x);
            this.Controls.Add(this.txt_loc_mouse_y);
            this.Controls.Add(this.txt_loc_mouse_x);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "drawapp_stage";
            this.Text = "DrawApp - Draw Lines and Curves using Points";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox txt_loc_mouse_x;
        private System.Windows.Forms.TextBox txt_loc_mouse_y;
        private System.Windows.Forms.Label label_loc_mouse_x;
        private System.Windows.Forms.Label label_loc_mouse_y;
        private System.Windows.Forms.TextBox curveLength_txt;
        private System.Windows.Forms.Button btn_calculate_curveLength;
        private System.Windows.Forms.ComboBox combobox_pointColor;
        private System.Windows.Forms.Label label_settings;
        private System.Windows.Forms.Label label_pointColor;
        private System.Windows.Forms.Label label_curveColor;
        private System.Windows.Forms.ComboBox combobox_curveColor;
        private System.Windows.Forms.Panel draw_pane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

