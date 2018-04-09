namespace Accounting_App
{
    partial class formHome
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
            this.btnAddentry = new System.Windows.Forms.Button();
            this.boekhoudenDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boekhoudenDataSet = new Accounting_App.BoekhoudenDataSet();
            this.btnGotobalans = new System.Windows.Forms.Button();
            this.btnJournal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.boekhoudenDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boekhoudenDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddentry
            // 
            this.btnAddentry.Location = new System.Drawing.Point(620, 49);
            this.btnAddentry.Name = "btnAddentry";
            this.btnAddentry.Size = new System.Drawing.Size(75, 23);
            this.btnAddentry.TabIndex = 0;
            this.btnAddentry.Text = "AddEntry";
            this.btnAddentry.UseVisualStyleBackColor = true;
            this.btnAddentry.Click += new System.EventHandler(this.button1_Click);
            // 
            // boekhoudenDataSetBindingSource
            // 
            this.boekhoudenDataSetBindingSource.DataSource = this.boekhoudenDataSet;
            this.boekhoudenDataSetBindingSource.Position = 0;
            // 
            // boekhoudenDataSet
            // 
            this.boekhoudenDataSet.DataSetName = "BoekhoudenDataSet";
            this.boekhoudenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnGotobalans
            // 
            this.btnGotobalans.Location = new System.Drawing.Point(351, 158);
            this.btnGotobalans.Name = "btnGotobalans";
            this.btnGotobalans.Size = new System.Drawing.Size(75, 23);
            this.btnGotobalans.TabIndex = 2;
            this.btnGotobalans.Text = "Balans";
            this.btnGotobalans.UseVisualStyleBackColor = true;
            this.btnGotobalans.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnJournal
            // 
            this.btnJournal.Location = new System.Drawing.Point(57, 29);
            this.btnJournal.Name = "btnJournal";
            this.btnJournal.Size = new System.Drawing.Size(139, 23);
            this.btnJournal.TabIndex = 3;
            this.btnJournal.Text = "Jounaliseer";
            this.btnJournal.UseVisualStyleBackColor = true;
            this.btnJournal.Click += new System.EventHandler(this.btnJournal_Click);
            // 
            // formHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJournal);
            this.Controls.Add(this.btnGotobalans);
            this.Controls.Add(this.btnAddentry);
            this.Name = "formHome";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.boekhoudenDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boekhoudenDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddentry;
        private System.Windows.Forms.BindingSource boekhoudenDataSetBindingSource;
        private BoekhoudenDataSet boekhoudenDataSet;
        private System.Windows.Forms.Button btnGotobalans;
        private System.Windows.Forms.Button btnJournal;
    }
}

