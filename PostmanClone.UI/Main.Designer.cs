namespace PostmanClone.UI
{
    partial class Main
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
            label1 = new Label();
            label2 = new Label();
            txtURL = new TextBox();
            btnCallAPI = new Button();
            txtResult = new TextBox();
            label3 = new Label();
            statusStrip1 = new StatusStrip();
            lblSystemStatus = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 79);
            label1.Name = "label1";
            label1.Size = new Size(86, 41);
            label1.TabIndex = 0;
            label1.Text = "URL :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 27);
            label2.Name = "label2";
            label2.Size = new Size(218, 41);
            label2.TabIndex = 1;
            label2.Text = "Postman Clone";
            // 
            // txtURL
            // 
            txtURL.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtURL.BorderStyle = BorderStyle.FixedSingle;
            txtURL.Location = new Point(128, 79);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(654, 47);
            txtURL.TabIndex = 2;
            // 
            // btnCallAPI
            // 
            btnCallAPI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCallAPI.BackColor = Color.OrangeRed;
            btnCallAPI.FlatAppearance.BorderSize = 0;
            btnCallAPI.FlatStyle = FlatStyle.Flat;
            btnCallAPI.ForeColor = Color.White;
            btnCallAPI.Location = new Point(788, 79);
            btnCallAPI.Name = "btnCallAPI";
            btnCallAPI.Size = new Size(94, 47);
            btnCallAPI.TabIndex = 3;
            btnCallAPI.Text = "Go";
            btnCallAPI.UseVisualStyleBackColor = false;
            // 
            // txtResult
            // 
            txtResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtResult.BorderStyle = BorderStyle.FixedSingle;
            txtResult.Location = new Point(128, 195);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(754, 304);
            txtResult.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 146);
            label3.Name = "label3";
            label3.Size = new Size(111, 41);
            label3.TabIndex = 5;
            label3.Text = "Results";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblSystemStatus });
            statusStrip1.Location = new Point(0, 519);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(954, 37);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblSystemStatus
            // 
            lblSystemStatus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSystemStatus.Name = "lblSystemStatus";
            lblSystemStatus.Size = new Size(76, 31);
            lblSystemStatus.Text = "Ready";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(954, 556);
            Controls.Add(statusStrip1);
            Controls.Add(label3);
            Controls.Add(txtResult);
            Controls.Add(btnCallAPI);
            Controls.Add(txtURL);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6);
            Name = "Main";
            Text = "Postman Clone";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtURL;
        private Button btnCallAPI;
        private TextBox txtResult;
        private Label label3;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblSystemStatus;
    }
}
