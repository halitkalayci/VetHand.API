﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfEmergencyRequestDal : EfEntityRepositoryBase<EmergencyRequest,VetHandContext> , IEmergencyRequestDal
    {

    }
}
