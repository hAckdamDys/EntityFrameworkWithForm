using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bazy2
{
    public partial class AddPostForm : Form
    {
        private BlogContext _context;

        public AddPostForm()
        {
            InitializeComponent();
            _context = new BlogContext();
        }
        private void AddPostForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Choose a blog...");
            comboBox1.SelectedItem = comboBox1.Items[0];
            var blogs = from b in _context.Blogs
                            orderby b.Name
                            select b.Name;
            foreach (var blog in blogs)
            {
                comboBox1.Items.Add(blog);
            }

        }

        private void add_Click(object sender, EventArgs e)
        {

            var selectedBlog = (string)comboBox1.SelectedItem;
            int blogId;
            
            blogId = (from b in _context.Blogs where b.Name == selectedBlog select b.BlogId).FirstOrDefault();
            if (blogId == 0)
            {
                MessageBox.Show("No blog selected.");
                return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("No title!");
                return;
            }
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("Post should have some content...");
                return;
            }
            var post = new Post();
            post.BlogId = blogId;
            post.Content = richTextBox1.Text;
            post.Title = textBox1.Text;
            _context.Posts.Add(post);
            _context.SaveChanges();
            Hide();
            DestroyHandle();

        }
        private void cancel_Click(object sender, EventArgs e)
        {
            Hide();
            DestroyHandle();
        }
    }
}
