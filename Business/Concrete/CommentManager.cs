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
        public List<Comment>CommentByStatus()
        {
            return repocomment.List(x => x.CommentStatus == true);
        }
        public List<Comment> CommentByStatusFalse()
        {
            return repocomment.List(x => x.CommentStatus == false);
        }
        public void CommentAdd(Comment c)
        {
        //    if (c.CommentText.Length <= 1 || c.CommentText.Length >= 301 || c.UserName == "" || c.Mail == "" || c.UserName.Length <= 3)
        //    {
        //        return -1;
        //    }
             repocomment.Insert(c);
        }
        public void UpdateCommentStatusToFalse(int id )
        {
            Comment com = repocomment.Find(x => x.CommentId ==id);
            com.CommentStatus = false;
             repocomment.Update(com);
        }
        public void CommentStatusChangeTrue(int id)
        {
            Comment com = repocomment.Find(x => x.CommentId == id);
            com.CommentStatus = true;
             repocomment.Update(com);
        }
    }
}
