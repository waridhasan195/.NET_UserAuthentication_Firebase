using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAuthentication.Classes
{
    internal static class FirestoreHelper
    {
        //https://firebase.google.com/docs/firestore
        //https://csharpcode.org/blog/simple-encryption-and-decryption-in-c/
        //https://console.firebase.google.com/u/0/
        static string fireconfig = @"
        {
            ""type"": ""service_account"",
            ""project_id"": ""cloudfiredb-7ceb2"",
            ""private_key_id"": ""8fd2a84928d68b88bc63f1c20075d81032bd8c91"",
            ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvQIBADANBgkqhkiG9w0BAQEFAASCBKcwggSjAgEAAoIBAQCpKOelTBcG2Gqm\nNMH2RzYvNSE+GT0kvI9ZvOBT14IokhS1vvwoh/Jji4/yKDRxa/xmz1E+akUfXamg\nZkqovJvynn0Pf6RwrtJ6Z1YK4IT63RuRBaTSvKkptRx26VlSvfLcVCPHm26btNxC\n3rJgRA0DzIxKDFWYJ7e8IeD+Mvk8nLpxYyt8e7WdB9Rr2o5pDs2a5FK/1eZ5emfc\nSWtV8YwadWEn7K5BUWtzJazfZZwsRKsA5YXFg25DjUeov0yJMlmKBoR913k7wctv\ny//z0u6XdbZWtFj/MHEgjW8XnGx52FMM4yMzat+M/R1s8/heX42oBg8BL+8hh43y\nnYcdtm/nAgMBAAECggEAFzvQX9piP0Uc638g34agYT4sNq9DaqGgvsk7tnL0eZth\neiT6f/FMJXKsbqzUUc/BzGJ6h4FpGl8Zm+JGLC7blyiVh2TCB91lzfzAy0r9zhxD\nBll+w0MOU6ArLK9C3s51ZjWtmbjg1ES0YVWHrRkrqx3pFt04KbyAITg2At6qxNw4\nvfKzDAFEHBUcbwcgyMWzow8u4zg2jWeecWAfipRvcJ3hizmT4IJGCpWhPjDKEpXb\nUY156gFIrGFaW+SKWLYbJtepsOU7BVOsmuGEbiffILKRj0xq2FGYACP9R3vlB75x\nccl36/b3SVArUvv/RJWhhNz0k06ycYh8kuQnbW35YQKBgQDWzTbu1h5TbYlWCl+1\n/WimIJwDsAyMRaXHPLflzaiCyHGlqHtmOByQDMA3LcMK4KdsCcMC9D/f9n+mSkya\nGmAuhuNZ9tAGY+5F4F85Sd5/vir1NqfTn/4ShDhjsSSfo+oWdncehc//iSuvpBi8\nOAo2gDW0qorzmdphjZoMHjSfUwKBgQDJmquyWnozIEDbxkjVdy6UcGGCJdgD2Y5w\n95WXRy1CXEqU+i13riyraAlHxwpFqYHGgmS8Ku4os/y3QF7geHCaW3MWQxtIhvEB\ntupZid2bPL8kugZkjMO1gzqv/UgU7rUh/7g6OAIAbchscYuTgGgNGiFPS9Hn/pZJ\nFHzy+IcenQKBgCn3Rfg7lQkvqVlKBZEExWFPlauSxaDSKqVWU4duOrHyf2GiHRnH\ndK0gEJ23Lxf89DjDX3pARgp3mlDey0CATrJIYDq/Yb0d4Pt97py+td23RaVK3FcY\nNwdfFbVEcqdN2vowgu1Pr2d5YTObl8mOGVC0k8mMWEFnmabdh28+p4FJAoGASFe9\nNuHqqb/wJi0P47HBwDhXdRlZW4BM8dKWFlPPNNnjVXQ0rpaMpvFNKzmMQRUjYXVW\n6oLJNUfo7mUl5oyxc2JPePSZrLvnbcMScxDauaLhwC8Uri4o6FBv1ckgfYpu6wVV\nOWbxqO+8FNXlzQctz03KGCdP6lzb1tuIPrPZ4K0CgYEAvwnBVBR8w83LgauZ5o27\np60fo038UOBHzXFRCSh6OehDiyWMCZJoGav6AMk1AueblSvPQ93zPSriHUgVPNFm\nawl2UMUId7aX4AUlvoUFpMlRGfOkOiKUMgYdUVLEScfrqSS4Dc/Al1dyDlwe7pVf\nho67DG/w0+bLMDtfmYBCtkE=\n-----END PRIVATE KEY-----\n"",
            ""client_email"": ""firebase-adminsdk-4cvw1@cloudfiredb-7ceb2.iam.gserviceaccount.com"",
            ""client_id"": ""113347214652674599296"",
            ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
            ""token_uri"": ""https://oauth2.googleapis.com/token"",
            ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
            ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-4cvw1%40cloudfiredb-7ceb2.iam.gserviceaccount.com"",
            ""universe_domain"": ""googleapis.com""
        } ";
        static string filepath = "";
        public static FirestoreDb? Database { get; private set; }

        public static void SetEnvironmentVariable()
        {
            filepath = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(Path.GetRandomFileName())) + ".json";
            File.WriteAllText(filepath, fireconfig);
            File.SetAttributes(filepath, FileAttributes.Hidden);
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filepath);
            Database = FirestoreDb.Create("cloudfiredb-7ceb2");
            File.Delete(filepath);
        }
    }
   
}
