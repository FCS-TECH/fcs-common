using System;

namespace FCS.Lib.Common
{
    public class VatStateInfo
    {
        public string Name { get; set; } = "";
        public string VatNumber { get; set; } = "";
        public bool VatNumberValid { get; set; }
        public bool HasFolded  { get; set; }
        public DateTime RequestDate { get; set; }
    }
}