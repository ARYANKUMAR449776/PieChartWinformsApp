namespace BarGraphFinalAssignment
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
            btnDrawChart = new Button();
            txtInput = new TextBox();
            panelChart = new Panel();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnDrawChart
            // 
            btnDrawChart.Location = new Point(268, 106);
            btnDrawChart.Name = "btnDrawChart";
            btnDrawChart.Size = new Size(94, 29);
            btnDrawChart.TabIndex = 0;
            btnDrawChart.Text = "Draw Chart";
            btnDrawChart.UseVisualStyleBackColor = true;
            btnDrawChart.Click += btnDrawChart_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(236, 66);
            txtInput.Name = "txtInput";
            txtInput.PlaceholderText = "Enter Numbers (x,y,z...)";
            txtInput.Size = new Size(157, 27);
            txtInput.TabIndex = 1;
            // 
            // panelChart
            // 
            panelChart.Location = new Point(12, 147);
            panelChart.Name = "panelChart";
            panelChart.Size = new Size(607, 325);
            panelChart.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(172, 9);
            label1.Name = "label1";
            label1.Size = new Size(292, 41);
            label1.TabIndex = 3;
            label1.Text = "Pie Chart Generator";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(627, 484);
            Controls.Add(label1);
            Controls.Add(panelChart);
            Controls.Add(txtInput);
            Controls.Add(btnDrawChart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDrawChart;
        private TextBox txtInput;
        private Panel panelChart;
        private Label label1;
    }
}
