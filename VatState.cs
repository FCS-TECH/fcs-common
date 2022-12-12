// ***********************************************************************
// Assembly         : FCS.Lib.Virk
// Author           : FH
// Created          : 01-01-2022
//
// Last Modified By : FH
// Last Modified On : 02-24-2022
// ***********************************************************************
// <copyright file="CvrState.cs" company="FCS">
//    Copyright (C) 2022 FCS Frede's Computer Services.
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the Affero GNU General Public License as
//    published by the Free Software Foundation, either version 3 of the
//    License, or (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    Affero GNU General Public License for more details.
//
//    You should have received a copy of the Affero GNU General Public License
//    along with this program.  If not, see [https://www.gnu.org/licenses/agpl-3.0.en.html]
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace FCS.Lib.Common
{
    /// <summary>
    /// Class VatState
    /// </summary>
    public class VatState
    {
        /// <summary>
        /// Last update of vatState
        /// </summary>
        public string LastUpdate { get; set; } = "";
        /// <summary>
        /// The state
        /// </summary>
        public string State { get; set; } = "";
        /// <summary>
        /// Time frame
        /// </summary>
        /// <see cref="TimeFrame"/>
        public TimeFrame TimeFrame { get; set; } = new();
    }
}