namespace Martype.XrmToolBox.AccessTeamUpdater
{
    partial class PluginControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_LoadAccessTeamTemplates = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_LoadAccessTeams = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_UpdateAccessTeams = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Help = new System.Windows.Forms.ToolStripButton();
            this.label_AccessTeamTemplates = new System.Windows.Forms.Label();
            this.dataGridView_AccessTeamTemplates = new System.Windows.Forms.DataGridView();
            this.TeamTemplateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamTemplateName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.DefaultAccessRightsMask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessRights = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_AccessTeams = new System.Windows.Forms.DataGridView();
            this.label_AccessTeams = new System.Windows.Forms.Label();
            this.label_AccessTeamTemplateName = new System.Windows.Forms.Label();
            this.textBox_AccessTeamTemplate = new System.Windows.Forms.TextBox();
            this.label_AccessRights = new System.Windows.Forms.Label();
            this.textBox_AccessRights = new System.Windows.Forms.TextBox();
            this.checkBox_DivergentOnly = new System.Windows.Forms.CheckBox();
            this.label_DivergentOnly = new System.Windows.Forms.Label();
            this.textBox_FetchXmlFilter = new System.Windows.Forms.TextBox();
            this.label_FetchXmlFilter = new System.Windows.Forms.Label();
            this.TeamId = new System.Windows.Forms.DataGridViewLinkColumn();
            this.TeamAccessRights = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegardingObject = new System.Windows.Forms.DataGridViewLinkColumn();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AccessTeamTemplates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AccessTeams)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_LoadAccessTeamTemplates,
            this.toolStripButton_LoadAccessTeams,
            this.toolStripSeparator,
            this.toolStripButton_UpdateAccessTeams,
            this.toolStripButton_Help});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(839, 25);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // toolStripButton_LoadAccessTeamTemplates
            // 
            this.toolStripButton_LoadAccessTeamTemplates.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_LoadAccessTeamTemplates.Name = "toolStripButton_LoadAccessTeamTemplates";
            this.toolStripButton_LoadAccessTeamTemplates.Size = new System.Drawing.Size(163, 22);
            this.toolStripButton_LoadAccessTeamTemplates.Text = "Load Access Team Templates";
            this.toolStripButton_LoadAccessTeamTemplates.Click += new System.EventHandler(this.GetAccessTeamTemplates);
            // 
            // toolStripButton_LoadAccessTeams
            // 
            this.toolStripButton_LoadAccessTeams.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_LoadAccessTeams.Name = "toolStripButton_LoadAccessTeams";
            this.toolStripButton_LoadAccessTeams.Size = new System.Drawing.Size(112, 22);
            this.toolStripButton_LoadAccessTeams.Text = "Load Access Teams";
            this.toolStripButton_LoadAccessTeams.ToolTipText = "Load Access Teams";
            this.toolStripButton_LoadAccessTeams.Click += new System.EventHandler(this.GetAccessTeams);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_UpdateAccessTeams
            // 
            this.toolStripButton_UpdateAccessTeams.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_UpdateAccessTeams.Name = "toolStripButton_UpdateAccessTeams";
            this.toolStripButton_UpdateAccessTeams.Size = new System.Drawing.Size(124, 22);
            this.toolStripButton_UpdateAccessTeams.Text = "Update Access Teams";
            this.toolStripButton_UpdateAccessTeams.Click += new System.EventHandler(this.UpdateAccessTeams);
            // 
            // toolStripButton_Help
            // 
            this.toolStripButton_Help.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Help.Image")));
            this.toolStripButton_Help.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Help.Name = "toolStripButton_Help";
            this.toolStripButton_Help.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton_Help.Text = "Help";
            this.toolStripButton_Help.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolStripButton_Help.Click += new System.EventHandler(this.toolStripButton_Help_Click);
            // 
            // label_AccessTeamTemplates
            // 
            this.label_AccessTeamTemplates.AutoSize = true;
            this.label_AccessTeamTemplates.Location = new System.Drawing.Point(4, 29);
            this.label_AccessTeamTemplates.Name = "label_AccessTeamTemplates";
            this.label_AccessTeamTemplates.Size = new System.Drawing.Size(125, 13);
            this.label_AccessTeamTemplates.TabIndex = 7;
            this.label_AccessTeamTemplates.Text = "Access Team Tempates:";
            // 
            // dataGridView_AccessTeamTemplates
            // 
            this.dataGridView_AccessTeamTemplates.AllowUserToAddRows = false;
            this.dataGridView_AccessTeamTemplates.AllowUserToDeleteRows = false;
            this.dataGridView_AccessTeamTemplates.AllowUserToResizeRows = false;
            this.dataGridView_AccessTeamTemplates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView_AccessTeamTemplates.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_AccessTeamTemplates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AccessTeamTemplates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeamTemplateId,
            this.TeamTemplateName,
            this.DefaultAccessRightsMask,
            this.AccessRights});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_AccessTeamTemplates.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_AccessTeamTemplates.Location = new System.Drawing.Point(7, 45);
            this.dataGridView_AccessTeamTemplates.MultiSelect = false;
            this.dataGridView_AccessTeamTemplates.Name = "dataGridView_AccessTeamTemplates";
            this.dataGridView_AccessTeamTemplates.ReadOnly = true;
            this.dataGridView_AccessTeamTemplates.RowHeadersVisible = false;
            this.dataGridView_AccessTeamTemplates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_AccessTeamTemplates.Size = new System.Drawing.Size(340, 402);
            this.dataGridView_AccessTeamTemplates.TabIndex = 8;
            this.dataGridView_AccessTeamTemplates.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_AccessTeamTemplates_CellContentClick);
            this.dataGridView_AccessTeamTemplates.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_AccessTeamTemplates_CellFormatting);
            // 
            // TeamTemplateId
            // 
            this.TeamTemplateId.HeaderText = "Id";
            this.TeamTemplateId.Name = "TeamTemplateId";
            this.TeamTemplateId.ReadOnly = true;
            this.TeamTemplateId.Visible = false;
            // 
            // TeamTemplateName
            // 
            this.TeamTemplateName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TeamTemplateName.HeaderText = "Name";
            this.TeamTemplateName.Name = "TeamTemplateName";
            this.TeamTemplateName.ReadOnly = true;
            this.TeamTemplateName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TeamTemplateName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TeamTemplateName.Width = 60;
            // 
            // DefaultAccessRightsMask
            // 
            this.DefaultAccessRightsMask.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DefaultAccessRightsMask.HeaderText = "Access Mask";
            this.DefaultAccessRightsMask.Name = "DefaultAccessRightsMask";
            this.DefaultAccessRightsMask.ReadOnly = true;
            this.DefaultAccessRightsMask.Visible = false;
            // 
            // AccessRights
            // 
            this.AccessRights.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AccessRights.HeaderText = "Access Rights";
            this.AccessRights.Name = "AccessRights";
            this.AccessRights.ReadOnly = true;
            // 
            // dataGridView_AccessTeams
            // 
            this.dataGridView_AccessTeams.AllowUserToAddRows = false;
            this.dataGridView_AccessTeams.AllowUserToDeleteRows = false;
            this.dataGridView_AccessTeams.AllowUserToResizeRows = false;
            this.dataGridView_AccessTeams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_AccessTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AccessTeams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeamId,
            this.TeamAccessRights,
            this.RegardingObject});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_AccessTeams.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_AccessTeams.Location = new System.Drawing.Point(353, 202);
            this.dataGridView_AccessTeams.Name = "dataGridView_AccessTeams";
            this.dataGridView_AccessTeams.ReadOnly = true;
            this.dataGridView_AccessTeams.RowHeadersVisible = false;
            this.dataGridView_AccessTeams.Size = new System.Drawing.Size(483, 245);
            this.dataGridView_AccessTeams.TabIndex = 9;
            this.dataGridView_AccessTeams.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_AccessTeams_CellContentClick);
            this.dataGridView_AccessTeams.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_AccessTeams_CellFormatting);
            this.dataGridView_AccessTeams.SelectionChanged += new System.EventHandler(this.UndoSelection);
            // 
            // label_AccessTeams
            // 
            this.label_AccessTeams.AutoSize = true;
            this.label_AccessTeams.Location = new System.Drawing.Point(353, 186);
            this.label_AccessTeams.Name = "label_AccessTeams";
            this.label_AccessTeams.Size = new System.Drawing.Size(80, 13);
            this.label_AccessTeams.TabIndex = 10;
            this.label_AccessTeams.Text = "Access Teams:";
            // 
            // label_AccessTeamTemplateName
            // 
            this.label_AccessTeamTemplateName.AutoSize = true;
            this.label_AccessTeamTemplateName.Location = new System.Drawing.Point(353, 134);
            this.label_AccessTeamTemplateName.Name = "label_AccessTeamTemplateName";
            this.label_AccessTeamTemplateName.Size = new System.Drawing.Size(122, 13);
            this.label_AccessTeamTemplateName.TabIndex = 11;
            this.label_AccessTeamTemplateName.Text = "Access Team Template:";
            // 
            // textBox_AccessTeamTemplate
            // 
            this.textBox_AccessTeamTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_AccessTeamTemplate.Enabled = false;
            this.textBox_AccessTeamTemplate.Location = new System.Drawing.Point(481, 131);
            this.textBox_AccessTeamTemplate.Name = "textBox_AccessTeamTemplate";
            this.textBox_AccessTeamTemplate.Size = new System.Drawing.Size(355, 20);
            this.textBox_AccessTeamTemplate.TabIndex = 12;
            // 
            // label_AccessRights
            // 
            this.label_AccessRights.AutoSize = true;
            this.label_AccessRights.Location = new System.Drawing.Point(353, 160);
            this.label_AccessRights.Name = "label_AccessRights";
            this.label_AccessRights.Size = new System.Drawing.Size(78, 13);
            this.label_AccessRights.TabIndex = 11;
            this.label_AccessRights.Text = "Access Rights:";
            // 
            // textBox_AccessRights
            // 
            this.textBox_AccessRights.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_AccessRights.Enabled = false;
            this.textBox_AccessRights.Location = new System.Drawing.Point(481, 157);
            this.textBox_AccessRights.Name = "textBox_AccessRights";
            this.textBox_AccessRights.Size = new System.Drawing.Size(355, 20);
            this.textBox_AccessRights.TabIndex = 12;
            // 
            // checkBox_DivergentOnly
            // 
            this.checkBox_DivergentOnly.AutoSize = true;
            this.checkBox_DivergentOnly.Checked = true;
            this.checkBox_DivergentOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_DivergentOnly.Location = new System.Drawing.Point(481, 111);
            this.checkBox_DivergentOnly.Name = "checkBox_DivergentOnly";
            this.checkBox_DivergentOnly.Size = new System.Drawing.Size(15, 14);
            this.checkBox_DivergentOnly.TabIndex = 13;
            this.checkBox_DivergentOnly.UseVisualStyleBackColor = true;
            // 
            // label_DivergentOnly
            // 
            this.label_DivergentOnly.AutoSize = true;
            this.label_DivergentOnly.Location = new System.Drawing.Point(353, 111);
            this.label_DivergentOnly.Name = "label_DivergentOnly";
            this.label_DivergentOnly.Size = new System.Drawing.Size(80, 13);
            this.label_DivergentOnly.TabIndex = 11;
            this.label_DivergentOnly.Text = "Divergent Only:";
            // 
            // textBox_FetchXmlFilter
            // 
            this.textBox_FetchXmlFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_FetchXmlFilter.Location = new System.Drawing.Point(481, 45);
            this.textBox_FetchXmlFilter.Multiline = true;
            this.textBox_FetchXmlFilter.Name = "textBox_FetchXmlFilter";
            this.textBox_FetchXmlFilter.Size = new System.Drawing.Size(355, 60);
            this.textBox_FetchXmlFilter.TabIndex = 14;
            // 
            // label_FetchXmlFilter
            // 
            this.label_FetchXmlFilter.AutoSize = true;
            this.label_FetchXmlFilter.Location = new System.Drawing.Point(353, 48);
            this.label_FetchXmlFilter.Name = "label_FetchXmlFilter";
            this.label_FetchXmlFilter.Size = new System.Drawing.Size(79, 13);
            this.label_FetchXmlFilter.TabIndex = 15;
            this.label_FetchXmlFilter.Text = "FetchXml Filter:";
            // 
            // TeamId
            // 
            this.TeamId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TeamId.HeaderText = "Id";
            this.TeamId.Name = "TeamId";
            this.TeamId.ReadOnly = true;
            this.TeamId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TeamId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TeamId.Width = 41;
            // 
            // TeamAccessRights
            // 
            this.TeamAccessRights.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.TeamAccessRights.HeaderText = "Access Rights";
            this.TeamAccessRights.MinimumWidth = 100;
            this.TeamAccessRights.Name = "TeamAccessRights";
            this.TeamAccessRights.ReadOnly = true;
            // 
            // RegardingObject
            // 
            this.RegardingObject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.RegardingObject.HeaderText = "Regarding Object";
            this.RegardingObject.MinimumWidth = 200;
            this.RegardingObject.Name = "RegardingObject";
            this.RegardingObject.ReadOnly = true;
            this.RegardingObject.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RegardingObject.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.RegardingObject.Width = 200;
            // 
            // PluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.label_FetchXmlFilter);
            this.Controls.Add(this.textBox_FetchXmlFilter);
            this.Controls.Add(this.checkBox_DivergentOnly);
            this.Controls.Add(this.textBox_AccessRights);
            this.Controls.Add(this.textBox_AccessTeamTemplate);
            this.Controls.Add(this.label_AccessRights);
            this.Controls.Add(this.label_DivergentOnly);
            this.Controls.Add(this.label_AccessTeamTemplateName);
            this.Controls.Add(this.label_AccessTeams);
            this.Controls.Add(this.dataGridView_AccessTeams);
            this.Controls.Add(this.dataGridView_AccessTeamTemplates);
            this.Controls.Add(this.label_AccessTeamTemplates);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "PluginControl";
            this.Size = new System.Drawing.Size(839, 450);
            this.Load += new System.EventHandler(this.LoadPlugin);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AccessTeamTemplates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AccessTeams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton toolStripButton_LoadAccessTeamTemplates;
        private System.Windows.Forms.Label label_AccessTeamTemplates;
        private System.Windows.Forms.Label label_AccessTeams;
        private System.Windows.Forms.ToolStripButton toolStripButton_LoadAccessTeams;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton toolStripButton_UpdateAccessTeams;
        private System.Windows.Forms.Label label_AccessTeamTemplateName;
        private System.Windows.Forms.Label label_AccessRights;
        public System.Windows.Forms.DataGridView dataGridView_AccessTeamTemplates;
        public System.Windows.Forms.DataGridView dataGridView_AccessTeams;
        public System.Windows.Forms.TextBox textBox_AccessTeamTemplate;
        public System.Windows.Forms.TextBox textBox_AccessRights;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamTemplateId;
        private System.Windows.Forms.DataGridViewLinkColumn TeamTemplateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefaultAccessRightsMask;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessRights;
        private System.Windows.Forms.Label label_DivergentOnly;
        public System.Windows.Forms.TextBox textBox_FetchXmlFilter;
        private System.Windows.Forms.Label label_FetchXmlFilter;
        public System.Windows.Forms.CheckBox checkBox_DivergentOnly;
        private System.Windows.Forms.ToolStripButton toolStripButton_Help;
        private System.Windows.Forms.DataGridViewLinkColumn TeamId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamAccessRights;
        private System.Windows.Forms.DataGridViewLinkColumn RegardingObject;
    }
}
