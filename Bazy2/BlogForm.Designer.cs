namespace Bazy2
{
    partial class BlogForm
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
            this.blogDataGridView = new System.Windows.Forms.DataGridView();
            this.postsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postsDataGridView = new System.Windows.Forms.DataGridView();
            this.addPostButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.getAllPostsButton = new System.Windows.Forms.Button();
            this.postLabel = new System.Windows.Forms.Label();
            this.getBlogPostsButton = new System.Windows.Forms.Button();
            this.blogLabel = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.blogDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // blogDataGridView
            // 
            this.blogDataGridView.AllowUserToAddRows = false;
            this.blogDataGridView.AllowUserToDeleteRows = false;
            this.blogDataGridView.AutoGenerateColumns = false;
            this.blogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.blogDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.blogDataGridView.DataSource = this.blogBindingSource;
            this.blogDataGridView.Location = new System.Drawing.Point(12, 28);
            this.blogDataGridView.Name = "blogDataGridView";
            this.blogDataGridView.ReadOnly = true;
            this.blogDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.blogDataGridView.Size = new System.Drawing.Size(343, 240);
            this.blogDataGridView.TabIndex = 1;
            // 
            // postsBindingSource
            // 
            this.postsBindingSource.DataMember = "Posts";
            this.postsBindingSource.DataSource = this.blogBindingSource;
            // 
            // postsDataGridView
            // 
            this.postsDataGridView.AllowUserToAddRows = false;
            this.postsDataGridView.AllowUserToDeleteRows = false;
            this.postsDataGridView.AutoGenerateColumns = false;
            this.postsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.postsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.postsDataGridView.DataSource = this.postsBindingSource;
            this.postsDataGridView.Location = new System.Drawing.Point(361, 28);
            this.postsDataGridView.Name = "postsDataGridView";
            this.postsDataGridView.ReadOnly = true;
            this.postsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.postsDataGridView.Size = new System.Drawing.Size(344, 240);
            this.postsDataGridView.TabIndex = 2;
            // 
            // addPostButton
            // 
            this.addPostButton.Location = new System.Drawing.Point(361, 274);
            this.addPostButton.Name = "addPostButton";
            this.addPostButton.Size = new System.Drawing.Size(75, 23);
            this.addPostButton.TabIndex = 3;
            this.addPostButton.Text = "Add Post";
            this.addPostButton.UseVisualStyleBackColor = true;
            this.addPostButton.Click += new System.EventHandler(this.addPost_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.refresh_Click);
            // 
            // getAllPostsButton
            // 
            this.getAllPostsButton.Location = new System.Drawing.Point(442, 274);
            this.getAllPostsButton.Name = "getAllPostsButton";
            this.getAllPostsButton.Size = new System.Drawing.Size(112, 23);
            this.getAllPostsButton.TabIndex = 5;
            this.getAllPostsButton.Text = "Show All Posts";
            this.getAllPostsButton.UseVisualStyleBackColor = true;
            this.getAllPostsButton.Click += new System.EventHandler(this.getAllPosts_Click);
            // 
            // postLabel
            // 
            this.postLabel.AutoSize = true;
            this.postLabel.Location = new System.Drawing.Point(361, 9);
            this.postLabel.Name = "postLabel";
            this.postLabel.Size = new System.Drawing.Size(50, 13);
            this.postLabel.TabIndex = 6;
            this.postLabel.Text = "All Posts:";
            // 
            // getBlogPostsButton
            // 
            this.getBlogPostsButton.Location = new System.Drawing.Point(12, 303);
            this.getBlogPostsButton.Name = "getBlogPostsButton";
            this.getBlogPostsButton.Size = new System.Drawing.Size(156, 23);
            this.getBlogPostsButton.TabIndex = 7;
            this.getBlogPostsButton.Text = "Get Posts for selected Blog";
            this.getBlogPostsButton.UseVisualStyleBackColor = true;
            this.getBlogPostsButton.Click += new System.EventHandler(this.getPostsForSelectedBlog_Click);
            // 
            // blogLabel
            // 
            this.blogLabel.AutoSize = true;
            this.blogLabel.Location = new System.Drawing.Point(9, 9);
            this.blogLabel.Name = "blogLabel";
            this.blogLabel.Size = new System.Drawing.Size(36, 13);
            this.blogLabel.TabIndex = 8;
            this.blogLabel.Text = "Blogs:";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PostId";
            this.dataGridViewTextBoxColumn4.HeaderText = "PostId";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn5.HeaderText = "Title";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Content";
            this.dataGridViewTextBoxColumn6.HeaderText = "Content";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // blogBindingSource
            // 
            this.blogBindingSource.DataSource = typeof(Bazy2.Blog);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BlogId";
            this.dataGridViewTextBoxColumn1.HeaderText = "BlogId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Url";
            this.dataGridViewTextBoxColumn3.HeaderText = "Url";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(174, 274);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(181, 20);
            this.searchBox.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Search for blog by name:";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.search_Click);
            // 
            // BlogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 460);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.blogLabel);
            this.Controls.Add(this.getBlogPostsButton);
            this.Controls.Add(this.postLabel);
            this.Controls.Add(this.getAllPostsButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addPostButton);
            this.Controls.Add(this.postsDataGridView);
            this.Controls.Add(this.blogDataGridView);
            this.Name = "BlogForm";
            this.Text = "BlogForm";
            ((System.ComponentModel.ISupportInitialize)(this.blogDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource blogBindingSource;
        private System.Windows.Forms.DataGridView blogDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource postsBindingSource;
        private System.Windows.Forms.DataGridView postsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button addPostButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button getAllPostsButton;
        private System.Windows.Forms.Label postLabel;
        private System.Windows.Forms.Button getBlogPostsButton;
        private System.Windows.Forms.Label blogLabel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button button2;
    }
}