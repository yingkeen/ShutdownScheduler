using System;

namespace ShutdownScheduler
{
    partial class Shutdown
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
            this.lblMinutes = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clOptions = new System.Windows.Forms.CheckedListBox();
            this.btnAbort = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.numMinutes = new System.Windows.Forms.NumericUpDown();
            this.rbShutdown = new System.Windows.Forms.RadioButton();
            this.rbRestart = new System.Windows.Forms.RadioButton();
            this.rbLogOff = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(16, 33);
            this.lblMinutes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(67, 17);
            this.lblMinutes.TabIndex = 1;
            this.lblMinutes.Text = "Minute(s)";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.clOptions);
            this.panel2.Location = new System.Drawing.Point(173, 73);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 118);
            this.panel2.TabIndex = 5;
            // 
            // clOptions
            // 
            this.clOptions.FormattingEnabled = true;
            this.clOptions.Location = new System.Drawing.Point(4, 7);
            this.clOptions.Margin = new System.Windows.Forms.Padding(4);
            this.clOptions.Name = "clOptions";
            this.clOptions.Size = new System.Drawing.Size(125, 89);
            this.clOptions.TabIndex = 0;
            // 
            // btnAbort
            // 
            this.btnAbort.BackColor = System.Drawing.Color.Red;
            this.btnAbort.ForeColor = System.Drawing.Color.White;
            this.btnAbort.Location = new System.Drawing.Point(40, 207);
            this.btnAbort.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(115, 31);
            this.btnAbort.TabIndex = 6;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = false;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(173, 207);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(115, 31);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // numMinutes
            // 
            this.numMinutes.Location = new System.Drawing.Point(91, 31);
            this.numMinutes.Margin = new System.Windows.Forms.Padding(4);
            this.numMinutes.Name = "numMinutes";
            this.numMinutes.Size = new System.Drawing.Size(93, 22);
            this.numMinutes.TabIndex = 8;
            // 
            // rbShutdown
            // 
            this.rbShutdown.AutoSize = true;
            this.rbShutdown.Location = new System.Drawing.Point(9, 15);
            this.rbShutdown.Margin = new System.Windows.Forms.Padding(4);
            this.rbShutdown.Name = "rbShutdown";
            this.rbShutdown.Size = new System.Drawing.Size(91, 21);
            this.rbShutdown.TabIndex = 2;
            this.rbShutdown.Text = "Shutdown";
            this.rbShutdown.UseVisualStyleBackColor = true;
            this.rbShutdown.Checked = true;
            // 
            // rbRestart
            // 
            this.rbRestart.AutoSize = true;
            this.rbRestart.Location = new System.Drawing.Point(9, 43);
            this.rbRestart.Margin = new System.Windows.Forms.Padding(4);
            this.rbRestart.Name = "rbRestart";
            this.rbRestart.Size = new System.Drawing.Size(75, 21);
            this.rbRestart.TabIndex = 3;
            this.rbRestart.Text = "Restart";
            this.rbRestart.UseVisualStyleBackColor = true;
            // 
            // rbLogOff
            // 
            this.rbLogOff.AutoSize = true;
            this.rbLogOff.Location = new System.Drawing.Point(9, 71);
            this.rbLogOff.Margin = new System.Windows.Forms.Padding(4);
            this.rbLogOff.Name = "rbLogOff";
            this.rbLogOff.Size = new System.Drawing.Size(73, 21);
            this.rbLogOff.TabIndex = 4;
            this.rbLogOff.Text = "Log off";
            this.rbLogOff.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbLogOff);
            this.panel1.Controls.Add(this.rbRestart);
            this.panel1.Controls.Add(this.rbShutdown);
            this.panel1.Location = new System.Drawing.Point(20, 73);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 118);
            this.panel1.TabIndex = 4;
            // 
            // Shutdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 262);
            this.Controls.Add(this.numMinutes);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Shutdown";
            this.Text = "Shutdown";
            this.Load += new System.EventHandler(this.Shutdown_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckedListBox clOptions;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.NumericUpDown numMinutes;
        private System.Windows.Forms.RadioButton rbShutdown;
        private System.Windows.Forms.RadioButton rbRestart;
        private System.Windows.Forms.RadioButton rbLogOff;
        private System.Windows.Forms.Panel panel1;
    }
}

