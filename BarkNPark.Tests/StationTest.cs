// <copyright file="StationTest.cs">Copyright ©  2018</copyright>
using System;
using BarkNPark;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BarkNPark.Tests
{
    /// <summary>This class contains parameterized unit tests for Station</summary>
    [PexClass(typeof(Station))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class StationTest
    {
        /// <summary>Test stub for get_Code()</summary>
        [PexMethod]
        internal StationCode CodeGetTest([PexAssumeUnderTest]Station target)
        {
            StationCode result = target.Code;
            return result;
            // TODO: add assertions to method StationTest.CodeGetTest(Station)
        }

        /// <summary>Test stub for .ctor(StationCode)</summary>
        [PexMethod]
        internal Station ConstructorTest(StationCode code)
        {
            Station target = new Station(code);
            return target;
            // TODO: add assertions to method StationTest.ConstructorTest(StationCode)
        }

        /// <summary>Test stub for DispenseItem(ItemType[])</summary>
        [PexMethod]
        internal int DispenseItemTest([PexAssumeUnderTest]Station target, ItemType[] items)
        {
            int result = target.DispenseItem(items);
            return result;
            // TODO: add assertions to method StationTest.DispenseItemTest(Station, ItemType[])
        }

        /// <summary>Test stub for ToString()</summary>
        [PexMethod]
        internal string ToStringTest([PexAssumeUnderTest]Station target)
        {
            string result = target.ToString();
            return result;
            // TODO: add assertions to method StationTest.ToStringTest(Station)
        }

        /// <summary>Test stub for changeStatus(Boolean, Boolean)</summary>
        [PexMethod]
        internal int changeStatusTest(
            [PexAssumeUnderTest]Station target,
            bool broken,
            bool inMain
        )
        {
            int result = target.changeStatus(broken, inMain);
            return result;
            // TODO: add assertions to method StationTest.changeStatusTest(Station, Boolean, Boolean)
        }

        /// <summary>Test stub for check_out()</summary>
        [PexMethod]
        internal int check_outTest([PexAssumeUnderTest]Station target)
        {
            int result = target.check_out();
            return result;
            // TODO: add assertions to method StationTest.check_outTest(Station)
        }

        /// <summary>Test stub for isAvailable()</summary>
        [PexMethod]
        internal bool isAvailableTest([PexAssumeUnderTest]Station target)
        {
            bool result = target.isAvailable();
            return result;
            // TODO: add assertions to method StationTest.isAvailableTest(Station)
        }

        /// <summary>Test stub for open_door()</summary>
        [PexMethod]
        internal int open_doorTest([PexAssumeUnderTest]Station target)
        {
            int result = target.open_door();
            return result;
            // TODO: add assertions to method StationTest.open_doorTest(Station)
        }

        /// <summary>Test stub for get_stationCode()</summary>
        [PexMethod]
        internal StationCode stationCodeGetTest([PexAssumeUnderTest]Station target)
        {
            StationCode result = target.stationCode;
            return result;
            // TODO: add assertions to method StationTest.stationCodeGetTest(Station)
        }
    }
}
