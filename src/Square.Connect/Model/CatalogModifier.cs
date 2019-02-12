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
    /// A modifier in the Catalog object model.
    /// </summary>
    [DataContract]
    public partial class CatalogModifier :  IEquatable<CatalogModifier>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogModifier" /> class.
        /// </summary>
        /// <param name="Name">The modifier&#39;s name. Searchable. This field has max length of 255 Unicode code points..</param>
        /// <param name="PriceMoney">The modifier&#39;s price..</param>
        public CatalogModifier(string Name = default(string), Money PriceMoney = default(Money))
        {
            this.Name = Name;
            this.PriceMoney = PriceMoney;
        }
        
        /// <summary>
        /// The modifier&#39;s name. Searchable. This field has max length of 255 Unicode code points.
        /// </summary>
        /// <value>The modifier&#39;s name. Searchable. This field has max length of 255 Unicode code points.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The modifier&#39;s price.
        /// </summary>
        /// <value>The modifier&#39;s price.</value>
        [DataMember(Name="price_money", EmitDefaultValue=false)]
        public Money PriceMoney { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CatalogModifier {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PriceMoney: ").Append(PriceMoney).Append("\n");
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
            return this.Equals(obj as CatalogModifier);
        }

        /// <summary>
        /// Returns true if CatalogModifier instances are equal
        /// </summary>
        /// <param name="other">Instance of CatalogModifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CatalogModifier other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.PriceMoney == other.PriceMoney ||
                    this.PriceMoney != null &&
                    this.PriceMoney.Equals(other.PriceMoney)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.PriceMoney != null)
                    hash = hash * 59 + this.PriceMoney.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
