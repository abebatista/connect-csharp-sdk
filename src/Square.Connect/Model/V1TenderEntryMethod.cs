/* 
 * Square Connect API
 *
 * Client library for accessing the Square Connect APIs
 *
 * OpenAPI spec version: 2.0
 * Contact: developers@squareup.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Square.Connect.Model
{
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum V1TenderEntryMethod
    {
        
        /// <summary>
        /// Enum MANUAL for "MANUAL"
        /// </summary>
        [EnumMember(Value = "MANUAL")]
        MANUAL,
        
        /// <summary>
        /// Enum SCANNED for "SCANNED"
        /// </summary>
        [EnumMember(Value = "SCANNED")]
        SCANNED,
        
        /// <summary>
        /// Enum SQUARECASH for "SQUARE_CASH"
        /// </summary>
        [EnumMember(Value = "SQUARE_CASH")]
        SQUARECASH,
        
        /// <summary>
        /// Enum SQUAREWALLET for "SQUARE_WALLET"
        /// </summary>
        [EnumMember(Value = "SQUARE_WALLET")]
        SQUAREWALLET,
        
        /// <summary>
        /// Enum SWIPED for "SWIPED"
        /// </summary>
        [EnumMember(Value = "SWIPED")]
        SWIPED,
        
        /// <summary>
        /// Enum WEBFORM for "WEB_FORM"
        /// </summary>
        [EnumMember(Value = "WEB_FORM")]
        WEBFORM,
        
        /// <summary>
        /// Enum OTHER for "OTHER"
        /// </summary>
        [EnumMember(Value = "OTHER")]
        OTHER
    }

}
