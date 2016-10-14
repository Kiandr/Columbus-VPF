/* Copyright (c) 1994-2014 Sage Software, Inc.  All rights reserved.*/

#region Namespace
using Sage.CA.SBS.ERP.Sage300.Common.Interfaces.Repository;
using Sage.CA.SBS.ERP.Sage300.VPF.Models;
#endregion

namespace Sage.CA.SBS.ERP.Sage300.VPF.Interfaces.BussinessRepository
{
    /// <summary>
    /// Business interface representing the binding process between service and business layer
    /// </summary>
    /// <typeparam name="T"> Flow Model </typeparam>
    public interface IFlowEntiy<T> : IBusinessRepository<T>, ISecurity where T : Flow, new()
    {
        /// <summary>
        /// Interface for retrieving business logic in the visual process flow module. 
        /// Use the id and actual file path to locate the visual process flow associated to the id(identifier) of that object 
        /// from an xml file which consists of all of the visual process flowes.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="filePath">Path string to visual process flow located on the main web project</param>
        /// <returns>returns a model Flow, which contains the Data in svg format located in that model.</returns>
        T Get(int id, string filePath);

    }
}

