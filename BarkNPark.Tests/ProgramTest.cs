// <copyright file="ProgramTest.cs">Copyright ©  2018</copyright>
using System;
using BarkNPark;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BarkNPark.Tests
{
    /// <summary>This class contains parameterized unit tests for Program</summary>
    [PexClass(typeof(Program))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ProgramTest
    {
        /// <summary>Test stub for Main(String[])</summary>
        [PexMethod]
        public void MainTest(string[] args)
        {
            Program.Main(args);
            // TODO: add assertions to method ProgramTest.MainTest(String[])
        }
    }
}
