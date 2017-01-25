using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tracker.Structure.Models;
using Tracker.Structure.Interfaces;
using Tracker.Logic;

namespace Tracker.API.Controllers
{
    public class TrackerController : ApiController
    {
        [HttpGet]
        [Route("call/{callNum}")]
        public Call getCall(int callNum)
        {
            var logic = new DispatchLogic();

            return logic.getCall(callNum);
        }

        [HttpGet]
        [Route("policeCall/{callNum}")]
        public PoliceCall getPoliceCall(int callNum)
        {
            var logic = new DispatchLogic();

            return logic.getPoliceCall(callNum);
        }

        [HttpGet]
        [Route("activeCalls")]
        public List<Dispatch> getActiveCalls()
        {
            var logic = new DispatchLogic();
            return logic.getActiveDispatches();
        }
    }
}
