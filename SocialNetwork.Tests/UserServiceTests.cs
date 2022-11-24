using SocialNetwork.PLL.Views;
using System;
using System.Net.Mail;
using Microsoft.VisualBasic.CompilerServices;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using Xunit;
using SocialNetwork.PLL.Helpers;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Assert = Xunit.Assert;
using SocialNetwork.BLL.Exceptions;

namespace SocialNetwork.Tests
{
    [TestFixture]
    public class UserServiceTests

    {
        [Test]
        public void RegisterMustReturnArgumentNullException()
        {
            var userService = new UserService();

            var userRegistrationData = new UserRegistrationData();

            Assert.Throws<ArgumentNullException>(() => userService.Register(userRegistrationData));
        }
    }
}