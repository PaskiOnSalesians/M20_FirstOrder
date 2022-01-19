
namespace StarKillerBase
{
    partial class StarKillerBase
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_blueprints = new System.Windows.Forms.Button();
            this.pctbox_base = new System.Windows.Forms.PictureBox();
            this.pnl_interactive = new System.Windows.Forms.Panel();
            this.pnl_info = new System.Windows.Forms.Panel();
            this.pnl_image = new System.Windows.Forms.Panel();
            this.pnl_text = new System.Windows.Forms.Panel();
            this.pctbox_detail = new System.Windows.Forms.PictureBox();
            this.txtbox_info = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_base)).BeginInit();
            this.pnl_interactive.SuspendLayout();
            this.pnl_info.SuspendLayout();
            this.pnl_image.SuspendLayout();
            this.pnl_text.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_detail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_blueprints);
            this.panel1.Location = new System.Drawing.Point(32, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 67);
            this.panel1.TabIndex = 0;
            // 
            // btn_blueprints
            // 
            this.btn_blueprints.FlatAppearance.BorderSize = 3;
            this.btn_blueprints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_blueprints.Font = new System.Drawing.Font("Ebrima", 24F, System.Drawing.FontStyle.Bold);
            this.btn_blueprints.ForeColor = System.Drawing.Color.White;
            this.btn_blueprints.Location = new System.Drawing.Point(3, 3);
            this.btn_blueprints.Name = "btn_blueprints";
            this.btn_blueprints.Size = new System.Drawing.Size(206, 60);
            this.btn_blueprints.TabIndex = 2;
            this.btn_blueprints.Text = "Blueprints";
            this.btn_blueprints.UseVisualStyleBackColor = true;
            // 
            // pctbox_base
            // 
            this.pctbox_base.Image = global::StarKillerBase.Properties.Resources.DSPlan;
            this.pctbox_base.Location = new System.Drawing.Point(34, 44);
            this.pctbox_base.Name = "pctbox_base";
            this.pctbox_base.Size = new System.Drawing.Size(348, 300);
            this.pctbox_base.TabIndex = 1;
            this.pctbox_base.TabStop = false;
            // 
            // pnl_interactive
            // 
            this.pnl_interactive.Controls.Add(this.pctbox_base);
            this.pnl_interactive.Location = new System.Drawing.Point(35, 191);
            this.pnl_interactive.Name = "pnl_interactive";
            this.pnl_interactive.Size = new System.Drawing.Size(415, 387);
            this.pnl_interactive.TabIndex = 2;
            // 
            // pnl_info
            // 
            this.pnl_info.Controls.Add(this.pnl_text);
            this.pnl_info.Controls.Add(this.pnl_image);
            this.pnl_info.Location = new System.Drawing.Point(603, 62);
            this.pnl_info.Name = "pnl_info";
            this.pnl_info.Size = new System.Drawing.Size(399, 516);
            this.pnl_info.TabIndex = 3;
            // 
            // pnl_image
            // 
            this.pnl_image.Controls.Add(this.pctbox_detail);
            this.pnl_image.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_image.Location = new System.Drawing.Point(0, 0);
            this.pnl_image.Name = "pnl_image";
            this.pnl_image.Size = new System.Drawing.Size(399, 241);
            this.pnl_image.TabIndex = 0;
            // 
            // pnl_text
            // 
            this.pnl_text.Controls.Add(this.txtbox_info);
            this.pnl_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_text.Location = new System.Drawing.Point(0, 241);
            this.pnl_text.Name = "pnl_text";
            this.pnl_text.Size = new System.Drawing.Size(399, 275);
            this.pnl_text.TabIndex = 1;
            // 
            // pctbox_detail
            // 
            this.pctbox_detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctbox_detail.Location = new System.Drawing.Point(0, 0);
            this.pctbox_detail.Name = "pctbox_detail";
            this.pctbox_detail.Size = new System.Drawing.Size(399, 241);
            this.pctbox_detail.TabIndex = 0;
            this.pctbox_detail.TabStop = false;
            // 
            // txtbox_info
            // 
            this.txtbox_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtbox_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbox_info.ForeColor = System.Drawing.Color.White;
            this.txtbox_info.Location = new System.Drawing.Point(0, 0);
            this.txtbox_info.Name = "txtbox_info";
            this.txtbox_info.Size = new System.Drawing.Size(399, 275);
            this.txtbox_info.TabIndex = 0;
            this.txtbox_info.Text = "";
            // 
            // StarKillerBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(1049, 634);
            this.Controls.Add(this.pnl_info);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_interactive);
            this.Name = "StarKillerBase";
            this.Text = "StarKiller Base";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_base)).EndInit();
            this.pnl_interactive.ResumeLayout(false);
            this.pnl_info.ResumeLayout(false);
            this.pnl_image.ResumeLayout(false);
            this.pnl_text.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_detail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_blueprints;
        private System.Windows.Forms.PictureBox pctbox_base;
        private System.Windows.Forms.Panel pnl_interactive;
        private System.Windows.Forms.Panel pnl_info;
        private System.Windows.Forms.Panel pnl_text;
        private System.Windows.Forms.Panel pnl_image;
        private System.Windows.Forms.PictureBox pctbox_detail;
        private System.Windows.Forms.RichTextBox txtbox_info;
    }
}

