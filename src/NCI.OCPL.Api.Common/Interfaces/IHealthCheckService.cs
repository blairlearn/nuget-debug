﻿using System.Threading.Tasks;

namespace NCI.OCPL.Api.Common
{
    /// <summary>
    /// Defines an interface for verifying that a service is in
    /// a 'healthy' condition and able to fulfill requests.
    /// </summary>
    public interface IHealthCheckService
    {
        /// <summary>
        /// True if a service is able to fulfill requests.
        /// </summary>
        Task<bool> IndexIsHealthy();
    }
}
