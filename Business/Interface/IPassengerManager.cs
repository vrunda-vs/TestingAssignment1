using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace Business.Interface
{
    class IPassengerManager
    {
        string CreateNewPassenger(PassengerView model);
        List<PassengerView> GetAllPassengers();
        PassengerView GetPassenger(int? Id);
        string UpdatePassenger(int id, PassengerView model);
        bool DeletePassnger(int? Id);
    }
}
