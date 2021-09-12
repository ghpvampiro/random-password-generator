
namespace PasswordGenerator
{
    partial class Aplic
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
            this.textBoxLenght = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxRandomLenght = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxSpecialCharacters = new System.Windows.Forms.CheckBox();
            this.checkBoxDigits = new System.Windows.Forms.CheckBox();
            this.checkBoxLowercase = new System.Windows.Forms.CheckBox();
            this.checkBoxUppercase = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxLenght
            // 
            this.textBoxLenght.Location = new System.Drawing.Point(124, 22);
            this.textBoxLenght.Name = "textBoxLenght";
            this.textBoxLenght.Size = new System.Drawing.Size(69, 23);
            this.textBoxLenght.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lenght";
            // 
            // checkBoxRandomLenght
            // 
            this.checkBoxRandomLenght.AutoSize = true;
            this.checkBoxRandomLenght.Location = new System.Drawing.Point(226, 24);
            this.checkBoxRandomLenght.Name = "checkBoxRandomLenght";
            this.checkBoxRandomLenght.Size = new System.Drawing.Size(111, 19);
            this.checkBoxRandomLenght.TabIndex = 3;
            this.checkBoxRandomLenght.Text = "Random Lenght";
            this.checkBoxRandomLenght.UseVisualStyleBackColor = true;
            this.checkBoxRandomLenght.CheckedChanged += new System.EventHandler(this.checkBoxRandomLenght_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxSpecialCharacters);
            this.panel1.Controls.Add(this.checkBoxDigits);
            this.panel1.Controls.Add(this.checkBoxLowercase);
            this.panel1.Controls.Add(this.checkBoxUppercase);
            this.panel1.Location = new System.Drawing.Point(111, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 175);
            this.panel1.TabIndex = 4;
            // 
            // checkBoxSpecialCharacters
            // 
            this.checkBoxSpecialCharacters.AutoSize = true;
            this.checkBoxSpecialCharacters.Location = new System.Drawing.Point(13, 138);
            this.checkBoxSpecialCharacters.Name = "checkBoxSpecialCharacters";
            this.checkBoxSpecialCharacters.Size = new System.Drawing.Size(122, 19);
            this.checkBoxSpecialCharacters.TabIndex = 3;
            this.checkBoxSpecialCharacters.Text = "Special Characters";
            this.checkBoxSpecialCharacters.UseVisualStyleBackColor = true;
            // 
            // checkBoxDigits
            // 
            this.checkBoxDigits.AutoSize = true;
            this.checkBoxDigits.Location = new System.Drawing.Point(13, 98);
            this.checkBoxDigits.Name = "checkBoxDigits";
            this.checkBoxDigits.Size = new System.Drawing.Size(56, 19);
            this.checkBoxDigits.TabIndex = 2;
            this.checkBoxDigits.Text = "Digits";
            this.checkBoxDigits.UseVisualStyleBackColor = true;
            // 
            // checkBoxLowercase
            // 
            this.checkBoxLowercase.AutoSize = true;
            this.checkBoxLowercase.Location = new System.Drawing.Point(13, 56);
            this.checkBoxLowercase.Name = "checkBoxLowercase";
            this.checkBoxLowercase.Size = new System.Drawing.Size(119, 19);
            this.checkBoxLowercase.TabIndex = 1;
            this.checkBoxLowercase.Text = "Lowercase Letters";
            this.checkBoxLowercase.UseVisualStyleBackColor = true;
            // 
            // checkBoxUppercase
            // 
            this.checkBoxUppercase.AutoSize = true;
            this.checkBoxUppercase.Location = new System.Drawing.Point(13, 16);
            this.checkBoxUppercase.Name = "checkBoxUppercase";
            this.checkBoxUppercase.Size = new System.Drawing.Size(119, 19);
            this.checkBoxUppercase.TabIndex = 0;
            this.checkBoxUppercase.Text = "Uppercase Letters";
            this.checkBoxUppercase.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Choose your options";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(111, 338);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(161, 37);
            this.buttonGenerate.TabIndex = 6;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(278, 487);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 23);
            this.buttonCopy.TabIndex = 7;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(12, 491);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(88, 15);
            this.labelPassword.TabIndex = 8;
            this.labelPassword.Text = "...........................";
            // 
            // Aplic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 522);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBoxRandomLenght);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLenght);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Aplic";
            this.Text = "Password Generator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLenght;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxRandomLenght;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxSpecialCharacters;
        private System.Windows.Forms.CheckBox checkBoxDigits;
        private System.Windows.Forms.CheckBox checkBoxLowercase;
        private System.Windows.Forms.CheckBox checkBoxUppercase;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Label labelPassword;
    }
}

