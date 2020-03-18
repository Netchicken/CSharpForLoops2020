namespace CSharpForLoops2020
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
            this.btnGo = new System.Windows.Forms.Button();
            this.lbxLoop = new System.Windows.Forms.ListBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtUpperLimit = new System.Windows.Forms.TextBox();
            this.btnGoForEach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(511, 44);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(144, 61);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lbxLoop
            // 
            this.lbxLoop.FormattingEnabled = true;
            this.lbxLoop.ItemHeight = 16;
            this.lbxLoop.Location = new System.Drawing.Point(12, 29);
            this.lbxLoop.Name = "lbxLoop";
            this.lbxLoop.Size = new System.Drawing.Size(493, 324);
            this.lbxLoop.TabIndex = 1;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(525, 141);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(148, 22);
            this.txtNumber.TabIndex = 2;
            // 
            // txtUpperLimit
            // 
            this.txtUpperLimit.Location = new System.Drawing.Point(525, 193);
            this.txtUpperLimit.Name = "txtUpperLimit";
            this.txtUpperLimit.Size = new System.Drawing.Size(148, 22);
            this.txtUpperLimit.TabIndex = 3;
            // 
            // btnGoForEach
            // 
            this.btnGoForEach.Location = new System.Drawing.Point(511, 240);
            this.btnGoForEach.Name = "btnGoForEach";
            this.btnGoForEach.Size = new System.Drawing.Size(144, 61);
            this.btnGoForEach.TabIndex = 4;
            this.btnGoForEach.Text = "Go ForEach";
            this.btnGoForEach.UseVisualStyleBackColor = true;
            this.btnGoForEach.Click += new System.EventHandler(this.btnGoForEach_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.btnGoForEach);
            this.Controls.Add(this.txtUpperLimit);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lbxLoop);
            this.Controls.Add(this.btnGo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ListBox lbxLoop;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtUpperLimit;
        private System.Windows.Forms.Button btnGoForEach;
    }
}

