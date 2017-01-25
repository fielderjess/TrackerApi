using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker.Structure.Interfaces;
using Tracker.Structure.Models;

namespace Tracker.Logic
{
    public class DispatchLogic : IDispatchLogic
    {
        public List<Dispatch> getActiveDispatches()
        {
            List<Dispatch> list = new List<Dispatch>();

            list.Add(new Dispatch
            {
                callNum = 1,
                destination = "Cleveland",
                driver = "Paul",
                location = "Columbus",
                priority = 1,

            });


            list.Add(new Dispatch
            {
                callNum = 2,
                destination = "Brunswick",
                driver = "John",
                location = "Oxford",
                priority = 2,

            });

            return list;
        }

        public Call getCall(int callNum)
        {
            return new Call()
            {
                caller = "BOB",
                bill = new Billing()
                {
                    billingZip = "34"
                }
            };
        }

        public List<Dispatch> getDispatchedCalls(DateTime startDate, DateTime endDate)
        {
            List<Dispatch> list = new List<Dispatch>();

            list.Add(new Dispatch
            {
                callNum = 1,
                destination = "Cleveland",
                driver = "Paul",
                location = "Columbus",
                priority = 1,

            });


            list.Add(new Dispatch
            {
                callNum = 2,
                destination = "Brunswick",
                driver = "John",
                location = "Oxford",
                priority = 2,

            });

            return list;
        }

        public List<OnDutyTrucks> getOnDutyTrucks()
        {
            List<OnDutyTrucks> list = new List<OnDutyTrucks>();

            list.Add(new OnDutyTrucks
            {
                driver = "driver",
                status = "status",
                truck = "truck",
                type = "type"

            });


            list.Add(new OnDutyTrucks
            {
                driver = "driver2",
                status = "status2",
                truck = "truck2",
                type = "type2"

            });

            return list;
        }

        public PoliceCall getPoliceCall(int callNum)
        {
            return new PoliceCall
            {
                color = "red",
                make = "car",
                rqedBy = "rqedBy"
            };
        }

        public Call saveCall(Call newCall)
        {
            throw new NotImplementedException();
        }

        public PoliceCall savePoliceCall(PoliceCall newCall)
        {
            throw new NotImplementedException();
        }
    }
}
