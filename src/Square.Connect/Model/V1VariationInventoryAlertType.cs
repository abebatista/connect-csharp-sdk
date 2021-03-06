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
    public enum V1VariationInventoryAlertType
    {
        
        /// <summary>
        /// Enum LOWQUANTITY for "LOW_QUANTITY"
        /// </summary>
        [EnumMember(Value = "LOW_QUANTITY")]
        LOWQUANTITY,
        
        /// <summary>
        /// Enum NONE for "NONE"
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE,
        
        /// <summary>
        /// Enum INVESTMENT for "INVESTMENT"
        /// </summary>
        [EnumMember(Value = "INVESTMENT")]
        INVESTMENT,
        
        /// <summary>
        /// Enum LOAN for "LOAN"
        /// </summary>
        [EnumMember(Value = "LOAN")]
        LOAN,
        
        /// <summary>
        /// Enum SAVINGS for "SAVINGS"
        /// </summary>
        [EnumMember(Value = "SAVINGS")]
        SAVINGS,
        
        /// <summary>
        /// Enum OTHER for "OTHER"
        /// </summary>
        [EnumMember(Value = "OTHER")]
        OTHER
    }

}
