/* Copyright (c) 1994-2014 Sage Software, Inc.  All rights reserved. */

#region Namespace
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Xml.Linq;
using Sage.CA.SBS.ERP.Sage300.Common.BusinessRepository.Base;
using Sage.CA.SBS.ERP.Sage300.Common.Interfaces.Entity;
using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Sage.CA.SBS.ERP.Sage300.VPF.Interfaces.BussinessRepository;
using Sage.CA.SBS.ERP.Sage300.VPF.Models;
using Sage.CA.SBS.ERP.Sage300.VPF.BusinessRepository.Mappers;
# endregion


namespace Sage.CA.SBS.ERP.Sage300.VPF.BusinessRepository
{
    /// <summary>
    /// Business Repository containing the logic of visual process flow
    /// </summary>
    /// <typeparam name="T">Flow Object</typeparam>
    public class FlowRepository<T> : FlatRepository<T>, IFlowEntiy<T> where T : Flow, new()
    {


        #region Constructors
        /// <summary>
        /// Terms Repository Constructor
        /// </summary>
        /// <param name="context">context</param>
        public FlowRepository(Context context)
            : base(context, new FlowMapper<T>(context), null)
        {

        }
        #endregion

        /// <summary>
        /// Method to open the xml container of visual process flow and read and extract 
        /// associated visual process fow to the model.Id which is considered and object identifier
        /// </summary>
        /// <param name="id">Flow</param>
        /// <param name="filePath">Path to xml file on the server</param>
        /// <returns>Model with embedded data at Flow.Data</returns>
        public virtual T Get(int id, string filePath)
        {
            var flow = new T();
            var xmlDoc = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + filePath);
            XNamespace svg = "http://www.w3.org/2000/svg";
            var element = from item in xmlDoc.Root.Descendants("item")
                          where (string)item.Element("Id") == id.ToString()
                          select new { data = item.Element("div").Element(svg + "svg") };
            foreach (var t in element)
            {

                var temp = t.data;
                temp.Attributes(XNamespace.Xmlns + "svg").Remove();
                flow.Elements = temp.ToString();
            }
            return flow;
        }

        /// <summary>
        /// Implementation of the Interface, reserved for future use.
        /// </summary>
        /// <returns>Bussiness Entity</returns>
        protected override IBusinessEntity CreateBusinessEntities()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Implementation of Get Update Expression, reserved for future use
        /// </summary>
        /// <param name="model">Flow</param>
        /// <returns>Expression Object, reserved for future use</returns>
        protected override Expression<Func<T, bool>> GetUpdateExpression(T model)
        {
            throw new NotImplementedException();
        }
    }
}

