
namespace Dierentuin
{
    partial class FormDierentuin
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnUil = new System.Windows.Forms.Button();
            this.btnTijger = new System.Windows.Forms.Button();
            this.btnAap = new System.Windows.Forms.Button();
            this.btnPin = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnGewicht = new System.Windows.Forms.Button();
            this.lblGewicht = new System.Windows.Forms.Label();
            this.btnPraat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblApen = new System.Windows.Forms.Label();
            this.lblTijgers = new System.Windows.Forms.Label();
            this.lblPins = new System.Windows.Forms.Label();
            this.lblUilen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(284, 81);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 108);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dieren Toevoegen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnUil
            // 
            this.btnUil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUil.Location = new System.Drawing.Point(16, 82);
            this.btnUil.Name = "btnUil";
            this.btnUil.Size = new System.Drawing.Size(108, 52);
            this.btnUil.TabIndex = 2;
            this.btnUil.Text = "UIL";
            this.btnUil.UseVisualStyleBackColor = true;
            this.btnUil.Click += new System.EventHandler(this.btnUil_Click);
            // 
            // btnTijger
            // 
            this.btnTijger.Location = new System.Drawing.Point(130, 145);
            this.btnTijger.Name = "btnTijger";
            this.btnTijger.Size = new System.Drawing.Size(108, 52);
            this.btnTijger.TabIndex = 6;
            this.btnTijger.Text = "TIJGER";
            this.btnTijger.UseVisualStyleBackColor = true;
            this.btnTijger.Click += new System.EventHandler(this.btnTijger_Click);
            // 
            // btnAap
            // 
            this.btnAap.Location = new System.Drawing.Point(130, 82);
            this.btnAap.Name = "btnAap";
            this.btnAap.Size = new System.Drawing.Size(108, 52);
            this.btnAap.TabIndex = 10;
            this.btnAap.Text = "AAP";
            this.btnAap.UseVisualStyleBackColor = true;
            this.btnAap.Click += new System.EventHandler(this.btnAap_Click);
            // 
            // btnPin
            // 
            this.btnPin.Location = new System.Drawing.Point(16, 145);
            this.btnPin.Name = "btnPin";
            this.btnPin.Size = new System.Drawing.Size(108, 52);
            this.btnPin.TabIndex = 9;
            this.btnPin.Text = "PINGUÏN";
            this.btnPin.UseVisualStyleBackColor = true;
            this.btnPin.Click += new System.EventHandler(this.btnPin_Click);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(444, 40);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(108, 23);
            this.btnVerwijder.TabIndex = 15;
            this.btnVerwijder.Text = "Dier Verwijderen";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(558, 40);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(108, 23);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnGewicht
            // 
            this.btnGewicht.Location = new System.Drawing.Point(444, 69);
            this.btnGewicht.Name = "btnGewicht";
            this.btnGewicht.Size = new System.Drawing.Size(336, 23);
            this.btnGewicht.TabIndex = 17;
            this.btnGewicht.Text = "Bereken Gemiddelde Gewicht";
            this.btnGewicht.UseVisualStyleBackColor = true;
            this.btnGewicht.Click += new System.EventHandler(this.btnGewicht_Click);
            // 
            // lblGewicht
            // 
            this.lblGewicht.AutoSize = true;
            this.lblGewicht.Location = new System.Drawing.Point(441, 98);
            this.lblGewicht.Name = "lblGewicht";
            this.lblGewicht.Size = new System.Drawing.Size(153, 91);
            this.lblGewicht.TabIndex = 18;
            this.lblGewicht.Text = "Gemiddelde Gewicht Apen:\r\n\r\nGemiddelde Gewicht Uilen:\r\n\r\nGemiddelde Gewicht Pingu" +
    "ïns:\r\n\r\nGemiddelde Gewicht Tijgers:";
            // 
            // btnPraat
            // 
            this.btnPraat.Location = new System.Drawing.Point(672, 40);
            this.btnPraat.Name = "btnPraat";
            this.btnPraat.Size = new System.Drawing.Size(108, 23);
            this.btnPraat.TabIndex = 19;
            this.btnPraat.Text = "Praat";
            this.btnPraat.UseVisualStyleBackColor = true;
            this.btnPraat.Click += new System.EventHandler(this.btnPraat_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 31);
            this.label2.TabIndex = 20;
            this.label2.Text = "DIERENTUIN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblApen
            // 
            this.lblApen.AutoSize = true;
            this.lblApen.Location = new System.Drawing.Point(631, 98);
            this.lblApen.Name = "lblApen";
            this.lblApen.Size = new System.Drawing.Size(13, 13);
            this.lblApen.TabIndex = 21;
            this.lblApen.Text = "0";
            // 
            // lblTijgers
            // 
            this.lblTijgers.AutoSize = true;
            this.lblTijgers.Location = new System.Drawing.Point(631, 176);
            this.lblTijgers.Name = "lblTijgers";
            this.lblTijgers.Size = new System.Drawing.Size(13, 13);
            this.lblTijgers.TabIndex = 22;
            this.lblTijgers.Text = "0";
            // 
            // lblPins
            // 
            this.lblPins.AutoSize = true;
            this.lblPins.Location = new System.Drawing.Point(631, 150);
            this.lblPins.Name = "lblPins";
            this.lblPins.Size = new System.Drawing.Size(13, 13);
            this.lblPins.TabIndex = 23;
            this.lblPins.Text = "0";
            // 
            // lblUilen
            // 
            this.lblUilen.AutoSize = true;
            this.lblUilen.Location = new System.Drawing.Point(631, 124);
            this.lblUilen.Name = "lblUilen";
            this.lblUilen.Size = new System.Drawing.Size(13, 13);
            this.lblUilen.TabIndex = 24;
            this.lblUilen.Text = "0";
            // 
            // FormDierentuin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 230);
            this.Controls.Add(this.lblUilen);
            this.Controls.Add(this.lblPins);
            this.Controls.Add(this.lblTijgers);
            this.Controls.Add(this.lblApen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPraat);
            this.Controls.Add(this.lblGewicht);
            this.Controls.Add(this.btnGewicht);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.btnAap);
            this.Controls.Add(this.btnPin);
            this.Controls.Add(this.btnTijger);
            this.Controls.Add(this.btnUil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "FormDierentuin";
            this.Text = "Dierentuin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUil;
        private System.Windows.Forms.Button btnTijger;
        private System.Windows.Forms.Button btnAap;
        private System.Windows.Forms.Button btnPin;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnGewicht;
        private System.Windows.Forms.Label lblGewicht;
        private System.Windows.Forms.Button btnPraat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblApen;
        private System.Windows.Forms.Label lblTijgers;
        private System.Windows.Forms.Label lblPins;
        private System.Windows.Forms.Label lblUilen;
    }
}

