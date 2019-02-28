// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="EntityFactory.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud
{
    using Mbed.Cloud.Common;
    using Mbed.Cloud.Foundation;

    /// <summary>
    /// Entity Factory
    /// </summary>
    public partial class EntityFactory
    {
        public AccountRepository AccountRepository()
        {
            return new AccountRepository(config, client);
        }

        public ApiKeyRepository ApiKeyRepository()
        {
            return new ApiKeyRepository(config, client);
        }

        public CertificateEnrollmentRepository CertificateEnrollmentRepository()
        {
            return new CertificateEnrollmentRepository(config, client);
        }

        public CertificateIssuerRepository CertificateIssuerRepository()
        {
            return new CertificateIssuerRepository(config, client);
        }

        public CertificateIssuerConfigRepository CertificateIssuerConfigRepository()
        {
            return new CertificateIssuerConfigRepository(config, client);
        }

        public DeveloperCertificateRepository DeveloperCertificateRepository()
        {
            return new DeveloperCertificateRepository(config, client);
        }

        public DeviceRepository DeviceRepository()
        {
            return new DeviceRepository(config, client);
        }

        public DeviceEnrollmentRepository DeviceEnrollmentRepository()
        {
            return new DeviceEnrollmentRepository(config, client);
        }

        public DeviceEnrollmentBulkCreateRepository DeviceEnrollmentBulkCreateRepository()
        {
            return new DeviceEnrollmentBulkCreateRepository(config, client);
        }

        public DeviceEnrollmentBulkDeleteRepository DeviceEnrollmentBulkDeleteRepository()
        {
            return new DeviceEnrollmentBulkDeleteRepository(config, client);
        }

        public DeviceEventsRepository DeviceEventsRepository()
        {
            return new DeviceEventsRepository(config, client);
        }

        public ServerCredentialsRepository ServerCredentialsRepository()
        {
            return new ServerCredentialsRepository(config, client);
        }

        public SubtenantTrustedCertificateRepository SubtenantTrustedCertificateRepository()
        {
            return new SubtenantTrustedCertificateRepository(config, client);
        }

        public SubtenantUserRepository SubtenantUserRepository()
        {
            return new SubtenantUserRepository(config, client);
        }

        public SubtenantUserInvitationRepository SubtenantUserInvitationRepository()
        {
            return new SubtenantUserInvitationRepository(config, client);
        }

        public TrustedCertificateRepository TrustedCertificateRepository()
        {
            return new TrustedCertificateRepository(config, client);
        }

        public UserRepository UserRepository()
        {
            return new UserRepository(config, client);
        }

        public UserInvitationRepository UserInvitationRepository()
        {
            return new UserInvitationRepository(config, client);
        }
    }
}