using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using Core.Repository;
using ZeroMQ;

namespace Core.Services.ExChange
{
    public class ExChangeService
    {

        public List<RepositiryItem> getData()
        {
            return GetItems();
        }

        private List<RepositiryItem> GetItems()
        {
            var items = new List<RepositiryItem>();
            var res = getMessage();///for loop on res
            RepositiryItem item = ParsRes(res);
            items.Add(item);
            return items;
        }

        public string getMessage()
        {

            var args = new string[] { "tcp://79.125.80.209:4002" };
            string endpoint = args[0];

            // Create
            using (var context = new ZContext())
            using (var requester = new ZSocket(context, ZSocketType.PULL))
            {
                // Connect
                requester.Connect(endpoint);

                var res = requester.ReceiveMessage().FirstOrDefault();
                return res == null ? "" : res.ToString();
            }


        }



        private RepositiryItem ParsRes(string res)
        {
            string[] sentenses = res.Split(' ');
            string exchangeName = sentenses[0].Trim();
            string date = sentenses[1].Trim();
            string currency1 = sentenses[2].Trim();
            string currency2 = sentenses[3].Trim();
            string fixedDate = date.Replace('-', ' ');

            RepositiryItem item = new RepositiryItem();
            item.Message = exchangeName;
            item.Rate1 = currency1;
            item.Rate2 = currency2;
            item.Time = DateTime.Parse(fixedDate);
            return item;
        }

    }
}
