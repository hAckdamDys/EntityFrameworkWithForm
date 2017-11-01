
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bazy2
{
    public partial class BlogForm : Form
    {
        BlogContext _context;
        private int selectedBlogId = 0;
        private string selectedBlogName = "";
        private string nameToSearch = "";
        bool takeAllPosts = true;
        public BlogForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = new BlogContext();
            //selectedBlogPosts = _context.Posts.Local.ToBindingList();
           // postsDataGridView.DataSource = _context.Posts.ToList();
            this.refresh_Click(null, e);
        }


        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this._context.Dispose();
        }
        

        private void addPost_Click(object sender, EventArgs e)
        {
            
            (new AddPostForm()).ShowDialog();
            this.refresh_Click(sender, e);

        }


        private void refresh_Click(object sender, EventArgs e)
        {
            IQueryable<Blog> blogs = _context.Blogs;
            if (nameToSearch != "")
            {
                blogs = from b in blogs
                        where b.Name.Contains(nameToSearch)
                        select b;
                //blogs = blogs.Where(b => b.Name.Contains(nameToSearch));
            }
            blogDataGridView.DataSource = blogs.ToList();
            blogDataGridView.Update();
            if (takeAllPosts)
            {
                postsDataGridView.DataSource = _context.Posts.ToList();
            }
            else
            {
                Blog blog = _context.Blogs.Include("Posts").Where(b => b.BlogId == selectedBlogId).FirstOrDefault();
                postsDataGridView.DataSource = blog.Posts;
            }
            postsDataGridView.Update();
        }


        private void getAllPosts_Click(object sender, EventArgs e)
        {
            takeAllPosts = true;
            refresh_Click(sender, e);
            postLabel.Text = "All Posts:";
        }

        private void getSelectedBlog()
        {
            var selectedRows = blogDataGridView.SelectedRows;
            selectedBlogId = int.Parse(selectedRows[0].Cells[0].FormattedValue.ToString());
            selectedBlogName = selectedRows[0].Cells[1].FormattedValue.ToString();
        }

        private void getPostsForSelectedBlog_Click(object sender, EventArgs e)
        {
            getSelectedBlog();
            takeAllPosts = false;
            this.refresh_Click(sender, e);
            postLabel.Text = "Posts for blog " + selectedBlogName + ":";
        }

        private void search_Click(object sender, EventArgs e)
        {
            nameToSearch = searchBox.Text.ToString();
            refresh_Click(sender,e);
        }
    }
}
