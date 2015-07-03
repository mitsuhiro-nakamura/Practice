namespace Cal
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Back = new System.Windows.Forms.Button();
            this.ClearEnd = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.cal7 = new System.Windows.Forms.Button();
            this.cal8 = new System.Windows.Forms.Button();
            this.cal9 = new System.Windows.Forms.Button();
            this.cal4 = new System.Windows.Forms.Button();
            this.cal5 = new System.Windows.Forms.Button();
            this.cal6 = new System.Windows.Forms.Button();
            this.cal1 = new System.Windows.Forms.Button();
            this.cal2 = new System.Windows.Forms.Button();
            this.cal3 = new System.Windows.Forms.Button();
            this.cal0 = new System.Windows.Forms.Button();
            this.plusOrMinus = new System.Windows.Forms.Button();
            this.syosu = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.not = new System.Windows.Forms.Button();
            this.fraction = new System.Windows.Forms.Button();
            this.icol = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.opeLabel = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.Label();
            this.smallZeroLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Back.Location = new System.Drawing.Point(12, 37);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(70, 22);
            this.Back.TabIndex = 1;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // ClearEnd
            // 
            this.ClearEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearEnd.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ClearEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClearEnd.Location = new System.Drawing.Point(82, 37);
            this.ClearEnd.Name = "ClearEnd";
            this.ClearEnd.Size = new System.Drawing.Size(70, 22);
            this.ClearEnd.TabIndex = 2;
            this.ClearEnd.Text = "CE";
            this.ClearEnd.UseVisualStyleBackColor = true;
            this.ClearEnd.Click += new System.EventHandler(this.ClearEnd_Click);
            // 
            // Clear
            // 
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Clear.Location = new System.Drawing.Point(152, 37);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(70, 22);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // cal7
            // 
            this.cal7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cal7.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cal7.ForeColor = System.Drawing.Color.Teal;
            this.cal7.Location = new System.Drawing.Point(14, 65);
            this.cal7.Name = "cal7";
            this.cal7.Size = new System.Drawing.Size(37, 48);
            this.cal7.TabIndex = 4;
            this.cal7.Text = "7";
            this.cal7.UseVisualStyleBackColor = true;
            this.cal7.Click += new System.EventHandler(this.cal7_Click);
            // 
            // cal8
            // 
            this.cal8.BackColor = System.Drawing.Color.Black;
            this.cal8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cal8.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cal8.ForeColor = System.Drawing.Color.Teal;
            this.cal8.Location = new System.Drawing.Point(56, 65);
            this.cal8.Name = "cal8";
            this.cal8.Size = new System.Drawing.Size(37, 48);
            this.cal8.TabIndex = 5;
            this.cal8.Text = "8";
            this.cal8.UseVisualStyleBackColor = false;
            this.cal8.Click += new System.EventHandler(this.cal8_Click);
            // 
            // cal9
            // 
            this.cal9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cal9.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cal9.ForeColor = System.Drawing.Color.Teal;
            this.cal9.Location = new System.Drawing.Point(99, 65);
            this.cal9.Name = "cal9";
            this.cal9.Size = new System.Drawing.Size(37, 48);
            this.cal9.TabIndex = 6;
            this.cal9.Text = "9";
            this.cal9.UseVisualStyleBackColor = true;
            this.cal9.Click += new System.EventHandler(this.cal9_Click);
            // 
            // cal4
            // 
            this.cal4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cal4.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cal4.ForeColor = System.Drawing.Color.Teal;
            this.cal4.Location = new System.Drawing.Point(14, 119);
            this.cal4.Name = "cal4";
            this.cal4.Size = new System.Drawing.Size(37, 48);
            this.cal4.TabIndex = 7;
            this.cal4.Text = "4";
            this.cal4.UseVisualStyleBackColor = true;
            this.cal4.Click += new System.EventHandler(this.cal4_Click);
            // 
            // cal5
            // 
            this.cal5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cal5.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cal5.ForeColor = System.Drawing.Color.Teal;
            this.cal5.Location = new System.Drawing.Point(56, 119);
            this.cal5.Name = "cal5";
            this.cal5.Size = new System.Drawing.Size(37, 48);
            this.cal5.TabIndex = 8;
            this.cal5.Text = "5";
            this.cal5.UseVisualStyleBackColor = true;
            this.cal5.Click += new System.EventHandler(this.cal5_Click);
            // 
            // cal6
            // 
            this.cal6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cal6.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cal6.ForeColor = System.Drawing.Color.Teal;
            this.cal6.Location = new System.Drawing.Point(99, 119);
            this.cal6.Name = "cal6";
            this.cal6.Size = new System.Drawing.Size(37, 48);
            this.cal6.TabIndex = 9;
            this.cal6.Text = "6";
            this.cal6.UseVisualStyleBackColor = true;
            this.cal6.Click += new System.EventHandler(this.cal6_Click);
            // 
            // cal1
            // 
            this.cal1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cal1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cal1.ForeColor = System.Drawing.Color.Teal;
            this.cal1.Location = new System.Drawing.Point(14, 173);
            this.cal1.Name = "cal1";
            this.cal1.Size = new System.Drawing.Size(37, 48);
            this.cal1.TabIndex = 10;
            this.cal1.Text = "1";
            this.cal1.UseVisualStyleBackColor = true;
            this.cal1.Click += new System.EventHandler(this.cal1_Click);
            // 
            // cal2
            // 
            this.cal2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cal2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cal2.ForeColor = System.Drawing.Color.Teal;
            this.cal2.Location = new System.Drawing.Point(56, 173);
            this.cal2.Name = "cal2";
            this.cal2.Size = new System.Drawing.Size(37, 48);
            this.cal2.TabIndex = 11;
            this.cal2.Text = "2";
            this.cal2.UseVisualStyleBackColor = true;
            this.cal2.Click += new System.EventHandler(this.cal2_Click);
            // 
            // cal3
            // 
            this.cal3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cal3.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cal3.ForeColor = System.Drawing.Color.Teal;
            this.cal3.Location = new System.Drawing.Point(99, 173);
            this.cal3.Name = "cal3";
            this.cal3.Size = new System.Drawing.Size(37, 48);
            this.cal3.TabIndex = 12;
            this.cal3.Text = "3";
            this.cal3.UseVisualStyleBackColor = true;
            this.cal3.Click += new System.EventHandler(this.cal3_Click);
            // 
            // cal0
            // 
            this.cal0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cal0.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cal0.ForeColor = System.Drawing.Color.Teal;
            this.cal0.Location = new System.Drawing.Point(14, 227);
            this.cal0.Name = "cal0";
            this.cal0.Size = new System.Drawing.Size(37, 48);
            this.cal0.TabIndex = 13;
            this.cal0.Text = "0";
            this.cal0.UseVisualStyleBackColor = true;
            this.cal0.Click += new System.EventHandler(this.cal0_Click);
            // 
            // plusOrMinus
            // 
            this.plusOrMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusOrMinus.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.plusOrMinus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.plusOrMinus.Location = new System.Drawing.Point(56, 227);
            this.plusOrMinus.Name = "plusOrMinus";
            this.plusOrMinus.Size = new System.Drawing.Size(37, 48);
            this.plusOrMinus.TabIndex = 14;
            this.plusOrMinus.Text = "+/-";
            this.plusOrMinus.UseVisualStyleBackColor = true;
            this.plusOrMinus.Click += new System.EventHandler(this.plusOrMinus_Click);
            // 
            // syosu
            // 
            this.syosu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.syosu.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.syosu.ForeColor = System.Drawing.Color.Teal;
            this.syosu.Location = new System.Drawing.Point(99, 227);
            this.syosu.Name = "syosu";
            this.syosu.Size = new System.Drawing.Size(37, 48);
            this.syosu.TabIndex = 15;
            this.syosu.Text = ".";
            this.syosu.UseVisualStyleBackColor = true;
            this.syosu.Click += new System.EventHandler(this.syosu_Click);
            // 
            // division
            // 
            this.division.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.division.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.division.ForeColor = System.Drawing.Color.Green;
            this.division.Location = new System.Drawing.Point(142, 65);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(37, 48);
            this.division.TabIndex = 16;
            this.division.Text = "÷";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // multiplication
            // 
            this.multiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplication.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.multiplication.ForeColor = System.Drawing.Color.Green;
            this.multiplication.Location = new System.Drawing.Point(142, 119);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(37, 48);
            this.multiplication.TabIndex = 17;
            this.multiplication.Text = "×";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // minus
            // 
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.minus.ForeColor = System.Drawing.Color.Green;
            this.minus.Location = new System.Drawing.Point(142, 173);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(37, 48);
            this.minus.TabIndex = 18;
            this.minus.Text = "－";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // plus
            // 
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.plus.ForeColor = System.Drawing.Color.Green;
            this.plus.Location = new System.Drawing.Point(142, 227);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(37, 48);
            this.plus.TabIndex = 19;
            this.plus.Text = "＋";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // sqrt
            // 
            this.sqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqrt.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sqrt.ForeColor = System.Drawing.Color.Green;
            this.sqrt.Location = new System.Drawing.Point(185, 65);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(37, 48);
            this.sqrt.TabIndex = 20;
            this.sqrt.Text = "√";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.sqrt_Click);
            // 
            // not
            // 
            this.not.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.not.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.not.ForeColor = System.Drawing.Color.Green;
            this.not.Location = new System.Drawing.Point(185, 119);
            this.not.Name = "not";
            this.not.Size = new System.Drawing.Size(37, 48);
            this.not.TabIndex = 21;
            this.not.Text = "％";
            this.not.UseVisualStyleBackColor = true;
            this.not.Click += new System.EventHandler(this.not_Click);
            // 
            // fraction
            // 
            this.fraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fraction.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fraction.ForeColor = System.Drawing.Color.Green;
            this.fraction.Location = new System.Drawing.Point(185, 173);
            this.fraction.Name = "fraction";
            this.fraction.Size = new System.Drawing.Size(37, 48);
            this.fraction.TabIndex = 22;
            this.fraction.Text = "1/x";
            this.fraction.UseVisualStyleBackColor = true;
            this.fraction.Click += new System.EventHandler(this.fraction_Click);
            // 
            // icol
            // 
            this.icol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icol.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.icol.ForeColor = System.Drawing.Color.White;
            this.icol.Location = new System.Drawing.Point(185, 227);
            this.icol.Name = "icol";
            this.icol.Size = new System.Drawing.Size(37, 48);
            this.icol.TabIndex = 23;
            this.icol.Text = "＝";
            this.icol.UseVisualStyleBackColor = true;
            this.icol.Click += new System.EventHandler(this.icol_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "label2";
            // 
            // opeLabel
            // 
            this.opeLabel.AutoSize = true;
            this.opeLabel.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.opeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.opeLabel.Location = new System.Drawing.Point(199, 7);
            this.opeLabel.Name = "opeLabel";
            this.opeLabel.Size = new System.Drawing.Size(18, 12);
            this.opeLabel.TabIndex = 26;
            this.opeLabel.Text = "＋";
            // 
            // answer
            // 
            this.answer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.answer.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.answer.ForeColor = System.Drawing.Color.Teal;
            this.answer.Location = new System.Drawing.Point(12, 7);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(181, 24);
            this.answer.TabIndex = 27;
            this.answer.Text = "num";
            this.answer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // smallZeroLabel
            // 
            this.smallZeroLabel.AutoSize = true;
            this.smallZeroLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.smallZeroLabel.Location = new System.Drawing.Point(183, 7);
            this.smallZeroLabel.Name = "smallZeroLabel";
            this.smallZeroLabel.Size = new System.Drawing.Size(11, 12);
            this.smallZeroLabel.TabIndex = 28;
            this.smallZeroLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(238, 285);
            this.Controls.Add(this.smallZeroLabel);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.opeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.icol);
            this.Controls.Add(this.fraction);
            this.Controls.Add(this.not);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.division);
            this.Controls.Add(this.syosu);
            this.Controls.Add(this.plusOrMinus);
            this.Controls.Add(this.cal0);
            this.Controls.Add(this.cal3);
            this.Controls.Add(this.cal2);
            this.Controls.Add(this.cal1);
            this.Controls.Add(this.cal6);
            this.Controls.Add(this.cal5);
            this.Controls.Add(this.cal4);
            this.Controls.Add(this.cal9);
            this.Controls.Add(this.cal8);
            this.Controls.Add(this.cal7);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.ClearEnd);
            this.Controls.Add(this.Back);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "電卓";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button ClearEnd;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button cal7;
        private System.Windows.Forms.Button cal8;
        private System.Windows.Forms.Button cal9;
        private System.Windows.Forms.Button cal4;
        private System.Windows.Forms.Button cal5;
        private System.Windows.Forms.Button cal6;
        private System.Windows.Forms.Button cal1;
        private System.Windows.Forms.Button cal2;
        private System.Windows.Forms.Button cal3;
        private System.Windows.Forms.Button cal0;
        private System.Windows.Forms.Button plusOrMinus;
        private System.Windows.Forms.Button syosu;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button not;
        private System.Windows.Forms.Button fraction;
        private System.Windows.Forms.Button icol;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label opeLabel;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.Label smallZeroLabel;
    }
}

