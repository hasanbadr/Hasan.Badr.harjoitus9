namespace Hasan.Badr.harjoitus9
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
            groupBox1 = new GroupBox();
            FahrenheitRB = new RadioButton();
            CelsiusRB = new RadioButton();
            label1 = new Label();
            AsteetTB = new TextBox();
            MuunnatBT = new Button();
            VastausLB = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(FahrenheitRB);
            groupBox1.Controls.Add(CelsiusRB);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(257, 37);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(183, 129);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Miten muunnat?";
            // 
            // FahrenheitRB
            // 
            FahrenheitRB.AutoSize = true;
            FahrenheitRB.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            FahrenheitRB.Location = new Point(19, 87);
            FahrenheitRB.Margin = new Padding(5);
            FahrenheitRB.Name = "FahrenheitRB";
            FahrenheitRB.Size = new Size(102, 24);
            FahrenheitRB.TabIndex = 1;
            FahrenheitRB.TabStop = true;
            FahrenheitRB.Text = "Fahrenheit";
            FahrenheitRB.UseVisualStyleBackColor = true;
            // 
            // CelsiusRB
            // 
            CelsiusRB.AutoSize = true;
            CelsiusRB.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CelsiusRB.Location = new Point(19, 45);
            CelsiusRB.Margin = new Padding(5);
            CelsiusRB.Name = "CelsiusRB";
            CelsiusRB.Size = new Size(75, 24);
            CelsiusRB.TabIndex = 0;
            CelsiusRB.TabStop = true;
            CelsiusRB.Text = "Celsius";
            CelsiusRB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 80);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 1;
            label1.Text = "Anna asteet:";
            // 
            // AsteetTB
            // 
            AsteetTB.Location = new Point(142, 80);
            AsteetTB.Name = "AsteetTB";
            AsteetTB.Size = new Size(100, 33);
            AsteetTB.TabIndex = 2;
            // 
            // MuunnatBT
            // 
            MuunnatBT.Location = new Point(465, 80);
            MuunnatBT.Name = "MuunnatBT";
            MuunnatBT.Size = new Size(102, 33);
            MuunnatBT.TabIndex = 3;
            MuunnatBT.Text = "Muunna";
            MuunnatBT.UseVisualStyleBackColor = true;
            MuunnatBT.Click += MuunnatBT_Click;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Location = new Point(19, 157);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(76, 25);
            VastausLB.TabIndex = 4;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 206);
            Controls.Add(VastausLB);
            Controls.Add(MuunnatBT);
            Controls.Add(AsteetTB);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton FahrenheitRB;
        private RadioButton CelsiusRB;
        private Label label1;
        private TextBox AsteetTB;
        private Button MuunnatBT;
        private Label VastausLB;
    }
}