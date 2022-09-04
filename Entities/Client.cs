﻿using System;
using System.Collections.Generic;


namespace Csharp_EnumEComposicao.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            this.email = email;
            BirthDate = birthDate;
        }
    }
}
