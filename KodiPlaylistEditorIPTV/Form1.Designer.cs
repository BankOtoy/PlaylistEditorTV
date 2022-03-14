﻿namespace PlaylistEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.cutRowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteRowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cm1NewColumn = new System.Windows.Forms.ToolStripMenuItem();
            this.cm1ColCombo = new System.Windows.Forms.ToolStripComboBox();
            this.cm1AddColumn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cms1NewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.cms1Number = new System.Windows.Forms.ToolStripMenuItem();
            this.cms1GetName = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox_find = new System.Windows.Forms.TextBox();
            this.button_kodi = new PlaylistEditor.MyButton();
            this.button_import = new PlaylistEditor.MyButton();
            this.RedoButton = new PlaylistEditor.MyButton();
            this.UndoButton = new PlaylistEditor.MyButton();
            this.button_check = new PlaylistEditor.MyButton();
            this.button_vlc = new PlaylistEditor.MyButton();
            this.button_revert = new PlaylistEditor.MyButton();
            this.button_dup = new PlaylistEditor.MyButton();
            this.contextMenuStrip5 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cm5ColumNames = new System.Windows.Forms.ToolStripComboBox();
            this.cm5StartSearchDupli = new System.Windows.Forms.ToolStripMenuItem();
            this.button_search = new PlaylistEditor.MyButton();
            this.button_moveDown = new RepeatingButton();
            this.button_moveUp = new RepeatingButton();
            this.button_del_all = new PlaylistEditor.MyButton();
            this.button_settings = new PlaylistEditor.MyButton();
            this.button_add = new PlaylistEditor.MyButton();
            this.button_Info = new PlaylistEditor.MyButton();
            this.button_delLine = new PlaylistEditor.MyButton();
            this.button_save = new PlaylistEditor.MyButton();
            this.button_open = new PlaylistEditor.MyButton();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addUseragentCell = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editCellCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.editCellPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.editCellCut = new System.Windows.Forms.ToolStripMenuItem();
            this.label_central = new System.Windows.Forms.Label();
            this.lblRowCheck = new System.Windows.Forms.Label();
            this.lblColCheck = new System.Windows.Forms.Label();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cm3Scrollbar = new System.Windows.Forms.ToolStripMenuItem();
            this.cm3EditF2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cm4EditFIleHeader = new System.Windows.Forms.ToolStripMenuItem();
            this.button_refind = new PlaylistEditor.MyButton();
            this.button_clearfind = new PlaylistEditor.MyButton();
            this.plabel_Filename = new PathLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip5.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.contextMenuStrip4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dataGridView1_CellContextMenuStripNeeded);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            this.dataGridView1.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellValidated);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragDrop);
            this.dataGridView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragEnter);
            this.dataGridView1.DragOver += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragOver);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            this.dataGridView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseMove);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCopy,
            this.toolStripPaste,
            this.cutRowMenuItem,
            this.pasteRowMenuItem,
            this.toolStripSeparator2,
            this.playToolStripMenuItem,
            this.toolStripSeparator3,
            this.hideToolStripMenuItem,
            this.showToolStripMenuItem,
            this.cm1NewColumn,
            this.toolStripSeparator4,
            this.cms1NewWindow,
            this.cms1Number,
            this.cms1GetName});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolStripCopy
            // 
            this.toolStripCopy.Name = "toolStripCopy";
            resources.ApplyResources(this.toolStripCopy, "toolStripCopy");
            this.toolStripCopy.Click += new System.EventHandler(this.toolStripCopy_Click);
            // 
            // toolStripPaste
            // 
            resources.ApplyResources(this.toolStripPaste, "toolStripPaste");
            this.toolStripPaste.Name = "toolStripPaste";
            this.toolStripPaste.Click += new System.EventHandler(this.toolStripPaste_Click);
            // 
            // cutRowMenuItem
            // 
            resources.ApplyResources(this.cutRowMenuItem, "cutRowMenuItem");
            this.cutRowMenuItem.Name = "cutRowMenuItem";
            this.cutRowMenuItem.Click += new System.EventHandler(this.cutRowMenuItem_Click);
            // 
            // pasteRowMenuItem
            // 
            resources.ApplyResources(this.pasteRowMenuItem, "pasteRowMenuItem");
            this.pasteRowMenuItem.Name = "pasteRowMenuItem";
            this.pasteRowMenuItem.Click += new System.EventHandler(this.pasteRowMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            resources.ApplyResources(this.playToolStripMenuItem, "playToolStripMenuItem");
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            resources.ApplyResources(this.hideToolStripMenuItem, "hideToolStripMenuItem");
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            resources.ApplyResources(this.showToolStripMenuItem, "showToolStripMenuItem");
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // cm1NewColumn
            // 
            this.cm1NewColumn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cm1ColCombo,
            this.cm1AddColumn});
            this.cm1NewColumn.Name = "cm1NewColumn";
            resources.ApplyResources(this.cm1NewColumn, "cm1NewColumn");
            this.cm1NewColumn.Click += new System.EventHandler(this.cm1NewColumn_Click);
            // 
            // cm1ColCombo
            // 
            this.cm1ColCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cm1ColCombo.Name = "cm1ColCombo";
            resources.ApplyResources(this.cm1ColCombo, "cm1ColCombo");
            this.cm1ColCombo.SelectedIndexChanged += new System.EventHandler(this.cm1ColCombo_SelectedIndexChanged);
            this.cm1ColCombo.Click += new System.EventHandler(this.cm1ColCombo_Click);
            // 
            // cm1AddColumn
            // 
            resources.ApplyResources(this.cm1AddColumn, "cm1AddColumn");
            this.cm1AddColumn.Name = "cm1AddColumn";
            this.cm1AddColumn.Click += new System.EventHandler(this.cm1AddColumn_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // cms1NewWindow
            // 
            this.cms1NewWindow.Name = "cms1NewWindow";
            resources.ApplyResources(this.cms1NewWindow, "cms1NewWindow");
            this.cms1NewWindow.Click += new System.EventHandler(this.newWindowToolStripMenuItem_Click);
            // 
            // cms1Number
            // 
            resources.ApplyResources(this.cms1Number, "cms1Number");
            this.cms1Number.Name = "cms1Number";
            this.cms1Number.Click += new System.EventHandler(this.cm1Number_Click);
            // 
            // cms1GetName
            // 
            this.cms1GetName.Name = "cms1GetName";
            resources.ApplyResources(this.cms1GetName, "cms1GetName");
            this.cms1GetName.Click += new System.EventHandler(this.cms1GetName_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "m3u";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "m3u";
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // textBox_find
            // 
            resources.ApplyResources(this.textBox_find, "textBox_find");
            this.textBox_find.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_find.Name = "textBox_find";
            this.toolTip1.SetToolTip(this.textBox_find, resources.GetString("textBox_find.ToolTip"));
            this.textBox_find.TextChanged += new System.EventHandler(this.textBox_find_TextChange);
            this.textBox_find.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_find_KeyPress);
            // 
            // button_kodi
            // 
            resources.ApplyResources(this.button_kodi, "button_kodi");
            this.button_kodi.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_kodi.FlatAppearance.BorderSize = 0;
            this.button_kodi.Image = global::PlaylistEditor.Properties.Resources.arrow_right_circle_outline_2_r;
            this.button_kodi.Name = "button_kodi";
            this.toolTip1.SetToolTip(this.button_kodi, resources.GetString("button_kodi.ToolTip"));
            this.button_kodi.UseVisualStyleBackColor = true;
            this.button_kodi.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_import
            // 
            resources.ApplyResources(this.button_import, "button_import");
            this.button_import.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_import.FlatAppearance.BorderSize = 0;
            this.button_import.Image = global::PlaylistEditor.Properties.Resources.import_r;
            this.button_import.Name = "button_import";
            this.toolTip1.SetToolTip(this.button_import, resources.GetString("button_import.ToolTip"));
            this.button_import.UseVisualStyleBackColor = true;
            this.button_import.Click += new System.EventHandler(this.button_import_Click);
            // 
            // RedoButton
            // 
            this.RedoButton.BackColor = System.Drawing.Color.MidnightBlue;
            resources.ApplyResources(this.RedoButton, "RedoButton");
            this.RedoButton.FlatAppearance.BorderSize = 0;
            this.RedoButton.Image = global::PlaylistEditor.Properties.Resources.redo_r;
            this.RedoButton.Name = "RedoButton";
            this.toolTip1.SetToolTip(this.RedoButton, resources.GetString("RedoButton.ToolTip"));
            this.RedoButton.UseVisualStyleBackColor = true;
            this.RedoButton.Click += new System.EventHandler(this.RedoButton_Click);
            // 
            // UndoButton
            // 
            this.UndoButton.BackColor = System.Drawing.Color.MidnightBlue;
            resources.ApplyResources(this.UndoButton, "UndoButton");
            this.UndoButton.FlatAppearance.BorderSize = 0;
            this.UndoButton.Image = global::PlaylistEditor.Properties.Resources.undo_r;
            this.UndoButton.Name = "UndoButton";
            this.toolTip1.SetToolTip(this.UndoButton, resources.GetString("UndoButton.ToolTip"));
            this.UndoButton.UseVisualStyleBackColor = true;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // button_check
            // 
            resources.ApplyResources(this.button_check, "button_check");
            this.button_check.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_check.FlatAppearance.BorderSize = 0;
            this.button_check.Image = global::PlaylistEditor.Properties.Resources.playlist_check_r;
            this.button_check.Name = "button_check";
            this.toolTip1.SetToolTip(this.button_check, resources.GetString("button_check.ToolTip"));
            this.button_check.UseVisualStyleBackColor = true;
            this.button_check.Click += new System.EventHandler(this.Button_check_Click);
            // 
            // button_vlc
            // 
            resources.ApplyResources(this.button_vlc, "button_vlc");
            this.button_vlc.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_vlc.FlatAppearance.BorderSize = 0;
            this.button_vlc.Image = global::PlaylistEditor.Properties.Resources.arrow_right_drop_circle_outline_r;
            this.button_vlc.Name = "button_vlc";
            this.toolTip1.SetToolTip(this.button_vlc, resources.GetString("button_vlc.ToolTip"));
            this.button_vlc.UseVisualStyleBackColor = true;
            this.button_vlc.Click += new System.EventHandler(this.button_vlc_Click);
            // 
            // button_revert
            // 
            this.button_revert.BackColor = System.Drawing.Color.MidnightBlue;
            resources.ApplyResources(this.button_revert, "button_revert");
            this.button_revert.FlatAppearance.BorderSize = 0;
            this.button_revert.Image = global::PlaylistEditor.Properties.Resources.reload_r;
            this.button_revert.Name = "button_revert";
            this.toolTip1.SetToolTip(this.button_revert, resources.GetString("button_revert.ToolTip"));
            this.button_revert.UseVisualStyleBackColor = true;
            this.button_revert.Click += new System.EventHandler(this.button_revert_Click);
            // 
            // button_dup
            // 
            resources.ApplyResources(this.button_dup, "button_dup");
            this.button_dup.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_dup.ContextMenuStrip = this.contextMenuStrip5;
            this.button_dup.FlatAppearance.BorderSize = 0;
            this.button_dup.Image = global::PlaylistEditor.Properties.Resources.content_duplicate_r;
            this.button_dup.Name = "button_dup";
            this.toolTip1.SetToolTip(this.button_dup, resources.GetString("button_dup.ToolTip"));
            this.button_dup.UseVisualStyleBackColor = true;
            this.button_dup.Click += new System.EventHandler(this.button_dup_Click);
            // 
            // contextMenuStrip5
            // 
            this.contextMenuStrip5.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contextMenuStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cm5ColumNames,
            this.cm5StartSearchDupli});
            this.contextMenuStrip5.Name = "contextMenuStrip5";
            resources.ApplyResources(this.contextMenuStrip5, "contextMenuStrip5");
            this.contextMenuStrip5.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip5_Opening);
            // 
            // cm5ColumNames
            // 
            this.cm5ColumNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cm5ColumNames.Name = "cm5ColumNames";
            resources.ApplyResources(this.cm5ColumNames, "cm5ColumNames");
            this.cm5ColumNames.SelectedIndexChanged += new System.EventHandler(this.cm5ColumNames_SelectedIndexChanged);
            // 
            // cm5StartSearchDupli
            // 
            resources.ApplyResources(this.cm5StartSearchDupli, "cm5StartSearchDupli");
            this.cm5StartSearchDupli.Name = "cm5StartSearchDupli";
            this.cm5StartSearchDupli.Click += new System.EventHandler(this.cm5StartSearchDupli_Click);
            // 
            // button_search
            // 
            resources.ApplyResources(this.button_search, "button_search");
            this.button_search.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_search.FlatAppearance.BorderSize = 0;
            this.button_search.Image = global::PlaylistEditor.Properties.Resources.table_search_r;
            this.button_search.Name = "button_search";
            this.toolTip1.SetToolTip(this.button_search, resources.GetString("button_search.ToolTip"));
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_moveDown
            // 
            resources.ApplyResources(this.button_moveDown, "button_moveDown");
            this.button_moveDown.FlatAppearance.BorderSize = 0;
            this.button_moveDown.Image = global::PlaylistEditor.Properties.Resources.arrow_down_bold_r;
            this.button_moveDown.Name = "button_moveDown";
            this.toolTip1.SetToolTip(this.button_moveDown, resources.GetString("button_moveDown.ToolTip"));
            this.button_moveDown.UseVisualStyleBackColor = true;
            this.button_moveDown.Click += new System.EventHandler(this.button_moveDown_Click);
            // 
            // button_moveUp
            // 
            resources.ApplyResources(this.button_moveUp, "button_moveUp");
            this.button_moveUp.FlatAppearance.BorderSize = 0;
            this.button_moveUp.Image = global::PlaylistEditor.Properties.Resources.arrow_up_bold_r;
            this.button_moveUp.Name = "button_moveUp";
            this.toolTip1.SetToolTip(this.button_moveUp, resources.GetString("button_moveUp.ToolTip"));
            this.button_moveUp.UseVisualStyleBackColor = true;
            this.button_moveUp.Click += new System.EventHandler(this.button_moveUp_Click);
            // 
            // button_del_all
            // 
            resources.ApplyResources(this.button_del_all, "button_del_all");
            this.button_del_all.FlatAppearance.BorderSize = 0;
            this.button_del_all.Image = global::PlaylistEditor.Properties.Resources.delete_forever_outline_r;
            this.button_del_all.Name = "button_del_all";
            this.toolTip1.SetToolTip(this.button_del_all, resources.GetString("button_del_all.ToolTip"));
            this.button_del_all.UseVisualStyleBackColor = true;
            this.button_del_all.Click += new System.EventHandler(this.button_del_all_Click);
            // 
            // button_settings
            // 
            resources.ApplyResources(this.button_settings, "button_settings");
            this.button_settings.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_settings.FlatAppearance.BorderSize = 0;
            this.button_settings.Image = global::PlaylistEditor.Properties.Resources.settings_outline_r;
            this.button_settings.Name = "button_settings";
            this.toolTip1.SetToolTip(this.button_settings, resources.GetString("button_settings.ToolTip"));
            this.button_settings.UseVisualStyleBackColor = true;
            this.button_settings.Click += new System.EventHandler(this.button_settings_Click);
            // 
            // button_add
            // 
            resources.ApplyResources(this.button_add, "button_add");
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.Image = global::PlaylistEditor.Properties.Resources.playlist_plus_r;
            this.button_add.Name = "button_add";
            this.toolTip1.SetToolTip(this.button_add, resources.GetString("button_add.ToolTip"));
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_Info
            // 
            resources.ApplyResources(this.button_Info, "button_Info");
            this.button_Info.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_Info.FlatAppearance.BorderSize = 0;
            this.button_Info.Image = global::PlaylistEditor.Properties.Resources.information_outline_r;
            this.button_Info.Name = "button_Info";
            this.toolTip1.SetToolTip(this.button_Info, resources.GetString("button_Info.ToolTip"));
            this.button_Info.UseVisualStyleBackColor = true;
            this.button_Info.Click += new System.EventHandler(this.button_Info_Click);
            // 
            // button_delLine
            // 
            resources.ApplyResources(this.button_delLine, "button_delLine");
            this.button_delLine.FlatAppearance.BorderSize = 0;
            this.button_delLine.Image = global::PlaylistEditor.Properties.Resources.close_box_outline_r;
            this.button_delLine.Name = "button_delLine";
            this.toolTip1.SetToolTip(this.button_delLine, resources.GetString("button_delLine.ToolTip"));
            this.button_delLine.UseVisualStyleBackColor = true;
            this.button_delLine.Click += new System.EventHandler(this.button_delLine_Click);
            // 
            // button_save
            // 
            resources.ApplyResources(this.button_save, "button_save");
            this.button_save.FlatAppearance.BorderSize = 0;
            this.button_save.Image = global::PlaylistEditor.Properties.Resources.content_save_r;
            this.button_save.Name = "button_save";
            this.toolTip1.SetToolTip(this.button_save, resources.GetString("button_save.ToolTip"));
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_open
            // 
            resources.ApplyResources(this.button_open, "button_open");
            this.button_open.FlatAppearance.BorderSize = 0;
            this.button_open.Image = global::PlaylistEditor.Properties.Resources.open_in_app_r;
            this.button_open.Name = "button_open";
            this.toolTip1.SetToolTip(this.button_open, resources.GetString("button_open.ToolTip"));
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUseragentCell,
            this.toolStripSeparator1,
            this.editCellCopy,
            this.editCellPaste,
            this.editCellCut});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            resources.ApplyResources(this.contextMenuStrip2, "contextMenuStrip2");
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // addUseragentCell
            // 
            this.addUseragentCell.Name = "addUseragentCell";
            resources.ApplyResources(this.addUseragentCell, "addUseragentCell");
            this.addUseragentCell.Click += new System.EventHandler(this.addUseragentCell_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // editCellCopy
            // 
            this.editCellCopy.Name = "editCellCopy";
            resources.ApplyResources(this.editCellCopy, "editCellCopy");
            this.editCellCopy.Click += new System.EventHandler(this.editCellCopy_Click);
            // 
            // editCellPaste
            // 
            this.editCellPaste.Name = "editCellPaste";
            resources.ApplyResources(this.editCellPaste, "editCellPaste");
            this.editCellPaste.Click += new System.EventHandler(this.editCellPaste_Click);
            // 
            // editCellCut
            // 
            this.editCellCut.Name = "editCellCut";
            resources.ApplyResources(this.editCellCut, "editCellCut");
            this.editCellCut.Click += new System.EventHandler(this.editCellCut_Click);
            // 
            // label_central
            // 
            resources.ApplyResources(this.label_central, "label_central");
            this.label_central.BackColor = System.Drawing.Color.Gray;
            this.label_central.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_central.Name = "label_central";
            this.label_central.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // lblRowCheck
            // 
            resources.ApplyResources(this.lblRowCheck, "lblRowCheck");
            this.lblRowCheck.BackColor = System.Drawing.Color.White;
            this.lblRowCheck.ForeColor = System.Drawing.Color.Black;
            this.lblRowCheck.Name = "lblRowCheck";
            this.lblRowCheck.Click += new System.EventHandler(this.label_click);
            // 
            // lblColCheck
            // 
            resources.ApplyResources(this.lblColCheck, "lblColCheck");
            this.lblColCheck.BackColor = System.Drawing.Color.White;
            this.lblColCheck.ForeColor = System.Drawing.Color.Black;
            this.lblColCheck.Name = "lblColCheck";
            this.lblColCheck.Click += new System.EventHandler(this.label_click);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cm3Scrollbar,
            this.cm3EditF2});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            resources.ApplyResources(this.contextMenuStrip3, "contextMenuStrip3");
            // 
            // cm3Scrollbar
            // 
            this.cm3Scrollbar.Checked = true;
            this.cm3Scrollbar.CheckOnClick = true;
            this.cm3Scrollbar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cm3Scrollbar.Name = "cm3Scrollbar";
            resources.ApplyResources(this.cm3Scrollbar, "cm3Scrollbar");
            this.cm3Scrollbar.CheckStateChanged += new System.EventHandler(this.cm3Scrollbar_CheckStateChanged);
            // 
            // cm3EditF2
            // 
            this.cm3EditF2.Checked = true;
            this.cm3EditF2.CheckOnClick = true;
            this.cm3EditF2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cm3EditF2.Name = "cm3EditF2";
            resources.ApplyResources(this.cm3EditF2, "cm3EditF2");
            this.cm3EditF2.CheckStateChanged += new System.EventHandler(this.cm3EditF2_CheckStateChanged);
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contextMenuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cm4EditFIleHeader});
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            resources.ApplyResources(this.contextMenuStrip4, "contextMenuStrip4");
            // 
            // cm4EditFIleHeader
            // 
            this.cm4EditFIleHeader.Name = "cm4EditFIleHeader";
            resources.ApplyResources(this.cm4EditFIleHeader, "cm4EditFIleHeader");
            this.cm4EditFIleHeader.Click += new System.EventHandler(this.cm4EditFIleHeader_Click);
            // 
            // button_refind
            // 
            resources.ApplyResources(this.button_refind, "button_refind");
            this.button_refind.BackColor = System.Drawing.Color.White;
            this.button_refind.FlatAppearance.BorderSize = 0;
            this.button_refind.ForeColor = System.Drawing.Color.Black;
            this.button_refind.Name = "button_refind";
            this.button_refind.UseVisualStyleBackColor = false;
            this.button_refind.Click += new System.EventHandler(this.button_refind_Click);
            // 
            // button_clearfind
            // 
            resources.ApplyResources(this.button_clearfind, "button_clearfind");
            this.button_clearfind.BackColor = System.Drawing.Color.White;
            this.button_clearfind.FlatAppearance.BorderSize = 0;
            this.button_clearfind.ForeColor = System.Drawing.SystemColors.Control;
            this.button_clearfind.Name = "button_clearfind";
            this.button_clearfind.UseVisualStyleBackColor = false;
            this.button_clearfind.Click += new System.EventHandler(this.button_clearfind_Click);
            // 
            // plabel_Filename
            // 
            resources.ApplyResources(this.plabel_Filename, "plabel_Filename");
            this.plabel_Filename.BackColor = System.Drawing.Color.MidnightBlue;
            this.plabel_Filename.ContextMenuStrip = this.contextMenuStrip4;
            this.plabel_Filename.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.plabel_Filename.Name = "plabel_Filename";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.Controls.Add(this.button_refind);
            this.Controls.Add(this.lblColCheck);
            this.Controls.Add(this.lblRowCheck);
            this.Controls.Add(this.label_central);
            this.Controls.Add(this.button_clearfind);
            this.Controls.Add(this.button_kodi);
            this.Controls.Add(this.button_import);
            this.Controls.Add(this.RedoButton);
            this.Controls.Add(this.UndoButton);
            this.Controls.Add(this.button_check);
            this.Controls.Add(this.button_vlc);
            this.Controls.Add(this.button_revert);
            this.Controls.Add(this.button_dup);
            this.Controls.Add(this.textBox_find);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_moveDown);
            this.Controls.Add(this.button_moveUp);
            this.Controls.Add(this.button_del_all);
            this.Controls.Add(this.button_settings);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.plabel_Filename);
            this.Controls.Add(this.button_Info);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_delLine);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_open);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip5.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.contextMenuStrip4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PlaylistEditor.MyButton button_open;
        private PlaylistEditor.MyButton button_save;
        private PlaylistEditor.MyButton button_delLine;
        private PlaylistEditor.MyButton button_Info;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private PathLabel plabel_Filename;
        private PlaylistEditor.MyButton button_add;
        private PlaylistEditor.MyButton button_settings;
        private PlaylistEditor.MyButton button_del_all;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pasteRowMenuItem;
        private RepeatingButton button_moveUp;
        private RepeatingButton button_moveDown;
        private PlaylistEditor.MyButton button_search;
        private System.Windows.Forms.TextBox textBox_find;
        private PlaylistEditor.MyButton button_dup;
        private System.Windows.Forms.ToolStripMenuItem toolStripCopy;
        private System.Windows.Forms.ToolStripMenuItem toolStripPaste;
        private System.Windows.Forms.ToolStripMenuItem cutRowMenuItem;
        private PlaylistEditor.MyButton button_revert;
        private PlaylistEditor.MyButton button_vlc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private PlaylistEditor.MyButton button_check;
        private PlaylistEditor.MyButton UndoButton;
        private PlaylistEditor.MyButton RedoButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private PlaylistEditor.MyButton button_import;
        private PlaylistEditor.MyButton button_kodi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem addUseragentCell;
        private System.Windows.Forms.ToolStripMenuItem editCellCopy;
        private System.Windows.Forms.ToolStripMenuItem editCellPaste;
        private System.Windows.Forms.ToolStripMenuItem editCellCut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private PlaylistEditor.MyButton button_clearfind;
        private System.Windows.Forms.Label label_central;
        private System.Windows.Forms.Label lblRowCheck;
        private System.Windows.Forms.Label lblColCheck;
        private MyButton button_refind;
        private System.Windows.Forms.ToolStripMenuItem cms1NewWindow;
        private System.Windows.Forms.ToolStripMenuItem cms1Number;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem cm3EditF2;
        private System.Windows.Forms.ToolStripMenuItem cm3Scrollbar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem cms1GetName;
        private System.Windows.Forms.ToolStripMenuItem cm1NewColumn;
        private System.Windows.Forms.ToolStripComboBox cm1ColCombo;
        private System.Windows.Forms.ToolStripMenuItem cm1AddColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.ToolStripMenuItem cm4EditFIleHeader;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip5;
        private System.Windows.Forms.ToolStripMenuItem cm5StartSearchDupli;
        private System.Windows.Forms.ToolStripComboBox cm5ColumNames;
    }
}

