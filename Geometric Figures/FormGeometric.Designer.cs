
namespace Geometric_Figures
{
    partial class FormGeometric
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.numHoogte = new System.Windows.Forms.NumericUpDown();
            this.numBreedte = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRechthoek = new System.Windows.Forms.Button();
            this.btnDriehoek = new System.Windows.Forms.Button();
            this.btnVierkant = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numHoogte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBreedte)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(305, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(232, 134);
            this.listBox1.TabIndex = 0;
            // 
            // numHoogte
            // 
            this.numHoogte.Location = new System.Drawing.Point(100, 52);
            this.numHoogte.Name = "numHoogte";
            this.numHoogte.Size = new System.Drawing.Size(162, 20);
            this.numHoogte.TabIndex = 1;
            // 
            // numBreedte
            // 
            this.numBreedte.Location = new System.Drawing.Point(100, 94);
            this.numBreedte.Name = "numBreedte";
            this.numBreedte.Size = new System.Drawing.Size(162, 20);
            this.numBreedte.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Breedte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hoogte";
            // 
            // btnRechthoek
            // 
            this.btnRechthoek.Location = new System.Drawing.Point(25, 138);
            this.btnRechthoek.Name = "btnRechthoek";
            this.btnRechthoek.Size = new System.Drawing.Size(75, 23);
            this.btnRechthoek.TabIndex = 6;
            this.btnRechthoek.Text = "Rechthoek";
            this.btnRechthoek.UseVisualStyleBackColor = true;
            this.btnRechthoek.Click += new System.EventHandler(this.btnRechthoek_Click);
            // 
            // btnDriehoek
            // 
            this.btnDriehoek.Location = new System.Drawing.Point(187, 138);
            this.btnDriehoek.Name = "btnDriehoek";
            this.btnDriehoek.Size = new System.Drawing.Size(75, 23);
            this.btnDriehoek.TabIndex = 7;
            this.btnDriehoek.Text = "Driehoek";
            this.btnDriehoek.UseVisualStyleBackColor = true;
            this.btnDriehoek.Click += new System.EventHandler(this.btnDriehoek_Click);
            // 
            // btnVierkant
            // 
            this.btnVierkant.Location = new System.Drawing.Point(106, 138);
            this.btnVierkant.Name = "btnVierkant";
            this.btnVierkant.Size = new System.Drawing.Size(75, 23);
            this.btnVierkant.TabIndex = 8;
            this.btnVierkant.Text = "Vierkant";
            this.btnVierkant.UseVisualStyleBackColor = true;
            this.btnVierkant.Click += new System.EventHandler(this.btnVierkant_Click);
            // 
            // FormGeometric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 215);
            this.Controls.Add(this.btnVierkant);
            this.Controls.Add(this.btnDriehoek);
            this.Controls.Add(this.btnRechthoek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numBreedte);
            this.Controls.Add(this.numHoogte);
            this.Controls.Add(this.listBox1);
            this.Name = "FormGeometric";
            this.Text = "Geometric Figures";
            ((System.ComponentModel.ISupportInitialize)(this.numHoogte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBreedte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown numHoogte;
        private System.Windows.Forms.NumericUpDown numBreedte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRechthoek;
        private System.Windows.Forms.Button btnDriehoek;
        private System.Windows.Forms.Button btnVierkant;
    }
}

