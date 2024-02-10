namespace C__Winform_Radio_Group
{
    partial class Form1
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
            radioPetY = new RadioButton();
            radioPetN = new RadioButton();
            radioPetMale = new RadioButton();
            radioPetFemale = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // radioPetY
            // 
            radioPetY.AutoSize = true;
            radioPetY.Location = new Point(6, 22);
            radioPetY.Name = "radioPetY";
            radioPetY.Size = new Size(49, 19);
            radioPetY.TabIndex = 0;
            radioPetY.TabStop = true;
            radioPetY.Text = "있음";
            radioPetY.UseVisualStyleBackColor = true;
            radioPetY.CheckedChanged += radioPetY_CheckedChanged;
            // 
            // radioPetN
            // 
            radioPetN.AutoSize = true;
            radioPetN.Location = new Point(6, 47);
            radioPetN.Name = "radioPetN";
            radioPetN.Size = new Size(49, 19);
            radioPetN.TabIndex = 1;
            radioPetN.TabStop = true;
            radioPetN.Text = "없음";
            radioPetN.UseVisualStyleBackColor = true;
            radioPetN.CheckedChanged += radioPetN_CheckedChanged;
            // 
            // radioPetMale
            // 
            radioPetMale.AutoSize = true;
            radioPetMale.Location = new Point(6, 22);
            radioPetMale.Name = "radioPetMale";
            radioPetMale.Size = new Size(49, 19);
            radioPetMale.TabIndex = 2;
            radioPetMale.TabStop = true;
            radioPetMale.Text = "수컷";
            radioPetMale.UseVisualStyleBackColor = true;
            radioPetMale.CheckedChanged += radioPetMale_CheckedChanged;
            // 
            // radioPetFemale
            // 
            radioPetFemale.AutoSize = true;
            radioPetFemale.Location = new Point(6, 47);
            radioPetFemale.Name = "radioPetFemale";
            radioPetFemale.Size = new Size(49, 19);
            radioPetFemale.TabIndex = 3;
            radioPetFemale.TabStop = true;
            radioPetFemale.Text = "암컷";
            radioPetFemale.UseVisualStyleBackColor = true;
            radioPetFemale.CheckedChanged += radioPetFemale_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioPetY);
            groupBox1.Controls.Add(radioPetN);
            groupBox1.Location = new Point(21, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(122, 83);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "애완동물 유무";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioPetMale);
            groupBox2.Controls.Add(radioPetFemale);
            groupBox2.Location = new Point(21, 109);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(122, 80);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "애완동물 성별";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 67);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 198);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioPetY;
        private RadioButton radioPetN;
        private RadioButton radioPetMale;
        private RadioButton radioPetFemale;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
    }
}