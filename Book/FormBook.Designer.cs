
namespace Book
{
    partial class FormBook
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
            this.listBook = new System.Windows.Forms.ListBox();
            this.comboBook1 = new System.Windows.Forms.ComboBox();
            this.comboBook2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBook
            // 
            this.listBook.FormattingEnabled = true;
            this.listBook.Location = new System.Drawing.Point(12, 12);
            this.listBook.Name = "listBook";
            this.listBook.Size = new System.Drawing.Size(333, 199);
            this.listBook.TabIndex = 0;
            // 
            // comboBook1
            // 
            this.comboBook1.FormattingEnabled = true;
            this.comboBook1.Location = new System.Drawing.Point(379, 54);
            this.comboBook1.Name = "comboBook1";
            this.comboBook1.Size = new System.Drawing.Size(262, 21);
            this.comboBook1.TabIndex = 1;
            this.comboBook1.SelectedIndexChanged += new System.EventHandler(this.comboBook1_SelectedIndexChanged);
            // 
            // comboBook2
            // 
            this.comboBook2.FormattingEnabled = true;
            this.comboBook2.Location = new System.Drawing.Point(379, 153);
            this.comboBook2.Name = "comboBook2";
            this.comboBook2.Size = new System.Drawing.Size(262, 21);
            this.comboBook2.TabIndex = 2;
            this.comboBook2.SelectedIndexChanged += new System.EventHandler(this.comboBook2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 72);
            this.label1.TabIndex = 3;
            this.label1.Text = "Compare Books";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 218);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBook2);
            this.Controls.Add(this.comboBook1);
            this.Controls.Add(this.listBook);
            this.Name = "FormBook";
            this.Text = "Book";
            this.Load += new System.EventHandler(this.FormBook_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBook;
        private System.Windows.Forms.ComboBox comboBook1;
        private System.Windows.Forms.ComboBox comboBook2;
        private System.Windows.Forms.Label label1;
    }
}

