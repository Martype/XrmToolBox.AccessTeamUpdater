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
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_LoadAccessTeamTemplates = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_LoadAccessTeams = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_UpdateAccessTeams = new System.Windows.Forms.ToolStripButton();
            this.label_AccessTeamTemplates = new System.Windows.Forms.Label();
            this.dataGridView_AccessTeamTemplates = new System.Windows.Forms.DataGridView();
            this.dataGridView_AccessTeams = new System.Windows.Forms.DataGridView();
            this.label_AccessTeams = new System.Windows.Forms.Label();
            this.label_AccessTeamTemplateName = new System.Windows.Forms.Label();
            this.textBox_AccessTeamTemplateId = new System.Windows.Forms.TextBox();
            this.label_AccessRights = new System.Windows.Forms.Label();
            this.textBox_AccessMask = new System.Windows.Forms.TextBox();
            this.TeamId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegardingObjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegardingObjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamTemplateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamTemplateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefaultAccessRightsMask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessRights = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.toolStripButton_UpdateAccessTeams});
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
            this.dataGridView_AccessTeamTemplates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AccessTeamTemplates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeamTemplateId,
            this.TeamTemplateName,
            this.DefaultAccessRightsMask,
            this.AccessRights});
            this.dataGridView_AccessTeamTemplates.Location = new System.Drawing.Point(7, 45);
            this.dataGridView_AccessTeamTemplates.MultiSelect = false;
            this.dataGridView_AccessTeamTemplates.Name = "dataGridView_AccessTeamTemplates";
            this.dataGridView_AccessTeamTemplates.ReadOnly = true;
            this.dataGridView_AccessTeamTemplates.RowHeadersVisible = false;
            this.dataGridView_AccessTeamTemplates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_AccessTeamTemplates.Size = new System.Drawing.Size(300, 402);
            this.dataGridView_AccessTeamTemplates.TabIndex = 8;
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
            this.TeamName,
            this.RegardingObjectId,
            this.RegardingObjectName});
            this.dataGridView_AccessTeams.Location = new System.Drawing.Point(313, 116);
            this.dataGridView_AccessTeams.Name = "dataGridView_AccessTeams";
            this.dataGridView_AccessTeams.ReadOnly = true;
            this.dataGridView_AccessTeams.RowHeadersVisible = false;
            this.dataGridView_AccessTeams.Size = new System.Drawing.Size(523, 331);
            this.dataGridView_AccessTeams.TabIndex = 9;
            this.dataGridView_AccessTeams.SelectionChanged += new System.EventHandler(this.dataGridView_AccessTeams_SelectionChanged);
            // 
            // label_AccessTeams
            // 
            this.label_AccessTeams.AutoSize = true;
            this.label_AccessTeams.Location = new System.Drawing.Point(313, 100);
            this.label_AccessTeams.Name = "label_AccessTeams";
            this.label_AccessTeams.Size = new System.Drawing.Size(80, 13);
            this.label_AccessTeams.TabIndex = 10;
            this.label_AccessTeams.Text = "Access Teams:";
            // 
            // label_AccessTeamTemplateName
            // 
            this.label_AccessTeamTemplateName.AutoSize = true;
            this.label_AccessTeamTemplateName.Location = new System.Drawing.Point(313, 48);
            this.label_AccessTeamTemplateName.Name = "label_AccessTeamTemplateName";
            this.label_AccessTeamTemplateName.Size = new System.Drawing.Size(122, 13);
            this.label_AccessTeamTemplateName.TabIndex = 11;
            this.label_AccessTeamTemplateName.Text = "Access Team Template:";
            // 
            // textBox_AccessTeamTemplateId
            // 
            this.textBox_AccessTeamTemplateId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_AccessTeamTemplateId.Enabled = false;
            this.textBox_AccessTeamTemplateId.Location = new System.Drawing.Point(441, 45);
            this.textBox_AccessTeamTemplateId.Name = "textBox_AccessTeamTemplateId";
            this.textBox_AccessTeamTemplateId.Size = new System.Drawing.Size(395, 20);
            this.textBox_AccessTeamTemplateId.TabIndex = 12;
            // 
            // label_AccessRights
            // 
            this.label_AccessRights.AutoSize = true;
            this.label_AccessRights.Location = new System.Drawing.Point(313, 74);
            this.label_AccessRights.Name = "label_AccessRights";
            this.label_AccessRights.Size = new System.Drawing.Size(78, 13);
            this.label_AccessRights.TabIndex = 11;
            this.label_AccessRights.Text = "Access Rights:";
            // 
            // textBox_AccessMask
            // 
            this.textBox_AccessMask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_AccessMask.Enabled = false;
            this.textBox_AccessMask.Location = new System.Drawing.Point(441, 71);
            this.textBox_AccessMask.Name = "textBox_AccessMask";
            this.textBox_AccessMask.Size = new System.Drawing.Size(395, 20);
            this.textBox_AccessMask.TabIndex = 12;
            // 
            // TeamId
            // 
            this.TeamId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TeamId.HeaderText = "Id";
            this.TeamId.Name = "TeamId";
            this.TeamId.ReadOnly = true;
            this.TeamId.Width = 41;
            // 
            // TeamName
            // 
            this.TeamName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TeamName.HeaderText = "Name";
            this.TeamName.Name = "TeamName";
            this.TeamName.ReadOnly = true;
            this.TeamName.Width = 60;
            // 
            // RegardingObjectId
            // 
            this.RegardingObjectId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.RegardingObjectId.HeaderText = "Regarding Object Id";
            this.RegardingObjectId.MinimumWidth = 200;
            this.RegardingObjectId.Name = "RegardingObjectId";
            this.RegardingObjectId.ReadOnly = true;
            this.RegardingObjectId.Width = 200;
            // 
            // RegardingObjectName
            // 
            this.RegardingObjectName.HeaderText = "Regarding Object Name";
            this.RegardingObjectName.Name = "RegardingObjectName";
            this.RegardingObjectName.ReadOnly = true;
            this.RegardingObjectName.Visible = false;
            this.RegardingObjectName.Width = 200;
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
            this.TeamTemplateName.Width = 60;
            // 
            // DefaultAccessRightsMask
            // 
            this.DefaultAccessRightsMask.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DefaultAccessRightsMask.HeaderText = "Access Mask";
            this.DefaultAccessRightsMask.Name = "DefaultAccessRightsMask";
            this.DefaultAccessRightsMask.ReadOnly = true;
            this.DefaultAccessRightsMask.Visible = false;
            this.DefaultAccessRightsMask.Width = 96;
            // 
            // AccessRights
            // 
            this.AccessRights.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AccessRights.HeaderText = "Access Rights";
            this.AccessRights.Name = "AccessRights";
            this.AccessRights.ReadOnly = true;
            // 
            // PluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.textBox_AccessMask);
            this.Controls.Add(this.textBox_AccessTeamTemplateId);
            this.Controls.Add(this.label_AccessRights);
            this.Controls.Add(this.label_AccessTeamTemplateName);
            this.Controls.Add(this.label_AccessTeams);
            this.Controls.Add(this.dataGridView_AccessTeams);
            this.Controls.Add(this.dataGridView_AccessTeamTemplates);
            this.Controls.Add(this.label_AccessTeamTemplates);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "PluginControl";
            this.Size = new System.Drawing.Size(839, 450);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
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
        private System.Windows.Forms.DataGridView dataGridView_AccessTeamTemplates;
        private System.Windows.Forms.DataGridView dataGridView_AccessTeams;
        private System.Windows.Forms.Label label_AccessTeams;
        private System.Windows.Forms.ToolStripButton toolStripButton_LoadAccessTeams;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton toolStripButton_UpdateAccessTeams;
        private System.Windows.Forms.Label label_AccessTeamTemplateName;
        private System.Windows.Forms.TextBox textBox_AccessTeamTemplateId;
        private System.Windows.Forms.Label label_AccessRights;
        private System.Windows.Forms.TextBox textBox_AccessMask;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegardingObjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegardingObjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamTemplateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamTemplateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefaultAccessRightsMask;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessRights;
    }
}
