namespace CalStar
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button buttonConvert;
        private Button buttonBrowse;
        private TextBox txtInputFile;
        private Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            txtInputFile = new TextBox();
            buttonBrowse = new Button();
            buttonConvert = new Button();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            // 
            // txtInputFile
            // 
            txtInputFile.BorderStyle = BorderStyle.FixedSingle;
            txtInputFile.Location = new Point(43, 125);
            txtInputFile.Name = "txtInputFile";
            txtInputFile.Size = new Size(200, 23);
            txtInputFile.TabIndex = 0;
            // 
            // buttonBrowse
            // 
            buttonBrowse.Location = new Point(249, 123);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(85, 25);
            buttonBrowse.TabIndex = 1;
            buttonBrowse.Text = "Upload";
            buttonBrowse.UseVisualStyleBackColor = true;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // buttonConvert
            // 
            buttonConvert.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonConvert.Location = new Point(155, 193);
            buttonConvert.Name = "buttonConvert";
            buttonConvert.Size = new Size(88, 39);
            buttonConvert.TabIndex = 2;
            buttonConvert.Text = "Convert";
            buttonConvert.UseVisualStyleBackColor = true;
            buttonConvert.Click += buttonConvert_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(29, 59);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(314, 24);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Calstar to Cornerstone Converter";
            // 
            // Form1
            // 
            ClientSize = new Size(384, 361);
            Controls.Add(lblTitle);
            Controls.Add(buttonConvert);
            Controls.Add(buttonBrowse);
            Controls.Add(txtInputFile);
            MinimumSize = new Size(400, 400);
            Name = "Form1";
            Text = "Calstar Convertor";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
