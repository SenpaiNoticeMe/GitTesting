﻿namespace Shiritori
{
    partial class mGame
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
            this.components = new System.ComponentModel.Container();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.p1_score = new System.Windows.Forms.Label();
            this.deadclock = new System.Windows.Forms.ProgressBar();
            this.deadtimer = new System.Windows.Forms.Timer(this.components);
            this.lblprev = new System.Windows.Forms.Label();
            this.lblpword = new System.Windows.Forms.Label();
            this.lblround = new System.Windows.Forms.Label();
            this.lblroundNo = new System.Windows.Forms.Label();
            this.lblp1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.p2_score = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(197, 194);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(99, 40);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtword
            // 
            this.txtword.Location = new System.Drawing.Point(16, 148);
            this.txtword.Margin = new System.Windows.Forms.Padding(4);
            this.txtword.Name = "txtword";
            this.txtword.Size = new System.Drawing.Size(475, 27);
            this.txtword.TabIndex = 1;
            this.txtword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtword_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter word:";
            // 
            // p1_score
            // 
            this.p1_score.AutoSize = true;
            this.p1_score.Location = new System.Drawing.Point(11, 278);
            this.p1_score.Name = "p1_score";
            this.p1_score.Size = new System.Drawing.Size(81, 19);
            this.p1_score.TabIndex = 4;
            this.p1_score.Text = "000000000";
            // 
            // deadclock
            // 
            this.deadclock.Location = new System.Drawing.Point(12, 346);
            this.deadclock.Name = "deadclock";
            this.deadclock.Size = new System.Drawing.Size(480, 23);
            this.deadclock.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.deadclock.TabIndex = 5;
            this.deadclock.Value = 100;
            // 
            // deadtimer
            // 
            this.deadtimer.Interval = 1000;
            this.deadtimer.Tick += new System.EventHandler(this.deadtimer_Tick);
            // 
            // lblprev
            // 
            this.lblprev.AutoSize = true;
            this.lblprev.Location = new System.Drawing.Point(364, 9);
            this.lblprev.Name = "lblprev";
            this.lblprev.Size = new System.Drawing.Size(114, 19);
            this.lblprev.TabIndex = 6;
            this.lblprev.Text = "Previous Word:";
            // 
            // lblpword
            // 
            this.lblpword.AutoSize = true;
            this.lblpword.Location = new System.Drawing.Point(401, 28);
            this.lblpword.Name = "lblpword";
            this.lblpword.Size = new System.Drawing.Size(33, 19);
            this.lblpword.TabIndex = 7;
            this.lblpword.Text = "n/a";
            this.lblpword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblround
            // 
            this.lblround.AutoSize = true;
            this.lblround.Location = new System.Drawing.Point(225, 9);
            this.lblround.Name = "lblround";
            this.lblround.Size = new System.Drawing.Size(54, 19);
            this.lblround.TabIndex = 8;
            this.lblround.Text = "Round";
            // 
            // lblroundNo
            // 
            this.lblroundNo.AutoSize = true;
            this.lblroundNo.Location = new System.Drawing.Point(243, 28);
            this.lblroundNo.Name = "lblroundNo";
            this.lblroundNo.Size = new System.Drawing.Size(17, 19);
            this.lblroundNo.TabIndex = 9;
            this.lblroundNo.Text = "1";
            this.lblroundNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblp1
            // 
            this.lblp1.AutoSize = true;
            this.lblp1.Location = new System.Drawing.Point(12, 259);
            this.lblp1.Name = "lblp1";
            this.lblp1.Size = new System.Drawing.Size(68, 19);
            this.lblp1.TabIndex = 10;
            this.lblp1.Text = "Player 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Player 2:";
            // 
            // p2_score
            // 
            this.p2_score.AutoSize = true;
            this.p2_score.Location = new System.Drawing.Point(388, 278);
            this.p2_score.Name = "p2_score";
            this.p2_score.Size = new System.Drawing.Size(81, 19);
            this.p2_score.TabIndex = 4;
            this.p2_score.Text = "000000000";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "send";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // mGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 381);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblp1);
            this.Controls.Add(this.lblroundNo);
            this.Controls.Add(this.lblround);
            this.Controls.Add(this.lblpword);
            this.Controls.Add(this.lblprev);
            this.Controls.Add(this.deadclock);
            this.Controls.Add(this.p2_score);
            this.Controls.Add(this.p1_score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtword);
            this.Controls.Add(this.btnOk);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mGame";
            this.Text = "The Beginning of The End";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGame_FormClosed);
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnOk;
        public System.Windows.Forms.TextBox txtword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label p1_score;
        private System.Windows.Forms.ProgressBar deadclock;
        private System.Windows.Forms.Timer deadtimer;
        private System.Windows.Forms.Label lblprev;
        public System.Windows.Forms.Label lblpword;
        private System.Windows.Forms.Label lblround;
        private System.Windows.Forms.Label lblroundNo;
        private System.Windows.Forms.Label lblp1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label p2_score;
        private System.Windows.Forms.Button button1;
    }
}

