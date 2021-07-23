﻿using System;

namespace WebApi.Models
{
    public class ApiData
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Endpoint { get; set; }
        public string Category { get; set; }
    }
}