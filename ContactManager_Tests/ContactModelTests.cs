﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using ContactManager;

namespace ContactManager_Tests
{
    [TestClass]
    public class ContactModelTests
    {
        [TestMethod]
        public void TestFailure(){
         Assert.IsTrue(1==1);   
        }
        [TestMethod]
        public void TestKnowValidContactModel_IsValid()
        {
            var contact = new ContactModel
            {
                FirstName = "Jason",
                LastName = "Whelehon",
                EmailAddress = "wheelie33@gmail.com",
                HomeAddressLine1 = "3922 Berview",
                HomeAddressCity = "St Louis",
                HomeAddressState = "MO",
                HomeAddressPostalCode = 63125,

                WorkAddressLine1 = "930 Kehrs Mill Rd",
                WorkAddressLine2 = "Suite 302",
                WorkAddressCity = "Baldwin",
                WorkAddressState = "Missouri",
                WorkAddressPostalCode = 63011
            };

            var isValid = contact.IsValid(out string validationError);

            Assert.IsTrue(string.IsNullOrEmpty(validationError));
            Assert.IsTrue(isValid);
        }
    }
}
