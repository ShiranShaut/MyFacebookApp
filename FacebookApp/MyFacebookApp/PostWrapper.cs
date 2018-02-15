using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace MyFacebookApp
{
    internal class PostWrapper
    {
        private readonly Post r_RealPost;

        public PostWrapper(Post i_Post)
        {
            r_RealPost = i_Post;
        }

        public override string ToString()
        {
            string postDetail = null;

            if (r_RealPost.Message != null)
            {
                postDetail = r_RealPost.Message;
            }
            else if (r_RealPost.Caption != null)
            {
                postDetail = r_RealPost.Caption;
            }
            else
            {
                postDetail = string.Format("[{0}]", r_RealPost.Type);
            }

            return postDetail;
        }
    }
}
