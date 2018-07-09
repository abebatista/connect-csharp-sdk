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
    /// Represents a query (filtering and sorting criteria) used to search for customer profiles.
    /// </summary>
    [DataContract]
    public partial class CustomerQuery :  IEquatable<CustomerQuery>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerQuery" /> class.
        /// </summary>
        /// <param name="Filter">A list of filter criteria..</param>
        /// <param name="Sort">Sort criteria for query results. The default sort behavior is to order customers alphabetically by &#x60;given_name&#x60; and &#x60;last_name&#x60;..</param>
        public CustomerQuery(CustomerFilter Filter = default(CustomerFilter), CustomerSort Sort = default(CustomerSort))
        {
            this.Filter = Filter;
            this.Sort = Sort;
        }
        
        /// <summary>
        /// A list of filter criteria.
        /// </summary>
        /// <value>A list of filter criteria.</value>
        [DataMember(Name="filter", EmitDefaultValue=false)]
        public CustomerFilter Filter { get; set; }
        /// <summary>
        /// Sort criteria for query results. The default sort behavior is to order customers alphabetically by &#x60;given_name&#x60; and &#x60;last_name&#x60;.
        /// </summary>
        /// <value>Sort criteria for query results. The default sort behavior is to order customers alphabetically by &#x60;given_name&#x60; and &#x60;last_name&#x60;.</value>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public CustomerSort Sort { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerQuery {\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as CustomerQuery);
        }

        /// <summary>
        /// Returns true if CustomerQuery instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomerQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerQuery other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Filter == other.Filter ||
                    this.Filter != null &&
                    this.Filter.Equals(other.Filter)
                ) && 
                (
                    this.Sort == other.Sort ||
                    this.Sort != null &&
                    this.Sort.Equals(other.Sort)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Filter != null)
                    hash = hash * 59 + this.Filter.GetHashCode();
                if (this.Sort != null)
                    hash = hash * 59 + this.Sort.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}