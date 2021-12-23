
namespace FrameWorkForBook
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabLOOK = new System.Windows.Forms.TabPage();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.listView = new System.Windows.Forms.ListView();
            this.BookNameColumn = new System.Windows.Forms.ColumnHeader();
            this.BookAuthorColumn = new System.Windows.Forms.ColumnHeader();
            this.PageCountColumn = new System.Windows.Forms.ColumnHeader();
            this.ValuationColumn = new System.Windows.Forms.ColumnHeader();
            this.label_forCount = new System.Windows.Forms.Label();
            this.buttonClear_search = new System.Windows.Forms.Button();
            this.comboForAdditionalSearch = new System.Windows.Forms.ComboBox();
            this.textForAdditionalSearch = new System.Windows.Forms.TextBox();
            this.checkForAdditionalSearch = new System.Windows.Forms.CheckBox();
            this.buttonForSearch = new System.Windows.Forms.Button();
            this.comboFORsearch = new System.Windows.Forms.ComboBox();
            this.textFORsearch = new System.Windows.Forms.TextBox();
            this.tabADD = new System.Windows.Forms.TabPage();
            this.buttonClear_add = new System.Windows.Forms.Button();
            this.buttonADD = new System.Windows.Forms.Button();
            this.labelValuation = new System.Windows.Forms.Label();
            this.labelPageCount = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelBookName = new System.Windows.Forms.Label();
            this.comboValuation = new System.Windows.Forms.ComboBox();
            this.textPageCount = new System.Windows.Forms.TextBox();
            this.textAuthor = new System.Windows.Forms.TextBox();
            this.textBookName = new System.Windows.Forms.TextBox();
            this.tabDELETE = new System.Windows.Forms.TabPage();
            this.buttonClear_delete = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textDelete = new System.Windows.Forms.TextBox();
            this.comboDelete = new System.Windows.Forms.ComboBox();
            this.tabUPDATE = new System.Windows.Forms.TabPage();
            this.buttonClear_update = new System.Windows.Forms.Button();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.textupdateOUT = new System.Windows.Forms.TextBox();
            this.textupdateIN = new System.Windows.Forms.TextBox();
            this.comboupdateOUT = new System.Windows.Forms.ComboBox();
            this.comboupdateIN = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl.SuspendLayout();
            this.tabLOOK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tabADD.SuspendLayout();
            this.tabDELETE.SuspendLayout();
            this.tabUPDATE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabLOOK);
            this.tabControl.Controls.Add(this.tabADD);
            this.tabControl.Controls.Add(this.tabDELETE);
            this.tabControl.Controls.Add(this.tabUPDATE);
            this.tabControl.Location = new System.Drawing.Point(-6, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(941, 545);
            this.tabControl.TabIndex = 0;
            // 
            // tabLOOK
            // 
            this.tabLOOK.Controls.Add(this.splitContainer);
            this.tabLOOK.Location = new System.Drawing.Point(4, 24);
            this.tabLOOK.Name = "tabLOOK";
            this.tabLOOK.Padding = new System.Windows.Forms.Padding(3);
            this.tabLOOK.Size = new System.Drawing.Size(933, 517);
            this.tabLOOK.TabIndex = 0;
            this.tabLOOK.Text = "Просмотр";
            this.tabLOOK.UseVisualStyleBackColor = true;
            // 
            // splitContainer
            // 
            this.splitContainer.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(3, 3);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.listView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.label_forCount);
            this.splitContainer.Panel2.Controls.Add(this.buttonClear_search);
            this.splitContainer.Panel2.Controls.Add(this.comboForAdditionalSearch);
            this.splitContainer.Panel2.Controls.Add(this.textForAdditionalSearch);
            this.splitContainer.Panel2.Controls.Add(this.checkForAdditionalSearch);
            this.splitContainer.Panel2.Controls.Add(this.buttonForSearch);
            this.splitContainer.Panel2.Controls.Add(this.comboFORsearch);
            this.splitContainer.Panel2.Controls.Add(this.textFORsearch);
            this.splitContainer.Size = new System.Drawing.Size(927, 511);
            this.splitContainer.SplitterDistance = 641;
            this.splitContainer.TabIndex = 0;
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BookNameColumn,
            this.BookAuthorColumn,
            this.PageCountColumn,
            this.ValuationColumn});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(641, 511);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // BookNameColumn
            // 
            this.BookNameColumn.Text = "Название книги";
            this.BookNameColumn.Width = 150;
            // 
            // BookAuthorColumn
            // 
            this.BookAuthorColumn.Text = "Автор";
            this.BookAuthorColumn.Width = 120;
            // 
            // PageCountColumn
            // 
            this.PageCountColumn.Text = "Количество страниц";
            this.PageCountColumn.Width = 170;
            // 
            // ValuationColumn
            // 
            this.ValuationColumn.Text = "Оценка";
            this.ValuationColumn.Width = 100;
            // 
            // label_forCount
            // 
            this.label_forCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_forCount.AutoSize = true;
            this.label_forCount.Location = new System.Drawing.Point(1, 470);
            this.label_forCount.Name = "label_forCount";
            this.label_forCount.Size = new System.Drawing.Size(106, 15);
            this.label_forCount.TabIndex = 7;
            this.label_forCount.Text = "Количество книг: ";
            // 
            // buttonClear_search
            // 
            this.buttonClear_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear_search.Location = new System.Drawing.Point(167, 198);
            this.buttonClear_search.Name = "buttonClear_search";
            this.buttonClear_search.Size = new System.Drawing.Size(112, 46);
            this.buttonClear_search.TabIndex = 6;
            this.buttonClear_search.Text = "Очистить";
            this.buttonClear_search.UseVisualStyleBackColor = true;
            this.buttonClear_search.Click += new System.EventHandler(this.buttonClear_search_Click);
            // 
            // comboForAdditionalSearch
            // 
            this.comboForAdditionalSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboForAdditionalSearch.FormattingEnabled = true;
            this.comboForAdditionalSearch.Items.AddRange(new object[] {
            "Название книги",
            "Автор",
            "Количество страниц",
            "Оценка"});
            this.comboForAdditionalSearch.Location = new System.Drawing.Point(1, 75);
            this.comboForAdditionalSearch.Name = "comboForAdditionalSearch";
            this.comboForAdditionalSearch.Size = new System.Drawing.Size(159, 23);
            this.comboForAdditionalSearch.TabIndex = 5;
            // 
            // textForAdditionalSearch
            // 
            this.textForAdditionalSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textForAdditionalSearch.Location = new System.Drawing.Point(2, 46);
            this.textForAdditionalSearch.Multiline = true;
            this.textForAdditionalSearch.Name = "textForAdditionalSearch";
            this.textForAdditionalSearch.Size = new System.Drawing.Size(158, 23);
            this.textForAdditionalSearch.TabIndex = 4;
            // 
            // checkForAdditionalSearch
            // 
            this.checkForAdditionalSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkForAdditionalSearch.AutoSize = true;
            this.checkForAdditionalSearch.Location = new System.Drawing.Point(194, 79);
            this.checkForAdditionalSearch.Name = "checkForAdditionalSearch";
            this.checkForAdditionalSearch.Size = new System.Drawing.Size(85, 19);
            this.checkForAdditionalSearch.TabIndex = 3;
            this.checkForAdditionalSearch.Text = "доп. поиск";
            this.checkForAdditionalSearch.UseVisualStyleBackColor = true;
            this.checkForAdditionalSearch.CheckedChanged += new System.EventHandler(this.checkForAdditionalSearch_CheckedChanged);
            // 
            // buttonForSearch
            // 
            this.buttonForSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonForSearch.Location = new System.Drawing.Point(167, 140);
            this.buttonForSearch.Name = "buttonForSearch";
            this.buttonForSearch.Size = new System.Drawing.Size(112, 52);
            this.buttonForSearch.TabIndex = 2;
            this.buttonForSearch.Text = "Поиск";
            this.buttonForSearch.UseVisualStyleBackColor = true;
            this.buttonForSearch.Click += new System.EventHandler(this.buttonForSearch_Click);
            // 
            // comboFORsearch
            // 
            this.comboFORsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboFORsearch.FormattingEnabled = true;
            this.comboFORsearch.Items.AddRange(new object[] {
            "Название книги",
            "Автор",
            "Количество страниц",
            "Оценка"});
            this.comboFORsearch.Location = new System.Drawing.Point(2, 169);
            this.comboFORsearch.Name = "comboFORsearch";
            this.comboFORsearch.Size = new System.Drawing.Size(159, 23);
            this.comboFORsearch.TabIndex = 1;
            // 
            // textFORsearch
            // 
            this.textFORsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textFORsearch.Location = new System.Drawing.Point(3, 140);
            this.textFORsearch.Multiline = true;
            this.textFORsearch.Name = "textFORsearch";
            this.textFORsearch.Size = new System.Drawing.Size(158, 23);
            this.textFORsearch.TabIndex = 0;
            // 
            // tabADD
            // 
            this.tabADD.Controls.Add(this.buttonClear_add);
            this.tabADD.Controls.Add(this.buttonADD);
            this.tabADD.Controls.Add(this.labelValuation);
            this.tabADD.Controls.Add(this.labelPageCount);
            this.tabADD.Controls.Add(this.labelAuthor);
            this.tabADD.Controls.Add(this.labelBookName);
            this.tabADD.Controls.Add(this.comboValuation);
            this.tabADD.Controls.Add(this.textPageCount);
            this.tabADD.Controls.Add(this.textAuthor);
            this.tabADD.Controls.Add(this.textBookName);
            this.tabADD.Location = new System.Drawing.Point(4, 24);
            this.tabADD.Name = "tabADD";
            this.tabADD.Padding = new System.Windows.Forms.Padding(3);
            this.tabADD.Size = new System.Drawing.Size(933, 517);
            this.tabADD.TabIndex = 1;
            this.tabADD.Text = "Добавление";
            this.tabADD.UseVisualStyleBackColor = true;
            // 
            // buttonClear_add
            // 
            this.buttonClear_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear_add.Location = new System.Drawing.Point(497, 168);
            this.buttonClear_add.Name = "buttonClear_add";
            this.buttonClear_add.Size = new System.Drawing.Size(212, 34);
            this.buttonClear_add.TabIndex = 9;
            this.buttonClear_add.Text = "Очистить";
            this.buttonClear_add.UseVisualStyleBackColor = true;
            this.buttonClear_add.Click += new System.EventHandler(this.buttonClear_add_Click);
            // 
            // buttonADD
            // 
            this.buttonADD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonADD.Location = new System.Drawing.Point(715, 166);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(212, 36);
            this.buttonADD.TabIndex = 8;
            this.buttonADD.Text = "Добавить";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // labelValuation
            // 
            this.labelValuation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelValuation.AutoSize = true;
            this.labelValuation.Location = new System.Drawing.Point(658, 137);
            this.labelValuation.Name = "labelValuation";
            this.labelValuation.Size = new System.Drawing.Size(51, 15);
            this.labelValuation.TabIndex = 7;
            this.labelValuation.Text = "Оценка:";
            // 
            // labelPageCount
            // 
            this.labelPageCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPageCount.AutoSize = true;
            this.labelPageCount.Location = new System.Drawing.Point(586, 97);
            this.labelPageCount.Name = "labelPageCount";
            this.labelPageCount.Size = new System.Drawing.Size(123, 15);
            this.labelPageCount.TabIndex = 6;
            this.labelPageCount.Text = "Количество страниц:";
            // 
            // labelAuthor
            // 
            this.labelAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(666, 59);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(43, 15);
            this.labelAuthor.TabIndex = 5;
            this.labelAuthor.Text = "Автор:";
            // 
            // labelBookName
            // 
            this.labelBookName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBookName.AutoSize = true;
            this.labelBookName.Location = new System.Drawing.Point(612, 21);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(97, 15);
            this.labelBookName.TabIndex = 4;
            this.labelBookName.Text = "Название книги:";
            // 
            // comboValuation
            // 
            this.comboValuation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboValuation.FormattingEnabled = true;
            this.comboValuation.Items.AddRange(new object[] {
            "Плохо",
            "Нормально",
            "Отлично",
            "Шедевр"});
            this.comboValuation.Location = new System.Drawing.Point(715, 137);
            this.comboValuation.Name = "comboValuation";
            this.comboValuation.Size = new System.Drawing.Size(212, 23);
            this.comboValuation.TabIndex = 3;
            // 
            // textPageCount
            // 
            this.textPageCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textPageCount.Location = new System.Drawing.Point(715, 97);
            this.textPageCount.Multiline = true;
            this.textPageCount.Name = "textPageCount";
            this.textPageCount.Size = new System.Drawing.Size(212, 32);
            this.textPageCount.TabIndex = 2;
            // 
            // textAuthor
            // 
            this.textAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textAuthor.Location = new System.Drawing.Point(715, 59);
            this.textAuthor.Multiline = true;
            this.textAuthor.Name = "textAuthor";
            this.textAuthor.Size = new System.Drawing.Size(212, 32);
            this.textAuthor.TabIndex = 1;
            // 
            // textBookName
            // 
            this.textBookName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBookName.Location = new System.Drawing.Point(715, 21);
            this.textBookName.Multiline = true;
            this.textBookName.Name = "textBookName";
            this.textBookName.Size = new System.Drawing.Size(212, 32);
            this.textBookName.TabIndex = 0;
            // 
            // tabDELETE
            // 
            this.tabDELETE.Controls.Add(this.buttonClear_delete);
            this.tabDELETE.Controls.Add(this.buttonDelete);
            this.tabDELETE.Controls.Add(this.textDelete);
            this.tabDELETE.Controls.Add(this.comboDelete);
            this.tabDELETE.Location = new System.Drawing.Point(4, 24);
            this.tabDELETE.Name = "tabDELETE";
            this.tabDELETE.Size = new System.Drawing.Size(933, 517);
            this.tabDELETE.TabIndex = 2;
            this.tabDELETE.Text = "Удаление";
            this.tabDELETE.UseVisualStyleBackColor = true;
            // 
            // buttonClear_delete
            // 
            this.buttonClear_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear_delete.Location = new System.Drawing.Point(524, 170);
            this.buttonClear_delete.Name = "buttonClear_delete";
            this.buttonClear_delete.Size = new System.Drawing.Size(165, 28);
            this.buttonClear_delete.TabIndex = 10;
            this.buttonClear_delete.Text = "Очистить";
            this.buttonClear_delete.UseVisualStyleBackColor = true;
            this.buttonClear_delete.Click += new System.EventHandler(this.buttonClear_delete_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(695, 170);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(214, 28);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textDelete
            // 
            this.textDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textDelete.Location = new System.Drawing.Point(695, 140);
            this.textDelete.Multiline = true;
            this.textDelete.Name = "textDelete";
            this.textDelete.Size = new System.Drawing.Size(214, 23);
            this.textDelete.TabIndex = 1;
            // 
            // comboDelete
            // 
            this.comboDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboDelete.FormattingEnabled = true;
            this.comboDelete.Items.AddRange(new object[] {
            "Название книги",
            "Автор",
            "Количество страниц",
            "Оценка"});
            this.comboDelete.Location = new System.Drawing.Point(524, 140);
            this.comboDelete.Name = "comboDelete";
            this.comboDelete.Size = new System.Drawing.Size(165, 23);
            this.comboDelete.TabIndex = 0;
            // 
            // tabUPDATE
            // 
            this.tabUPDATE.Controls.Add(this.buttonClear_update);
            this.tabUPDATE.Controls.Add(this.buttonupdate);
            this.tabUPDATE.Controls.Add(this.textupdateOUT);
            this.tabUPDATE.Controls.Add(this.textupdateIN);
            this.tabUPDATE.Controls.Add(this.comboupdateOUT);
            this.tabUPDATE.Controls.Add(this.comboupdateIN);
            this.tabUPDATE.Location = new System.Drawing.Point(4, 24);
            this.tabUPDATE.Name = "tabUPDATE";
            this.tabUPDATE.Size = new System.Drawing.Size(933, 517);
            this.tabUPDATE.TabIndex = 3;
            this.tabUPDATE.Text = "Редактирование";
            this.tabUPDATE.UseVisualStyleBackColor = true;
            // 
            // buttonClear_update
            // 
            this.buttonClear_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear_update.Location = new System.Drawing.Point(616, 179);
            this.buttonClear_update.Name = "buttonClear_update";
            this.buttonClear_update.Size = new System.Drawing.Size(183, 48);
            this.buttonClear_update.TabIndex = 10;
            this.buttonClear_update.Text = "Очистить";
            this.buttonClear_update.UseVisualStyleBackColor = true;
            this.buttonClear_update.Click += new System.EventHandler(this.buttonClear_update_Click);
            // 
            // buttonupdate
            // 
            this.buttonupdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonupdate.Location = new System.Drawing.Point(445, 273);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(165, 48);
            this.buttonupdate.TabIndex = 5;
            this.buttonupdate.Text = "Изменить";
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // textupdateOUT
            // 
            this.textupdateOUT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textupdateOUT.Location = new System.Drawing.Point(616, 243);
            this.textupdateOUT.Multiline = true;
            this.textupdateOUT.Name = "textupdateOUT";
            this.textupdateOUT.Size = new System.Drawing.Size(183, 23);
            this.textupdateOUT.TabIndex = 4;
            // 
            // textupdateIN
            // 
            this.textupdateIN.Location = new System.Drawing.Point(203, 118);
            this.textupdateIN.Multiline = true;
            this.textupdateIN.Name = "textupdateIN";
            this.textupdateIN.Size = new System.Drawing.Size(183, 23);
            this.textupdateIN.TabIndex = 3;
            // 
            // comboupdateOUT
            // 
            this.comboupdateOUT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboupdateOUT.FormattingEnabled = true;
            this.comboupdateOUT.Items.AddRange(new object[] {
            "Название книги",
            "Автор",
            "Количество страниц",
            "Оценка"});
            this.comboupdateOUT.Location = new System.Drawing.Point(445, 243);
            this.comboupdateOUT.Name = "comboupdateOUT";
            this.comboupdateOUT.Size = new System.Drawing.Size(165, 23);
            this.comboupdateOUT.TabIndex = 2;
            // 
            // comboupdateIN
            // 
            this.comboupdateIN.FormattingEnabled = true;
            this.comboupdateIN.Items.AddRange(new object[] {
            "Название книги",
            "Автор",
            "Количество страниц",
            "Оценка"});
            this.comboupdateIN.Location = new System.Drawing.Point(32, 118);
            this.comboupdateIN.Name = "comboupdateIN";
            this.comboupdateIN.Size = new System.Drawing.Size(165, 23);
            this.comboupdateIN.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Location = new System.Drawing.Point(180, 163);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(384, 187);
            this.splitContainer1.SplitterDistance = 128;
            this.splitContainer1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 548);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabLOOK.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tabADD.ResumeLayout(false);
            this.tabADD.PerformLayout();
            this.tabDELETE.ResumeLayout(false);
            this.tabDELETE.PerformLayout();
            this.tabUPDATE.ResumeLayout(false);
            this.tabUPDATE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabLOOK;
        private System.Windows.Forms.TabPage tabADD;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader BookNameColumn;
        private System.Windows.Forms.ColumnHeader BookAuthorColumn;
        private System.Windows.Forms.ColumnHeader PageCountColumn;
        private System.Windows.Forms.ColumnHeader ValuationColumn;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.ComboBox comboValuation;
        private System.Windows.Forms.TextBox textPageCount;
        private System.Windows.Forms.TextBox textAuthor;
        private System.Windows.Forms.TextBox textBookName;
        private System.Windows.Forms.Label labelPageCount;
        private System.Windows.Forms.Label labelValuation;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.TabPage tabDELETE;
        private System.Windows.Forms.ComboBox comboDelete;
        private System.Windows.Forms.TabPage tabUPDATE;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textDelete;
        private System.Windows.Forms.ComboBox comboupdateOUT;
        private System.Windows.Forms.ComboBox comboupdateIN;
        private System.Windows.Forms.TextBox textupdateOUT;
        private System.Windows.Forms.TextBox textupdateIN;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.TextBox textFORsearch;
        private System.Windows.Forms.ComboBox comboFORsearch;
        private System.Windows.Forms.Button buttonForSearch;
        private System.Windows.Forms.CheckBox checkForAdditionalSearch;
        private System.Windows.Forms.ComboBox comboForAdditionalSearch;
        private System.Windows.Forms.TextBox textForAdditionalSearch;
        private System.Windows.Forms.Button buttonClear_search;
        private System.Windows.Forms.Button buttonClear_add;
        private System.Windows.Forms.Button buttonClear_delete;
        private System.Windows.Forms.Button buttonClear_update;
        private System.Windows.Forms.Label label_forCount;
    }
}

