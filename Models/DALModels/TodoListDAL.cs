using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models.DALModels
{
    public class TodoListDAL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string ItemDes { get; set; }
        public DateTime DueDate{ get; set; }
        public bool IsCompleteOrNot { get; set; }
    }
}
