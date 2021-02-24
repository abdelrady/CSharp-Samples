using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace MM_TokenGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int test1 = 4;
            object test5 = 4;
            var test6 = (SystemEventAttendeeStatusOption?)test5;

            //Console.WriteLine(new Regex(@"^[0-9a-zA-Z ]+$").IsMatch("abc _efg"));
            //var tokenModel = ParseToken("_acIFCrldJrlXjE2N5HOPcqnrFdBL45u_oicIzPNtXM");
            //Console.WriteLine();
            Console.WriteLine(GetLoginToken(84, DateTime.UtcNow));
        }


        // Define other methods and classes here
        public enum SystemEventAttendeeStatusOption : byte
        {
            Attended = 5,
            Cancelled = 6,
            Declined = 2,
            Invited = 1,
            NoShow = 7,
            Registered = 4,
            Tentative = 3,
            Unknown = 0,
            WaitingList = 8,
        }
        public static TokenModel ParseToken(string token)
        {
            try
            {
                var encryptedBytes = BasicEncryption.Base64DecodeUrlSafe(token);
                var decryptedBytes = BasicEncryption.DecryptBytesFromBytes_Aes(encryptedBytes);
                int loginId = BitConverter.ToInt32(decryptedBytes, 0);
                long ticks = BitConverter.ToInt64(decryptedBytes, sizeof(int));
                bool oneTimeUse = BitConverter.ToBoolean(decryptedBytes, sizeof(int) + sizeof(long) + 16);
                return new TokenModel
                {
                    ObjectId = loginId,
                    Ticks = ticks,
                    IsOneTimeUse = oneTimeUse
                };
            }
            catch (Exception)
            {
                return null;
            }
        }

        public class TokenModel
        {
            public int ObjectId { get; set; }
            public long Ticks { get; set; }
            public bool IsOneTimeUse { get; set; }
            public bool IsExpired => DateTime.UtcNow.Ticks > Ticks;
        }

        public static byte[] GetRandomBytes()
        {
            byte[] randomBytes = new byte[16];
            new Random().NextBytes(randomBytes);
            return randomBytes;
        }

        public static string GetLoginToken(int loginId, DateTime expirationDate, bool oneTimeUse = true)
        {
            byte[] expirationBytes = BitConverter.GetBytes(expirationDate.Ticks);
            byte[] loginIdBytes = BitConverter.GetBytes(loginId);

            var randomBytes = GetRandomBytes();
            byte[] oneTimeUseBytes = BitConverter.GetBytes(oneTimeUse);

            byte[] allTheBytes = new byte[loginIdBytes.Length + expirationBytes.Length + randomBytes.Length + sizeof(bool)];
            Buffer.BlockCopy(loginIdBytes, 0, allTheBytes, 0, loginIdBytes.Length);
            Buffer.BlockCopy(expirationBytes, 0, allTheBytes, loginIdBytes.Length, expirationBytes.Length);
            Buffer.BlockCopy(randomBytes, 0, allTheBytes, loginIdBytes.Length + expirationBytes.Length, randomBytes.Length);
            Buffer.BlockCopy(oneTimeUseBytes, 0, allTheBytes, loginIdBytes.Length + expirationBytes.Length + randomBytes.Length, oneTimeUseBytes.Length);

            byte[] encryptedBytes = BasicEncryption.EncryptBytesToBytes_Aes(allTheBytes);
            string encryptedData = BasicEncryption.Base64EncodeUrlSafe(encryptedBytes);
            return encryptedData;
        }

    }
    public class BasicEncryption
    {
        private static readonly byte[] DefaultSecretKey = new byte[] { 0x20, 0xF5, 0xE4, 0xEC, 0x1, 0xC4, 0xDD, 0xB4, 0x9A, 0x22, 0x56, 0xFC, 0x5F, 0x7E, 0x77, 0x57, 0xC6, 0x97, 0x4E, 0x70, 0xE3, 0x59, 0x3C, 0x5, 0xD5, 0xBE, 0x37, 0x24, 0x1C, 0x45, 0x8E, 0xEF };

        private static readonly byte[] DefaultInitializationVector = new byte[] { 0x22, 0xC2, 0x20, 0xAB, 0x7F, 0xC3, 0x61, 0x7F, 0x5E, 0x57, 0xC1, 0x37, 0x73, 0xC7, 0x97, 0xA2 };

        public static string DefaultHash(byte[] plainBytes)
        {
            return SHA512HashToBase64(plainBytes);
        }

        public static string DefaultHash(string plainText)
        {
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
            return SHA512HashToBase64(plainBytes);
        }

        public static string SHA512HashToBase64(byte[] plainBytes, byte[] secretKey = null)
        {
            byte[] garbage = null;
            CheckData(ref secretKey, ref garbage);
            using (var hashing = new HMACSHA512(secretKey))
            {
                byte[] hashBytes = hashing.ComputeHash(plainBytes);
                return Base64Encode(hashBytes);
            }
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Encode(byte[] plainText)
        {
            return Convert.ToBase64String(plainText);
        }

        public static string Base64EncodeUrlSafe(byte[] bytes)
        {
            string plainBase64 = Convert.ToBase64String(bytes);
            return plainBase64.Replace('+', '-').Replace('/', '_').TrimEnd(new[] { '=' });
        }

        public static byte[] Base64DecodeUrlSafe(string base64String)
        {
            string firstPass = base64String.Replace('_', '/').Replace('-', '+');
            switch (firstPass.Length % 4)
            {
                case 2:
                    firstPass += "==";
                    break;
                case 3:
                    firstPass += "=";
                    break;
            }

            return Convert.FromBase64String(firstPass);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public static byte[] Base64DecodeToBytes(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return base64EncodedBytes;
        }

        public static byte[] EncryptBytesToBytes_Aes(byte[] plainBytes, byte[] secretKey = null, byte[] initializationVector = null)
        {
            // Check arguments. 
            CheckData(ref secretKey, ref initializationVector);
            if (plainBytes == null || plainBytes.Length <= 0)
            {
                throw new ArgumentNullException("plainBytes is empty");
            }

            // Begin Encryption
            byte[] encrypted;
            using (var aesAlg = Aes.Create())
            {
                // Provide data so we can decrypt later
                aesAlg.Key = secretKey;
                aesAlg.IV = initializationVector;
                using (var encryptor = aesAlg.CreateEncryptor())
                using (var memoryStream = new MemoryStream())
                {
                    using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        // Write plain data to CryptoStream which puts the encrypted data on the MemoryStream
                        cryptoStream.Write(plainBytes, 0, plainBytes.Length);
                    }

                    // Need to let CryptoStream close out before pulling from MemoryStream
                    encrypted = memoryStream.ToArray();
                }
            }

            // Return the encrypted bytes from the memory stream. 
            return encrypted;
        }

        private static void CheckData(ref byte[] secretKey, ref byte[] initializationVector)
        {
            if (secretKey == null || secretKey.Length <= 0)
            {
                secretKey = DefaultSecretKey;
            }

            if (initializationVector == null || initializationVector.Length <= 0)
            {
                initializationVector = DefaultInitializationVector;
            }
        }

        public static byte[] EncryptStringToBytes_Aes(string plainText, byte[] secretKey = null, byte[] initializationVector = null)
        {
            // Check arguments. 
            if (plainText == null || plainText.Length <= 0)
            {
                throw new ArgumentNullException("plainText is empty");
            }

            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return EncryptBytesToBytes_Aes(plainTextBytes, secretKey, initializationVector);
        }

        public static string DecryptStringFromBase64(string encryptedText, byte[] secretKey, byte[] initializationVector)
        {
            var bytes = Base64DecodeToBytes(encryptedText);
            return DecryptStringFromBytes_Aes(bytes, secretKey, initializationVector);
        }

        public static byte[] DecryptBytesFromBytes_Aes(byte[] encryptedBytes, byte[] secretKey = null, byte[] initializationVector = null)
        {
            // Check arguments.
            CheckData(ref secretKey, ref initializationVector);
            if (encryptedBytes == null || encryptedBytes.Length <= 0)
            {
                throw new ArgumentNullException("cipherText");
            }

            // Begin Decryption
            byte[] decrypted;
            using (var aesAlg = Aes.Create())
            {
                // Provide data so we can decrypt later
                aesAlg.Key = secretKey;
                aesAlg.IV = initializationVector;
                using (var decryptor = aesAlg.CreateDecryptor())
                using (var memoryStream = new MemoryStream())
                {
                    using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Write))
                    {
                        // Write encrypted data to CryptoStream which puts the decrypted data on the MemoryStream
                        cryptoStream.Write(encryptedBytes, 0, encryptedBytes.Length);
                    }

                    // Need to let CryptoStream close out before pulling from MemoryStream
                    decrypted = memoryStream.ToArray();
                }
            }

            // Return the decrypted bytes from the memory stream. 
            return decrypted;
        }

        public static string DecryptStringFromBytes_Aes(byte[] encryptedText, byte[] secretKey = null, byte[] initializationVector = null)
        {
            var decryptedBytes = DecryptBytesFromBytes_Aes(encryptedText, secretKey, initializationVector);
            return Encoding.UTF8.GetString(decryptedBytes);
        }

        public static int? DecryptUrlSafeTimedToken(string token)
        {
            var encryptedBytes = Base64DecodeUrlSafe(token);
            var decryptedBytes = DecryptBytesFromBytes_Aes(encryptedBytes);
            int id = BitConverter.ToInt32(decryptedBytes, 0);
            long ticks = BitConverter.ToInt64(decryptedBytes, sizeof(int));
            bool expired = DateTime.UtcNow.Ticks > ticks;
            if (expired)
            {
                return null;
            }

            return id;
        }

        public static string EncryptUrlSafeTimedToken(int id, TimeSpan timeToLive)
        {
            var idBytes = BitConverter.GetBytes(id);
            var expirationBytes = BitConverter.GetBytes(DateTime.UtcNow.Add(timeToLive).Ticks);
            var encryptedBytes = EncryptBytesToBytes_Aes(idBytes.Concat(expirationBytes).ToArray());
            var token = Base64EncodeUrlSafe(encryptedBytes);
            return token;
        }

        public static bool DecryptUrlSafeTimedToken(string token, out int id1, out int id2, out DateTime expirationDateUtc)
        {
            var encryptedBytes = Base64DecodeUrlSafe(token);
            var decryptedBytes = DecryptBytesFromBytes_Aes(encryptedBytes);
            id1 = BitConverter.ToInt32(decryptedBytes, 0);
            id2 = BitConverter.ToInt32(decryptedBytes, sizeof(int));
            long ticks = BitConverter.ToInt64(decryptedBytes, sizeof(int) + sizeof(int));
            expirationDateUtc = new DateTime(ticks);
            bool expired = DateTime.UtcNow.Ticks > ticks;
            return expired;
        }

        public static string EncryptUrlSafeTimedToken(int id1, int id2, TimeSpan timeToLive)
        {
            var id1Bytes = BitConverter.GetBytes(id1);
            var id2Bytes = BitConverter.GetBytes(id2);
            var expirationBytes = BitConverter.GetBytes(DateTime.UtcNow.Add(timeToLive).Ticks);
            var encryptedBytes = EncryptBytesToBytes_Aes(id1Bytes.Concat(id2Bytes).Concat(expirationBytes).ToArray());
            var token = Base64EncodeUrlSafe(encryptedBytes);
            return token;
        }

        public static string Encrypt(string plainText)
        {
            if (string.IsNullOrWhiteSpace(plainText))
            {
                throw new ArgumentException("String must have a value", nameof(plainText));
            }

            return Convert.ToBase64String(EncryptStringToBytes_Aes(plainText));
        }

        public static string Decrypt(string cipherText)
        {
            if (string.IsNullOrWhiteSpace(cipherText))
            {
                throw new ArgumentException("String must have a value", nameof(cipherText));
            }

            return DecryptStringFromBytes_Aes(Base64DecodeToBytes(cipherText));
        }
    }
}
