﻿using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace BLL
{
    public partial interface IReligionBusiness
    {
        List<Religion> GetData();
    }
}
