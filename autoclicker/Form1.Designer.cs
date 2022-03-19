
namespace autoclicker
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CPSTrackbar = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.CPSValue = new System.Windows.Forms.Label();
            this.Autoclicker = new System.Windows.Forms.Timer(this.components);
            this.btnToggle = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.Random = new System.Windows.Forms.Timer(this.components);
            this.randomTB = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.btnBind = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.Binding = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autoclicker";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(14, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Left Click CPS";
            // 
            // CPSTrackbar
            // 
            this.CPSTrackbar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.CPSTrackbar.HoverState.Parent = this.CPSTrackbar;
            this.CPSTrackbar.Location = new System.Drawing.Point(130, 43);
            this.CPSTrackbar.Maximum = 30;
            this.CPSTrackbar.Minimum = 10;
            this.CPSTrackbar.Name = "CPSTrackbar";
            this.CPSTrackbar.Size = new System.Drawing.Size(303, 33);
            this.CPSTrackbar.TabIndex = 3;
            this.CPSTrackbar.ThumbColor = System.Drawing.Color.Red;
            this.CPSTrackbar.Value = 10;
            this.CPSTrackbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.CPSTrackbar_Scroll);
            // 
            // CPSValue
            // 
            this.CPSValue.AutoSize = true;
            this.CPSValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CPSValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPSValue.ForeColor = System.Drawing.Color.Red;
            this.CPSValue.Location = new System.Drawing.Point(439, 50);
            this.CPSValue.Name = "CPSValue";
            this.CPSValue.Size = new System.Drawing.Size(63, 20);
            this.CPSValue.TabIndex = 4;
            this.CPSValue.Text = "10 CPS";
            this.CPSValue.Click += new System.EventHandler(this.label3_Click);
            // 
            // Autoclicker
            // 
            this.Autoclicker.Tick += new System.EventHandler(this.Autoclicker_Tick);
            // 
            // btnToggle
            // 
            this.btnToggle.CheckedState.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnToggle.CheckedState.Parent = this.btnToggle;
            this.btnToggle.CustomImages.Parent = this.btnToggle;
            this.btnToggle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnToggle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnToggle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToggle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnToggle.DisabledState.Parent = this.btnToggle;
            this.btnToggle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnToggle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnToggle.ForeColor = System.Drawing.Color.Red;
            this.btnToggle.HoverState.Parent = this.btnToggle;
            this.btnToggle.Location = new System.Drawing.Point(18, 89);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.ShadowDecoration.Parent = this.btnToggle;
            this.btnToggle.Size = new System.Drawing.Size(220, 23);
            this.btnToggle.TabIndex = 5;
            this.btnToggle.Text = "enable";
            this.btnToggle.TextChanged += new System.EventHandler(this.btnToggle_TextChanged);
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // Random
            // 
            this.Random.Enabled = true;
            this.Random.Interval = 150;
            this.Random.Tick += new System.EventHandler(this.Random_Tick);
            // 
            // randomTB
            // 
            this.randomTB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.randomTB.HoverState.Parent = this.randomTB;
            this.randomTB.Location = new System.Drawing.Point(24, 135);
            this.randomTB.Maximum = 34;
            this.randomTB.Name = "randomTB";
            this.randomTB.Size = new System.Drawing.Size(467, 33);
            this.randomTB.TabIndex = 6;
            this.randomTB.ThumbColor = System.Drawing.Color.Red;
            this.randomTB.Value = 10;
            // 
            // btnBind
            // 
            this.btnBind.CheckedState.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBind.CheckedState.Parent = this.btnBind;
            this.btnBind.CustomImages.Parent = this.btnBind;
            this.btnBind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBind.DisabledState.Parent = this.btnBind;
            this.btnBind.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnBind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBind.ForeColor = System.Drawing.Color.Red;
            this.btnBind.HoverState.Parent = this.btnBind;
            this.btnBind.Location = new System.Drawing.Point(271, 89);
            this.btnBind.Name = "btnBind";
            this.btnBind.ShadowDecoration.Parent = this.btnBind;
            this.btnBind.Size = new System.Drawing.Size(220, 23);
            this.btnBind.TabIndex = 7;
            this.btnBind.Text = "none";
            this.btnBind.Click += new System.EventHandler(this.btnBind_Click);
            this.btnBind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnBind_KeyDown);
            // 
            // Binding
            // 
            this.Binding.Enabled = true;
            this.Binding.Tick += new System.EventHandler(this.Binding_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(515, 183);
            this.Controls.Add(this.btnBind);
            this.Controls.Add(this.randomTB);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.CPSValue);
            this.Controls.Add(this.CPSTrackbar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Autoclicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar CPSTrackbar;
        private System.Windows.Forms.Label CPSValue;
        private System.Windows.Forms.Timer Autoclicker;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnToggle;
        private System.Windows.Forms.Timer Random;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar randomTB;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnBind;
        private System.Windows.Forms.Timer Binding;
    }
}

