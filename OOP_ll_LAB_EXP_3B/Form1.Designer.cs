namespace OOP_ll_LAB_EXP_3B
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonRot3 = new System.Windows.Forms.RadioButton();
            this.radioButtonCeaser = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.CipherLabel = new System.Windows.Forms.Label();
            this.CipherTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CipheredText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuccessLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonRot3
            // 
            this.radioButtonRot3.AutoSize = true;
            this.radioButtonRot3.Location = new System.Drawing.Point(394, 68);
            this.radioButtonRot3.Name = "radioButtonRot3";
            this.radioButtonRot3.Size = new System.Drawing.Size(78, 28);
            this.radioButtonRot3.TabIndex = 0;
            this.radioButtonRot3.TabStop = true;
            this.radioButtonRot3.Text = "ROT3";
            this.radioButtonRot3.UseVisualStyleBackColor = true;
            // 
            // radioButtonCeaser
            // 
            this.radioButtonCeaser.AutoSize = true;
            this.radioButtonCeaser.Location = new System.Drawing.Point(394, 137);
            this.radioButtonCeaser.Name = "radioButtonCeaser";
            this.radioButtonCeaser.Size = new System.Drawing.Size(149, 28);
            this.radioButtonCeaser.TabIndex = 1;
            this.radioButtonCeaser.TabStop = true;
            this.radioButtonCeaser.Text = "Ceaser Cipher";
            this.radioButtonCeaser.UseVisualStyleBackColor = true;
            this.radioButtonCeaser.CheckedChanged += new System.EventHandler(this.radioButtonCeaser_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pasword:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(33, 68);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(248, 29);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // CipherLabel
            // 
            this.CipherLabel.AutoSize = true;
            this.CipherLabel.Location = new System.Drawing.Point(29, 137);
            this.CipherLabel.Name = "CipherLabel";
            this.CipherLabel.Size = new System.Drawing.Size(122, 24);
            this.CipherLabel.TabIndex = 4;
            this.CipherLabel.Text = "Cipher Code:";
            // 
            // CipherTextBox
            // 
            this.CipherTextBox.Location = new System.Drawing.Point(33, 190);
            this.CipherTextBox.Name = "CipherTextBox";
            this.CipherTextBox.Size = new System.Drawing.Size(248, 29);
            this.CipherTextBox.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.CipheredText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SuccessLabel);
            this.groupBox1.Location = new System.Drawing.Point(357, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 114);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // CipheredText
            // 
            this.CipheredText.AutoSize = true;
            this.CipheredText.Location = new System.Drawing.Point(126, 75);
            this.CipheredText.Name = "CipheredText";
            this.CipheredText.Size = new System.Drawing.Size(60, 24);
            this.CipheredText.TabIndex = 2;
            this.CipheredText.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "CIPHER:";
            // 
            // SuccessLabel
            // 
            this.SuccessLabel.AutoSize = true;
            this.SuccessLabel.Location = new System.Drawing.Point(88, 25);
            this.SuccessLabel.Name = "SuccessLabel";
            this.SuccessLabel.Size = new System.Drawing.Size(98, 24);
            this.SuccessLabel.TabIndex = 0;
            this.SuccessLabel.Text = "SUCCESS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(654, 346);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CipherTextBox);
            this.Controls.Add(this.CipherLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonCeaser);
            this.Controls.Add(this.radioButtonRot3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonRot3;
        private System.Windows.Forms.RadioButton radioButtonCeaser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label CipherLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label CipheredText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SuccessLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CipherTextBox;
    }
}

