using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repository.Interface
{
    class IPassengerRepository
    {
        string CreateNewPassenger(PassengerView model);
        List<PassengerView> GetAllPassengers();
        PassengerView GetPassenger(int? Id);
        string UpdatePassenger(int id, PassengerView model);
        bool DeletePassenger(int? Id);
    }
}
