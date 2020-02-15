using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using Core.Repository;

namespace Core.Services.ExChange
{
    public class ExChangeService : IExChangeService
    {
        private ExChangeRespository repo;
        public ExChangeService(ExChangeRespository repo)
        {
            this.repo = repo;
        }


        public Task<RepositiryItem> GetAsync()
        {
            return repo.Get();
        }
    }
}
