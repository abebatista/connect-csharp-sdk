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
    public enum V1UpdateModifierListRequestSelectionType
    {
        
        /// <summary>
        /// Enum SINGLE for "SINGLE"
        /// </summary>
        [EnumMember(Value = "SINGLE")]
        SINGLE,
        
        /// <summary>
        /// Enum MULTIPLE for "MULTIPLE"
        /// </summary>
        [EnumMember(Value = "MULTIPLE")]
        MULTIPLE
    }

}
