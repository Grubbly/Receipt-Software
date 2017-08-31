namespace Receipt_Tally
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
            this.ChkTristan = new System.Windows.Forms.CheckBox();
            this.ChkCollin = new System.Windows.Forms.CheckBox();
            this.ChkRyan = new System.Windows.Forms.CheckBox();
            this.ChkTad = new System.Windows.Forms.CheckBox();
            this.Display = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTristan = new System.Windows.Forms.Label();
            this.LblCollin = new System.Windows.Forms.Label();
            this.LblRyan = new System.Windows.Forms.Label();
            this.LblTad = new System.Windows.Forms.Label();
            this.LblSplit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChkTristan
            // 
            this.ChkTristan.AutoSize = true;
            this.ChkTristan.Location = new System.Drawing.Point(35, 35);
            this.ChkTristan.Name = "ChkTristan";
            this.ChkTristan.Size = new System.Drawing.Size(58, 17);
            this.ChkTristan.TabIndex = 0;
            this.ChkTristan.Text = "Tristan";
            this.ChkTristan.UseVisualStyleBackColor = true;
            this.ChkTristan.CheckedChanged += new System.EventHandler(this.ChkTristan_CheckedChanged);
            // 
            // ChkCollin
            // 
            this.ChkCollin.AutoSize = true;
            this.ChkCollin.Location = new System.Drawing.Point(35, 58);
            this.ChkCollin.Name = "ChkCollin";
            this.ChkCollin.Size = new System.Drawing.Size(51, 17);
            this.ChkCollin.TabIndex = 1;
            this.ChkCollin.Text = "Collin";
            this.ChkCollin.UseVisualStyleBackColor = true;
            this.ChkCollin.CheckedChanged += new System.EventHandler(this.ChkCollin_CheckedChanged);
            // 
            // ChkRyan
            // 
            this.ChkRyan.AutoSize = true;
            this.ChkRyan.Location = new System.Drawing.Point(35, 81);
            this.ChkRyan.Name = "ChkRyan";
            this.ChkRyan.Size = new System.Drawing.Size(51, 17);
            this.ChkRyan.TabIndex = 2;
            this.ChkRyan.Text = "Ryan";
            this.ChkRyan.UseVisualStyleBackColor = true;
            this.ChkRyan.CheckedChanged += new System.EventHandler(this.ChkRyan_CheckedChanged);
            // 
            // ChkTad
            // 
            this.ChkTad.AutoSize = true;
            this.ChkTad.Location = new System.Drawing.Point(35, 104);
            this.ChkTad.Name = "ChkTad";
            this.ChkTad.Size = new System.Drawing.Size(45, 17);
            this.ChkTad.TabIndex = 3;
            this.ChkTad.Text = "Tad";
            this.ChkTad.UseVisualStyleBackColor = true;
            this.ChkTad.CheckedChanged += new System.EventHandler(this.ChkTad_CheckedChanged);
            // 
            // Display
            // 
            this.Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.Location = new System.Drawing.Point(137, 58);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(125, 30);
            this.Display.TabIndex = 4;
            this.Display.TextChanged += new System.EventHandler(this.Display_TextChanged);
            this.Display.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Display_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Running Totals";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTristan
            // 
            this.lblTristan.AutoSize = true;
            this.lblTristan.Location = new System.Drawing.Point(32, 148);
            this.lblTristan.Name = "lblTristan";
            this.lblTristan.Size = new System.Drawing.Size(45, 13);
            this.lblTristan.TabIndex = 6;
            this.lblTristan.Text = "Tristan: ";
            // 
            // LblCollin
            // 
            this.LblCollin.AutoSize = true;
            this.LblCollin.Location = new System.Drawing.Point(32, 176);
            this.LblCollin.Name = "LblCollin";
            this.LblCollin.Size = new System.Drawing.Size(35, 13);
            this.LblCollin.TabIndex = 7;
            this.LblCollin.Text = "Collin:";
            this.LblCollin.Click += new System.EventHandler(this.LblCollin_Click);
            // 
            // LblRyan
            // 
            this.LblRyan.AutoSize = true;
            this.LblRyan.Location = new System.Drawing.Point(32, 202);
            this.LblRyan.Name = "LblRyan";
            this.LblRyan.Size = new System.Drawing.Size(35, 13);
            this.LblRyan.TabIndex = 8;
            this.LblRyan.Text = "Ryan:";
            this.LblRyan.Click += new System.EventHandler(this.LblRyan_Click);
            // 
            // LblTad
            // 
            this.LblTad.AutoSize = true;
            this.LblTad.Location = new System.Drawing.Point(32, 230);
            this.LblTad.Name = "LblTad";
            this.LblTad.Size = new System.Drawing.Size(32, 13);
            this.LblTad.TabIndex = 9;
            this.LblTad.Text = "Tad: ";
            this.LblTad.Click += new System.EventHandler(this.LblTad_Click);
            // 
            // LblSplit
            // 
            this.LblSplit.AutoSize = true;
            this.LblSplit.Location = new System.Drawing.Point(137, 35);
            this.LblSplit.Name = "LblSplit";
            this.LblSplit.Size = new System.Drawing.Size(27, 13);
            this.LblSplit.TabIndex = 10;
            this.LblSplit.Text = "Split";
            this.LblSplit.Click += new System.EventHandler(this.LblSplit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LblSplit);
            this.Controls.Add(this.LblTad);
            this.Controls.Add(this.LblRyan);
            this.Controls.Add(this.LblCollin);
            this.Controls.Add(this.lblTristan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.ChkTad);
            this.Controls.Add(this.ChkRyan);
            this.Controls.Add(this.ChkCollin);
            this.Controls.Add(this.ChkTristan);
            this.Name = "Form1";
            this.Text = "Receipt Tally";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ChkTristan;
        private System.Windows.Forms.CheckBox ChkCollin;
        private System.Windows.Forms.CheckBox ChkRyan;
        private System.Windows.Forms.CheckBox ChkTad;
        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTristan;
        private System.Windows.Forms.Label LblCollin;
        private System.Windows.Forms.Label LblRyan;
        private System.Windows.Forms.Label LblTad;
        private System.Windows.Forms.Label LblSplit;
    }
}

