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
    public class MasterAccountTests
    {
        [TestMethod()]
        public void TryImportVaultTest()
        {
            //Arrange
            MasterAccount user = MasterAccount.User;
            user.TryRegister("TestAccountName", "TestAccountPassword");
            Vault vault = user.Vault;

            Identity identity = vault.GenerateIdentity();
            identity.GenerateCredential();

            //CSV files
            //Act
            user.TryExportVault(Porting.VaultFormat.CSV, "", "ImportTestData/testvault.csv");

            vault.DeleteAllCredentials();
            user.TryImportVault(Porting.VaultFormat.CSV, "ImportTestData/testvault.csv", false);

            vault.CalculateHealthScore(false);

            //Assert
            Assert.AreEqual(1, vault.TotalCredentialCount);

            //Arrange
            vault.DeleteAllCredentials();
            identity.GenerateCredential();

            //JSON files
            //Act
            user.TryExportVault(Porting.VaultFormat.JSON, "", "ImportTestData/testvault.json");

            vault.DeleteAllCredentials();
            user.TryImportVault(Porting.VaultFormat.JSON, "ImportTestData/testvault.json", false);

            vault.CalculateHealthScore(false);

            //Assert
            Assert.AreEqual(1, vault.TotalCredentialCount);

            //Arrange
            vault.DeleteAllCredentials();
            identity.GenerateCredential();

            //Encrypted files
            //Act
            user.TryExportVault(Porting.VaultFormat.Encrypted, "", "ImportTestData/testvault");

            vault.DeleteAllCredentials();
            user.TryImportVault(Porting.VaultFormat.Encrypted, "ImportTestData/testvault", false);

            vault.CalculateHealthScore(false);

            //Assert
            Assert.AreEqual(1, vault.TotalCredentialCount);

            user.DeleteAccount();
        }

        [TestMethod()]
        public void TryExportVaultTest()
        {
            //Arrange
            MasterAccount user = MasterAccount.User;
            user.TryRegister("TestAccountName", "TestAccountPassword");
            Vault vault = user.Vault;

            Identity identity = vault.GenerateIdentity();
            identity.GenerateCredential();

            //CSV files
            //Act
            bool exportedCSV = user.TryExportVault(Porting.VaultFormat.CSV, "", "ExportTestData/testvault.csv");

            //Assert
            Assert.IsTrue(exportedCSV);

            //JSON files
            //Act
            bool exportedJSON = user.TryExportVault(Porting.VaultFormat.CSV, "", "ExportTestData/testvault.json");

            //Assert
            Assert.IsTrue(exportedJSON);

            //Encrypted files
            //Act
            bool exportedEncrypted = user.TryExportVault(Porting.VaultFormat.CSV, "", "ExportTestData/testvault");

            //Assert
            Assert.IsTrue(exportedEncrypted);

            user.DeleteAccount();
        }

        [TestMethod()]
        public void TryLoginTest()
        {
            //Arrange
            MasterAccount user = MasterAccount.User;
            user.TryRegister("TestAccountName", "TestAccountPassword");

            //Act
            bool loggedIn = user.TryLogin("TestAccountName", "TestAccountPassword");

            //Assert
            Assert.IsTrue(loggedIn);

            user.DeleteAccount();
        }

        [TestMethod()]
        public void TryChangePasswordTest()
        {
            //Arrange
            MasterAccount user = MasterAccount.User;
            user.TryRegister("TestAccountName", "TestAccountPassword");

            //Act
            bool changed = user.TryChangePassword("TestAccountPassword", "TestNewAccountPassword");

            //Assert
            Assert.IsTrue(changed);

            user.DeleteAccount();
        }

        [TestMethod()]
        public void TryChangeNameTest()
        {
            //Arrange
            MasterAccount user = MasterAccount.User;
            user.TryRegister("TestAccountName", "TestAccountPassword");

            //Act
            bool changed = user.TryChangeName("TestAccountPassword", "TestNewAccountName");

            //Assert
            Assert.IsTrue(changed);

            user.DeleteAccount();
        }

        [TestMethod()]
        public void LogoutTest()
        {
            //Arrange
            MasterAccount user = MasterAccount.User;
            user.TryRegister("TestAccountName", "TestAccountPassword");

            //Act
            user.Logout();

            //Assert
            Assert.IsNull(user.Vault);

            user.TryLogin("TestAccountName", "TestAccountPassword");

            user.DeleteAccount();
        }
    }
}