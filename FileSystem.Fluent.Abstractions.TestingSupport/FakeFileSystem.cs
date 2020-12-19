using System;
using FileSystem.Fluent.Abstractions.Core;

namespace FileSystem.Fluent.Abstractions.TestingSupport
{
    public class FakeFileSystem : IFileSystem
    {
        public IFile File(string path)
        {
            return new FakeFile(path, this);
        }

        public IDirectory Directory(string path)
        {
            return new FakeDirectory(path, this);
        }
    }
}