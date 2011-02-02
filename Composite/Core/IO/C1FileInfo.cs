﻿using System;
using System.IO;
using System.Runtime.Serialization;
using Composite.Core.Implementation;


namespace Composite.Core.IO
{
    /// <summary>
    /// IOLayer - documentation pending
    /// </summary>
    public class C1FileInfo : C1FileSystemInfo
    {
        private ImplementationContainer<C1FileInfoImplementation> _implementation;

        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="fileName"></param>
        public C1FileInfo(string fileName)
        {
            _implementation = new ImplementationContainer<C1FileInfoImplementation>(() => ImplementationFactory.CurrentFactory.CreateC1FileInfo(fileName));
            _implementation.CreateImplementation();
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public string DirectoryName
        {
            get
            {
                return _implementation.Implementation.DirectoryName;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public C1DirectoryInfo Directory
        {
            get
            {
                return _implementation.Implementation.Directory;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public string Name
        {
            get
            {
                return _implementation.Implementation.Name;
            }
        }




        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public override string FullName
        {
            get
            {
                return _implementation.Implementation.FullName;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public override bool Exists
        {
            get
            {
                return _implementation.Implementation.Exists;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public override string Extension
        {
            get
            {
                return _implementation.Implementation.Extension;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public bool IsReadOnly
        {
            get
            {
                return _implementation.Implementation.IsReadOnly;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public long Length
        {
            get
            {
                return _implementation.Implementation.Length;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public override FileAttributes Attributes
        {
            get
            {
                return _implementation.Implementation.Attributes;
            }
            set
            {
                _implementation.Implementation.Attributes = value;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <returns></returns>
        public C1FileStream Create()
        {
            return _implementation.Implementation.Create();
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <returns></returns>
        public C1StreamWriter CreateText()
        {
            return _implementation.Implementation.CreateText();
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <returns></returns>
        public C1StreamWriter AppendText()
        {
            return _implementation.Implementation.AppendText();
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public C1FileStream Open(FileMode mode)
        {
            return _implementation.Implementation.Open(mode);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="access"></param>
        /// <returns></returns>
        public C1FileStream Open(FileMode mode, FileAccess access)
        {
            return _implementation.Implementation.Open(mode, access);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="access"></param>
        /// <param name="share"></param>
        /// <returns></returns>
        public C1FileStream Open(FileMode mode, FileAccess access, FileShare share)
        {
            return _implementation.Implementation.Open(mode, access, share);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <returns></returns>
        public C1FileStream OpenRead()
        {
            return _implementation.Implementation.OpenRead();
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <returns></returns>
        public C1StreamReader OpenText()
        {
            return _implementation.Implementation.OpenText();
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <returns></returns>
        public C1FileStream OpenWrite()
        {
            return _implementation.Implementation.OpenWrite();
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="destFileName"></param>
        /// <returns></returns>
        public C1FileInfo CopyTo(string destFileName)
        {
            return _implementation.Implementation.CopyTo(destFileName);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="destFileName"></param>
        /// <param name="overwrite"></param>
        /// <returns></returns>
        public C1FileInfo CopyTo(string destFileName, bool overwrite)
        {
            return _implementation.Implementation.CopyTo(destFileName, overwrite);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="destFileName"></param>
        public void MoveTo(string destFileName)
        {
            _implementation.Implementation.MoveTo(destFileName);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="destinationFileName"></param>
        /// <param name="destinationBackupFileName"></param>
        /// <returns></returns>
        public C1FileInfo Replace(string destinationFileName, string destinationBackupFileName)
        {
            return _implementation.Implementation.Replace(destinationFileName, destinationBackupFileName);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="destinationFileName"></param>
        /// <param name="destinationBackupFileName"></param>
        /// <param name="ignoreMetadataErrors"></param>
        /// <returns></returns>
        public C1FileInfo Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
        {
            return _implementation.Implementation.Replace(destinationFileName, destinationBackupFileName, ignoreMetadataErrors);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public override void Delete()
        {
            _implementation.Implementation.Delete();
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public override void Refresh()
        {
            _implementation.Implementation.Refresh();
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            _implementation.Implementation.GetObjectData(info, context);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public override DateTime CreationTime
        {
            get
            {
                return _implementation.Implementation.CreationTime;
            }
            set
            {
                _implementation.Implementation.CreationTime = value;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public override DateTime CreationTimeUtc
        {
            get
            {
                return _implementation.Implementation.CreationTimeUtc;
            }
            set
            {
                _implementation.Implementation.CreationTimeUtc = value;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public override DateTime LastAccessTime
        {
            get
            {
                return _implementation.Implementation.LastAccessTime;
            }
            set
            {
                _implementation.Implementation.LastAccessTime = value;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public override DateTime LastAccessTimeUtc
        {
            get
            {
                return _implementation.Implementation.LastAccessTimeUtc;
            }
            set
            {
                _implementation.Implementation.LastAccessTimeUtc = value;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public override DateTime LastWriteTime
        {
            get
            {
                return _implementation.Implementation.LastWriteTime;
            }
            set
            {
                _implementation.Implementation.LastWriteTime = value;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public override DateTime LastWriteTimeUtc
        {
            get
            {
                return _implementation.Implementation.LastWriteTimeUtc;
            }
            set
            {
                _implementation.Implementation.LastWriteTimeUtc = value;
            }
        }

        //public FileSecurity GetAccessControl();
        //public FileSecurity GetAccessControl(AccessControlSections includeSections);
        //public void SetAccessControl(FileSecurity fileSecurity);

        //public void Decrypt();        
        //public void Encrypt();
    }
}
