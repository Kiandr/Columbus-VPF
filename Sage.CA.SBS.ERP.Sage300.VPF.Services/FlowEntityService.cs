/* Copyright (c) 1994-2014 Sage Software, Inc.  All rights reserved. */

#region Namespace
using Microsoft.Practices.Unity;
using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Sage.CA.SBS.ERP.Sage300.Common.Services.Base;
using Sage.CA.SBS.ERP.Sage300.VPF.Interfaces.BussinessRepository;
using Sage.CA.SBS.ERP.Sage300.VPF.Interfaces.Services;
using Sage.CA.SBS.ERP.Sage300.VPF.Models;
#endregion

namespace Sage.CA.SBS.ERP.Sage300.VPF.Services
{

    /// <summary>
    /// Implementation of IFlow Interface
    /// </summary>
    /// <typeparam name="T">Flow Object</typeparam>
    public class FlowEntityService<T> : FlatService<T, IFlowEntiy<T>>, IFlowEntityService<T> where T : Flow, new()
    {
        #region Constructor
        /// <summary>
        ///  To Request Context
        /// </summary>
        /// <param name="context">Request Context</param>
        public FlowEntityService(Context context)
            : base(context)
        {
        }
        #endregion

        /// <summary>
        /// Method to request for the  particular visual process Flow associated to the model.Id
        /// Return object contains actual data in the model.Data 
        /// </summary>
        /// <param name="id">model identifier, representing the visual process flow menu id</param>
        /// <param name="filePath"> string representing the visual process flow</param>
        /// <returns>Model Flow Containing The SVG Data</returns>
        public T Get(int id, string filePath)
        {

            using (var repository = Context.Container.Resolve<IFlowEntiy<T>>((new ParameterOverride("context", Context))))
            {
                return repository.Get(id, filePath);
            }
        }

    }
}

