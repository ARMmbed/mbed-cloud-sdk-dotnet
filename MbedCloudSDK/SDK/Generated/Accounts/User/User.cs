namespace MbedCloud.SDK.Entities
{
    using System;
    using System.Collections.Generic;
    using MbedCloud.SDK.Entities;
    using MbedCloud.SDK.Enums;

    /// <summary>
    /// User
    /// </summary>
    public class User
    {
        /// <summary>
        /// account_id
        /// </summary>
        public string AccountId
        {
            get;
            set;
        }

        /// <summary>
        /// address
        /// </summary>
        public string Address
        {
            get;
            set;
        }

        /// <summary>
        /// created_at
        /// </summary>
        public DateTime? CreatedAt
        {
            get;
            set;
        }

        /// <summary>
        /// creation_time
        /// </summary>
        public long? CreationTime
        {
            get;
            set;
        }

        /// <summary>
        /// email
        /// </summary>
        public string Email
        {
            get;
            set;
        }

        /// <summary>
        /// email_verified
        /// </summary>
        public bool? EmailVerified
        {
            get;
            set;
        }

        /// <summary>
        /// full_name
        /// </summary>
        public string FullName
        {
            get;
            set;
        }

        /// <summary>
        /// group_ids
        /// </summary>
        public List<string> GroupIds
        {
            get;
            set;
        }

        /// <summary>
        /// id
        /// </summary>
        public string Id
        {
            get;
            set;
        }

        /// <summary>
        /// last_login_time
        /// </summary>
        public long? LastLoginTime
        {
            get;
            set;
        }

        /// <summary>
        /// login_history
        /// </summary>
        public List<LoginHistory> LoginHistory
        {
            get;
            set;
        }

        /// <summary>
        /// marketing_accepted
        /// </summary>
        public bool? MarketingAccepted
        {
            get;
            set;
        }

        /// <summary>
        /// password
        /// </summary>
        public string Password
        {
            get;
            set;
        }

        /// <summary>
        /// password_changed_time
        /// </summary>
        public long? PasswordChangedTime
        {
            get;
            set;
        }

        /// <summary>
        /// phone_number
        /// </summary>
        public string PhoneNumber
        {
            get;
            set;
        }

        /// <summary>
        /// status
        /// </summary>
        public UserStatusEnum? Status
        {
            get;
            set;
        }

        /// <summary>
        /// terms_accepted
        /// </summary>
        public bool? TermsAccepted
        {
            get;
            set;
        }

        /// <summary>
        /// two_factor_authentication
        /// </summary>
        public bool? TwoFactorAuthentication
        {
            get;
            set;
        }

        /// <summary>
        /// updated_at
        /// </summary>
        public DateTime? UpdatedAt
        {
            get;
            set;
        }

        /// <summary>
        /// username
        /// </summary>
        public string Username
        {
            get;
            set;
        }
    }
}