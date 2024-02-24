namespace Resim_Görüntüleme
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
            pcBox = new PictureBox();
            txtId = new TextBox();
            btnBaglan = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pcBox).BeginInit();
            SuspendLayout();
            // 
            // pcBox
            // 
            pcBox.Location = new Point(1, 74);
            pcBox.Name = "pcBox";
            pcBox.Size = new Size(223, 159);
            pcBox.TabIndex = 0;
            pcBox.TabStop = false;
            // 
            // txtId
            // 
            txtId.Location = new Point(123, 12);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            // 
            // btnBaglan
            // 
            btnBaglan.Location = new Point(0, 45);
            btnBaglan.Name = "btnBaglan";
            btnBaglan.Size = new Size(223, 23);
            btnBaglan.TabIndex = 2;
            btnBaglan.Text = "Veri Getir";
            btnBaglan.UseVisualStyleBackColor = true;
            btnBaglan.Click += btnBaglan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 15);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 3;
            label1.Text = "Ürün Id değeri giriniz";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(236, 262);
            Controls.Add(label1);
            Controls.Add(btnBaglan);
            Controls.Add(txtId);
            Controls.Add(pcBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pcBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcBox;
        private TextBox txtId;
        private Button btnBaglan;
        private Label label1;
    }
}