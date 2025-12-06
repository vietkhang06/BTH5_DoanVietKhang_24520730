namespace BTH5_BT10
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
            this.pnelControls = new System.Windows.Forms.Panel();
            this.pnlDraw = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDashStyle = new System.Windows.Forms.ComboBox();
            this.cboWidth = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLineJoin = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDashCap = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboStartCap = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboEndCap = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnelControls
            // 
            this.pnelControls.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnelControls.Controls.Add(this.cboEndCap);
            this.pnelControls.Controls.Add(this.label6);
            this.pnelControls.Controls.Add(this.cboStartCap);
            this.pnelControls.Controls.Add(this.label5);
            this.pnelControls.Controls.Add(this.cboDashCap);
            this.pnelControls.Controls.Add(this.label4);
            this.pnelControls.Controls.Add(this.cboLineJoin);
            this.pnelControls.Controls.Add(this.label3);
            this.pnelControls.Controls.Add(this.cboWidth);
            this.pnelControls.Controls.Add(this.label2);
            this.pnelControls.Controls.Add(this.cboDashStyle);
            this.pnelControls.Controls.Add(this.label1);
            this.pnelControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnelControls.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnelControls.Location = new System.Drawing.Point(0, 0);
            this.pnelControls.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnelControls.Name = "pnelControls";
            this.pnelControls.Size = new System.Drawing.Size(347, 354);
            this.pnelControls.TabIndex = 0;
            // 
            // pnlDraw
            // 
            this.pnlDraw.BackColor = System.Drawing.Color.White;
            this.pnlDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDraw.Location = new System.Drawing.Point(347, 0);
            this.pnlDraw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(498, 354);
            this.pnlDraw.TabIndex = 1;
            this.pnlDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDraw_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dash Style:";
            // 
            // cboDashStyle
            // 
            this.cboDashStyle.FormattingEnabled = true;
            this.cboDashStyle.Location = new System.Drawing.Point(130, 13);
            this.cboDashStyle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboDashStyle.Name = "cboDashStyle";
            this.cboDashStyle.Size = new System.Drawing.Size(207, 36);
            this.cboDashStyle.TabIndex = 1;
            this.cboDashStyle.SelectedIndexChanged += new System.EventHandler(this.cboDashStyle_SelectedIndexChanged);
            // 
            // cboWidth
            // 
            this.cboWidth.FormattingEnabled = true;
            this.cboWidth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cboWidth.Location = new System.Drawing.Point(130, 72);
            this.cboWidth.Margin = new System.Windows.Forms.Padding(4);
            this.cboWidth.Name = "cboWidth";
            this.cboWidth.Size = new System.Drawing.Size(207, 36);
            this.cboWidth.TabIndex = 3;
            this.cboWidth.SelectedIndexChanged += new System.EventHandler(this.cboWidth_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width:";
            // 
            // cboLineJoin
            // 
            this.cboLineJoin.FormattingEnabled = true;
            this.cboLineJoin.Location = new System.Drawing.Point(130, 131);
            this.cboLineJoin.Margin = new System.Windows.Forms.Padding(4);
            this.cboLineJoin.Name = "cboLineJoin";
            this.cboLineJoin.Size = new System.Drawing.Size(207, 36);
            this.cboLineJoin.TabIndex = 5;
            this.cboLineJoin.SelectedIndexChanged += new System.EventHandler(this.cboLineJoin_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Line Join:";
            // 
            // cboDashCap
            // 
            this.cboDashCap.FormattingEnabled = true;
            this.cboDashCap.Location = new System.Drawing.Point(130, 185);
            this.cboDashCap.Margin = new System.Windows.Forms.Padding(4);
            this.cboDashCap.Name = "cboDashCap";
            this.cboDashCap.Size = new System.Drawing.Size(207, 36);
            this.cboDashCap.TabIndex = 7;
            this.cboDashCap.SelectedIndexChanged += new System.EventHandler(this.cboDashCap_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dash Cap:";
            // 
            // cboStartCap
            // 
            this.cboStartCap.FormattingEnabled = true;
            this.cboStartCap.Location = new System.Drawing.Point(130, 242);
            this.cboStartCap.Margin = new System.Windows.Forms.Padding(4);
            this.cboStartCap.Name = "cboStartCap";
            this.cboStartCap.Size = new System.Drawing.Size(207, 36);
            this.cboStartCap.TabIndex = 9;
            this.cboStartCap.SelectedIndexChanged += new System.EventHandler(this.cboStartCap_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 245);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Start Cap:";
            // 
            // cboEndCap
            // 
            this.cboEndCap.FormattingEnabled = true;
            this.cboEndCap.Location = new System.Drawing.Point(130, 299);
            this.cboEndCap.Margin = new System.Windows.Forms.Padding(4);
            this.cboEndCap.Name = "cboEndCap";
            this.cboEndCap.Size = new System.Drawing.Size(207, 36);
            this.cboEndCap.TabIndex = 11;
            this.cboEndCap.SelectedIndexChanged += new System.EventHandler(this.cboEndCap_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 302);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "End Cap:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 354);
            this.Controls.Add(this.pnlDraw);
            this.Controls.Add(this.pnelControls);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Pen Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnelControls.ResumeLayout(false);
            this.pnelControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnelControls;
        private System.Windows.Forms.FlowLayoutPanel pnlDraw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEndCap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboStartCap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboDashCap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboLineJoin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDashStyle;
    }
}

