﻿using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class VetWithDistanceDto : IDto
    {
        public Vet Vet { get; set; }
        public double Distance { get; set; }
    }
}
