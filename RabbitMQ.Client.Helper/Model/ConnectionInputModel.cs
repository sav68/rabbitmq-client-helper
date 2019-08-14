﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMQ.Client.Helper.Model
{
    public class ConnectionInputModel
    {
        public string ServerIP { get; set; }
        public string ServerPort { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}