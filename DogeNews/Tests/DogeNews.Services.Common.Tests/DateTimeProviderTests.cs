﻿using System;
using NUnit.Framework;

namespace DogeNews.Services.Common.Tests
{
    [TestFixture]
    public class DateTimeProviderTests
    {
        [Test]
        public void Now_ShouldReturnDateTimeType()
        {
            DateTimeProvider dateTimeProvider = new DateTimeProvider();
            DateTime result = dateTimeProvider.Now;

            Assert.AreEqual(typeof(DateTime), result.GetType());
        }

        [Test]
        public void Now_ShouldReturnDateTimeUTCNow()
        {
            DateTimeProvider dateTimeProvider = new DateTimeProvider();
            DateTime result = dateTimeProvider.Now;

            Assert.AreEqual(typeof(DateTime), result.GetType());
            Assert.AreEqual(result.Year, DateTime.UtcNow.Year);
            Assert.AreEqual(result.Month, DateTime.UtcNow.Month);
            Assert.AreEqual(result.Day, DateTime.UtcNow.Day);
            Assert.AreEqual(result.Hour, DateTime.UtcNow.Hour);
            Assert.AreEqual(result.Minute, DateTime.UtcNow.Minute);
            Assert.AreEqual(result.Second, DateTime.UtcNow.Second);
        }
    }
}
