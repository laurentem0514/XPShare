﻿using System;

namespace XPShare.Domain.Tags
{
    public class Tag : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
