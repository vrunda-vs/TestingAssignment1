using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        private readonly Mock<IPassengerManager> mockDtaRepository = new Mock<IPassengerManager>();
        private readonly PassengerDATAController _passengerController;
        public PassengerUnitTest()
        {
            _passengerController = new PassengerController(mockDtaRepository.Object);
        }

        private static List<PassengerView> GetPassenger()
        {
            List<PassengerView> users = new List<PassengerView>()
            {
               
                new PassengerView() {P_No=1,F_Name="Vrunda",L_Name="Savaliya",Phone=8758695896},
                new PassengerView() {P_No=1,F_Name="Vidhi",L_Name="Kapadiya",Phone=9925963637},
                 new PassengerView() {P_No=1,F_Name="Harshil",L_Name="Sheth",Phone=9658993005},

            };
            return users;
        }

        [Fact]
        public void GetAllPassengertestcase1()
        {
            // Arrange
            var resultObj = mockDtaRepository.Setup(x => x.GetAllPassengers()).Returns(GetPassenger());

            // Act
            var response = _passengerController.GetPassengers();

            // Asert
            Assert.Equal(3, response.Count);

        }

        [Fact]
        public void GetAllPassengertestcase2()
        {
            // Arrange
            var resultObj = mockDtaRepository.Setup(x => x.GetAllPassengers()).Returns(GetPassenger());

            // Act
            var response = _passengerController.GetPassengers();

            // Asert
            Assert.NotEqual(2, response.Count);

        }

        [Fact]
        public void GetPassengerByIdtestcase3()
        {
            // Arrange
            var passenger = new PassengerView();
            passenger.P_No = 1;
            passenger.F_Name = "Vrunda";
            passenger.L_Name = "Savaliya";
            passenger.Phone = 8758394357;

            // Act
            var responseObj = mockDtaRepository.Setup(x => x.GetPassenger(passenger.P_No)).Returns(passenger);
            var result = _passengerController.GetPassenger(passenger.P_No);

            // Assert
            Assert.NotNull(result);
        }
        [Fact]
        public void GetPassengerByIdtestcase4()
        {
            // Arrange
            var passenger = new PassengerView();
            // Act
            var responseObj = mockDtaRepository.Setup(x => x.GetPassenger(4)).Returns(passenger);
            var result = _passengerController.GetPassenger(passenger.P_No);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void AddPassengertestcase5()
        {
            var newPassenger = new PassengerView();
            newPassenger.P_No = 4;
            newPassenger.F_Name = "Hetvi";
            newPassenger.L_Name = "shah";
            newPassenger.Phone = 3658963659;
            // Act
            var response = mockDtaRepository.Setup(x => x.CreateNewPassenger(newPassenger)).Returns("Added succeffuly");
            var result = _passengerController.PostPassenger(newPassenger);

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void AddPassengertestcase6()
        {
            var newPassenger = new PassengerView();

            // Act
            var response = mockDtaRepository.Setup(x => x.CreateNewPassenger(newPassenger)).Returns("Model is null");
            var result = _passengerController.PostPassenger(newPassenger);

            // Assert
            Assert.NotNull(result);
        }
        [Fact]
        public void UpdatePassengertestcase7()
        {
            // Arrange
            var UpdatePassenger = new PassengerView();
            UpdatePassenger.P_No = 4;
            UpdatePassenger.F_Name = "vidhi";
            UpdatePassenger.L_Name = "kapadia";
            UpdatePassenger.Phone = 8965236698;

            // Act
            var resultObj = mockDtaRepository.Setup(x => x.UpdatePassenger(4, UpdatePassenger)).Returns("Passenger updated");
            var response = _passengerController.PutPassenger(4, UpdatePassenger);
            // Assert
            Assert.Equal("Passenger updated", response);
        }
        [Fact]
        public void UpdatePassengertestcase8()
        {
            // Arrange
            var UpdatePassenger = new PassengerView();

            // Act
            var resultObj = mockDtaRepository.Setup(x => x.UpdatePassenger(5, UpdatePassenger)).Returns("Model is null");
            var response = _passengerController.PutPassenger(5, UpdatePassenger);
            // Assert
            Assert.NotEqual("Passenger updated", response);
        }
        [Fact]
        public void DeletePassengertestcase9()
        {
            var passenger = new PassengerView();
            passenger.P_No = 1;
            // Arrange
            var resultObj = mockDtaRepository.Setup(x => x.DeletePassenger(passenger.P_No)).Returns(true);

            // Act
            var response = _passengerController.DeletePassenger(passenger.P_No);

            //Assert
            Assert.True(response);

        }
        [Fact]
        public void DeletePassengertestcase10()
        {
            var passenger = new PassengerView();
            passenger.P_No = 4;
            // Arrange
            var resultObj = mockDtaRepository.Setup(x => x.DeletePassenger(passenger.P_No)).Returns(false);

            // Act
            var response = _passengerController.DeletePassenger(passenger.P_No);

            //Assert
            Assert.False(response);

        }
    }
}
