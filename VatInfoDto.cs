// ***********************************************************************
// Assembly         : FCS.Lib.Common
// Filename         : VatInfoDto.cs
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

using System.Collections.Generic;

namespace FCS.Lib.Common;

/// <summary>
///     Class VatInfoDto
/// </summary>
public class VatInfoDto
{
    /// <summary>
    ///     Entity vat number
    /// </summary>
    public string VatNumber { get; set; } = "";

    /// <summary>
    ///     Entity name
    /// </summary>
    public string Name { get; set; } = "";

    /// <summary>
    ///     Entity co-location name
    /// </summary>
    public string CoName { get; set; } = "";

    /// <summary>
    ///     Entity address
    /// </summary>
    public string Address { get; set; } = "";

    /// <summary>
    ///     Entity City
    /// </summary>
    public string City { get; set; } = "";

    /// <summary>
    ///     Entity postal code
    /// </summary>
    public string ZipCode { get; set; } = "";

    /// <summary>
    ///     List of entity states
    /// </summary>
    public List<VatState> States { get; set; } = new();

    /// <summary>
    ///     List of entity life cycles
    /// </summary>
    public List<LifeCycle> LifeCycles { get; set; } = new();

    /// <summary>
    ///     Registrar request date
    /// </summary>
    public string RequestDate { get; set; }
}