// <copyright file="SystemTest.cs">Copyright ©  2018</copyright>
using System;
using System.Collections.Generic;
using BarkNPark;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BarkNPark.Tests
{
    /// <summary>This class contains parameterized unit tests for System</summary>
    [PexClass(typeof(global::BarkNPark.System))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class SystemTest
    {
        /// <summary>Test stub for CheckIn(String, Double)</summary>
        [PexMethod]
        public int CheckInTest(
            [PexAssumeUnderTest]global::BarkNPark.System target,
            string name,
            double duration
        )
        {
            int result = target.CheckIn(name, duration);
            return result;
            // TODO: add assertions to method SystemTest.CheckInTest(System, String, Double)
        }

        /// <summary>Test stub for Checkout(String)</summary>
        [PexMethod]
        public int CheckoutTest([PexAssumeUnderTest]global::BarkNPark.System target, string name)
        {
            int result = target.Checkout(name);
            return result;
            // TODO: add assertions to method SystemTest.CheckoutTest(System, String)
        }

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public global::BarkNPark.System ConstructorTest()
        {
            System target = new System();
            return target;
            // TODO: add assertions to method SystemTest.ConstructorTest()
        }

        /// <summary>Test stub for GetStation(StationCode)</summary>
        [PexMethod]
        public IStation GetStationTest([PexAssumeUnderTest]global::BarkNPark.System target, StationCode code)
        {
            IStation result = target.GetStation(code);
            return result;
            // TODO: add assertions to method SystemTest.GetStationTest(System, StationCode)
        }

        /// <summary>Test stub for ToString()</summary>
        [PexMethod]
        public string ToStringTest([PexAssumeUnderTest]global::BarkNPark.System target)
        {
            string result = target.ToString();
            return result;
            // TODO: add assertions to method SystemTest.ToStringTest(System)
        }

        /// <summary>Test stub for addItem(String, ItemType[])</summary>
        [PexMethod]
        public int addItemTest(
            [PexAssumeUnderTest]global::BarkNPark.System target,
            string name,
            ItemType[] items
        )
        {
            int result = target.addItem(name, items);
            return result;
            // TODO: add assertions to method SystemTest.addItemTest(System, String, ItemType[])
        }

        /// <summary>Test stub for getAppointmentByName(String)</summary>
        [PexMethod]
        public IAppointment getAppointmentByNameTest([PexAssumeUnderTest]global::BarkNPark.System target, string name)
        {
            IAppointment result = target.getAppointmentByName(name);
            return result;
            // TODO: add assertions to method SystemTest.getAppointmentByNameTest(System, String)
        }

        /// <summary>Test stub for getFirstAvailableStation()</summary>
        [PexMethod]
        public IStation getFirstAvailableStationTest([PexAssumeUnderTest]global::BarkNPark.System target)
        {
            IStation result = target.getFirstAvailableStation();
            return result;
            // TODO: add assertions to method SystemTest.getFirstAvailableStationTest(System)
        }

        /// <summary>Test stub for listStations()</summary>
        [PexMethod]
        public List<IStation> listStationsTest([PexAssumeUnderTest]global::BarkNPark.System target)
        {
            List<IStation> result = target.listStations();
            return result;
            // TODO: add assertions to method SystemTest.listStationsTest(System)
        }

        /// <summary>Test stub for requestextension(String, Double)</summary>
        [PexMethod]
        public int requestextensionTest(
            [PexAssumeUnderTest]global::BarkNPark.System target,
            string name,
            double timeToAdd
        )
        {
            int result = target.requestextension(name, timeToAdd);
            return result;
            // TODO: add assertions to method SystemTest.requestextensionTest(System, String, Double)
        }
    }
}
