using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;
using System.Text;


namespace SoDotCash.Models
{
    /// <summary>
    /// Describes an account at a financual institution, including authentication credentials
    /// </summary>
    [Table("FIUser")]
    public class FinancialInstitutionUser
    {
        /// <summary>
        /// So.Cash unique id for this FI User
        /// </summary>
        [Key]
        public int FiUserId { get; set; }

        /// <summary>
        /// Identifier of the related financial institution.
        /// Do not use this field directly. Use FinancialInstitution relationship link.
        /// </summary>
        public int FiId { get; set; }

        /// <summary>
        /// User provided login for the OFX online update service
        /// </summary>
        [StringLength(50)]
        public string UserId { get; set; }

        /// <summary>
        /// User provided password for the OFX online update service
        /// </summary>
        [StringLength(500)]
        [Column("Password")]
        public string EncryptedPassword { get; set; }

        /// <summary>
        /// Wrapper that encrypts password stored in the database
        /// </summary>
        [NotMapped]
        public string Password
        {
            get
            {
                // Convert from base64 to bytes
                var combined = Convert.FromBase64String(EncryptedPassword);

                // Split into entropy and ciphertext
                var entropy = new byte[20];
                Array.Copy(combined, 0, entropy, 0, 20);
                var ciphertext = new byte[combined.Length - 20];
                Array.Copy(combined, 20, ciphertext, 0, ciphertext.Length);

                // Decrypt with current user credentials
                var plaintext = ProtectedData.Unprotect(ciphertext, entropy, DataProtectionScope.CurrentUser);

                // Convert to a string and return
                return Encoding.UTF8.GetString(plaintext);
            }
            set
            {
                // Data to protect. Convert a string to a byte[] using Encoding.UTF8.GetBytes().
                var plaintext = Encoding.UTF8.GetBytes(value);

                // Generate additional entropy (will be used as the Initialization vector)
                var entropy = new byte[20];
                using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
                    rng.GetBytes(entropy);

                // Encrypt with current user credentials
                var ciphertext = ProtectedData.Protect(plaintext, entropy, DataProtectionScope.CurrentUser);

                // Combine entropy and ciphertext
                var combined = new byte[entropy.Length + ciphertext.Length];
                Buffer.BlockCopy(entropy, 0, combined, 0, entropy.Length);
                Buffer.BlockCopy(ciphertext, 0, combined, entropy.Length, ciphertext.Length);

                // Convert to base64 for storage
                EncryptedPassword = Convert.ToBase64String(combined);
            }
        }

        /// <summary>
        /// Relationship link to the FI this user and credentials apply
        /// </summary>
        [InverseProperty("Users")]
        [ForeignKey("FiId")]
        public virtual FinancialInstitution FinancialInstitution { get; set; }

        /// <summary>
        /// Relationship link to So.Cash accounts that are linked to this FI with these credentials
        /// </summary>
        private ICollection<Account> _accounts;
        public virtual ICollection<Account> Accounts
        {
            get { return _accounts ?? (_accounts = new Collection<Account>()); }
            set { _accounts = value; }
        }
    }

}