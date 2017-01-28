using NUnit.Framework;

namespace BaseProject.Tests.Unit.Utilities
{
    [TestFixture]
    public class CacheControlTests
    {
        [Test]
        public void FiveRecipesInDatabase_MaxAge_ShouldBeOneHour()
        {
            var cacheControl = new Web.Utilities.CacheControl();

            var maxAge = cacheControl.MaxAge;

            Assert.AreEqual(3600, maxAge);
        }
    }
}