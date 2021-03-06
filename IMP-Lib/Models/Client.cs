﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IMP_Lib.Models
{
    [DataContract]
    public class Client
    {
        public int ClientId { get; set; }
        public string Username { get; set; }
        public string Fingerprint { get; set; }
        public DateTime CreationDate { get; set; }

        [NotMapped]
        public ConnectionInfo ConnectionInfo { get; set; }

        public virtual SystemInfo SystemInfo { get; set; }
        public virtual PersonalInformation PersonalInformation { get; set; }
    }
}
