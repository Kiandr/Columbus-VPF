/* Copyright (c) 1994-2014 Sage Software, Inc.  All rights reserved. */
#region Library

using Microsoft.Practices.Unity;
using Sage.CA.SBS.ERP.Sage300.Common.Interfaces.Bootstrap;
using Sage.CA.SBS.ERP.Sage300.Common.Utilities;
using Sage.CA.SBS.ERP.Sage300.VPF.BusinessRepository;
using Sage.CA.SBS.ERP.Sage300.VPF.Interfaces.BussinessRepository;
using Sage.CA.SBS.ERP.Sage300.VPF.Interfaces.Services;
using Sage.CA.SBS.ERP.Sage300.VPF.Models;
using System.ComponentModel.Composition;

#endregion
namespace Sage.CA.SBS.ERP.Sage300.VPF.Services
{
    /// <summary>
    /// Account Payable Bootstrapper Class
    /// </summary>
    [Export(typeof(IBootstrapperTask))]
    [BootstrapMetadataExport(BootstrapModule.VPF,
        new[] { BootstrapAppliesTo.Web, BootstrapAppliesTo.Worker, BootstrapAppliesTo.WebApi }, 10)]
    public class VPFBootstrapper : IBootstrapperTask
    {
        /// <summary>
        /// Bootstrap activity execution
        /// </summary>
        /// <param name="container">The Unity container</param>
        public void Execute(IUnityContainer container)
        {
            // Clustering the Service and Business Repository into distinguishable classes.
            RegisterService(container);
            // As mentioned, this class will contain only the registeration routine for business repository 
            RegisterRepositories(container);
        }

        /// <summary>
        /// Registeration of Services
        /// </summary>
        /// <param name="container"> Unity Container</param>
        private void RegisterService(IUnityContainer container)
        {
            #region VPF Services Repository
            // Flow Entity Service is being used to register Flow Entity Service, this service has been resolved in the VPF/Flow/Index controller (Flowcontroller.cs)
            UnityUtil.RegisterType<IFlowEntityService<Flow>, FlowEntityService<Flow>>(container);
            #endregion

        }
        /// <summary>
        /// Clustering the Flow Entity in this class. The following services are being implemented in the business repository and being resolved in the service layer (FlowEntityService.cs)
        /// </summary>
        /// <param name="container">Unity Container</param>
        private void RegisterRepositories(IUnityContainer container)
        {

            #region VPF Services Repository
            // Registeration of the Flow Entity, which is being used for providing business logic to the service layer. 
            UnityUtil.RegisterType<IFlowEntiy<Flow>, FlowRepository<Flow>>(container);
            #endregion

        }

    }
}
