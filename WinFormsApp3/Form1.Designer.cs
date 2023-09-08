namespace WinFormsApp3
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
            label1 = new System.Windows.Forms.Label();
            txtb1 = new System.Windows.Forms.TextBox();
            lbl = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(63, 57);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(132, 21);
            label1.TabIndex = 0;
            label1.Text = "¿Cuál es su edad?";
            // 
            // txtb1
            // 
            txtb1.Location = new System.Drawing.Point(221, 59);
            txtb1.Name = "txtb1";
            txtb1.Size = new System.Drawing.Size(50, 23);
            txtb1.TabIndex = 1;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl.Location = new System.Drawing.Point(221, 127);
            lbl.Name = "lbl";
            lbl.Size = new System.Drawing.Size(17, 21);
            lbl.TabIndex = 2;
            lbl.Text = "?";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(119, 122);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(64, 26);
            button1.TabIndex = 3;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(416, 450);
            Controls.Add(button1);
            Controls.Add(lbl);
            Controls.Add(txtb1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button button1;
    }
}
