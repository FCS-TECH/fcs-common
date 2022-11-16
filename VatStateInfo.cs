using System;

namespace FCS.Lib.Common
{
    /// <summary>
    /// Class VatStateInfo
    /// </summary>
    public class VatStateInfo
    {
        /// <summary>
        /// Business entity name
        /// </summary>
        public string Name { get; set; } = "";
        /// <summary>
        /// Business entity vat number
        /// </summary>
        public string VatNumber { get; set; } = "";
        /// <summary>
        /// Flag indicating valid format
        /// </summary>
        public bool VatNumberValid { get; set; }
        /// <summary>
        /// Flag indicating if entity is out of business
        /// </summary>
        public bool HasFolded  { get; set; }
        /// <summary>
        /// Request date
        /// </summary>
        public DateTime RequestDate { get; set; }
    }
}