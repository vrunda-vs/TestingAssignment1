using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Extension;
using Model.Repository;
using Model.Repository.Interface;

namespace Business.Helper
{
    class RepositoryHelper : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<IPassengerRepository, PassengerRepository>();
        }
    }
}
