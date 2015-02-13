using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace taskMVC.Models
{
    public class newTask
    {
        //public int taskId;

        [Required(ErrorMessage = "Please provide task id!")]
        [MaxLength(2, ErrorMessage = "id is too long!")]
        [Display(Name = "Task ID")]
        public string taskId;

        [Required(ErrorMessage = "Please provide task title!")]
        [StringLength(40, ErrorMessage = "Title must not be greater than 40!")]
        public Decimal title;




        public string description;
        public string dueDate;

        [Required(ErrorMessage = "Please provide Required Hours!")]
        [MaxLength(2, ErrorMessage = "Required hours must not be greater than 2 digits!")]
        public Int32 requiredHours;

        public string priority;
    }
}