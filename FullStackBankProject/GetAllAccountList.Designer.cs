namespace FullStackBankProject
{
    partial class GetAllAccountList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetAllAccountList));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.labGetAllAccounts = new System.Windows.Forms.Label();
            this.dgvGetAllClients = new Guna.UI2.WinForms.Guna2DataGridView();
            this.BtnBack = new Guna.UI2.WinForms.Guna2Button();
            this.labTotelAccountBalance = new System.Windows.Forms.Label();
            this.labNumberTotelAccountBalance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetAllClients)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.HasFormShadow = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // labGetAllAccounts
            // 
            this.labGetAllAccounts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labGetAllAccounts.AutoSize = true;
            this.labGetAllAccounts.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGetAllAccounts.Location = new System.Drawing.Point(117, 16);
            this.labGetAllAccounts.Name = "labGetAllAccounts";
            this.labGetAllAccounts.Size = new System.Drawing.Size(122, 29);
            this.labGetAllAccounts.TabIndex = 4;
            this.labGetAllAccounts.Text = "Accounts";
            // 
            // dgvGetAllClients
            // 
            this.dgvGetAllClients.AllowUserToAddRows = false;
            this.dgvGetAllClients.AllowUserToDeleteRows = false;
            this.dgvGetAllClients.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvGetAllClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGetAllClients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvGetAllClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGetAllClients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvGetAllClients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGetAllClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGetAllClients.ColumnHeadersHeight = 25;
            this.dgvGetAllClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGetAllClients.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGetAllClients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvGetAllClients.Location = new System.Drawing.Point(122, 72);
            this.dgvGetAllClients.Margin = new System.Windows.Forms.Padding(5);
            this.dgvGetAllClients.Name = "dgvGetAllClients";
            this.dgvGetAllClients.ReadOnly = true;
            this.dgvGetAllClients.RowHeadersVisible = false;
            this.dgvGetAllClients.RowTemplate.ReadOnly = true;
            this.dgvGetAllClients.Size = new System.Drawing.Size(900, 446);
            this.dgvGetAllClients.StandardTab = true;
            this.dgvGetAllClients.TabIndex = 5;
            this.dgvGetAllClients.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvGetAllClients.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvGetAllClients.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvGetAllClients.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvGetAllClients.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvGetAllClients.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvGetAllClients.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvGetAllClients.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvGetAllClients.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvGetAllClients.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvGetAllClients.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGetAllClients.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvGetAllClients.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvGetAllClients.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvGetAllClients.ThemeStyle.ReadOnly = true;
            this.dgvGetAllClients.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvGetAllClients.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGetAllClients.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGetAllClients.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvGetAllClients.ThemeStyle.RowsStyle.Height = 22;
            this.dgvGetAllClients.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvGetAllClients.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // BtnBack
            // 
            this.BtnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBack.Animated = true;
            this.BtnBack.AutoRoundedCorners = true;
            this.BtnBack.BackColor = System.Drawing.Color.Transparent;
            this.BtnBack.BorderRadius = 21;
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnBack.ForeColor = System.Drawing.Color.Black;
            this.BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnBack.Location = new System.Drawing.Point(122, 534);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(180, 45);
            this.BtnBack.TabIndex = 12;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseTransparentBackground = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // labTotelAccountBalance
            // 
            this.labTotelAccountBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labTotelAccountBalance.AutoSize = true;
            this.labTotelAccountBalance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotelAccountBalance.ForeColor = System.Drawing.Color.Tomato;
            this.labTotelAccountBalance.Location = new System.Drawing.Point(343, 550);
            this.labTotelAccountBalance.Name = "labTotelAccountBalance";
            this.labTotelAccountBalance.Size = new System.Drawing.Size(291, 29);
            this.labTotelAccountBalance.TabIndex = 13;
            this.labTotelAccountBalance.Text = "TotelAccountBalance =";
            // 
            // labNumberTotelAccountBalance
            // 
            this.labNumberTotelAccountBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labNumberTotelAccountBalance.AutoSize = true;
            this.labNumberTotelAccountBalance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNumberTotelAccountBalance.ForeColor = System.Drawing.Color.Tomato;
            this.labNumberTotelAccountBalance.Location = new System.Drawing.Point(640, 550);
            this.labNumberTotelAccountBalance.Name = "labNumberTotelAccountBalance";
            this.labNumberTotelAccountBalance.Size = new System.Drawing.Size(28, 29);
            this.labNumberTotelAccountBalance.TabIndex = 14;
            this.labNumberTotelAccountBalance.Text = "0";
            // 
            // GetAllAccountList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 675);
            this.Controls.Add(this.labNumberTotelAccountBalance);
            this.Controls.Add(this.labTotelAccountBalance);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.dgvGetAllClients);
            this.Controls.Add(this.labGetAllAccounts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GetAllAccountList";
            this.Text = "AccountList";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetAllClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label labGetAllAccounts;
        private Guna.UI2.WinForms.Guna2DataGridView dgvGetAllClients;
        private Guna.UI2.WinForms.Guna2Button BtnBack;
        private System.Windows.Forms.Label labNumberTotelAccountBalance;
        private System.Windows.Forms.Label labTotelAccountBalance;
    }
}