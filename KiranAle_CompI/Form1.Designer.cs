namespace KiranAle_CompI
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
            this.Pnl_Draw = new System.Windows.Forms.Panel();
            this.txt_cmd = new System.Windows.Forms.TextBox();
            this.btn_run = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_StartPosY = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_StartPosX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.txt_multiCmd = new System.Windows.Forms.TextBox();
            this.btn_exec = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Draw
            // 
            this.Pnl_Draw.BackColor = System.Drawing.SystemColors.Info;
            this.Pnl_Draw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pnl_Draw.Location = new System.Drawing.Point(0, 81);
            this.Pnl_Draw.Name = "Pnl_Draw";
            this.Pnl_Draw.Size = new System.Drawing.Size(500, 317);
            this.Pnl_Draw.TabIndex = 0;
            this.Pnl_Draw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pnl_Draw_MouseClick);
            // 
            // txt_cmd
            // 
            this.txt_cmd.Location = new System.Drawing.Point(0, 414);
            this.txt_cmd.Multiline = true;
            this.txt_cmd.Name = "txt_cmd";
            this.txt_cmd.Size = new System.Drawing.Size(500, 20);
            this.txt_cmd.TabIndex = 1;
            this.txt_cmd.TextChanged += new System.EventHandler(this.txt_cmd_TextChanged);
            // 
            // btn_run
            // 
            this.btn_run.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_run.Location = new System.Drawing.Point(529, 414);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(100, 23);
            this.btn_run.TabIndex = 2;
            this.btn_run.Text = "Run";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_StartPosY);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_StartPosX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 55);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Postion";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbl_StartPosY
            // 
            this.lbl_StartPosY.AutoSize = true;
            this.lbl_StartPosY.Location = new System.Drawing.Point(102, 27);
            this.lbl_StartPosY.Name = "lbl_StartPosY";
            this.lbl_StartPosY.Size = new System.Drawing.Size(25, 13);
            this.lbl_StartPosY.TabIndex = 7;
            this.lbl_StartPosY.Text = "000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "X";
            // 
            // lbl_StartPosX
            // 
            this.lbl_StartPosX.AutoSize = true;
            this.lbl_StartPosX.Location = new System.Drawing.Point(26, 27);
            this.lbl_StartPosX.Name = "lbl_StartPosX";
            this.lbl_StartPosX.Size = new System.Drawing.Size(25, 13);
            this.lbl_StartPosX.TabIndex = 5;
            this.lbl_StartPosX.Text = "000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(82, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Y";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // txt_multiCmd
            // 
            this.txt_multiCmd.Location = new System.Drawing.Point(529, 81);
            this.txt_multiCmd.Multiline = true;
            this.txt_multiCmd.Name = "txt_multiCmd";
            this.txt_multiCmd.Size = new System.Drawing.Size(214, 327);
            this.txt_multiCmd.TabIndex = 5;
            // 
            // btn_exec
            // 
            this.btn_exec.Location = new System.Drawing.Point(643, 414);
            this.btn_exec.Name = "btn_exec";
            this.btn_exec.Size = new System.Drawing.Size(100, 23);
            this.btn_exec.TabIndex = 6;
            this.btn_exec.Text = "Execute";
            this.btn_exec.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1200, 593);
            this.Controls.Add(this.btn_exec);
            this.Controls.Add(this.txt_multiCmd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.txt_cmd);
            this.Controls.Add(this.Pnl_Draw);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Graphical Programming Application";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Draw;
        private System.Windows.Forms.TextBox txt_cmd;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_StartPosY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_StartPosX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox txt_multiCmd;
        private System.Windows.Forms.Button btn_exec;
    }
}

