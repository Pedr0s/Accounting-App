namespace Accounting_App
{
    partial class formBalance
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
            this.gridviewBalans = new System.Windows.Forms.DataGridView();
            this.colActiva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActivaN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassiva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassivaN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewBalans)).BeginInit();
            this.SuspendLayout();
            // 
            // gridviewBalans
            // 
            this.gridviewBalans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewBalans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colActiva,
            this.colActivaN,
            this.colPassiva,
            this.colPassivaN});
            this.gridviewBalans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridviewBalans.Location = new System.Drawing.Point(0, 0);
            this.gridviewBalans.Name = "gridviewBalans";
            this.gridviewBalans.RowTemplate.Height = 24;
            this.gridviewBalans.Size = new System.Drawing.Size(800, 450);
            this.gridviewBalans.TabIndex = 0;
            // 
            // colActiva
            // 
            this.colActiva.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colActiva.HeaderText = "Activa";
            this.colActiva.Name = "colActiva";
            // 
            // colActivaN
            // 
            this.colActivaN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colActivaN.HeaderText = "";
            this.colActivaN.Name = "colActivaN";
            // 
            // colPassiva
            // 
            this.colPassiva.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPassiva.HeaderText = "Passiva";
            this.colPassiva.Name = "colPassiva";
            // 
            // colPassivaN
            // 
            this.colPassivaN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPassivaN.HeaderText = "";
            this.colPassivaN.Name = "colPassivaN";
            // 
            // formBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridviewBalans);
            this.Name = "formBalance";
            this.Text = "Balance";
            this.Load += new System.EventHandler(this.formBalance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewBalans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridviewBalans;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActiva;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActivaN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassiva;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassivaN;
    }
}