// <copyright file="SaleTest.cs">Copyright ©  2018</copyright>
using System;
using BarkNPark;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BarkNPark.Tests
{
    /// <summary>This class contains parameterized unit tests for Sale</summary>
    [PexClass(typeof(Sale))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class SaleTest
    {
        /// <summary>Test stub for .ctor(ItemType[])</summary>
        [PexMethod]
        internal Sale ConstructorTest(ItemType[] items)
        {
            Sale target = new Sale(items);
            return target;
            // TODO: add assertions to method SaleTest.ConstructorTest(ItemType[])
        }

        /// <summary>Test stub for ProcessPayment(String)</summary>
        [PexMethod]
        internal int ProcessPaymentTest([PexAssumeUnderTest]Sale target, string payPalEmail)
        {
            int result = target.ProcessPayment(payPalEmail);
            return result;
            // TODO: add assertions to method SaleTest.ProcessPaymentTest(Sale, String)
        }

        /// <summary>Test stub for ToString()</summary>
        [PexMethod]
        internal string ToStringTest([PexAssumeUnderTest]Sale target)
        {
            string result = target.ToString();
            return result;
            // TODO: add assertions to method SaleTest.ToStringTest(Sale)
        }
    }
}
