﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projekt.Models
{
    public class Wiadomosc
    {

        public int ID { get; set; }

        public string Tresc { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime Data { get; set; }

        public virtual Uzytkownik Uzytkownik { get; set; }

    }
}