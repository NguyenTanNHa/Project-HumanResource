﻿using System;

namespace HumanResource.src.DTO.Request
{
    internal class EmployeeHistoryReqDTO

    {
        private int historyId;
        private int employId;
        private DateTime? startDate;
        private DateTime? endDate;
        private string staging;

        public EmployeeHistoryReqDTO() { }


        public int HistoryId
        {
            get { return historyId; }
            set { historyId = value; }
        }

        public int EmployId
        {
            get { return employId; }
            set { employId = value; }
        }

        public DateTime? StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public DateTime? EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        public string Staging
        {
            get { return staging; }
            set { staging = value; }
        }
    }
}
