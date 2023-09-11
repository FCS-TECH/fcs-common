// ***********************************************************************
// Assembly         : FCS.Lib.Azure
// Author           : FH
// Created          : 05-18-2022
//
// Last Modified By : FH
// Last Modified On : 05-20-2022
// ***********************************************************************
// <copyright file="AzureToken.cs" company="">
//     Copyright ©  2022
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace FCS.Lib.Common
{
    public class AzureToken
    {
        public string TokenType { get; set; } = "";
        public string AccessToken { get; set; } = "";
        public long Expires { get; set; }

        public bool HasExpired(long timestamp)
        {
            return timestamp > Expires;
        }
    }
}