namespace WindowsFormsApp1
{
    partial class acceso
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(acceso));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.buttlogin = new System.Windows.Forms.Button();
            this.linkpass = new System.Windows.Forms.LinkLabel();
            this.textuser = new System.Windows.Forms.TextBox();
            this.textpass = new System.Windows.Forms.TextBox();
            this.buttmin = new System.Windows.Forms.PictureBox();
            this.buttclose = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttclose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 330);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 330);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(482, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGIN";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(780, 330);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.Gainsboro;
            this.lineShape3.Enabled = false;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 360;
            this.lineShape3.X2 = 690;
            this.lineShape3.Y1 = 107;
            this.lineShape3.Y2 = 107;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 360;
            this.lineShape2.X2 = 690;
            this.lineShape2.Y1 = 158;
            this.lineShape2.Y2 = 158;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Black;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 361;
            this.lineShape1.X2 = 689;
            this.lineShape1.Y1 = 105;
            this.lineShape1.Y2 = 105;
            // 
            // buttlogin
            // 
            this.buttlogin.BackColor = System.Drawing.Color.Transparent;
            this.buttlogin.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttlogin.FlatAppearance.BorderSize = 0;
            this.buttlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttlogin.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttlogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttlogin.Location = new System.Drawing.Point(360, 241);
            this.buttlogin.Name = "buttlogin";
            this.buttlogin.Size = new System.Drawing.Size(331, 28);
            this.buttlogin.TabIndex = 3;
            this.buttlogin.Text = "Acceder";
            this.buttlogin.UseVisualStyleBackColor = false;
            this.buttlogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkpass
            // 
            this.linkpass.ActiveLinkColor = System.Drawing.Color.Silver;
            this.linkpass.AutoSize = true;
            this.linkpass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linkpass.LinkColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linkpass.Location = new System.Drawing.Point(445, 289);
            this.linkpass.Name = "linkpass";
            this.linkpass.Size = new System.Drawing.Size(151, 13);
            this.linkpass.TabIndex = 0;
            this.linkpass.TabStop = true;
            this.linkpass.Text = "¿Has olvidado la contraseña ?";
            this.linkpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // textuser
            // 
            this.textuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(7)))), ((int)(((byte)(12)))));
            this.textuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textuser.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textuser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textuser.Location = new System.Drawing.Point(360, 87);
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(345, 19);
            this.textuser.TabIndex = 1;
            this.textuser.Text = "Usuario";
            this.textuser.TextChanged += new System.EventHandler(this.textuser_TextChanged);
            this.textuser.Enter += new System.EventHandler(this.textuser_enter);
            this.textuser.Leave += new System.EventHandler(this.textuser_Leave);
            // 
            // textpass
            // 
            this.textpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(7)))), ((int)(((byte)(12)))));
            this.textpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textpass.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textpass.Location = new System.Drawing.Point(360, 137);
            this.textpass.Name = "textpass";
            this.textpass.Size = new System.Drawing.Size(345, 19);
            this.textpass.TabIndex = 2;
            this.textpass.Text = "Contraseña ";
            this.textpass.Enter += new System.EventHandler(this.textpass_enter);
            this.textpass.Leave += new System.EventHandler(this.textpass_Leave);
            // 
            // buttmin
            // 
            this.buttmin.Image = ((System.Drawing.Image)(resources.GetObject("buttmin.Image")));
            this.buttmin.Location = new System.Drawing.Point(725, 0);
            this.buttmin.Margin = new System.Windows.Forms.Padding(2);
            this.buttmin.Name = "buttmin";
            this.buttmin.Size = new System.Drawing.Size(25, 18);
            this.buttmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttmin.TabIndex = 9;
            this.buttmin.TabStop = false;
            this.buttmin.Click += new System.EventHandler(this.buttmin_Click);
            // 
            // buttclose
            // 
            this.buttclose.Image = ((System.Drawing.Image)(resources.GetObject("buttclose.Image")));
            this.buttclose.Location = new System.Drawing.Point(755, 0);
            this.buttclose.Name = "buttclose";
            this.buttclose.Size = new System.Drawing.Size(25, 18);
            this.buttclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttclose.TabIndex = 7;
            this.buttclose.TabStop = false;
            this.buttclose.Click += new System.EventHandler(this.buttclose_Click);
            // 
            // acceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(7)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.textpass);
            this.Controls.Add(this.textuser);
            this.Controls.Add(this.buttmin);
            this.Controls.Add(this.buttclose);
            this.Controls.Add(this.linkpass);
            this.Controls.Add(this.buttlogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "acceso";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.v_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button buttlogin;
        private System.Windows.Forms.LinkLabel linkpass;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.TextBox textuser;
        private System.Windows.Forms.TextBox textpass;
        private System.Windows.Forms.PictureBox buttmin;
        private System.Windows.Forms.PictureBox buttclose;
    }
}

