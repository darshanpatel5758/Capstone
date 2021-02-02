using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models.DomainModels
{
    public class TodoListViewModel
    {
        public int ID { get; set; }
        public string ItemDes { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleteOrNot { get; set; }
    }
}
