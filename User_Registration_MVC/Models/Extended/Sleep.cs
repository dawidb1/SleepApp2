﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace User_Registration_MVC.Models
{
    [MetadataType(typeof(SleepMetaData))]
    public partial class Sleep
    {
        public void SetAmountOfSleep()
        {
            this.AmountOfSleep = EndSleep - StartSleep;
        }

        public DayOfWeek DayOfWeek { get { return this.StartSleep.DayOfWeek; } }
    }

    public class SleepMetaData
    {
        [Display(Name = "Start Sleep")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public System.DateTime StartSleep { get; set; }
        [Display(Name = "End Sleep")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public System.DateTime EndSleep { get; set; }
        [Display(Name = "Morning Rating")]
        [Range(typeof(int),"1","10",ErrorMessage = "must be intiger from 0-10")]
        public Nullable<int> MorningRating { get; set; }
        [Display(Name = "Evening Rating")]
        [Range(typeof(int), "1", "10", ErrorMessage = "must be intiger from 0-10")]
        public Nullable<int> EveningRating { get; set; }
        [Display(Name = "Amount of Sleep")]
        public Nullable<System.TimeSpan> AmountOfSleep { get; set; }
        [Display(Name ="Just a nap")]
        public bool QuickSleep { get; set; }
        [Display(Name ="Day of week")]
        public DayOfWeek DayOfWeek { get; }

    }
}