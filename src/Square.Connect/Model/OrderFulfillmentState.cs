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
    /// The state of the fulfillment.
    /// </summary>
    /// <value>The state of the fulfillment.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderFulfillmentState
    {
        
        /// <summary>
        /// Enum PROPOSED for "PROPOSED"
        /// </summary>
        [EnumMember(Value = "PROPOSED")]
        PROPOSED,
        
        /// <summary>
        /// Enum RESERVED for "RESERVED"
        /// </summary>
        [EnumMember(Value = "RESERVED")]
        RESERVED,
        
        /// <summary>
        /// Enum PREPARED for "PREPARED"
        /// </summary>
        [EnumMember(Value = "PREPARED")]
        PREPARED,
        
        /// <summary>
        /// Enum COMPLETED for "COMPLETED"
        /// </summary>
        [EnumMember(Value = "COMPLETED")]
        COMPLETED,
        
        /// <summary>
        /// Enum CANCELED for "CANCELED"
        /// </summary>
        [EnumMember(Value = "CANCELED")]
        CANCELED,
        
        /// <summary>
        /// Enum FAILED for "FAILED"
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED
    }

}
