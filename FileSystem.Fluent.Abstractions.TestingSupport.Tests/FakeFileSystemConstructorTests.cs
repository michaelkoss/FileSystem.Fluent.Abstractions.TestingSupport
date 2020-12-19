using FileSystem.Fluent.Abstractions.Core;
using NUnit.Framework;

namespace FileSystem.Fluent.Abstractions.TestingSupport.Tests
{
    public class FakeFileSystemConstructorTests
    {
        [Test]
        public void GivenEmptyFakeFileSystem_WhenWhenNotExists_ThenActionCalled()
        {
            IFileSystem fake = new FakeFileSystem();

            bool actionCalled = false;
            fake.File(@"c:\temp\test.txt")
                .WhenNotExists(f => actionCalled = true);
            
            Assert.IsTrue(actionCalled, "Expected the file to not exist and not call the action");
        }
    }
}