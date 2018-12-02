namespace Race
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.DomBukmacherski = new System.Windows.Forms.GroupBox();
            this.startButton = new System.Windows.Forms.Button();
            this.NumericDog = new System.Windows.Forms.NumericUpDown();
            this.NumericMoney = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Stawia = new System.Windows.Forms.Button();
            this.LabelArek = new System.Windows.Forms.Label();
            this.LabelBartek = new System.Windows.Forms.Label();
            this.BetterLabel = new System.Windows.Forms.Label();
            this.LabelJanek = new System.Windows.Forms.Label();
            this.RadioArek = new System.Windows.Forms.RadioButton();
            this.RadioBartek = new System.Windows.Forms.RadioButton();
            this.RadioJanek = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.finishLine = new System.Windows.Forms.PictureBox();
            this.raceTrack = new System.Windows.Forms.PictureBox();
            this.DomBukmacherski.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // DomBukmacherski
            // 
            this.DomBukmacherski.Controls.Add(this.startButton);
            this.DomBukmacherski.Controls.Add(this.NumericDog);
            this.DomBukmacherski.Controls.Add(this.NumericMoney);
            this.DomBukmacherski.Controls.Add(this.label1);
            this.DomBukmacherski.Controls.Add(this.Stawia);
            this.DomBukmacherski.Controls.Add(this.LabelArek);
            this.DomBukmacherski.Controls.Add(this.LabelBartek);
            this.DomBukmacherski.Controls.Add(this.BetterLabel);
            this.DomBukmacherski.Controls.Add(this.LabelJanek);
            this.DomBukmacherski.Controls.Add(this.RadioArek);
            this.DomBukmacherski.Controls.Add(this.RadioBartek);
            this.DomBukmacherski.Controls.Add(this.RadioJanek);
            this.DomBukmacherski.Location = new System.Drawing.Point(2, 208);
            this.DomBukmacherski.Name = "DomBukmacherski";
            this.DomBukmacherski.Size = new System.Drawing.Size(599, 200);
            this.DomBukmacherski.TabIndex = 0;
            this.DomBukmacherski.TabStop = false;
            this.DomBukmacherski.Text = "DomBukmacherski";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(451, 66);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(116, 64);
            this.startButton.TabIndex = 11;
            this.startButton.Text = "Start!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // NumericDog
            // 
            this.NumericDog.Location = new System.Drawing.Point(381, 162);
            this.NumericDog.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NumericDog.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericDog.Name = "NumericDog";
            this.NumericDog.Size = new System.Drawing.Size(70, 20);
            this.NumericDog.TabIndex = 10;
            this.NumericDog.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumericMoney
            // 
            this.NumericMoney.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumericMoney.Location = new System.Drawing.Point(198, 162);
            this.NumericMoney.Name = "NumericMoney";
            this.NumericMoney.Size = new System.Drawing.Size(51, 20);
            this.NumericMoney.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "zł na charta numer";
            // 
            // Stawia
            // 
            this.Stawia.Location = new System.Drawing.Point(102, 159);
            this.Stawia.Name = "Stawia";
            this.Stawia.Size = new System.Drawing.Size(75, 23);
            this.Stawia.TabIndex = 7;
            this.Stawia.Text = "stawia";
            this.Stawia.UseVisualStyleBackColor = true;
            this.Stawia.Click += new System.EventHandler(this.Stawia_Click);
            // 
            // LabelArek
            // 
            this.LabelArek.AutoSize = true;
            this.LabelArek.Location = new System.Drawing.Point(237, 115);
            this.LabelArek.Name = "LabelArek";
            this.LabelArek.Size = new System.Drawing.Size(35, 13);
            this.LabelArek.TabIndex = 6;
            this.LabelArek.Text = "label2";
            // 
            // LabelBartek
            // 
            this.LabelBartek.AutoSize = true;
            this.LabelBartek.Location = new System.Drawing.Point(237, 79);
            this.LabelBartek.Name = "LabelBartek";
            this.LabelBartek.Size = new System.Drawing.Size(35, 13);
            this.LabelBartek.TabIndex = 5;
            this.LabelBartek.Text = "label1";
            // 
            // BetterLabel
            // 
            this.BetterLabel.AutoSize = true;
            this.BetterLabel.Location = new System.Drawing.Point(19, 164);
            this.BetterLabel.Name = "BetterLabel";
            this.BetterLabel.Size = new System.Drawing.Size(35, 13);
            this.BetterLabel.TabIndex = 4;
            this.BetterLabel.Text = "label1";
            // 
            // LabelJanek
            // 
            this.LabelJanek.AutoSize = true;
            this.LabelJanek.Location = new System.Drawing.Point(237, 37);
            this.LabelJanek.Name = "LabelJanek";
            this.LabelJanek.Size = new System.Drawing.Size(35, 13);
            this.LabelJanek.TabIndex = 3;
            this.LabelJanek.Text = "label1";
            // 
            // RadioArek
            // 
            this.RadioArek.AutoSize = true;
            this.RadioArek.Location = new System.Drawing.Point(19, 113);
            this.RadioArek.Name = "RadioArek";
            this.RadioArek.Size = new System.Drawing.Size(85, 17);
            this.RadioArek.TabIndex = 2;
            this.RadioArek.TabStop = true;
            this.RadioArek.Text = "radioButton3";
            this.RadioArek.UseVisualStyleBackColor = true;
            this.RadioArek.CheckedChanged += new System.EventHandler(this.RadioArek_CheckedChanged);
            // 
            // RadioBartek
            // 
            this.RadioBartek.AutoSize = true;
            this.RadioBartek.Location = new System.Drawing.Point(19, 75);
            this.RadioBartek.Name = "RadioBartek";
            this.RadioBartek.Size = new System.Drawing.Size(85, 17);
            this.RadioBartek.TabIndex = 1;
            this.RadioBartek.TabStop = true;
            this.RadioBartek.Text = "radioButton2";
            this.RadioBartek.UseVisualStyleBackColor = true;
            this.RadioBartek.CheckedChanged += new System.EventHandler(this.RadioBartek_CheckedChanged);
            // 
            // RadioJanek
            // 
            this.RadioJanek.AutoSize = true;
            this.RadioJanek.Location = new System.Drawing.Point(19, 35);
            this.RadioJanek.Name = "RadioJanek";
            this.RadioJanek.Size = new System.Drawing.Size(85, 17);
            this.RadioJanek.TabIndex = 0;
            this.RadioJanek.TabStop = true;
            this.RadioJanek.Text = "radioButton1";
            this.RadioJanek.UseVisualStyleBackColor = true;
            this.RadioJanek.CheckedChanged += new System.EventHandler(this.RadioJanek_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\Lenovo\\Desktop\\dog.png";
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 25);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ImageLocation = "C:\\Users\\Lenovo\\Desktop\\dog.png";
            this.pictureBox2.Location = new System.Drawing.Point(12, 58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 22);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.ImageLocation = "C:\\Users\\Lenovo\\Desktop\\dog.png";
            this.pictureBox3.Location = new System.Drawing.Point(12, 111);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(73, 22);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.ImageLocation = "C:\\Users\\Lenovo\\Desktop\\dog.png";
            this.pictureBox4.Location = new System.Drawing.Point(12, 164);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(73, 21);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // finishLine
            // 
            this.finishLine.Location = new System.Drawing.Point(688, 12);
            this.finishLine.Name = "finishLine";
            this.finishLine.Size = new System.Drawing.Size(100, 279);
            this.finishLine.TabIndex = 5;
            this.finishLine.TabStop = false;
            // 
            // raceTrack
            // 
            this.raceTrack.ImageLocation = "C:\\Users\\Lenovo\\Desktop\\racetrack.png";
            this.raceTrack.Location = new System.Drawing.Point(2, 0);
            this.raceTrack.Name = "raceTrack";
            this.raceTrack.Size = new System.Drawing.Size(599, 202);
            this.raceTrack.TabIndex = 6;
            this.raceTrack.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 407);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DomBukmacherski);
            this.Controls.Add(this.raceTrack);
            this.Controls.Add(this.finishLine);
            this.Name = "Form1";
            this.Text = "Form1";
            this.DomBukmacherski.ResumeLayout(false);
            this.DomBukmacherski.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DomBukmacherski;
        private System.Windows.Forms.RadioButton RadioArek;
        private System.Windows.Forms.RadioButton RadioBartek;
        private System.Windows.Forms.RadioButton RadioJanek;
        private System.Windows.Forms.Label LabelJanek;
        private System.Windows.Forms.Label BetterLabel;
        private System.Windows.Forms.Label LabelArek;
        private System.Windows.Forms.Label LabelBartek;
        private System.Windows.Forms.NumericUpDown NumericDog;
        private System.Windows.Forms.NumericUpDown NumericMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Stawia;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox finishLine;
        private System.Windows.Forms.PictureBox raceTrack;
    }
}

