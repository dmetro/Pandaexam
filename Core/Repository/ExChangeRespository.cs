using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository
{
    public class ExChangeRespository :IExChangeRespository
    {
        public async Task<RepositiryItem> Get()
        {
            var item = new RepositiryItem
            {
                Id = 1,
                Message = "dima",
                Rate1 = 7.32,
                Rate2 = 7.41,
                Time = DateTime.UtcNow
            };
            return item;
        }
    }
}
