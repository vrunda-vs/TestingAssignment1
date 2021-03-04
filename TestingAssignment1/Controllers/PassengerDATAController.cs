using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessEntities;
using Business.Interface;

namespace TestingAssignment1.Controllers
{
    public class PassengerDATAController
    {
        // GET: Passenger
        private readonly IPassengerManager _passengerManager;

        public PassengerDATAController(IPassengerManager passengerManager)
        {
            _passengerManager = passengerManager;
        }

        // GET: api/Passengers
        public List<PassengerView> GetPassengersDATA()
        {
            return _passengerManager.GetAllPassengersDATA();
        }

        // GET: api/Passengers/5
        public PassengerView GetPassengerDATA(int id)
        {
            return _passengerManager.GetPassengerDATA(id); ;
        }

        // PUT: api/Passengers/5
        public string PutPassengerDATA(int id, PassengerViewDATA passenger)
        {
            return _passengerManager.UpdatePassengerDATA(id, passenger);
        }

        // POST: api/Passengers
        public string PostPassengerDATA(PassengerViewDATA passenger)
        {
            return _passengerManager.CreateNewPassengerDATA(passenger);
        }

        // DELETE: api/Passengers/5
        public bool DeletePassengerDATA(int id)
        {
            return _passengerManager.DeletePassengerDATA(id);
        }
    }
}