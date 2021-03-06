﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class RepositiryItem
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime Time { get; set; }
        public string Rate1 { get; set; }
        public string Rate2 { get; set; }


        protected bool Equals(RepositiryItem other)
        {
            return Id == other.Id;
        }
    }
}
