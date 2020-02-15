using Core.Models;
using Core.Services.ExChange;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository
{
    public class ExChangeRespository : IExChangeRespository
    {
        ExChangeService exChangeService = new ExChangeService();
        public async Task<List<RepositiryItem>> Get()
        {
            return exChangeService.getData();
        }
    }
}
