namespace GUI
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
            System.Windows.Forms.Label lbl_first;
            System.Windows.Forms.Label lbl_last;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_first = new System.Windows.Forms.TextBox();
            this.tb_last = new System.Windows.Forms.TextBox();
            this.btn_calculatePrimes = new System.Windows.Forms.Button();
            this.lb_list = new System.Windows.Forms.ListBox();
            lbl_first = new System.Windows.Forms.Label();
            lbl_last = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_first
            // 
            lbl_first.AutoSize = true;
            lbl_first.BackColor = System.Drawing.Color.Transparent;
            lbl_first.Font = new System.Drawing.Font("Aleo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_first.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lbl_first.Location = new System.Drawing.Point(145, 119);
            lbl_first.Name = "lbl_first";
            lbl_first.Size = new System.Drawing.Size(220, 29);
            lbl_first.TabIndex = 0;
            lbl_first.Text = "Enter first number:";
            // 
            // lbl_last
            // 
            lbl_last.AutoSize = true;
            lbl_last.BackColor = System.Drawing.Color.Transparent;
            lbl_last.Font = new System.Drawing.Font("Aleo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_last.Location = new System.Drawing.Point(145, 241);
            lbl_last.Name = "lbl_last";
            lbl_last.Size = new System.Drawing.Size(215, 29);
            lbl_last.TabIndex = 1;
            lbl_last.Text = "Enter last number:";
            // 
            // tb_first
            // 
            this.tb_first.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_first.Location = new System.Drawing.Point(186, 173);
            this.tb_first.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_first.Name = "tb_first";
            this.tb_first.Size = new System.Drawing.Size(114, 35);
            this.tb_first.TabIndex = 2;
            // 
            // tb_last
            // 
            this.tb_last.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_last.Location = new System.Drawing.Point(186, 291);
            this.tb_last.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_last.Name = "tb_last";
            this.tb_last.Size = new System.Drawing.Size(114, 35);
            this.tb_last.TabIndex = 3;
            // 
            // btn_calculatePrimes
            // 
            this.btn_calculatePrimes.Font = new System.Drawing.Font("Aleo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_calculatePrimes.Location = new System.Drawing.Point(115, 365);
            this.btn_calculatePrimes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_calculatePrimes.Name = "btn_calculatePrimes";
            this.btn_calculatePrimes.Size = new System.Drawing.Size(269, 66);
            this.btn_calculatePrimes.TabIndex = 4;
            this.btn_calculatePrimes.Text = "Calculate prime numbers";
            this.btn_calculatePrimes.UseVisualStyleBackColor = true;
            this.btn_calculatePrimes.Click += new System.EventHandler(this.btn_calculatePrimes_Click);
            // 
            // lb_list
            // 
            this.lb_list.DisplayMember = "70";
            this.lb_list.Font = new System.Drawing.Font("Aleo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_list.FormattingEnabled = true;
            this.lb_list.ItemHeight = 29;
            this.lb_list.Location = new System.Drawing.Point(488, 119);
            this.lb_list.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_list.Name = "lb_list";
            this.lb_list.Size = new System.Drawing.Size(141, 294);
            this.lb_list.TabIndex = 5;
            this.lb_list.ValueMember = "70";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(736, 575);
            this.Controls.Add(this.lb_list);
            this.Controls.Add(this.btn_calculatePrimes);
            this.Controls.Add(this.tb_last);
            this.Controls.Add(this.tb_first);
            this.Controls.Add(lbl_last);
            this.Controls.Add(lbl_first);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_first;
        private TextBox tb_last;
        private Button btn_calculatePrimes;
        private ListBox lb_list;
    }
}