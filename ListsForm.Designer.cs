namespace Lists
{
    partial class ListsForm
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
            lstPinkFloydAlbums = new System.Windows.Forms.ListBox();
            btnAddItem = new System.Windows.Forms.Button();
            btnRemoveItem = new System.Windows.Forms.Button();
            btnClearList = new System.Windows.Forms.Button();
            btnShowItem = new System.Windows.Forms.Button();
            cboColors = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // lstPinkFloydAlbums
            // 
            lstPinkFloydAlbums.FormattingEnabled = true;
            lstPinkFloydAlbums.ItemHeight = 15;
            lstPinkFloydAlbums.Items.AddRange(new object[] { "Atom Heart Mother", "Wish You Were Here", "Animals", "Echoes", "Meddle", "Dark Side of the Moon" });
            lstPinkFloydAlbums.Location = new System.Drawing.Point(64, 32);
            lstPinkFloydAlbums.Name = "lstPinkFloydAlbums";
            lstPinkFloydAlbums.Size = new System.Drawing.Size(160, 109);
            lstPinkFloydAlbums.TabIndex = 0;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new System.Drawing.Point(96, 159);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new System.Drawing.Size(100, 23);
            btnAddItem.TabIndex = 1;
            btnAddItem.Text = "Add an Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.Location = new System.Drawing.Point(96, 188);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new System.Drawing.Size(106, 23);
            btnRemoveItem.TabIndex = 2;
            btnRemoveItem.Text = "Remove an Item";
            btnRemoveItem.UseVisualStyleBackColor = true;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // btnClearList
            // 
            btnClearList.Location = new System.Drawing.Point(96, 217);
            btnClearList.Name = "btnClearList";
            btnClearList.Size = new System.Drawing.Size(100, 23);
            btnClearList.TabIndex = 3;
            btnClearList.Text = "Clear List";
            btnClearList.UseVisualStyleBackColor = true;
            btnClearList.Click += btnClearList_Click;
            // 
            // btnShowItem
            // 
            btnShowItem.Location = new System.Drawing.Point(96, 246);
            btnShowItem.Name = "btnShowItem";
            btnShowItem.Size = new System.Drawing.Size(100, 23);
            btnShowItem.TabIndex = 4;
            btnShowItem.Text = "Show Selected";
            btnShowItem.UseVisualStyleBackColor = true;
            btnShowItem.Click += btnShowItem_Click;
            // 
            // cboColors
            // 
            cboColors.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            cboColors.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cboColors.FormattingEnabled = true;
            cboColors.Items.AddRange(new object[] { "Black", "Blue", "Gold", "Green", "Red", "Yellow" });
            cboColors.Location = new System.Drawing.Point(64, 5);
            cboColors.Name = "cboColors";
            cboColors.Size = new System.Drawing.Size(160, 23);
            cboColors.TabIndex = 5;
            // 
            // ListsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(300, 281);
            Controls.Add(cboColors);
            Controls.Add(btnShowItem);
            Controls.Add(btnClearList);
            Controls.Add(btnRemoveItem);
            Controls.Add(btnAddItem);
            Controls.Add(lstPinkFloydAlbums);
            Name = "ListsForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox lstPinkFloydAlbums;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnShowItem;
        private System.Windows.Forms.ComboBox cboColors;
    }
}
