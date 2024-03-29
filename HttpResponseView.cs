// ***********************************************************************
// Assembly         : FCS.Lib.Common
// Filename         : HttpResponseView.cs
// Author           : Frede Hundewadt
// Created          : 2024 03 29 12:37
// 
// Last Modified By : root
// Last Modified On : 2024 03 29 12:37
// ***********************************************************************
// <copyright company="FCS">
//     Copyright (C) 2024-2024 FCS Frede's Computer Service.
//     This program is free software: you can redistribute it and/or modify
//     it under the terms of the GNU Affero General Public License as
//     published by the Free Software Foundation, either version 3 of the
//     License, or (at your option) any later version.
// 
//     This program is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU Affero General Public License for more details.
// 
//     You should have received a copy of the GNU Affero General Public License
//     along with this program.  If not, see [https://www.gnu.org/licenses]
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Net;

namespace FCS.Lib.Common;

/// <summary>
///     Service response view model
/// </summary>
public class HttpResponseView
{
    /// <summary>
    ///     Http request status code
    /// </summary>
    public HttpStatusCode Code { get; set; }

    /// <summary>
    ///     boolean value indicating success
    /// </summary>
    public bool IsSuccessStatusCode { get; set; }

    /// <summary>
    ///     Service response as string
    /// </summary>
    public string Message { get; set; } = "";
}