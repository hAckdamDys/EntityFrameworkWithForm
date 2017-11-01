using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazy2
{
    class Blog
    {
        private readonly ObservableListSource<Post> _posts =
                    new ObservableListSource<Post>();
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public virtual ObservableListSource<Post> Posts { get; set; }
    }
}
