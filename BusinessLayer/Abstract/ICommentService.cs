using EntityLayer.Concrete;
using System.Collections.Generic;


namespace BusinessLayer.Abstract
{
    public interface ICommentService : IGenericService<Comment>
    {


        List<Comment> GetCommentWithComment();

        List<Comment> GetList(int id);
    }
}
