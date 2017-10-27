namespace CA_Project
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
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.labelconnection = new MaterialSkin.Controls.MaterialLabel();
            this.tempreader = new System.Windows.Forms.Timer(this.components);
            this.labeltemp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(336, 247);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(147, 36);
            this.materialFlatButton1.TabIndex = 0;
            this.materialFlatButton1.Text = "Read Tempurature";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // labelconnection
            // 
            this.labelconnection.AutoSize = true;
            this.labelconnection.Depth = 0;
            this.labelconnection.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelconnection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelconnection.Location = new System.Drawing.Point(12, 255);
            this.labelconnection.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelconnection.Name = "labelconnection";
            this.labelconnection.Size = new System.Drawing.Size(17, 18);
            this.labelconnection.TabIndex = 2;
            this.labelconnection.Text = "*";
            // 
            // tempreader
            // 
            this.tempreader.Interval = 5000;
            this.tempreader.Tick += new System.EventHandler(this.tempreader_Tick);
            // 
            // labeltemp
            // 
            this.labeltemp.AutoSize = true;
            this.labeltemp.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltemp.Location = new System.Drawing.Point(12, 70);
            this.labeltemp.Name = "labeltemp";
            this.labeltemp.Size = new System.Drawing.Size(79, 78);
            this.labeltemp.TabIndex = 4;
            this.labeltemp.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 78);
            this.label1.TabIndex = 5;
            this.label1.Text = "°C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 78);
            this.label2.TabIndex = 6;
            this.label2.Text = "°F";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 286);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labeltemp);
            this.Controls.Add(this.labelconnection);
            this.Controls.Add(this.materialFlatButton1);
            this.Name = "Form1";
            this.Text = "Tempurature Sensor LM35";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialLabel labelconnection;
        private System.Windows.Forms.Timer tempreader;
        private System.Windows.Forms.Label labeltemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

