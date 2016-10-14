/* Copyright (c) 1994-2014 Sage Software, Inc.  All rights reserved. */
#region libraries
using System.Web.Optimization;
#endregion

namespace Sage.CA.SBS.ERP.Sage300.VPF.Web
{
    /// <summary>
    /// Bndle Registeratin
    /// </summary>
    public class VPFBundleRegisteration
    {
        /// <summary>
        /// Bundle Registeration
        /// </summary>
        /// <param name="bundles"> Bundles to Javascript libraries</param>
        internal static void RegisterBundles(BundleCollection bundles)
        {

            //Bundle registeration for visual process flow. Primarly used to bundle javascript codes into the views
            #region Sage.CA.SBS.ERP.Sage300.VPF
            /*  bundles.Add(new ScriptBundle("~/bundles/Flow").Include(
                "~/Areas/VPF/Scripts/Flow/Sage.CA.SBS.ERP.Sage300.VPF.FlowRepository.js",
                "~/Areas/VPF/Scripts/Flow/Sage.CA.SBS.ERP.Sage300.VPF.FlowBehaviour.js"
               
           ));*/
            #endregion


            // css holder for visual process flow 
            #region CSS VPF
            //     bundles.Add(new StyleBundle("~/Style/Flow").Include(
            //     "~/Areas/VPF/Scripts/svg-edit/Style/VPF.css"));
            #endregion

        }


    }
}