namespace WindowsFormsApp1
{
    partial class Form1
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
            this.haystackBox = new System.Windows.Forms.RichTextBox();
            this.needleBox = new System.Windows.Forms.TextBox();
            this.needleLabel = new System.Windows.Forms.Label();
            this.haystackLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // haystackBox
            // 
            this.haystackBox.Location = new System.Drawing.Point(486, 61);
            this.haystackBox.Name = "haystackBox";
            this.haystackBox.Size = new System.Drawing.Size(520, 673);
            this.haystackBox.TabIndex = 0;
            this.haystackBox.Text = "";
            this.haystackBox.TextChanged += new System.EventHandler(this.haystackBox_TextChanged);
            // 
            // needleBox
            // 
            this.needleBox.Location = new System.Drawing.Point(102, 61);
            this.needleBox.Name = "needleBox";
            this.needleBox.Size = new System.Drawing.Size(285, 26);
            this.needleBox.TabIndex = 1;
            this.needleBox.TextChanged += new System.EventHandler(this.needleBox_TextChanged);
            // 
            // needleLabel
            // 
            this.needleLabel.Location = new System.Drawing.Point(197, 35);
            this.needleLabel.Name = "needleLabel";
            this.needleLabel.Size = new System.Drawing.Size(100, 23);
            this.needleLabel.TabIndex = 2;
            this.needleLabel.Text = "Запрос";
            this.needleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // haystackLabel
            // 
            this.haystackLabel.Location = new System.Drawing.Point(710, 35);
            this.haystackLabel.Name = "haystackLabel";
            this.haystackLabel.Size = new System.Drawing.Size(100, 23);
            this.haystackLabel.TabIndex = 3;
            this.haystackLabel.Text = "Строка";
            this.haystackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultLabel
            // 
            this.resultLabel.Location = new System.Drawing.Point(197, 139);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(100, 23);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "Результат";
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(12, 165);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(447, 558);
            this.resultBox.TabIndex = 5;
            this.resultBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 746);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.haystackLabel);
            this.Controls.Add(this.needleLabel);
            this.Controls.Add(this.needleBox);
            this.Controls.Add(this.haystackBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public System.Windows.Forms.RichTextBox resultBox;

        private System.Windows.Forms.Label resultLabel;

        private System.Windows.Forms.Label haystackLabel;

        private System.Windows.Forms.Label needleLabel;

        private System.Windows.Forms.RichTextBox haystackBox;
        private System.Windows.Forms.TextBox needleBox;

        #endregion
    }
}