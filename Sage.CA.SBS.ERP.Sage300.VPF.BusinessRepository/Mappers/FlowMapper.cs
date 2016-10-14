/* Copyright (c) 1994-2014 Sage Software, Inc.  All rights reserved. */

#region Namespace
using System;
using Sage.CA.SBS.ERP.Sage300.Common.BusinessRepository;
using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Sage.CA.SBS.ERP.Sage300.VPF.Models;
#endregion

namespace Sage.CA.SBS.ERP.Sage300.VPF.BusinessRepository.Mappers
{
    /// <summary>
    /// Mapper class used to initialize the FlowEntity class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class FlowMapper<T> : ModelMapper<T> where T : Flow, new()
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context">Context</param>
        public FlowMapper(Context context)
            : base(context)
        {
        }
        /// <summary>
        /// Mapper function reserved for future use
        /// </summary>
        /// <param name="model">Flow model</param>
        /// <param name="entity">Business Entity</param>
        public override void Map(T model, Common.Interfaces.Entity.IBusinessEntity entity)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Mapper Key
        /// </summary>
        /// <param name="model">Flow Model</param>
        /// <param name="entity">Business Entity</param>
        public override void MapKey(T model, Common.Interfaces.Entity.IBusinessEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}


