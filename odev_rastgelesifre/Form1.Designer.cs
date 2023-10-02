namespace odev_rastgelesifre
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
            label1 = new Label();
            cboxKucukHarf = new CheckBox();
            cboxBuyukHarf = new CheckBox();
            cboxRakam = new CheckBox();
            cboxOzel = new CheckBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            btnSifreUret = new Button();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(105, 21);
            label1.TabIndex = 0;
            label1.Text = "Parametreler";
            // 
            // cboxKucukHarf
            // 
            cboxKucukHarf.AutoSize = true;
            cboxKucukHarf.Location = new Point(18, 60);
            cboxKucukHarf.Name = "cboxKucukHarf";
            cboxKucukHarf.Size = new Size(83, 19);
            cboxKucukHarf.TabIndex = 1;
            cboxKucukHarf.Text = "Küçük harf";
            cboxKucukHarf.UseVisualStyleBackColor = true;
            // 
            // cboxBuyukHarf
            // 
            cboxBuyukHarf.AutoSize = true;
            cboxBuyukHarf.Location = new Point(18, 96);
            cboxBuyukHarf.Name = "cboxBuyukHarf";
            cboxBuyukHarf.Size = new Size(83, 19);
            cboxBuyukHarf.TabIndex = 2;
            cboxBuyukHarf.Text = "Büyük harf";
            cboxBuyukHarf.UseVisualStyleBackColor = true;
            // 
            // cboxRakam
            // 
            cboxRakam.AutoSize = true;
            cboxRakam.Location = new Point(18, 132);
            cboxRakam.Name = "cboxRakam";
            cboxRakam.Size = new Size(62, 19);
            cboxRakam.TabIndex = 3;
            cboxRakam.Text = "Rakam";
            cboxRakam.UseVisualStyleBackColor = true;
            // 
            // cboxOzel
            // 
            cboxOzel.AutoSize = true;
            cboxOzel.Location = new Point(17, 163);
            cboxOzel.Name = "cboxOzel";
            cboxOzel.Size = new Size(94, 19);
            cboxOzel.TabIndex = 4;
            cboxOzel.Text = "Özel karakter";
            cboxOzel.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(115, 210);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 5;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(115, 251);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 6;
            // 
            // btnSifreUret
            // 
            btnSifreUret.Location = new Point(89, 332);
            btnSifreUret.Name = "btnSifreUret";
            btnSifreUret.Size = new Size(160, 68);
            btnSifreUret.TabIndex = 7;
            btnSifreUret.Text = "Üret";
            btnSifreUret.UseVisualStyleBackColor = true;
            btnSifreUret.Click += btnSifreUret_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 212);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 8;
            label2.Text = "Şifre uzunluğu : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 253);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 8;
            label3.Text = "Şifre sayısı  : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 467);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSifreUret);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(cboxOzel);
            Controls.Add(cboxRakam);
            Controls.Add(cboxBuyukHarf);
            Controls.Add(cboxKucukHarf);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox cboxKucukHarf;
        private CheckBox cboxBuyukHarf;
        private CheckBox cboxRakam;
        private CheckBox cboxOzel;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Button btnSifreUret;
        private Label label2;
        private Label label3;
    }
}