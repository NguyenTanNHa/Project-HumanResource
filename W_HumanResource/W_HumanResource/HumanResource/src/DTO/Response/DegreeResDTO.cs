﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.src.DTO.Response
{
    internal class DegreeResDTO
    {
        private int degreeId;
        private string degreeName;

        public int DegreeId
        {
            get { return degreeId; }
            set { degreeId = value; }
        }
        public string DegreeName
        {
            get { return degreeName; }
            set { degreeName = value; }
        }
    }
}
