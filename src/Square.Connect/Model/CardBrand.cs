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
    /// Indicates a card's brand, such as `VISA` or `MASTERCARD`.
    /// </summary>
    /// <value>Indicates a card's brand, such as `VISA` or `MASTERCARD`.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CardBrand
    {
        
        /// <summary>
        /// Enum OTHERBRAND for "OTHER_BRAND"
        /// </summary>
        [EnumMember(Value = "OTHER_BRAND")]
        OTHERBRAND,
        
        /// <summary>
        /// Enum VISA for "VISA"
        /// </summary>
        [EnumMember(Value = "VISA")]
        VISA,
        
        /// <summary>
        /// Enum MASTERCARD for "MASTERCARD"
        /// </summary>
        [EnumMember(Value = "MASTERCARD")]
        MASTERCARD,
        
        /// <summary>
        /// Enum AMERICANEXPRESS for "AMERICAN_EXPRESS"
        /// </summary>
        [EnumMember(Value = "AMERICAN_EXPRESS")]
        AMERICANEXPRESS,
        
        /// <summary>
        /// Enum DISCOVER for "DISCOVER"
        /// </summary>
        [EnumMember(Value = "DISCOVER")]
        DISCOVER,
        
        /// <summary>
        /// Enum DISCOVERDINERS for "DISCOVER_DINERS"
        /// </summary>
        [EnumMember(Value = "DISCOVER_DINERS")]
        DISCOVERDINERS,
        
        /// <summary>
        /// Enum JCB for "JCB"
        /// </summary>
        [EnumMember(Value = "JCB")]
        JCB,
        
        /// <summary>
        /// Enum CHINAUNIONPAY for "CHINA_UNIONPAY"
        /// </summary>
        [EnumMember(Value = "CHINA_UNIONPAY")]
        CHINAUNIONPAY,
        
        /// <summary>
        /// Enum SQUAREGIFTCARD for "SQUARE_GIFT_CARD"
        /// </summary>
        [EnumMember(Value = "SQUARE_GIFT_CARD")]
        SQUAREGIFTCARD
    }

}
