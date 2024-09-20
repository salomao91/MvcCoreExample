﻿using MvcCoreExample.Models;

namespace MvcCoreExample
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string SocialNumber { get; set; }
        public AddressModel Address { get; set; }
    }
}