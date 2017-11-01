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
        public BlogForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = new BlogContext();
            this.refresh_Click(null, e);
        }


        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this._context.Dispose();
        }

        private void BlogForm_Load(object sender, EventArgs e)
        {


        }

        private void blogDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addPost_Click(object sender, EventArgs e)
        {
            
            (new AddPostForm()).ShowDialog();
            this.refresh_Click(sender, e);

        }

        private void postsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            _context.Blogs.Load();
            _context.Posts.Load();
            this.blogBindingSource.DataSource =
                _context.Blogs.Local.ToBindingList();
            this.postsBindingSource.DataSource =
                _context.Posts.Local.ToBindingList();
        }
    }
}
