﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using vIDsafe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vIDsafe.Tests
{
    [TestClass()]
    public class CredentialGenerationTests
    {
        [TestMethod()]
        public void GenerateUsernameTest()
        {
            //Arrange
            string deriveName = "TestABC123";
            int usernameLength = 15;

            //Act
            CredentialGeneration.CurrentUsernameLength = usernameLength;
            string username = CredentialGeneration.GenerateUsername(deriveName);

            //Assert
            Assert.AreEqual(usernameLength, username.Length);
        }

        [TestMethod()]
        public void GeneratePasswordTest()
        {
            //Arrange
            int passwordLength = 15;

            //Act
            CredentialGeneration.CurrentPasswordLength = passwordLength;
            string password = CredentialGeneration.GeneratePassword();

            //Assert
            Assert.AreEqual(passwordLength, password.Length);

            //Arrange
            int passphraseLength = 5;

            //Act
            CredentialGeneration.Passphrase = true;

            CredentialGeneration.CurrentPassphraseLength = passphraseLength;

            string passphrase = CredentialGeneration.GeneratePassword();

            int wordCount = passphrase.Split('-').Length;

            //Assert
            Assert.AreEqual(passphraseLength, wordCount);
        }

        [TestMethod()]
        public void CheckStrengthTest()
        {
            //Arrange
            string password = CredentialGeneration.GeneratePassword();

            //Act
            double strength = CredentialGeneration.CheckStrength(password);

            //Assert

            bool expected = strength >= 30;

            Assert.IsTrue(expected);
        }
    }
}