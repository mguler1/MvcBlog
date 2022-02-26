using Business.Abstract;
using DataAccess.Concrete;
using DataAccess.Interface;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
  public   class CommentManager:ICommentService

    {
        ICommentDal __commentDal;
        Repository<Comment> repocomment = new Repository<Comment>();
        public CommentManager(ICommentDal commentDal)
        {
            __commentDal= commentDal;
        }

        public List<Comment> CommentByBlog(int id)
        {
            return __commentDal.List(x => x.BlogId == id);
        }

        public List<Comment> CommentByStatusTrue()
        {
            return __commentDal.List(x => x.CommentStatus == true);
        }

        public List<Comment> CommentByStatusFalse()
        {
            return repocomment.List(x => x.CommentStatus == false);
        }
        public void CommentStatusChangeToFalse(int id)
        {
            Comment comment = __commentDal.Find(x => x.CommentId == id);
            comment.CommentStatus = false;
            __commentDal.Update(comment);
        }
        public void CommentStatusChangeToTrue(int id)
        {
            Comment comment = __commentDal.Find(x => x.CommentId == id);
            comment.CommentStatus = true;
            __commentDal.Update(comment);
        }
        public List<Comment> GetList()
        {
            throw new NotImplementedException();
        }

        public Comment GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void CommentDelete(Comment comment)
        {
            throw new NotImplementedException();
        }

        public void CommentUpdate(Comment comment)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Comment t)
        {
            __commentDal.Insert(t);
        }

        public void TDelete(Comment t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();
        }
    }
}
