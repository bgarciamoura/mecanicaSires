namespace prjSires.Forms
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orçamentosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosRealizadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peçasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stsStatusBar = new System.Windows.Forms.StatusStrip();
            this.sttTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timTicks = new System.Windows.Forms.Timer(this.components);
            this.mnuPrincipal.SuspendLayout();
            this.stsStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.mnuPrincipal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.orçamentosToolStripMenuItem1,
            this.serviçosRealizadosToolStripMenuItem,
            this.peçasToolStripMenuItem1});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(1334, 32);
            this.mnuPrincipal.TabIndex = 1;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(80, 28);
            this.cadastrosToolStripMenuItem.Text = "C&lientes";
            this.cadastrosToolStripMenuItem.Click += new System.EventHandler(this.cadastrosToolStripMenuItem_Click);
            // 
            // orçamentosToolStripMenuItem1
            // 
            this.orçamentosToolStripMenuItem1.Name = "orçamentosToolStripMenuItem1";
            this.orçamentosToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.orçamentosToolStripMenuItem1.Size = new System.Drawing.Size(112, 28);
            this.orçamentosToolStripMenuItem1.Text = "O&rçamentos";
            // 
            // serviçosRealizadosToolStripMenuItem
            // 
            this.serviçosRealizadosToolStripMenuItem.Name = "serviçosRealizadosToolStripMenuItem";
            this.serviçosRealizadosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.serviçosRealizadosToolStripMenuItem.Size = new System.Drawing.Size(168, 28);
            this.serviçosRealizadosToolStripMenuItem.Text = "&Serviços Realizados";
            // 
            // peçasToolStripMenuItem1
            // 
            this.peçasToolStripMenuItem1.Name = "peçasToolStripMenuItem1";
            this.peçasToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.peçasToolStripMenuItem1.Size = new System.Drawing.Size(67, 28);
            this.peçasToolStripMenuItem1.Text = "&Peças";
            // 
            // stsStatusBar
            // 
            this.stsStatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sttTime});
            this.stsStatusBar.Location = new System.Drawing.Point(0, 710);
            this.stsStatusBar.Name = "stsStatusBar";
            this.stsStatusBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.stsStatusBar.Size = new System.Drawing.Size(1334, 24);
            this.stsStatusBar.TabIndex = 2;
            this.stsStatusBar.Text = "statusStrip1";
            // 
            // sttTime
            // 
            this.sttTime.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.sttTime.Name = "sttTime";
            this.sttTime.Size = new System.Drawing.Size(0, 19);
            // 
            // timTicks
            // 
            this.timTicks.Enabled = true;
            this.timTicks.Interval = 1000;
            this.timTicks.Tick += new System.EventHandler(this.timTicks_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 734);
            this.Controls.Add(this.stsStatusBar);
            this.Controls.Add(this.mnuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuPrincipal;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mecânica Sires - Menu Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.stsStatusBar.ResumeLayout(false);
            this.stsStatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orçamentosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem serviçosRealizadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peçasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel sttTime;
        private System.Windows.Forms.StatusStrip stsStatusBar;
        private System.Windows.Forms.Timer timTicks;
    }
}