namespace WorldWeaver
{
    partial class DM_info_sheet
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.playeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notestodmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hitpointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dexterityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constitutionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intelligenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wisdomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charismaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proficiencybonusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.walkingspeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initiativeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.armorclassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worldweaverDataSet = new WorldWeaver.worldweaverDataSet();
            this.playerTableAdapter = new WorldWeaver.worldweaverDataSetTableAdapters.playerTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.npcidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.npcnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hitpointsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strengthDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dexterityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constitutionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intelligenceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wisdomDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charismaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.armorclassDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.characternotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abilitiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attacksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.npcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.npcTableAdapter = new WorldWeaver.worldweaverDataSetTableAdapters.npcTableAdapter();
            this.charaBtn = new System.Windows.Forms.Button();
            this.npcBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldweaverDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playeridDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.raceDataGridViewTextBoxColumn,
            this.levelDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.notestodmDataGridViewTextBoxColumn,
            this.hitpointsDataGridViewTextBoxColumn,
            this.strengthDataGridViewTextBoxColumn,
            this.dexterityDataGridViewTextBoxColumn,
            this.constitutionDataGridViewTextBoxColumn,
            this.intelligenceDataGridViewTextBoxColumn,
            this.wisdomDataGridViewTextBoxColumn,
            this.charismaDataGridViewTextBoxColumn,
            this.proficiencybonusDataGridViewTextBoxColumn,
            this.walkingspeedDataGridViewTextBoxColumn,
            this.initiativeDataGridViewTextBoxColumn,
            this.armorclassDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.playerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1742, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // playeridDataGridViewTextBoxColumn
            // 
            this.playeridDataGridViewTextBoxColumn.DataPropertyName = "player_id";
            this.playeridDataGridViewTextBoxColumn.HeaderText = "player_id";
            this.playeridDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.playeridDataGridViewTextBoxColumn.Name = "playeridDataGridViewTextBoxColumn";
            this.playeridDataGridViewTextBoxColumn.ReadOnly = true;
            this.playeridDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // raceDataGridViewTextBoxColumn
            // 
            this.raceDataGridViewTextBoxColumn.DataPropertyName = "race";
            this.raceDataGridViewTextBoxColumn.HeaderText = "race";
            this.raceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.raceDataGridViewTextBoxColumn.Name = "raceDataGridViewTextBoxColumn";
            this.raceDataGridViewTextBoxColumn.Width = 150;
            // 
            // levelDataGridViewTextBoxColumn
            // 
            this.levelDataGridViewTextBoxColumn.DataPropertyName = "level";
            this.levelDataGridViewTextBoxColumn.HeaderText = "level";
            this.levelDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.levelDataGridViewTextBoxColumn.Name = "levelDataGridViewTextBoxColumn";
            this.levelDataGridViewTextBoxColumn.Width = 150;
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "class";
            this.classDataGridViewTextBoxColumn.HeaderText = "class";
            this.classDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            this.classDataGridViewTextBoxColumn.Width = 150;
            // 
            // notestodmDataGridViewTextBoxColumn
            // 
            this.notestodmDataGridViewTextBoxColumn.DataPropertyName = "notes_to_dm";
            this.notestodmDataGridViewTextBoxColumn.HeaderText = "notes_to_dm";
            this.notestodmDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.notestodmDataGridViewTextBoxColumn.Name = "notestodmDataGridViewTextBoxColumn";
            this.notestodmDataGridViewTextBoxColumn.Width = 150;
            // 
            // hitpointsDataGridViewTextBoxColumn
            // 
            this.hitpointsDataGridViewTextBoxColumn.DataPropertyName = "hit_points";
            this.hitpointsDataGridViewTextBoxColumn.HeaderText = "hit_points";
            this.hitpointsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hitpointsDataGridViewTextBoxColumn.Name = "hitpointsDataGridViewTextBoxColumn";
            this.hitpointsDataGridViewTextBoxColumn.Width = 150;
            // 
            // strengthDataGridViewTextBoxColumn
            // 
            this.strengthDataGridViewTextBoxColumn.DataPropertyName = "strength";
            this.strengthDataGridViewTextBoxColumn.HeaderText = "strength";
            this.strengthDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.strengthDataGridViewTextBoxColumn.Name = "strengthDataGridViewTextBoxColumn";
            this.strengthDataGridViewTextBoxColumn.Width = 150;
            // 
            // dexterityDataGridViewTextBoxColumn
            // 
            this.dexterityDataGridViewTextBoxColumn.DataPropertyName = "dexterity";
            this.dexterityDataGridViewTextBoxColumn.HeaderText = "dexterity";
            this.dexterityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dexterityDataGridViewTextBoxColumn.Name = "dexterityDataGridViewTextBoxColumn";
            this.dexterityDataGridViewTextBoxColumn.Width = 150;
            // 
            // constitutionDataGridViewTextBoxColumn
            // 
            this.constitutionDataGridViewTextBoxColumn.DataPropertyName = "constitution";
            this.constitutionDataGridViewTextBoxColumn.HeaderText = "constitution";
            this.constitutionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.constitutionDataGridViewTextBoxColumn.Name = "constitutionDataGridViewTextBoxColumn";
            this.constitutionDataGridViewTextBoxColumn.Width = 150;
            // 
            // intelligenceDataGridViewTextBoxColumn
            // 
            this.intelligenceDataGridViewTextBoxColumn.DataPropertyName = "intelligence";
            this.intelligenceDataGridViewTextBoxColumn.HeaderText = "intelligence";
            this.intelligenceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.intelligenceDataGridViewTextBoxColumn.Name = "intelligenceDataGridViewTextBoxColumn";
            this.intelligenceDataGridViewTextBoxColumn.Width = 150;
            // 
            // wisdomDataGridViewTextBoxColumn
            // 
            this.wisdomDataGridViewTextBoxColumn.DataPropertyName = "wisdom";
            this.wisdomDataGridViewTextBoxColumn.HeaderText = "wisdom";
            this.wisdomDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.wisdomDataGridViewTextBoxColumn.Name = "wisdomDataGridViewTextBoxColumn";
            this.wisdomDataGridViewTextBoxColumn.Width = 150;
            // 
            // charismaDataGridViewTextBoxColumn
            // 
            this.charismaDataGridViewTextBoxColumn.DataPropertyName = "charisma";
            this.charismaDataGridViewTextBoxColumn.HeaderText = "charisma";
            this.charismaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.charismaDataGridViewTextBoxColumn.Name = "charismaDataGridViewTextBoxColumn";
            this.charismaDataGridViewTextBoxColumn.Width = 150;
            // 
            // proficiencybonusDataGridViewTextBoxColumn
            // 
            this.proficiencybonusDataGridViewTextBoxColumn.DataPropertyName = "proficiency_bonus";
            this.proficiencybonusDataGridViewTextBoxColumn.HeaderText = "proficiency_bonus";
            this.proficiencybonusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.proficiencybonusDataGridViewTextBoxColumn.Name = "proficiencybonusDataGridViewTextBoxColumn";
            this.proficiencybonusDataGridViewTextBoxColumn.Width = 150;
            // 
            // walkingspeedDataGridViewTextBoxColumn
            // 
            this.walkingspeedDataGridViewTextBoxColumn.DataPropertyName = "walking_speed";
            this.walkingspeedDataGridViewTextBoxColumn.HeaderText = "walking_speed";
            this.walkingspeedDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.walkingspeedDataGridViewTextBoxColumn.Name = "walkingspeedDataGridViewTextBoxColumn";
            this.walkingspeedDataGridViewTextBoxColumn.Width = 150;
            // 
            // initiativeDataGridViewTextBoxColumn
            // 
            this.initiativeDataGridViewTextBoxColumn.DataPropertyName = "initiative";
            this.initiativeDataGridViewTextBoxColumn.HeaderText = "initiative";
            this.initiativeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.initiativeDataGridViewTextBoxColumn.Name = "initiativeDataGridViewTextBoxColumn";
            this.initiativeDataGridViewTextBoxColumn.Width = 150;
            // 
            // armorclassDataGridViewTextBoxColumn
            // 
            this.armorclassDataGridViewTextBoxColumn.DataPropertyName = "armor_class";
            this.armorclassDataGridViewTextBoxColumn.HeaderText = "armor_class";
            this.armorclassDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.armorclassDataGridViewTextBoxColumn.Name = "armorclassDataGridViewTextBoxColumn";
            this.armorclassDataGridViewTextBoxColumn.Width = 150;
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataMember = "player";
            this.playerBindingSource.DataSource = this.worldweaverDataSet;
            // 
            // worldweaverDataSet
            // 
            this.worldweaverDataSet.DataSetName = "worldweaverDataSet";
            this.worldweaverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playerTableAdapter
            // 
            this.playerTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.npcidDataGridViewTextBoxColumn,
            this.npcnameDataGridViewTextBoxColumn,
            this.hitpointsDataGridViewTextBoxColumn1,
            this.strengthDataGridViewTextBoxColumn1,
            this.dexterityDataGridViewTextBoxColumn1,
            this.constitutionDataGridViewTextBoxColumn1,
            this.intelligenceDataGridViewTextBoxColumn1,
            this.wisdomDataGridViewTextBoxColumn1,
            this.charismaDataGridViewTextBoxColumn1,
            this.armorclassDataGridViewTextBoxColumn1,
            this.characternotesDataGridViewTextBoxColumn,
            this.skillsDataGridViewTextBoxColumn,
            this.abilitiesDataGridViewTextBoxColumn,
            this.attacksDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.npcBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 575);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1251, 150);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // npcidDataGridViewTextBoxColumn
            // 
            this.npcidDataGridViewTextBoxColumn.DataPropertyName = "npc_id";
            this.npcidDataGridViewTextBoxColumn.HeaderText = "npc_id";
            this.npcidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.npcidDataGridViewTextBoxColumn.Name = "npcidDataGridViewTextBoxColumn";
            this.npcidDataGridViewTextBoxColumn.ReadOnly = true;
            this.npcidDataGridViewTextBoxColumn.Width = 150;
            // 
            // npcnameDataGridViewTextBoxColumn
            // 
            this.npcnameDataGridViewTextBoxColumn.DataPropertyName = "npc_name";
            this.npcnameDataGridViewTextBoxColumn.HeaderText = "npc_name";
            this.npcnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.npcnameDataGridViewTextBoxColumn.Name = "npcnameDataGridViewTextBoxColumn";
            this.npcnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // hitpointsDataGridViewTextBoxColumn1
            // 
            this.hitpointsDataGridViewTextBoxColumn1.DataPropertyName = "hit_points";
            this.hitpointsDataGridViewTextBoxColumn1.HeaderText = "hit_points";
            this.hitpointsDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.hitpointsDataGridViewTextBoxColumn1.Name = "hitpointsDataGridViewTextBoxColumn1";
            this.hitpointsDataGridViewTextBoxColumn1.Width = 150;
            // 
            // strengthDataGridViewTextBoxColumn1
            // 
            this.strengthDataGridViewTextBoxColumn1.DataPropertyName = "strength";
            this.strengthDataGridViewTextBoxColumn1.HeaderText = "strength";
            this.strengthDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.strengthDataGridViewTextBoxColumn1.Name = "strengthDataGridViewTextBoxColumn1";
            this.strengthDataGridViewTextBoxColumn1.Width = 150;
            // 
            // dexterityDataGridViewTextBoxColumn1
            // 
            this.dexterityDataGridViewTextBoxColumn1.DataPropertyName = "dexterity";
            this.dexterityDataGridViewTextBoxColumn1.HeaderText = "dexterity";
            this.dexterityDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dexterityDataGridViewTextBoxColumn1.Name = "dexterityDataGridViewTextBoxColumn1";
            this.dexterityDataGridViewTextBoxColumn1.Width = 150;
            // 
            // constitutionDataGridViewTextBoxColumn1
            // 
            this.constitutionDataGridViewTextBoxColumn1.DataPropertyName = "constitution";
            this.constitutionDataGridViewTextBoxColumn1.HeaderText = "constitution";
            this.constitutionDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.constitutionDataGridViewTextBoxColumn1.Name = "constitutionDataGridViewTextBoxColumn1";
            this.constitutionDataGridViewTextBoxColumn1.Width = 150;
            // 
            // intelligenceDataGridViewTextBoxColumn1
            // 
            this.intelligenceDataGridViewTextBoxColumn1.DataPropertyName = "intelligence";
            this.intelligenceDataGridViewTextBoxColumn1.HeaderText = "intelligence";
            this.intelligenceDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.intelligenceDataGridViewTextBoxColumn1.Name = "intelligenceDataGridViewTextBoxColumn1";
            this.intelligenceDataGridViewTextBoxColumn1.Width = 150;
            // 
            // wisdomDataGridViewTextBoxColumn1
            // 
            this.wisdomDataGridViewTextBoxColumn1.DataPropertyName = "wisdom";
            this.wisdomDataGridViewTextBoxColumn1.HeaderText = "wisdom";
            this.wisdomDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.wisdomDataGridViewTextBoxColumn1.Name = "wisdomDataGridViewTextBoxColumn1";
            this.wisdomDataGridViewTextBoxColumn1.Width = 150;
            // 
            // charismaDataGridViewTextBoxColumn1
            // 
            this.charismaDataGridViewTextBoxColumn1.DataPropertyName = "charisma";
            this.charismaDataGridViewTextBoxColumn1.HeaderText = "charisma";
            this.charismaDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.charismaDataGridViewTextBoxColumn1.Name = "charismaDataGridViewTextBoxColumn1";
            this.charismaDataGridViewTextBoxColumn1.Width = 150;
            // 
            // armorclassDataGridViewTextBoxColumn1
            // 
            this.armorclassDataGridViewTextBoxColumn1.DataPropertyName = "armor_class";
            this.armorclassDataGridViewTextBoxColumn1.HeaderText = "armor_class";
            this.armorclassDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.armorclassDataGridViewTextBoxColumn1.Name = "armorclassDataGridViewTextBoxColumn1";
            this.armorclassDataGridViewTextBoxColumn1.Width = 150;
            // 
            // characternotesDataGridViewTextBoxColumn
            // 
            this.characternotesDataGridViewTextBoxColumn.DataPropertyName = "character_notes";
            this.characternotesDataGridViewTextBoxColumn.HeaderText = "character_notes";
            this.characternotesDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.characternotesDataGridViewTextBoxColumn.Name = "characternotesDataGridViewTextBoxColumn";
            this.characternotesDataGridViewTextBoxColumn.Width = 150;
            // 
            // skillsDataGridViewTextBoxColumn
            // 
            this.skillsDataGridViewTextBoxColumn.DataPropertyName = "skills";
            this.skillsDataGridViewTextBoxColumn.HeaderText = "skills";
            this.skillsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.skillsDataGridViewTextBoxColumn.Name = "skillsDataGridViewTextBoxColumn";
            this.skillsDataGridViewTextBoxColumn.Width = 150;
            // 
            // abilitiesDataGridViewTextBoxColumn
            // 
            this.abilitiesDataGridViewTextBoxColumn.DataPropertyName = "abilities";
            this.abilitiesDataGridViewTextBoxColumn.HeaderText = "abilities";
            this.abilitiesDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.abilitiesDataGridViewTextBoxColumn.Name = "abilitiesDataGridViewTextBoxColumn";
            this.abilitiesDataGridViewTextBoxColumn.Width = 150;
            // 
            // attacksDataGridViewTextBoxColumn
            // 
            this.attacksDataGridViewTextBoxColumn.DataPropertyName = "attacks";
            this.attacksDataGridViewTextBoxColumn.HeaderText = "attacks";
            this.attacksDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.attacksDataGridViewTextBoxColumn.Name = "attacksDataGridViewTextBoxColumn";
            this.attacksDataGridViewTextBoxColumn.Width = 150;
            // 
            // npcBindingSource
            // 
            this.npcBindingSource.DataMember = "npc";
            this.npcBindingSource.DataSource = this.worldweaverDataSet;
            // 
            // npcTableAdapter
            // 
            this.npcTableAdapter.ClearBeforeFill = true;
            // 
            // charaBtn
            // 
            this.charaBtn.Location = new System.Drawing.Point(75, 263);
            this.charaBtn.Name = "charaBtn";
            this.charaBtn.Size = new System.Drawing.Size(152, 40);
            this.charaBtn.TabIndex = 2;
            this.charaBtn.Text = "Character Info";
            this.charaBtn.UseVisualStyleBackColor = true;
            this.charaBtn.Click += new System.EventHandler(this.charaBtn_Click);
            // 
            // npcBtn
            // 
            this.npcBtn.Location = new System.Drawing.Point(75, 775);
            this.npcBtn.Name = "npcBtn";
            this.npcBtn.Size = new System.Drawing.Size(152, 40);
            this.npcBtn.TabIndex = 3;
            this.npcBtn.Text = "NPC Info";
            this.npcBtn.UseVisualStyleBackColor = true;
            this.npcBtn.Click += new System.EventHandler(this.npcBtn_Click);
            // 
            // DM_info_sheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1766, 984);
            this.Controls.Add(this.npcBtn);
            this.Controls.Add(this.charaBtn);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DM_info_sheet";
            this.Text = "DM_info_sheet";
            this.Load += new System.EventHandler(this.DM_info_sheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldweaverDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private worldweaverDataSet worldweaverDataSet;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private worldweaverDataSetTableAdapters.playerTableAdapter playerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn playeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notestodmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hitpointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dexterityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constitutionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intelligenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wisdomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn charismaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proficiencybonusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn walkingspeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn initiativeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn armorclassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource npcBindingSource;
        private worldweaverDataSetTableAdapters.npcTableAdapter npcTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn npcidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn npcnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hitpointsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn strengthDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dexterityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn constitutionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn intelligenceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn wisdomDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn charismaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn armorclassDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn characternotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abilitiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attacksDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button charaBtn;
        private System.Windows.Forms.Button npcBtn;
    }
}