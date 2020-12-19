using System;
using System.IO;
using System.Text;
using FileSystem.Fluent.Abstractions.Core;

namespace FileSystem.Fluent.Abstractions.TestingSupport
{
    public class FakeFile : IFile
    {
        private readonly string path;
        private readonly FakeFileSystem filesystem;

        internal FakeFile(string path, FakeFileSystem filesystem)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(path));
            this.path = path;
            
            this.filesystem = filesystem ?? throw new ArgumentNullException(nameof(filesystem));
        }

        public IFile TryCreate()
        {
            throw new NotImplementedException();
        }

        public IFile CopyTo(IFile destination, Action<IFile, IFile> postCopyAction = null)
        {
            throw new NotImplementedException();
        }

        public IFile Delete()
        {
            throw new NotImplementedException();
        }

        public IFile OpenWrite(Action<Stream> action)
        {
            throw new NotImplementedException();
        }

        public IFile OpenRead(Action<Stream> action)
        {
            throw new NotImplementedException();
        }

        public IFile WriteContents(string contents, Encoding encoding = null)
        {
            throw new NotImplementedException();
        }

        public IFile AppendContents(string contents, Encoding encoding = null)
        {
            throw new NotImplementedException();
        }

        public IFile ReadLines(Action<string> action, Encoding encoding = null, string newline = null)
        {
            throw new NotImplementedException();
        }

        public IFile ReadAllLines(Action<string> action, Encoding encoding = null)
        {
            throw new NotImplementedException();
        }

        public IFile WhenExists(Action<IFile> action)
        {
            action(this);

            return this;
        }

        public IFile WhenNotExists(Action<IFile> action)
        {
            action(this);

            return this;
        }

        public IFile ForParent(Action<IDirectory> action)
        {
            throw new NotImplementedException();
        }
    }
}