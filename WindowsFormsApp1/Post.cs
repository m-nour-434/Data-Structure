﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Post
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public DateTime Timestamp { get; set; }

        public Post Next { get; set; }
        public Post Prev { get; set; }
    }

}
