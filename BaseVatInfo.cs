namespace FCS.Lib.Common
{
    public class BaseVatInfo
    {
        public string Name { get; set; }
        public string CoName { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string VatNumber { get; set; }
        public int VatNumberValid { get; set; }
        public int HasFolded  { get; set; }
        public string RequestDate { get; set; }
    }
}