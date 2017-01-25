using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker.Structure.Models;

namespace Tracker.Structure.Interfaces
{
    public interface IDispatchLogic
    {
        Call getCall(int callNum);
        PoliceCall getPoliceCall(int callNum);
        List<Dispatch> getActiveDispatches();
        List<Dispatch> getDispatchedCalls(DateTime startDate, DateTime endDate);
        List<OnDutyTrucks> getOnDutyTrucks();
        Call saveCall(Call newCall);
        PoliceCall savePoliceCall(PoliceCall newCall);
    }
}
