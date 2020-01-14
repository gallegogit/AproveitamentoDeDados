namespace AprovCSV
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btSelect = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.Paci_ln_Counter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paci_tx_NomePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paci_tx_TelefonesPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnClini02 = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.SuspendLayout();
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(446, 10);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(75, 23);
            this.btSelect.TabIndex = 0;
            this.btSelect.Text = "Select";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(12, 12);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(428, 20);
            this.txtFile.TabIndex = 1;
            // 
            // dgItems
            // 
            this.dgItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Paci_ln_Counter,
            this.Paci_tx_NomePaciente,
            this.Paci_tx_TelefonesPaciente});
            this.dgItems.Location = new System.Drawing.Point(12, 38);
            this.dgItems.Name = "dgItems";
            this.dgItems.Size = new System.Drawing.Size(509, 489);
            this.dgItems.TabIndex = 2;
            this.dgItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItems_CellContentClick);
            // 
            // Paci_ln_Counter
            // 
            this.Paci_ln_Counter.DataPropertyName = "Paci_ln_Counter";
            this.Paci_ln_Counter.HeaderText = "Paci_ln_Counter";
            this.Paci_ln_Counter.Name = "Paci_ln_Counter";
            // 
            // Paci_tx_NomePaciente
            // 
            this.Paci_tx_NomePaciente.DataPropertyName = "Paci_tx_NomePaciente";
            this.Paci_tx_NomePaciente.HeaderText = "Paci_tx_NomePaciente";
            this.Paci_tx_NomePaciente.Name = "Paci_tx_NomePaciente";
            // 
            // Paci_tx_TelefonesPaciente
            // 
            this.Paci_tx_TelefonesPaciente.DataPropertyName = "Paci_tx_TelefonesPaciente";
            this.Paci_tx_TelefonesPaciente.HeaderText = "Paci_tx_TelefonesPaciente";
            this.Paci_tx_TelefonesPaciente.Name = "Paci_tx_TelefonesPaciente";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 533);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(93, 533);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 562);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(509, 23);
            this.progressBar.TabIndex = 5;
            // 
            // btnClini02
            // 
            this.btnClini02.Location = new System.Drawing.Point(12, 591);
            this.btnClini02.Name = "btnClini02";
            this.btnClini02.Size = new System.Drawing.Size(75, 23);
            this.btnClini02.TabIndex = 6;
            this.btnClini02.Text = "Clini_02";
            this.btnClini02.UseVisualStyleBackColor = true;
            this.btnClini02.Visible = false;
            this.btnClini02.Click += new System.EventHandler(this.btnClini02_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(12, 620);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(509, 23);
            this.progressBar2.TabIndex = 7;
            this.progressBar2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 685);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.btnClini02);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgItems);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btSelect);
            this.Name = "Form1";
            this.Text = "Aproveitamento de Dados";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.DataGridView dgItems;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paci_ln_Counter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paci_tx_NomePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paci_tx_TelefonesPaciente;
        private System.Windows.Forms.Button btnClini02;
        private System.Windows.Forms.ProgressBar progressBar2;
    }
}

