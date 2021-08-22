using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
  public   class CommentManager
    {
        Repository<Comment> repocomment = new Repository<Comment>();
         public List<Comment> CommentList()
        {
            return repocomment.List();
        }
        public List<Comment> CommentByBlog(int id)
        {
            return repocomment.List(x=>x.BlogId==id);
        }
        public int CommentAdd(Comment c)
        {
            if (c.CommentText.Length <= 10 || c.CommentText.Length >= 301 || c.UserName=="" ||c.Mail=="" ||c.UserName.Length<=3)
            {
                return -1;
            }
            return repocomment.Insert(c);
        }
    }
}
