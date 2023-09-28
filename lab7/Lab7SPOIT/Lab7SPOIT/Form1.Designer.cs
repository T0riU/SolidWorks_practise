namespace Lab7SPOIT
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CD = new System.Windows.Forms.Label();
            this.CH = new System.Windows.Forms.Label();
            this.CTL = new System.Windows.Forms.Label();
            this.CTD = new System.Windows.Forms.Label();
            this.UCL = new System.Windows.Forms.Label();
            this.UTD = new System.Windows.Forms.Label();
            this.NumCD = new System.Windows.Forms.NumericUpDown();
            this.NumCH = new System.Windows.Forms.NumericUpDown();
            this.NumUPL = new System.Windows.Forms.NumericUpDown();
            this.NumCTL = new System.Windows.Forms.NumericUpDown();
            this.NumCTD = new System.Windows.Forms.NumericUpDown();
            this.NumUTD = new System.Windows.Forms.NumericUpDown();
            this.BTN = new System.Windows.Forms.Button();
            this.repay1 = new System.Windows.Forms.Label();
            this.repay2 = new System.Windows.Forms.Label();
            this.RU = new System.Windows.Forms.CheckBox();
            this.RC = new System.Windows.Forms.CheckBox();
            this.fpath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumCD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUPL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCTL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCTD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUTD)).BeginInit();
            this.SuspendLayout();
            // 
            // CD
            // 
            this.CD.AutoSize = true;
            this.CD.Location = new System.Drawing.Point(12, 44);
            this.CD.Name = "CD";
            this.CD.Size = new System.Drawing.Size(114, 16);
            this.CD.TabIndex = 0;
            this.CD.Text = "Cylinder Diameter";
            // 
            // CH
            // 
            this.CH.AutoSize = true;
            this.CH.Location = new System.Drawing.Point(12, 79);
            this.CH.Name = "CH";
            this.CH.Size = new System.Drawing.Size(98, 16);
            this.CH.TabIndex = 0;
            this.CH.Text = "Cylinder Height";
            // 
            // CTL
            // 
            this.CTL.AutoSize = true;
            this.CTL.Location = new System.Drawing.Point(12, 159);
            this.CTL.Name = "CTL";
            this.CTL.Size = new System.Drawing.Size(145, 16);
            this.CTL.TabIndex = 0;
            this.CTL.Text = "Central Triangle Lenght";
            this.CTL.Click += new System.EventHandler(this.label1_Click);
            // 
            // CTD
            // 
            this.CTD.AutoSize = true;
            this.CTD.Location = new System.Drawing.Point(12, 190);
            this.CTD.Name = "CTD";
            this.CTD.Size = new System.Drawing.Size(151, 16);
            this.CTD.TabIndex = 0;
            this.CTD.Text = "Central Triangle Degree";
            // 
            // UCL
            // 
            this.UCL.AutoSize = true;
            this.UCL.Location = new System.Drawing.Point(12, 257);
            this.UCL.Name = "UCL";
            this.UCL.Size = new System.Drawing.Size(121, 16);
            this.UCL.TabIndex = 0;
            this.UCL.Text = "Up Triangle Lenght";
            this.UCL.Click += new System.EventHandler(this.label1_Click);
            // 
            // UTD
            // 
            this.UTD.AutoSize = true;
            this.UTD.Location = new System.Drawing.Point(12, 287);
            this.UTD.Name = "UTD";
            this.UTD.Size = new System.Drawing.Size(127, 16);
            this.UTD.TabIndex = 0;
            this.UTD.Text = "Up Triangle Degree";
            // 
            // NumCD
            // 
            this.NumCD.Location = new System.Drawing.Point(227, 38);
            this.NumCD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumCD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumCD.Name = "NumCD";
            this.NumCD.Size = new System.Drawing.Size(120, 22);
            this.NumCD.TabIndex = 1;
            this.NumCD.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumCD.ValueChanged += new System.EventHandler(this.NumCH_ValueChanged);
            // 
            // NumCH
            // 
            this.NumCH.Location = new System.Drawing.Point(227, 73);
            this.NumCH.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumCH.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumCH.Name = "NumCH";
            this.NumCH.Size = new System.Drawing.Size(120, 22);
            this.NumCH.TabIndex = 1;
            this.NumCH.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // NumUPL
            // 
            this.NumUPL.Location = new System.Drawing.Point(227, 251);
            this.NumUPL.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumUPL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUPL.Name = "NumUPL";
            this.NumUPL.Size = new System.Drawing.Size(120, 22);
            this.NumUPL.TabIndex = 1;
            this.NumUPL.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // NumCTL
            // 
            this.NumCTL.Location = new System.Drawing.Point(227, 153);
            this.NumCTL.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumCTL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumCTL.Name = "NumCTL";
            this.NumCTL.Size = new System.Drawing.Size(120, 22);
            this.NumCTL.TabIndex = 1;
            this.NumCTL.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // NumCTD
            // 
            this.NumCTD.Location = new System.Drawing.Point(227, 184);
            this.NumCTD.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.NumCTD.Name = "NumCTD";
            this.NumCTD.Size = new System.Drawing.Size(120, 22);
            this.NumCTD.TabIndex = 1;
            this.NumCTD.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // NumUTD
            // 
            this.NumUTD.Location = new System.Drawing.Point(227, 281);
            this.NumUTD.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.NumUTD.Name = "NumUTD";
            this.NumUTD.Size = new System.Drawing.Size(120, 22);
            this.NumUTD.TabIndex = 1;
            this.NumUTD.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // BTN
            // 
            this.BTN.Location = new System.Drawing.Point(668, 348);
            this.BTN.Name = "BTN";
            this.BTN.Size = new System.Drawing.Size(120, 90);
            this.BTN.TabIndex = 2;
            this.BTN.Text = "Change";
            this.BTN.UseVisualStyleBackColor = true;
            this.BTN.Click += new System.EventHandler(this.BTN_Click);
            // 
            // repay1
            // 
            this.repay1.AutoSize = true;
            this.repay1.Location = new System.Drawing.Point(17, 329);
            this.repay1.Name = "repay1";
            this.repay1.Size = new System.Drawing.Size(93, 16);
            this.repay1.TabIndex = 0;
            this.repay1.Text = "Repay Central";
            // 
            // repay2
            // 
            this.repay2.AutoSize = true;
            this.repay2.Location = new System.Drawing.Point(17, 366);
            this.repay2.Name = "repay2";
            this.repay2.Size = new System.Drawing.Size(89, 16);
            this.repay2.TabIndex = 0;
            this.repay2.Text = "Repay Upper";
            // 
            // RU
            // 
            this.RU.AutoSize = true;
            this.RU.Location = new System.Drawing.Point(219, 362);
            this.RU.Name = "RU";
            this.RU.Size = new System.Drawing.Size(18, 17);
            this.RU.TabIndex = 3;
            this.RU.UseVisualStyleBackColor = true;
            // 
            // RC
            // 
            this.RC.AutoSize = true;
            this.RC.Location = new System.Drawing.Point(219, 328);
            this.RC.Name = "RC";
            this.RC.Size = new System.Drawing.Size(18, 17);
            this.RC.TabIndex = 3;
            this.RC.UseVisualStyleBackColor = true;
            // 
            // fpath
            // 
            this.fpath.Location = new System.Drawing.Point(12, 416);
            this.fpath.Name = "fpath";
            this.fpath.Size = new System.Drawing.Size(653, 22);
            this.fpath.TabIndex = 4;
            this.fpath.Text = "C:\\Users\\olegr\\source\\repos\\Lab7SPOIT\\Lab7SPOIT\\bin\\Debug\\lab.xlsx";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fpath);
            this.Controls.Add(this.RC);
            this.Controls.Add(this.RU);
            this.Controls.Add(this.BTN);
            this.Controls.Add(this.NumUTD);
            this.Controls.Add(this.NumCTD);
            this.Controls.Add(this.NumCTL);
            this.Controls.Add(this.NumUPL);
            this.Controls.Add(this.NumCH);
            this.Controls.Add(this.NumCD);
            this.Controls.Add(this.UTD);
            this.Controls.Add(this.CTD);
            this.Controls.Add(this.UCL);
            this.Controls.Add(this.CTL);
            this.Controls.Add(this.CH);
            this.Controls.Add(this.repay2);
            this.Controls.Add(this.repay1);
            this.Controls.Add(this.CD);
            this.Name = "Form1";
            this.Text = "ADD to Excel";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumCD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUPL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCTL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCTD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUTD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CD;
        private System.Windows.Forms.Label CH;
        private System.Windows.Forms.Label CTL;
        private System.Windows.Forms.Label CTD;
        private System.Windows.Forms.Label UCL;
        private System.Windows.Forms.Label UTD;
        private System.Windows.Forms.NumericUpDown NumCD;
        private System.Windows.Forms.NumericUpDown NumCH;
        private System.Windows.Forms.NumericUpDown NumUPL;
        private System.Windows.Forms.NumericUpDown NumCTL;
        private System.Windows.Forms.NumericUpDown NumCTD;
        private System.Windows.Forms.NumericUpDown NumUTD;
        private System.Windows.Forms.Button BTN;
        private System.Windows.Forms.Label repay1;
        private System.Windows.Forms.Label repay2;
        private System.Windows.Forms.CheckBox RU;
        private System.Windows.Forms.CheckBox RC;
        private System.Windows.Forms.TextBox fpath;
    }
}

