using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using CBS.Common.Interface;
using System.IO;
using System.Threading.Tasks;

namespace CBS.Common.Services.Azure_Storage
{
    public class AzureBlobStorage : IAzureBlobStorage
    {
        public AzureBlobStorage(AzureBlobSettings settings)
        {
            this.settings = settings;
        }

        #region Default Settings
        public async Task UploadAsync(string blobName, Stream stream)
        {

            CloudBlockBlob blockBlob = await GetBlockBlobAsync(blobName);
            stream.Position = 0;
            await blockBlob.UploadFromStreamAsync(stream);
        }

        public async Task<MemoryStream> DownloadAsync(string blobName)
        {
            CloudBlockBlob blockBlob = await GetBlockBlobAsync(blobName);

            using (var stream = new MemoryStream())
            {
                await blockBlob.DownloadToStreamAsync(stream);
                return stream;
            }
        }

        public async Task DeleteAsync(string blobName)
        {
            CloudBlockBlob blockBlob = await GetBlockBlobAsync(blobName);
            await blockBlob.DeleteAsync();
        }

        public async Task<bool> ExistsAsync(string blobName)
        {
            CloudBlockBlob blockBlob = await GetBlockBlobAsync(blobName);
            return await blockBlob.ExistsAsync();
        }
        #endregion

        #region With parameter Container Name

        public async Task UploadAsync(string blobName, Stream stream, string containername)
        {

            CloudBlockBlob blockBlob = await GetBlockBlobAsync(blobName, containername);
            stream.Position = 0;
            await blockBlob.UploadFromStreamAsync(stream);
        }

        public async Task<MemoryStream> DownloadAsync(string blobName, string containername)
        {
            CloudBlockBlob blockBlob = await GetBlockBlobAsync(blobName, containername);

            using (var stream = new MemoryStream())
            {
                await blockBlob.DownloadToStreamAsync(stream);
                return stream;
            }
        }

        public async Task<byte[]> DownloadByteArrayAsync(string blobName, string containername)
        {
            CloudBlockBlob blockBlob = await GetBlockBlobAsync(blobName, containername);
           
            using (MemoryStream ms = new MemoryStream())
            {
                await blockBlob.DownloadToStreamAsync(ms);
                return ms.ToArray();
            }

        }




        public async Task DeleteAsync(string blobName, string containername)
        {
            CloudBlockBlob blockBlob = await GetBlockBlobAsync(blobName, containername);
            await blockBlob.DeleteAsync();
        }

        public async Task<bool> ExistsAsync(string blobName, string containername)
        {
            CloudBlockBlob blockBlob = await GetBlockBlobAsync(blobName, containername);
            return await blockBlob.ExistsAsync();
        }
        #endregion

        #region Internal Class

        private readonly AzureBlobSettings settings;

        private async Task<CloudBlobContainer> GetContainerAsync()
        {
            CloudStorageAccount storageAccount = new CloudStorageAccount(new StorageCredentials(settings.StorageAccount, settings.StorageKey), false);
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer blobContainer = blobClient.GetContainerReference(settings.ContainerName);
            await blobContainer.CreateIfNotExistsAsync();

            return blobContainer;
        }


        private async Task<CloudBlobContainer> GetContainerAsync(string containername)
        {
            CloudStorageAccount storageAccount = new CloudStorageAccount(new StorageCredentials(settings.StorageAccount, settings.StorageKey), false);
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer blobContainer = blobClient.GetContainerReference(containername);
            await blobContainer.CreateIfNotExistsAsync();

            return blobContainer;
        }

        private async Task<CloudBlockBlob> GetBlockBlobAsync(string blobName)
        {
            CloudBlobContainer blobContainer = await GetContainerAsync();
            CloudBlockBlob blockBlob = blobContainer.GetBlockBlobReference(blobName);

            return blockBlob;
        }


        private async Task<CloudBlockBlob> GetBlockBlobAsync(string blobName, string containername)
        {
            CloudBlobContainer blobContainer = await GetContainerAsync(containername);
            CloudBlockBlob blockBlob = blobContainer.GetBlockBlobReference(blobName);

            return blockBlob;
        }


        #endregion
    }
}
