namespace Minesweeper
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnTemp = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_boom = new System.Windows.Forms.Label();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BtnTemp);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(244, 261);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // BtnTemp
            // 
            this.BtnTemp.BackColor = System.Drawing.Color.Pink;
            this.BtnTemp.ForeColor = System.Drawing.Color.Gray;
            this.BtnTemp.Location = new System.Drawing.Point(3, 3);
            this.BtnTemp.Name = "BtnTemp";
            this.BtnTemp.Size = new System.Drawing.Size(40, 40);
            this.BtnTemp.TabIndex = 0;
            this.BtnTemp.Text = "1";
            this.BtnTemp.UseVisualStyleBackColor = false;
            this.BtnTemp.Click += new System.EventHandler(this.btnTemp_Click);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Pink;
            this.btn_start.ForeColor = System.Drawing.Color.Gray;
            this.btn_start.Location = new System.Drawing.Point(279, 15);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(176, 29);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(299, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(299, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Boom!!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_boom
            // 
            this.lbl_boom.AutoSize = true;
            this.lbl_boom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_boom.ForeColor = System.Drawing.Color.Red;
            this.lbl_boom.Location = new System.Drawing.Point(371, 122);
            this.lbl_boom.Name = "lbl_boom";
            this.lbl_boom.Size = new System.Drawing.Size(23, 28);
            this.lbl_boom.TabIndex = 4;
            this.lbl_boom.Text = "0";
            // 
            // lbl_Score
            // 
            this.lbl_Score.AutoSize = true;
            this.lbl_Score.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Score.ForeColor = System.Drawing.Color.Pink;
            this.lbl_Score.Location = new System.Drawing.Point(371, 94);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(28, 28);
            this.lbl_Score.TabIndex = 5;
            this.lbl_Score.Text = "0 ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(483, 321);
            this.Controls.Add(this.lbl_Score);
            this.Controls.Add(this.lbl_boom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "Form1";
            this.Text = "Minesweeper";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button BtnTemp;
        private Button btn_start;
        private Label label1;
        private Label label2;
        private Label lbl_boom;
        private Label lbl_Score;
    }
}