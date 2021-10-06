
namespace CSharpPythonTest
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtPathPython = new System.Windows.Forms.TextBox();
            this.txtPathPic = new System.Windows.Forms.TextBox();
            this.lblPathPython = new System.Windows.Forms.Label();
            this.lblPathPic = new System.Windows.Forms.Label();
            this.cmdPathPython = new System.Windows.Forms.Button();
            this.cmdPahtPic = new System.Windows.Forms.Button();
            this.picPallet = new System.Windows.Forms.PictureBox();
            this.cmdRun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.cmdPyScriptPath = new System.Windows.Forms.Button();
            this.lblPyScriptPath = new System.Windows.Forms.Label();
            this.txtPyScriptPath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPallet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPathPython
            // 
            this.txtPathPython.Location = new System.Drawing.Point(146, 12);
            this.txtPathPython.Name = "txtPathPython";
            this.txtPathPython.Size = new System.Drawing.Size(472, 20);
            this.txtPathPython.TabIndex = 0;
            // 
            // txtPathPic
            // 
            this.txtPathPic.Location = new System.Drawing.Point(146, 38);
            this.txtPathPic.Name = "txtPathPic";
            this.txtPathPic.Size = new System.Drawing.Size(472, 20);
            this.txtPathPic.TabIndex = 1;
            // 
            // lblPathPython
            // 
            this.lblPathPython.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPathPython.Location = new System.Drawing.Point(12, 15);
            this.lblPathPython.Name = "lblPathPython";
            this.lblPathPython.Size = new System.Drawing.Size(128, 23);
            this.lblPathPython.TabIndex = 2;
            this.lblPathPython.Text = "Путь к python.exe:";
            this.lblPathPython.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPathPic
            // 
            this.lblPathPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPathPic.Location = new System.Drawing.Point(12, 41);
            this.lblPathPic.Name = "lblPathPic";
            this.lblPathPic.Size = new System.Drawing.Size(128, 17);
            this.lblPathPic.TabIndex = 3;
            this.lblPathPic.Text = "Путь к картинке:";
            this.lblPathPic.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmdPathPython
            // 
            this.cmdPathPython.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmdPathPython.Location = new System.Drawing.Point(635, 10);
            this.cmdPathPython.Name = "cmdPathPython";
            this.cmdPathPython.Size = new System.Drawing.Size(153, 23);
            this.cmdPathPython.TabIndex = 4;
            this.cmdPathPython.Text = "Выбрать";
            this.cmdPathPython.UseVisualStyleBackColor = true;
            this.cmdPathPython.Click += new System.EventHandler(this.cmdPathPython_Click);
            // 
            // cmdPahtPic
            // 
            this.cmdPahtPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmdPahtPic.Location = new System.Drawing.Point(635, 36);
            this.cmdPahtPic.Name = "cmdPahtPic";
            this.cmdPahtPic.Size = new System.Drawing.Size(153, 23);
            this.cmdPahtPic.TabIndex = 5;
            this.cmdPahtPic.Text = "Выбрать";
            this.cmdPahtPic.UseVisualStyleBackColor = true;
            this.cmdPahtPic.Click += new System.EventHandler(this.cmdPahtPic_Click);
            // 
            // picPallet
            // 
            this.picPallet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPallet.Location = new System.Drawing.Point(15, 88);
            this.picPallet.Name = "picPallet";
            this.picPallet.Size = new System.Drawing.Size(603, 271);
            this.picPallet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPallet.TabIndex = 6;
            this.picPallet.TabStop = false;
            // 
            // cmdRun
            // 
            this.cmdRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmdRun.Location = new System.Drawing.Point(635, 88);
            this.cmdRun.Name = "cmdRun";
            this.cmdRun.Size = new System.Drawing.Size(153, 271);
            this.cmdRun.TabIndex = 7;
            this.cmdRun.Text = "Анализировать";
            this.cmdRun.UseVisualStyleBackColor = true;
            this.cmdRun.Click += new System.EventHandler(this.cmdRun_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Результат:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(146, 379);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(642, 20);
            this.txtResult.TabIndex = 9;
            // 
            // cmdPyScriptPath
            // 
            this.cmdPyScriptPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmdPyScriptPath.Location = new System.Drawing.Point(635, 60);
            this.cmdPyScriptPath.Name = "cmdPyScriptPath";
            this.cmdPyScriptPath.Size = new System.Drawing.Size(153, 23);
            this.cmdPyScriptPath.TabIndex = 12;
            this.cmdPyScriptPath.Text = "Выбрать";
            this.cmdPyScriptPath.UseVisualStyleBackColor = true;
            this.cmdPyScriptPath.Click += new System.EventHandler(this.cmdPyScriptPath_Click);
            // 
            // lblPyScriptPath
            // 
            this.lblPyScriptPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPyScriptPath.Location = new System.Drawing.Point(12, 65);
            this.lblPyScriptPath.Name = "lblPyScriptPath";
            this.lblPyScriptPath.Size = new System.Drawing.Size(128, 17);
            this.lblPyScriptPath.TabIndex = 11;
            this.lblPyScriptPath.Text = "Путь к скрипту py:";
            this.lblPyScriptPath.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPyScriptPath
            // 
            this.txtPyScriptPath.Location = new System.Drawing.Point(146, 62);
            this.txtPyScriptPath.Name = "txtPyScriptPath";
            this.txtPyScriptPath.Size = new System.Drawing.Size(472, 20);
            this.txtPyScriptPath.TabIndex = 10;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.Controls.Add(this.cmdPyScriptPath);
            this.Controls.Add(this.lblPyScriptPath);
            this.Controls.Add(this.txtPyScriptPath);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdRun);
            this.Controls.Add(this.picPallet);
            this.Controls.Add(this.cmdPahtPic);
            this.Controls.Add(this.cmdPathPython);
            this.Controls.Add(this.lblPathPic);
            this.Controls.Add(this.lblPathPython);
            this.Controls.Add(this.txtPathPic);
            this.Controls.Add(this.txtPathPython);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 450);
            this.MinimumSize = new System.Drawing.Size(816, 450);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test C# and Python";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPallet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPathPython;
        private System.Windows.Forms.TextBox txtPathPic;
        private System.Windows.Forms.Label lblPathPython;
        private System.Windows.Forms.Label lblPathPic;
        private System.Windows.Forms.Button cmdPathPython;
        private System.Windows.Forms.Button cmdPahtPic;
        private System.Windows.Forms.PictureBox picPallet;
        private System.Windows.Forms.Button cmdRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button cmdPyScriptPath;
        private System.Windows.Forms.Label lblPyScriptPath;
        private System.Windows.Forms.TextBox txtPyScriptPath;
    }
}

