﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Reddit.NET.Models.Structures
{
    [Serializable]
    public class MoreChildren
    {
        public List<Comment> Comments;
        public List<MoreData> MoreData;

        public MoreChildren(List<Comment> comments, List<MoreData> moreData)
        {
            Comments = comments;
            MoreData = moreData;
        }

        public MoreChildren()
        {
            Comments = new List<Comment>();
            MoreData = new List<MoreData>();
        }
    }
}
