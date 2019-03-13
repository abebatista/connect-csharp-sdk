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
    public enum V1PaymentItemizationItemizationType
    {
        
        /// <summary>
        /// Enum ITEM for "ITEM"
        /// </summary>
        [EnumMember(Value = "ITEM")]
        ITEM,
        
        /// <summary>
        /// Enum CUSTOMAMOUNT for "CUSTOM_AMOUNT"
        /// </summary>
        [EnumMember(Value = "CUSTOM_AMOUNT")]
        CUSTOMAMOUNT,
        
        /// <summary>
        /// Enum GIFTCARDACTIVATION for "GIFT_CARD_ACTIVATION"
        /// </summary>
        [EnumMember(Value = "GIFT_CARD_ACTIVATION")]
        GIFTCARDACTIVATION,
        
        /// <summary>
        /// Enum GIFTCARDRELOAD for "GIFT_CARD_RELOAD"
        /// </summary>
        [EnumMember(Value = "GIFT_CARD_RELOAD")]
        GIFTCARDRELOAD,
        
        /// <summary>
        /// Enum GIFTCARDUNKNOWN for "GIFT_CARD_UNKNOWN"
        /// </summary>
        [EnumMember(Value = "GIFT_CARD_UNKNOWN")]
        GIFTCARDUNKNOWN,
        
        /// <summary>
        /// Enum OTHER for "OTHER"
        /// </summary>
        [EnumMember(Value = "OTHER")]
        OTHER
    }

}