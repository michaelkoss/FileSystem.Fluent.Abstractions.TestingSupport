using System;
using FileSystem.Fluent.Abstractions.Core;

namespace FileSystem.Fluent.Abstractions.TestingSupport
{
    public class FakeDirectory : IDirectory
    {
        private readonly string path;
        private readonly FakeFileSystem filesystem;

        internal FakeDirectory(string path, FakeFileSystem filesystem)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(path));
            this.path = path;
            
            this.filesystem = filesystem ?? throw new ArgumentNullException(nameof(filesystem));
        }

        public IDirectory TryCreate()
        {
            throw new NotImplementedException();
        }

        public IDirectory Delete()
        {
            throw new NotImplementedException();
        }

        public IDirectory DeleteRecursive()
        {
            throw new NotImplementedException();
        }

        public IDirectory ForEachSubDirectory(Action<IDirectory> action)
        {
            throw new NotImplementedException();
        }

        public IDirectory ForEachFile(Action<IFile> action)
        {
            throw new NotImplementedException();
        }

        public IDirectory WhenExists(Action<IDirectory> action)
        {
            throw new NotImplementedException();
        }

        public IDirectory WhenNotExists(Action<IDirectory> action)
        {
            throw new NotImplementedException();
        }

        public IDirectory ForParent(Action<IDirectory> action)
        {
            throw new NotImplementedException();
        }
    }
}