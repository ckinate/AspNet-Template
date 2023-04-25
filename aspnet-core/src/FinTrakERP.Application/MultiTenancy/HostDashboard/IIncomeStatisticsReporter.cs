using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FinTrakERP.MultiTenancy.HostDashboard.Dto;

namespace FinTrakERP.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}