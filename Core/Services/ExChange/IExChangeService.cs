using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.ExChange
{
    public interface IExChangeService
    {
        Task<RepositiryItem> GetAsync();
    }

    public class ExChangeConext
    {
        public int Id { get; set; }
        public RepositiryItem Item { get; set; }
    }
}
