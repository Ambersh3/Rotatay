namespace Rotatay
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.rotateBtn = new System.Windows.Forms.Button();
            this.StopRotateBtn = new System.Windows.Forms.Button();
            this.ScreenInt = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenInt)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rotateBtn
            // 
            this.rotateBtn.AutoSize = true;
            this.rotateBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rotateBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.rotateBtn.Location = new System.Drawing.Point(10, 10);
            this.rotateBtn.Name = "rotateBtn";
            this.rotateBtn.Size = new System.Drawing.Size(82, 58);
            this.rotateBtn.TabIndex = 0;
            this.rotateBtn.Text = "Rotated";
            this.rotateBtn.UseVisualStyleBackColor = true;
            this.rotateBtn.Click += new System.EventHandler(this.rotateBtn_Click);
            // 
            // StopRotateBtn
            // 
            this.StopRotateBtn.AutoSize = true;
            this.StopRotateBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StopRotateBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.StopRotateBtn.Location = new System.Drawing.Point(92, 10);
            this.StopRotateBtn.Name = "StopRotateBtn";
            this.StopRotateBtn.Size = new System.Drawing.Size(82, 58);
            this.StopRotateBtn.TabIndex = 1;
            this.StopRotateBtn.Text = "Not\r\nRotated";
            this.StopRotateBtn.UseVisualStyleBackColor = true;
            this.StopRotateBtn.Click += new System.EventHandler(this.StopRotateBtn_Click);
            // 
            // ScreenInt
            // 
            this.ScreenInt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ScreenInt.AutoSize = true;
            this.ScreenInt.Location = new System.Drawing.Point(72, 3);
            this.ScreenInt.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ScreenInt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ScreenInt.Name = "ScreenInt";
            this.ScreenInt.Size = new System.Drawing.Size(34, 27);
            this.ScreenInt.TabIndex = 2;
            this.ScreenInt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ScreenInt.ValueChanged += new System.EventHandler(this.ScreenInt_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Screen";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.ScreenInt);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 68);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(332, 33);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(352, 111);
            this.Controls.Add(this.StopRotateBtn);
            this.Controls.Add(this.rotateBtn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Consolas", 12.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(25, 25);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(200, 150);
            this.Name = "MainFrm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Rotatay";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScreenInt)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rotateBtn;
        private System.Windows.Forms.Button StopRotateBtn;
        private System.Windows.Forms.NumericUpDown ScreenInt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}