﻿using NUnit.Framework;
using Testura.Code.Generators.Common;
using Testura.Code.Models;
using Assert = NUnit.Framework.Assert;

namespace Testura.Code.Tests.Helper.Common
{
    [TestFixture]
    public class AttributesTests
    {
        [Test]
        public void Create_WhenNotProvidingAnyAttributes_ShouldGetEmptyString()
        {
            Assert.AreEqual(string.Empty, AttributeGenerator.Create().ToString());
        }

        [Test]
        public void Create_WhenCreatingWithSingleAttrbute_ShoulGenerateCorrectCode()
        {
            Assert.AreEqual("[Test]", AttributeGenerator.Create(new Attribute("Test")).ToString());
        }

        [Test]
        public void Create_WhenCreatingWithMultipleAttributes_ShoulGenerateCorrectCode()
        {
            Assert.AreEqual("[Test][TestCase]", AttributeGenerator.Create(new Attribute("Test"), new Attribute("TestCase")).ToString());
        }

    }
}
