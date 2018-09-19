using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;

namespace CBS.Common.Interface
{
    public interface IAzureBlobStorage
    {
        Task UploadAsync(string blobName, Stream stream);
        Task<MemoryStream> DownloadAsync(string blobName);
        Task DeleteAsync(string blobName);
        Task<bool> ExistsAsync(string blobName);

        Task UploadAsync(string blobName, Stream stream, string containername);
        Task<MemoryStream> DownloadAsync(string blobName, string containername);
        Task DeleteAsync(string blobName, string containername);
        Task<bool> ExistsAsync(string blobName, string containername);
        Task<byte[]> DownloadByteArrayAsync(string blobName, string containername);
    }
}
