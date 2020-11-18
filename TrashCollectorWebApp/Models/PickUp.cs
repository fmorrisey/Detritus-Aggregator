﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollectorWebApp.Models
{
    public class PickUp
    {

        [Key]
        public int PickUP_ID { get; set; }
        
        [ForeignKey("Customer_ID")]
        public int Customer_ID { get; set; }
        public Customer customer { get; set; }

        [Display(Name = "Weekly Pick Up Day (Mo, Tu, We, Th, Fr)")]
        public DayOfWeek Customer_PickUp_Reccuring { get; set; }

        [Display(Name = "One Time Pick Up")]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Customer_PickUp_OneTime { get; set; }

        [Display(Name = "Suspend Pick Up Start Date")]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Customer_PickUp_Temp_Start { get; set; }

        [Display(Name = "Suspend Pick Up End Date")]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Customer_PickUp_Temp_End { get; set; }
        public bool ConfirmPickUp { get; set; }


    }

}