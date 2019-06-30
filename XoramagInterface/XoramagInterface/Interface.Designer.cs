namespace XoramagInterface
{
    partial class Interface
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Weapon = new System.Windows.Forms.ListBox();
            this.Armor = new System.Windows.Forms.ListBox();
            this.Misc = new System.Windows.Forms.ListBox();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.CharacterMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CharacterNew = new System.Windows.Forms.ToolStripMenuItem();
            this.CharacterSave = new System.Windows.Forms.ToolStripMenuItem();
            this.CharacterLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.InventoryMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.InventoryAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.InventoryRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.AdventureMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AdventureCombat = new System.Windows.Forms.ToolStripMenuItem();
            this.AdventureDestiny = new System.Windows.Forms.ToolStripMenuItem();
            this.NaturalAbility = new System.Windows.Forms.TextBox();
            this.CombatAbility = new System.Windows.Forms.TextBox();
            this.BestWeaponDamageBonus = new System.Windows.Forms.TextBox();
            this.Protection = new System.Windows.Forms.TextBox();
            this.FocusedItem = new System.Windows.Forms.ListBox();
            this.NaturalAbilityChangeButton = new System.Windows.Forms.Button();
            this.EndurenceChangeButton = new System.Windows.Forms.Button();
            this.ZeroPrivilege = new System.Windows.Forms.TextBox();
            this.ZeroPrivilegeChangeButton = new System.Windows.Forms.Button();
            this.Endurence = new System.Windows.Forms.TextBox();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Weapon
            // 
            this.Weapon.FormattingEnabled = true;
            this.Weapon.Location = new System.Drawing.Point(12, 148);
            this.Weapon.Name = "Weapon";
            this.Weapon.Size = new System.Drawing.Size(214, 290);
            this.Weapon.TabIndex = 0;
            this.Weapon.SelectedIndexChanged += new System.EventHandler(this.WeaponEvent);
            // 
            // Armor
            // 
            this.Armor.FormattingEnabled = true;
            this.Armor.Location = new System.Drawing.Point(232, 149);
            this.Armor.Name = "Armor";
            this.Armor.Size = new System.Drawing.Size(214, 290);
            this.Armor.TabIndex = 1;
            this.Armor.SelectedIndexChanged += new System.EventHandler(this.ArmorEvent);
            // 
            // Misc
            // 
            this.Misc.FormattingEnabled = true;
            this.Misc.Location = new System.Drawing.Point(452, 148);
            this.Misc.Name = "Misc";
            this.Misc.Size = new System.Drawing.Size(214, 290);
            this.Misc.TabIndex = 2;
            this.Misc.SelectedIndexChanged += new System.EventHandler(this.MiscEvent);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CharacterMenu,
            this.InventoryMenu,
            this.AdventureMenu});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(678, 24);
            this.MainMenu.TabIndex = 3;
            this.MainMenu.Text = "menuStrip1";
            this.MainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MainMenu_ItemClicked);
            // 
            // CharacterMenu
            // 
            this.CharacterMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CharacterNew,
            this.CharacterSave,
            this.CharacterLoad});
            this.CharacterMenu.Name = "CharacterMenu";
            this.CharacterMenu.Size = new System.Drawing.Size(70, 20);
            this.CharacterMenu.Text = "Character";
            // 
            // CharacterNew
            // 
            this.CharacterNew.Name = "CharacterNew";
            this.CharacterNew.Size = new System.Drawing.Size(100, 22);
            this.CharacterNew.Text = "New";
            this.CharacterNew.Click += new System.EventHandler(this.CharacterNewEvent);
            // 
            // CharacterSave
            // 
            this.CharacterSave.Name = "CharacterSave";
            this.CharacterSave.Size = new System.Drawing.Size(100, 22);
            this.CharacterSave.Text = "Save";
            this.CharacterSave.Click += new System.EventHandler(this.CharacterSaveEvent);
            // 
            // CharacterLoad
            // 
            this.CharacterLoad.Name = "CharacterLoad";
            this.CharacterLoad.Size = new System.Drawing.Size(100, 22);
            this.CharacterLoad.Text = "Load";
            this.CharacterLoad.Click += new System.EventHandler(this.CharacterLoadEvent);
            // 
            // InventoryMenu
            // 
            this.InventoryMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InventoryAdd,
            this.InventoryRemove});
            this.InventoryMenu.Name = "InventoryMenu";
            this.InventoryMenu.Size = new System.Drawing.Size(69, 20);
            this.InventoryMenu.Text = "Inventory";
            // 
            // InventoryAdd
            // 
            this.InventoryAdd.Name = "InventoryAdd";
            this.InventoryAdd.Size = new System.Drawing.Size(160, 22);
            this.InventoryAdd.Text = "Add a new item";
            this.InventoryAdd.Click += new System.EventHandler(this.InventoryAddEvent);
            // 
            // InventoryRemove
            // 
            this.InventoryRemove.Name = "InventoryRemove";
            this.InventoryRemove.Size = new System.Drawing.Size(160, 22);
            this.InventoryRemove.Text = "Remove an item";
            this.InventoryRemove.Click += new System.EventHandler(this.InventoryRemoveEvent);
            // 
            // AdventureMenu
            // 
            this.AdventureMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdventureCombat,
            this.AdventureDestiny});
            this.AdventureMenu.Name = "AdventureMenu";
            this.AdventureMenu.Size = new System.Drawing.Size(67, 20);
            this.AdventureMenu.Text = "Aventure";
            // 
            // AdventureCombat
            // 
            this.AdventureCombat.Name = "AdventureCombat";
            this.AdventureCombat.Size = new System.Drawing.Size(153, 22);
            this.AdventureCombat.Text = "Combat";
            this.AdventureCombat.Click += new System.EventHandler(this.AdventureCombatEvent);
            // 
            // AdventureDestiny
            // 
            this.AdventureDestiny.Name = "AdventureDestiny";
            this.AdventureDestiny.Size = new System.Drawing.Size(153, 22);
            this.AdventureDestiny.Text = "Map of destiny";
            this.AdventureDestiny.Click += new System.EventHandler(this.AdventureDestinyEvent);
            // 
            // NaturalAbility
            // 
            this.NaturalAbility.Location = new System.Drawing.Point(12, 53);
            this.NaturalAbility.Name = "NaturalAbility";
            this.NaturalAbility.ReadOnly = true;
            this.NaturalAbility.Size = new System.Drawing.Size(214, 20);
            this.NaturalAbility.TabIndex = 4;
            this.NaturalAbility.Text = "Natural Ability";
            // 
            // CombatAbility
            // 
            this.CombatAbility.Location = new System.Drawing.Point(232, 53);
            this.CombatAbility.Name = "CombatAbility";
            this.CombatAbility.ReadOnly = true;
            this.CombatAbility.Size = new System.Drawing.Size(214, 20);
            this.CombatAbility.TabIndex = 6;
            this.CombatAbility.Text = "CombatAbility";
            // 
            // BestWeaponDamageBonus
            // 
            this.BestWeaponDamageBonus.Location = new System.Drawing.Point(232, 79);
            this.BestWeaponDamageBonus.Name = "BestWeaponDamageBonus";
            this.BestWeaponDamageBonus.ReadOnly = true;
            this.BestWeaponDamageBonus.Size = new System.Drawing.Size(214, 20);
            this.BestWeaponDamageBonus.TabIndex = 8;
            this.BestWeaponDamageBonus.Text = "BestWeaponDamageBonus";
            // 
            // Protection
            // 
            this.Protection.Location = new System.Drawing.Point(232, 105);
            this.Protection.Name = "Protection";
            this.Protection.ReadOnly = true;
            this.Protection.Size = new System.Drawing.Size(214, 20);
            this.Protection.TabIndex = 9;
            this.Protection.Text = "Protection";
            // 
            // FocusedItem
            // 
            this.FocusedItem.FormattingEnabled = true;
            this.FocusedItem.Location = new System.Drawing.Point(452, 53);
            this.FocusedItem.Name = "FocusedItem";
            this.FocusedItem.Size = new System.Drawing.Size(214, 82);
            this.FocusedItem.TabIndex = 10;
            // 
            // NaturalAbilityChangeButton
            // 
            this.NaturalAbilityChangeButton.Location = new System.Drawing.Point(151, 53);
            this.NaturalAbilityChangeButton.Name = "NaturalAbilityChangeButton";
            this.NaturalAbilityChangeButton.Size = new System.Drawing.Size(75, 20);
            this.NaturalAbilityChangeButton.TabIndex = 12;
            this.NaturalAbilityChangeButton.Text = "Change";
            this.NaturalAbilityChangeButton.UseVisualStyleBackColor = true;
            this.NaturalAbilityChangeButton.Click += new System.EventHandler(this.NaturalAbilityButtonChanged);
            // 
            // EndurenceChangeButton
            // 
            this.EndurenceChangeButton.Location = new System.Drawing.Point(151, 79);
            this.EndurenceChangeButton.Name = "EndurenceChangeButton";
            this.EndurenceChangeButton.Size = new System.Drawing.Size(75, 20);
            this.EndurenceChangeButton.TabIndex = 16;
            this.EndurenceChangeButton.Text = "Change";
            this.EndurenceChangeButton.UseVisualStyleBackColor = true;
            this.EndurenceChangeButton.Click += new System.EventHandler(this.EndurenceButtonChanged);
            // 
            // ZeroPrivilege
            // 
            this.ZeroPrivilege.Location = new System.Drawing.Point(12, 105);
            this.ZeroPrivilege.Name = "ZeroPrivilege";
            this.ZeroPrivilege.ReadOnly = true;
            this.ZeroPrivilege.Size = new System.Drawing.Size(214, 20);
            this.ZeroPrivilege.TabIndex = 15;
            this.ZeroPrivilege.Text = "ZeroPrivilege";
            // 
            // ZeroPrivilegeChangeButton
            // 
            this.ZeroPrivilegeChangeButton.Location = new System.Drawing.Point(151, 105);
            this.ZeroPrivilegeChangeButton.Name = "ZeroPrivilegeChangeButton";
            this.ZeroPrivilegeChangeButton.Size = new System.Drawing.Size(75, 20);
            this.ZeroPrivilegeChangeButton.TabIndex = 18;
            this.ZeroPrivilegeChangeButton.Text = "Change";
            this.ZeroPrivilegeChangeButton.UseVisualStyleBackColor = true;
            this.ZeroPrivilegeChangeButton.Click += new System.EventHandler(this.ZeroPrivilegeButtonChanged);
            // 
            // Endurence
            // 
            this.Endurence.Location = new System.Drawing.Point(12, 79);
            this.Endurence.Name = "Endurence";
            this.Endurence.ReadOnly = true;
            this.Endurence.Size = new System.Drawing.Size(214, 20);
            this.Endurence.TabIndex = 17;
            this.Endurence.Text = "Endurence";
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.ZeroPrivilegeChangeButton);
            this.Controls.Add(this.EndurenceChangeButton);
            this.Controls.Add(this.ZeroPrivilege);
            this.Controls.Add(this.FocusedItem);
            this.Controls.Add(this.Protection);
            this.Controls.Add(this.BestWeaponDamageBonus);
            this.Controls.Add(this.CombatAbility);
            this.Controls.Add(this.Misc);
            this.Controls.Add(this.Armor);
            this.Controls.Add(this.Weapon);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.Endurence);
            this.Controls.Add(this.NaturalAbilityChangeButton);
            this.Controls.Add(this.NaturalAbility);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "Interface";
            this.Text = "Xhoramag Combat Simulator - Character Sheet";
            this.Load += new System.EventHandler(this.InterfaceLoad);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Weapon;
        private System.Windows.Forms.ListBox Armor;
        private System.Windows.Forms.ListBox Misc;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem CharacterMenu;
        private System.Windows.Forms.ToolStripMenuItem CharacterNew;
        private System.Windows.Forms.ToolStripMenuItem CharacterSave;
        private System.Windows.Forms.ToolStripMenuItem CharacterLoad;
        private System.Windows.Forms.ToolStripMenuItem InventoryMenu;
        private System.Windows.Forms.ToolStripMenuItem InventoryAdd;
        private System.Windows.Forms.ToolStripMenuItem InventoryRemove;
        private System.Windows.Forms.ToolStripMenuItem AdventureMenu;
        private System.Windows.Forms.ToolStripMenuItem AdventureCombat;
        private System.Windows.Forms.ToolStripMenuItem AdventureDestiny;
        private System.Windows.Forms.TextBox NaturalAbility;
        private System.Windows.Forms.TextBox CombatAbility;
        private System.Windows.Forms.TextBox BestWeaponDamageBonus;
        private System.Windows.Forms.TextBox Protection;
        private System.Windows.Forms.ListBox FocusedItem;
        private System.Windows.Forms.Button NaturalAbilityChangeButton;
        private System.Windows.Forms.Button EndurenceChangeButton;
        private System.Windows.Forms.TextBox ZeroPrivilege;
        private System.Windows.Forms.Button ZeroPrivilegeChangeButton;
        private System.Windows.Forms.TextBox Endurence;
    }
}

