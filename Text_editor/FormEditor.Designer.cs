namespace Text_editor
{
    partial class FormEditor
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditor));
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripButton();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripButton();
            this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripButton();
            this.italicToolStripMenuItem = new System.Windows.Forms.ToolStripButton();
            this.underlinedToolStripMenuItem = new System.Windows.Forms.ToolStripButton();
            this.strikeoutToolStripMenuItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxProgrammingLanguages = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.textBoxFind = new System.Windows.Forms.ToolStripTextBox();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.textBoxReplace = new System.Windows.Forms.ToolStripTextBox();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox.Location = new System.Drawing.Point(0, 47);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(1375, 530);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            this.richTextBox.DoubleClick += new System.EventHandler(this.richTextBox_DoubleClick);
            this.richTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox_KeyDown);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator3,
            this.toolStripLabel4,
            this.fontToolStripMenuItem,
            this.boldToolStripMenuItem,
            this.italicToolStripMenuItem,
            this.underlinedToolStripMenuItem,
            this.strikeoutToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripLabel5,
            this.toolStripComboBoxProgrammingLanguages,
            this.toolStripSeparator4,
            this.toolStripLabel1,
            this.textBoxFind,
            this.findToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.textBoxReplace,
            this.replaceToolStripMenuItem});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1375, 34);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(45, 31);
            this.toolStripLabel3.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripMenuItem.Image = global::Text_editor.Properties.Resources.icon_open_file;
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5);
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(29, 24);
            this.openToolStripMenuItem.Text = "Открыть файл...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripMenuItem.Image = global::Text_editor.Properties.Resources.icon_save_file1;
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5);
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(29, 24);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveAsToolStripMenuItem.Image = global::Text_editor.Properties.Resources.icon_save_as;
            this.saveAsToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveAsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5);
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(29, 24);
            this.saveAsToolStripMenuItem.Text = "Сохранить как...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripMenuItem.Image = global::Text_editor.Properties.Resources.icon_copy_text;
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5);
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(29, 24);
            this.copyToolStripMenuItem.Text = "Копировать";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripMenuItem.Image = global::Text_editor.Properties.Resources.icon_paste_text;
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5);
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(29, 24);
            this.pasteToolStripMenuItem.Text = "Вставить";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 34);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(45, 31);
            this.toolStripLabel4.Text = "Текст";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fontToolStripMenuItem.Image = global::Text_editor.Properties.Resources.icon_fonts;
            this.fontToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fontToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5);
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(29, 24);
            this.fontToolStripMenuItem.Text = "Настроить шрифт";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // boldToolStripMenuItem
            // 
            this.boldToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boldToolStripMenuItem.Image = global::Text_editor.Properties.Resources.icon_bold_text;
            this.boldToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5);
            this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            this.boldToolStripMenuItem.Size = new System.Drawing.Size(29, 24);
            this.boldToolStripMenuItem.Text = "Выделить жирным";
            this.boldToolStripMenuItem.Click += new System.EventHandler(this.boldToolStripMenuItem_Click);
            // 
            // italicToolStripMenuItem
            // 
            this.italicToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italicToolStripMenuItem.Image = global::Text_editor.Properties.Resources.icon_italic_text;
            this.italicToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5);
            this.italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            this.italicToolStripMenuItem.Size = new System.Drawing.Size(29, 24);
            this.italicToolStripMenuItem.Text = "Выделить курсивом";
            this.italicToolStripMenuItem.Click += new System.EventHandler(this.italicToolStripMenuItem_Click);
            // 
            // underlinedToolStripMenuItem
            // 
            this.underlinedToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underlinedToolStripMenuItem.Image = global::Text_editor.Properties.Resources.icon_underlined_text;
            this.underlinedToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underlinedToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5);
            this.underlinedToolStripMenuItem.Name = "underlinedToolStripMenuItem";
            this.underlinedToolStripMenuItem.Size = new System.Drawing.Size(29, 24);
            this.underlinedToolStripMenuItem.Text = "Подчеркнуть";
            this.underlinedToolStripMenuItem.Click += new System.EventHandler(this.underlinedToolStripMenuItem_Click);
            // 
            // strikeoutToolStripMenuItem
            // 
            this.strikeoutToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.strikeoutToolStripMenuItem.Image = global::Text_editor.Properties.Resources.icon_strikeout_text1;
            this.strikeoutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strikeoutToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5);
            this.strikeoutToolStripMenuItem.Name = "strikeoutToolStripMenuItem";
            this.strikeoutToolStripMenuItem.Size = new System.Drawing.Size(29, 24);
            this.strikeoutToolStripMenuItem.Text = "Зачеркнуть";
            this.strikeoutToolStripMenuItem.Click += new System.EventHandler(this.strikeoutToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(188, 31);
            this.toolStripLabel5.Text = "Язык программирования";
            // 
            // toolStripComboBoxProgrammingLanguages
            // 
            this.toolStripComboBoxProgrammingLanguages.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBoxProgrammingLanguages.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripComboBoxProgrammingLanguages.Items.AddRange(new object[] {
            "Текст",
            "C++",
            "C#",
            "Java",
            "JS"});
            this.toolStripComboBoxProgrammingLanguages.Name = "toolStripComboBoxProgrammingLanguages";
            this.toolStripComboBoxProgrammingLanguages.Size = new System.Drawing.Size(121, 34);
            this.toolStripComboBoxProgrammingLanguages.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxProgrammingLanguages_SelectedIndexChanged);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 34);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(52, 31);
            this.toolStripLabel1.Text = "Поиск";
            // 
            // textBoxFind
            // 
            this.textBoxFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFind.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFind.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(100, 34);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.findToolStripMenuItem.Image = global::Text_editor.Properties.Resources.icon_find;
            this.findToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.findToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(29, 24);
            this.findToolStripMenuItem.Text = "Найти";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 34);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(61, 31);
            this.toolStripLabel2.Text = "Замена";
            // 
            // textBoxReplace
            // 
            this.textBoxReplace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxReplace.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxReplace.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxReplace.Name = "textBoxReplace";
            this.textBoxReplace.Size = new System.Drawing.Size(100, 34);
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.replaceToolStripMenuItem.Image = global::Text_editor.Properties.Resources.icon_replace;
            this.replaceToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.replaceToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(29, 24);
            this.replaceToolStripMenuItem.Text = "Заменить\\ndfdf";
            this.replaceToolStripMenuItem.ToolTipText = "Заменить";
            this.replaceToolStripMenuItem.Click += new System.EventHandler(this.replaceToolStripMenuItem_Click);
            // 
            // FormEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 583);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.richTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "FormEditor";
            this.Text = "Notepad Ultra Edition";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton openToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton findToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox textBoxFind;
        private System.Windows.Forms.ToolStripButton replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox textBoxReplace;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton boldToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton italicToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton underlinedToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton strikeoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxProgrammingLanguages;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

