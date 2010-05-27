using NUnit.Framework;

namespace Toxicity.Test
{
    [TestFixture]
    public class XmlMetricReaderTest
    {
        [Test]
        public void ShouldIgnoreTestClass()
        {
            Assert.IsTrue(XmlMetricReader.IgnoreType("XMLTest"));
        }

        [Test]
        public void ShouldIgnoreModuleClasses()
        {
            Assert.IsTrue(XmlMetricReader.IgnoreType("<Module>"));
        }

        [Test]
        public void ShouldNotIgnoreRegularClassName()
        {
            Assert.IsFalse(XmlMetricReader.IgnoreType("RegularClassName"));
        }

        [Test]
        public void ShouldNotIgnoreEmptyString()
        {
            Assert.IsFalse(XmlMetricReader.IgnoreType(""));
        }
    }
}