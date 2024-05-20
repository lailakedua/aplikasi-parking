namespace parking4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CapacityTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CostTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DescTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SectionList = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.EditBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.AddBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DeleteBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SectionList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 69);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::parking4.Properties.Resources._93682bee6c5c935a7752b3a075ba4595;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::parking4.Properties.Resources._00bee3d994af2ec2e31d92d2ffa0474d;
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(93, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parking Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SlateBlue;
            this.label2.Location = new System.Drawing.Point(537, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Section Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SlateBlue;
            this.label3.Location = new System.Drawing.Point(374, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Parking Row";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SlateBlue;
            this.label4.Location = new System.Drawing.Point(199, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Parking Block";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SlateBlue;
            this.label5.Location = new System.Drawing.Point(20, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Section Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Gadugi", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SlateBlue;
            this.label6.Location = new System.Drawing.Point(20, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Section Management";
            // 
            // SNameTb
            // 
            this.SNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SNameTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SNameTb.ForeColor = System.Drawing.Color.White;
            this.SNameTb.HintForeColor = System.Drawing.Color.Empty;
            this.SNameTb.HintText = "";
            this.SNameTb.isPassword = false;
            this.SNameTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.SNameTb.LineIdleColor = System.Drawing.Color.Gray;
            this.SNameTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.SNameTb.LineThickness = 3;
            this.SNameTb.Location = new System.Drawing.Point(13, 174);
            this.SNameTb.Margin = new System.Windows.Forms.Padding(4);
            this.SNameTb.Name = "SNameTb";
            this.SNameTb.Size = new System.Drawing.Size(145, 33);
            this.SNameTb.TabIndex = 6;
            this.SNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SNameTb.OnValueChanged += new System.EventHandler(this.SNameTb_OnValueChanged);
            // 
            // CapacityTb
            // 
            this.CapacityTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CapacityTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CapacityTb.ForeColor = System.Drawing.Color.White;
            this.CapacityTb.HintForeColor = System.Drawing.Color.Empty;
            this.CapacityTb.HintText = "";
            this.CapacityTb.isPassword = false;
            this.CapacityTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.CapacityTb.LineIdleColor = System.Drawing.Color.Gray;
            this.CapacityTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.CapacityTb.LineThickness = 3;
            this.CapacityTb.Location = new System.Drawing.Point(191, 174);
            this.CapacityTb.Margin = new System.Windows.Forms.Padding(4);
            this.CapacityTb.Name = "CapacityTb";
            this.CapacityTb.Size = new System.Drawing.Size(145, 33);
            this.CapacityTb.TabIndex = 7;
            this.CapacityTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CapacityTb.OnValueChanged += new System.EventHandler(this.CapacityTb_OnValueChanged);
            // 
            // CostTb
            // 
            this.CostTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CostTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CostTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CostTb.HintForeColor = System.Drawing.Color.Empty;
            this.CostTb.HintText = "";
            this.CostTb.isPassword = false;
            this.CostTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.CostTb.LineIdleColor = System.Drawing.Color.Gray;
            this.CostTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.CostTb.LineThickness = 3;
            this.CostTb.Location = new System.Drawing.Point(363, 174);
            this.CostTb.Margin = new System.Windows.Forms.Padding(4);
            this.CostTb.Name = "CostTb";
            this.CostTb.Size = new System.Drawing.Size(145, 33);
            this.CostTb.TabIndex = 8;
            this.CostTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DescTb
            // 
            this.DescTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DescTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.DescTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DescTb.HintForeColor = System.Drawing.Color.Empty;
            this.DescTb.HintText = "";
            this.DescTb.isPassword = false;
            this.DescTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.DescTb.LineIdleColor = System.Drawing.Color.Gray;
            this.DescTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.DescTb.LineThickness = 3;
            this.DescTb.Location = new System.Drawing.Point(540, 174);
            this.DescTb.Margin = new System.Windows.Forms.Padding(4);
            this.DescTb.Name = "DescTb";
            this.DescTb.Size = new System.Drawing.Size(189, 33);
            this.DescTb.TabIndex = 9;
            this.DescTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // SectionList
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SectionList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.SectionList.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.SectionList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SectionList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SectionList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.SectionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SectionList.DoubleBuffered = true;
            this.SectionList.EnableHeadersVisualStyles = false;
            this.SectionList.HeaderBgColor = System.Drawing.Color.MediumSlateBlue;
            this.SectionList.HeaderForeColor = System.Drawing.Color.MediumSlateBlue;
            this.SectionList.Location = new System.Drawing.Point(49, 305);
            this.SectionList.Name = "SectionList";
            this.SectionList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SectionList.Size = new System.Drawing.Size(659, 150);
            this.SectionList.TabIndex = 10;
            this.SectionList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SectionList_CellContentClick);
            // 
            // EditBtn
            // 
            this.EditBtn.ActiveBorderThickness = 1;
            this.EditBtn.ActiveCornerRadius = 20;
            this.EditBtn.ActiveFillColor = System.Drawing.Color.MediumSlateBlue;
            this.EditBtn.ActiveForecolor = System.Drawing.Color.White;
            this.EditBtn.ActiveLineColor = System.Drawing.Color.MediumSlateBlue;
            this.EditBtn.BackColor = System.Drawing.SystemColors.Control;
            this.EditBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditBtn.BackgroundImage")));
            this.EditBtn.ButtonText = "Edit Section";
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.MediumPurple;
            this.EditBtn.IdleBorderThickness = 1;
            this.EditBtn.IdleCornerRadius = 20;
            this.EditBtn.IdleFillColor = System.Drawing.Color.White;
            this.EditBtn.IdleForecolor = System.Drawing.Color.MediumSlateBlue;
            this.EditBtn.IdleLineColor = System.Drawing.Color.MediumSlateBlue;
            this.EditBtn.Location = new System.Drawing.Point(139, 241);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(5);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(126, 39);
            this.EditBtn.TabIndex = 11;
            this.EditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.ActiveBorderThickness = 1;
            this.AddBtn.ActiveCornerRadius = 20;
            this.AddBtn.ActiveFillColor = System.Drawing.Color.MediumSlateBlue;
            this.AddBtn.ActiveForecolor = System.Drawing.Color.White;
            this.AddBtn.ActiveLineColor = System.Drawing.Color.MediumSlateBlue;
            this.AddBtn.BackColor = System.Drawing.SystemColors.Control;
            this.AddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddBtn.BackgroundImage")));
            this.AddBtn.ButtonText = "Add Section";
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.MediumPurple;
            this.AddBtn.IdleBorderThickness = 1;
            this.AddBtn.IdleCornerRadius = 20;
            this.AddBtn.IdleFillColor = System.Drawing.Color.White;
            this.AddBtn.IdleForecolor = System.Drawing.Color.MediumSlateBlue;
            this.AddBtn.IdleLineColor = System.Drawing.Color.MediumSlateBlue;
            this.AddBtn.Location = new System.Drawing.Point(300, 239);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(5);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(153, 41);
            this.AddBtn.TabIndex = 12;
            this.AddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.ActiveBorderThickness = 1;
            this.DeleteBtn.ActiveCornerRadius = 20;
            this.DeleteBtn.ActiveFillColor = System.Drawing.Color.MediumPurple;
            this.DeleteBtn.ActiveForecolor = System.Drawing.Color.White;
            this.DeleteBtn.ActiveLineColor = System.Drawing.Color.MediumSlateBlue;
            this.DeleteBtn.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.BackgroundImage")));
            this.DeleteBtn.ButtonText = "Delete Section";
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.MediumPurple;
            this.DeleteBtn.IdleBorderThickness = 1;
            this.DeleteBtn.IdleCornerRadius = 20;
            this.DeleteBtn.IdleFillColor = System.Drawing.Color.White;
            this.DeleteBtn.IdleForecolor = System.Drawing.Color.MediumSlateBlue;
            this.DeleteBtn.IdleLineColor = System.Drawing.Color.MediumSlateBlue;
            this.DeleteBtn.Location = new System.Drawing.Point(487, 239);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(5);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(149, 39);
            this.DeleteBtn.TabIndex = 13;
            this.DeleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 504);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(747, 25);
            this.panel2.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::parking4.Properties.Resources.a533c4dac804c2d1f0784d2168bfb44e;
            this.ClientSize = new System.Drawing.Size(747, 529);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.SectionList);
            this.Controls.Add(this.DescTb);
            this.Controls.Add(this.CostTb);
            this.Controls.Add(this.CapacityTb);
            this.Controls.Add(this.SNameTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SectionList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SNameTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CapacityTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CostTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DescTb;
        private Bunifu.Framework.UI.BunifuCustomDataGrid SectionList;
        private Bunifu.Framework.UI.BunifuThinButton2 EditBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 AddBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteBtn;
        private System.Windows.Forms.Panel panel2;
    }
}

