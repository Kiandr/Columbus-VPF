/* Copyright (c) 1994-2014 Sage Software, Inc.  All rights reserved.*/

#region namespaces
using Sage.CA.SBS.ERP.Sage300.Common.Interfaces.Service;
using Sage.CA.SBS.ERP.Sage300.VPF.Models;
#endregion

namespace Sage.CA.SBS.ERP.Sage300.VPF.Interfaces.Services
{
    /// <summary>
    /// Interface Flow Service, are used to be consumed by Visual Process Flow requests
    /// </summary>
    /// <typeparam name="T">Model Flow</typeparam>
    public interface IFlowEntityService<T> : IEntityService<T>, ISecurityService where T : Flow, new()
    {

        /// <summary>
        /// Get Method, Sends a Flow Model and path to the visual process flow xml container
        /// Responsible to performing "Read Inquiry" base on model.Id on the XML file, and returning the same model
        /// with a member Data filled with the associated Visual Process Flow SVG Item.
        /// </summary>
        /// <param name="id">model identifier representing Flow Model menu id</param>
        /// <param name="filePath"> string path to xml location on web project</param>
        /// <returns>Flow Model containing the SVG Data Associated to the Object Id</returns>
        T Get(int id, string filePath);

    }

}
