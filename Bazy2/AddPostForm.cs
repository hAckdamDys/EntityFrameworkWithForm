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
        public AddPostForm()
        {
            InitializeComponent();
            this.Load += AddPostForm_Load;
        }
        private void AddPostForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Choose a blog...");
            comboBox1.SelectedItem = comboBox1.Items[0];
            using (var bContext = new BlogContext())
            {
                var blogs = from b in bContext.Blogs
                            orderby b.Name
                            select b.Name;
                foreach (var blog in blogs)
                {
                    comboBox1.Items.Add(blog);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var selectedBlog = (string)comboBox1.SelectedItem;
            int blogId;

            using (var bContext = new BlogContext())
            {
                blogId = (from b in bContext.Blogs where b.Name == selectedBlog select b.BlogId).FirstOrDefault();
                if (blogId == 0)
                {
                    MessageBox.Show("No blog selected.");
                    return;
                }
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
            using (var bContext = new BlogContext())
            {
                bContext.Posts.Add(post);
                bContext.SaveChanges();
            }
            Hide();
            DestroyHandle();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            DestroyHandle();
        }
    }
}
