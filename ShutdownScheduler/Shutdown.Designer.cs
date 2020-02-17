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
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.clOptions = new System.Windows.Forms.CheckedListBox();
            this.btnAbort = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.numMinutes = new System.Windows.Forms.NumericUpDown();
            this.rbShutdown = new System.Windows.Forms.RadioButton();
            this.rbRestart = new System.Windows.Forms.RadioButton();
            this.rbLogOff = new System.Windows.Forms.RadioButton();
            this.pnlShutdownType = new System.Windows.Forms.Panel();
            this.pnlOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).BeginInit();
            this.pnlShutdownType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(24, 52);
            this.lblMinutes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(102, 25);
            this.lblMinutes.TabIndex = 1;
            this.lblMinutes.Text = "Minute(s)";
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.clOptions);
            this.pnlOptions.Location = new System.Drawing.Point(260, 114);
            this.pnlOptions.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(202, 184);
            this.pnlOptions.TabIndex = 5;
            // 
            // clOptions
            // 
            this.clOptions.FormattingEnabled = true;
            this.clOptions.Location = new System.Drawing.Point(6, 11);
            this.clOptions.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.clOptions.Name = "clOptions";
            this.clOptions.Size = new System.Drawing.Size(186, 134);
            this.clOptions.TabIndex = 0;
            // 
            // btnAbort
            // 
            this.btnAbort.BackColor = System.Drawing.Color.Red;
            this.btnAbort.ForeColor = System.Drawing.Color.White;
            this.btnAbort.Location = new System.Drawing.Point(60, 323);
            this.btnAbort.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(172, 48);
            this.btnAbort.TabIndex = 6;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = false;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(260, 323);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(172, 48);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // numMinutes
            // 
            this.numMinutes.Location = new System.Drawing.Point(136, 48);
            this.numMinutes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numMinutes.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numMinutes.Name = "numMinutes";
            this.numMinutes.Size = new System.Drawing.Size(140, 31);
            this.numMinutes.TabIndex = 8;
            // 
            // rbShutdown
            // 
            this.rbShutdown.AutoSize = true;
            this.rbShutdown.Checked = true;
            this.rbShutdown.Location = new System.Drawing.Point(14, 23);
            this.rbShutdown.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbShutdown.Name = "rbShutdown";
            this.rbShutdown.Size = new System.Drawing.Size(125, 29);
            this.rbShutdown.TabIndex = 2;
            this.rbShutdown.TabStop = true;
            this.rbShutdown.Text = "Shutdown";
            this.rbShutdown.UseVisualStyleBackColor = true;
            // 
            // rbRestart
            // 
            this.rbRestart.AutoSize = true;
            this.rbRestart.Location = new System.Drawing.Point(14, 67);
            this.rbRestart.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbRestart.Name = "rbRestart";
            this.rbRestart.Size = new System.Drawing.Size(99, 29);
            this.rbRestart.TabIndex = 3;
            this.rbRestart.Text = "Restart";
            this.rbRestart.UseVisualStyleBackColor = true;
            // 
            // rbLogOff
            // 
            this.rbLogOff.AutoSize = true;
            this.rbLogOff.Location = new System.Drawing.Point(14, 111);
            this.rbLogOff.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbLogOff.Name = "rbLogOff";
            this.rbLogOff.Size = new System.Drawing.Size(96, 29);
            this.rbLogOff.TabIndex = 4;
            this.rbLogOff.Text = "Log off";
            this.rbLogOff.UseVisualStyleBackColor = true;
            // 
            // pnlShutdownType
            // 
            this.pnlShutdownType.Controls.Add(this.rbLogOff);
            this.pnlShutdownType.Controls.Add(this.rbRestart);
            this.pnlShutdownType.Controls.Add(this.rbShutdown);
            this.pnlShutdownType.Location = new System.Drawing.Point(30, 114);
            this.pnlShutdownType.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlShutdownType.Name = "pnlShutdownType";
            this.pnlShutdownType.Size = new System.Drawing.Size(202, 184);
            this.pnlShutdownType.TabIndex = 4;
            // 
            // Shutdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 409);
            this.Controls.Add(this.numMinutes);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.pnlShutdownType);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Shutdown";
            this.Text = "Shutdown";
            this.Load += new System.EventHandler(this.Shutdown_Load);
            this.pnlOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).EndInit();
            this.pnlShutdownType.ResumeLayout(false);
            this.pnlShutdownType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.CheckedListBox clOptions;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.NumericUpDown numMinutes;
        private System.Windows.Forms.RadioButton rbShutdown;
        private System.Windows.Forms.RadioButton rbRestart;
        private System.Windows.Forms.RadioButton rbLogOff;
        private System.Windows.Forms.Panel pnlShutdownType;
    }
}

