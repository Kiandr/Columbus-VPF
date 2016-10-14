/* Copyright (c) 1994-2014 Sage Software, Inc.  All rights reserved. */

using Sage.CA.SBS.ERP.Sage300.VPF.Web;
using System.Web.Mvc;
using System.Web.Optimization;

namespace Sage.CA.SBS.ERP.Sage300.Web.Areas.VPF
{

    /// <summary>
    /// Area Registeration Visual Process Flow
    /// </summary>
    public class VPFAreaRegistration : AreaRegistration
    {
        /// <summary>
        /// Area identifier for visual process flow. 
        /// </summary>
        public override string AreaName
        {
            get
            {
                return "VPF";
            }
        }

        /// <summary>
        /// Registeratioin of Route config
        /// </summary>
        /// <param name="context">the Context</param>
        public override void RegisterArea(AreaRegistrationContext context)
        {

            RegisterRoutes(context);
            RegisterBundles();

        }
        /// <summary>
        /// URL cunstroction for visual process flow. {tenant}/VPF/{Controller}/{action}/{id}
        /// </summary>
        /// <param name="context">Context object</param>
        private void RegisterRoutes(AreaRegistrationContext context)
        {
            context.MapRoute("Core_VPF", "{tenantAlias}/VPF/{controller}/{action}/{id}",
                new { area = "VPF", controller = "Flow", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "Sage.CA.SBS.ERP.Sage300.VPF.Web.Controllers" });

        }

        /// <summary>
        /// Register bundles
        /// </summary>
        private void RegisterBundles()
        {
            VPFBundleRegisteration.RegisterBundles(BundleTable.Bundles);
        }

    }


}