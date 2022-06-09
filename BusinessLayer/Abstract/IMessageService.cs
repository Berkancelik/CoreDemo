using EntityLayer.Concrete;
using System.Collections.Generic;


namespace BusinessLayer.Abstract
{
    interface IMessageService : IGenericService<Message>
    {
        List<Message> GetInboxListByWriter(string p);


    }
}
