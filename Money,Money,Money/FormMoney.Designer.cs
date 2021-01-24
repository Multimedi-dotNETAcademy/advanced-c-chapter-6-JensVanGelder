
namespace Money_Money_Money
{
    partial class FormMoney
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
            this.listRekening = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listRekening
            // 
            this.listRekening.FormattingEnabled = true;
            this.listRekening.Location = new System.Drawing.Point(12, 12);
            this.listRekening.Name = "listRekening";
            this.listRekening.Size = new System.Drawing.Size(390, 173);
            this.listRekening.TabIndex = 0;
            // 
            // FormMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 197);
            this.Controls.Add(this.listRekening);
            this.Name = "FormMoney";
            this.Text = "Money,Money,Money";
            this.Load += new System.EventHandler(this.FormMoney_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listRekening;
    }
}

