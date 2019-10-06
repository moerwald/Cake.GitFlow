
namespace Cake.GitFlow.Test.Release
{
    using Cake.GitFlow.Release.Workflow;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class MergeIformationTest
    {
        [Test]
        public void NewVersionIsNullThrowException()
            => Assert.Throws<ArgumentException>(
                () => new MergeInformation(null, "some commit message"));
    }
}
