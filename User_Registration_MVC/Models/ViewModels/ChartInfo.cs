﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace User_Registration_MVC.Models.ViewModels
{
    public class ChartInfo
    {
        public ChartInfo(TimeSpan? amountOfHours, DateTime date)
        {
            this.AmountOfHours = ((TimeSpan)amountOfHours).Ticks;
            this.DateJS = (long)date.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds;
        }
        public double AmountOfHours { get; set; }
        public long DateJS { get; set; }
    }
}