namespace NdpProjeOdevi
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
      this.components = new System.ComponentModel.Container();
      this.timerGenel = new System.Windows.Forms.Timer(this.components);
      this.timerMermi = new System.Windows.Forms.Timer(this.components);
      this.timerSavas = new System.Windows.Forms.Timer(this.components);
      this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.lblSkor = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // timerGenel
      // 
      this.timerGenel.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // timerMermi
      // 
      this.timerMermi.Tick += new System.EventHandler(this.timerMermi_Tick);
      // 
      // timerSavas
      // 
      this.timerSavas.Tick += new System.EventHandler(this.timerSavas_Tick);
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.Gray;
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Location = new System.Drawing.Point(9, 12);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(694, 124);
      this.panel1.TabIndex = 2;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.label3.Location = new System.Drawing.Point(13, 77);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(304, 18);
      this.label3.TabIndex = 0;
      this.label3.Text = "Ateş Etmek İçin BOŞLUK Tuşuna Basın";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.label2.Location = new System.Drawing.Point(13, 39);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(493, 18);
      this.label2.TabIndex = 0;
      this.label2.Text = "Uçak Savarı Hareket Ettirmek İçin Sağ/Sol Yön Tuşlarını Kullanın";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.label1.Location = new System.Drawing.Point(13, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(329, 18);
      this.label1.TabIndex = 0;
      this.label1.Text = "Oyuna Başlamak İçin ENTER tuşuna Basın";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label4.Location = new System.Drawing.Point(1193, 12);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(68, 16);
      this.label4.TabIndex = 3;
      this.label4.Text = "SCORE :";
      // 
      // lblSkor
      // 
      this.lblSkor.AutoSize = true;
      this.lblSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lblSkor.Location = new System.Drawing.Point(1267, 12);
      this.lblSkor.Name = "lblSkor";
      this.lblSkor.Size = new System.Drawing.Size(16, 16);
      this.lblSkor.TabIndex = 4;
      this.lblSkor.Text = "0";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.DarkCyan;
      this.ClientSize = new System.Drawing.Size(1322, 596);
      this.Controls.Add(this.lblSkor);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.panel1);
      this.KeyPreview = true;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
     
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Timer timerGenel;
    private System.Windows.Forms.Timer timerMermi;
    private System.Windows.Forms.Timer timerSavas;
    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label lblSkor;
  }
}

