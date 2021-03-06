// <copyright file="AppointmentTest.cs">Copyright ©  2018</copyright>
using System;
using BarkNPark;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BarkNPark.Tests
{
    /// <summary>This class contains parameterized unit tests for Appointment</summary>
    [PexClass(typeof(Appointment))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class AppointmentTest
    {
        /// <summary>Test stub for ProcessTransaction(ItemType[], TransactionType)</summary>
        [PexMethod]
        public int ProcessTransactionTest(
            [PexAssumeUnderTest]Appointment target,
            ItemType[] items,
            TransactionType type
        )
        {
            int result = target.ProcessTransaction(items, type);
            return result;
            // TODO: add assertions to method AppointmentTest.ProcessTransactionTest(Appointment, ItemType[], TransactionType)
        }
    }
}
