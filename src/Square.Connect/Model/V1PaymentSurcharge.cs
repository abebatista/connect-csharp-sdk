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
    /// V1PaymentSurcharge
    /// </summary>
    [DataContract]
    public partial class V1PaymentSurcharge :  IEquatable<V1PaymentSurcharge>, IValidatableObject
    {
        /// <summary>
        /// Indicates the source of the surcharge. For example, if it was applied as an automatic gratuity for a large group.
        /// </summary>
        /// <value>Indicates the source of the surcharge. For example, if it was applied as an automatic gratuity for a large group.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum UNKNOWN for "UNKNOWN"
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN,
            
            /// <summary>
            /// Enum AUTOGRATUITY for "AUTO_GRATUITY"
            /// </summary>
            [EnumMember(Value = "AUTO_GRATUITY")]
            AUTOGRATUITY,
            
            /// <summary>
            /// Enum CUSTOM for "CUSTOM"
            /// </summary>
            [EnumMember(Value = "CUSTOM")]
            CUSTOM
        }

        /// <summary>
        /// Indicates the source of the surcharge. For example, if it was applied as an automatic gratuity for a large group.
        /// </summary>
        /// <value>Indicates the source of the surcharge. For example, if it was applied as an automatic gratuity for a large group.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PaymentSurcharge" /> class.
        /// </summary>
        /// <param name="Name">The name of the surcharge..</param>
        /// <param name="AppliedMoney">The amount of money applied to the order as a result of the surcharge..</param>
        /// <param name="Rate">The amount of the surcharge as a percentage. The percentage is provided as a string representing the decimal equivalent of the percentage. For example, \&quot;0.7\&quot; corresponds to a 7% surcharge. Exactly one of rate or amount_money should be set..</param>
        /// <param name="AmountMoney">The amount of the surcharge as a Money object. Exactly one of rate or amount_money should be set..</param>
        /// <param name="Type">Indicates the source of the surcharge. For example, if it was applied as an automatic gratuity for a large group..</param>
        /// <param name="Taxable">Indicates whether the surcharge is taxable..</param>
        /// <param name="Taxes">The list of taxes that should be applied to the surcharge..</param>
        /// <param name="SurchargeId">SurchargeId.</param>
        public V1PaymentSurcharge(string Name = default(string), V1Money AppliedMoney = default(V1Money), string Rate = default(string), V1Money AmountMoney = default(V1Money), TypeEnum? Type = default(TypeEnum?), bool? Taxable = default(bool?), List<V1PaymentTax> Taxes = default(List<V1PaymentTax>), string SurchargeId = default(string))
        {
            this.Name = Name;
            this.AppliedMoney = AppliedMoney;
            this.Rate = Rate;
            this.AmountMoney = AmountMoney;
            this.Type = Type;
            this.Taxable = Taxable;
            this.Taxes = Taxes;
            this.SurchargeId = SurchargeId;
        }
        
        /// <summary>
        /// The name of the surcharge.
        /// </summary>
        /// <value>The name of the surcharge.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The amount of money applied to the order as a result of the surcharge.
        /// </summary>
        /// <value>The amount of money applied to the order as a result of the surcharge.</value>
        [DataMember(Name="applied_money", EmitDefaultValue=false)]
        public V1Money AppliedMoney { get; set; }
        /// <summary>
        /// The amount of the surcharge as a percentage. The percentage is provided as a string representing the decimal equivalent of the percentage. For example, \&quot;0.7\&quot; corresponds to a 7% surcharge. Exactly one of rate or amount_money should be set.
        /// </summary>
        /// <value>The amount of the surcharge as a percentage. The percentage is provided as a string representing the decimal equivalent of the percentage. For example, \&quot;0.7\&quot; corresponds to a 7% surcharge. Exactly one of rate or amount_money should be set.</value>
        [DataMember(Name="rate", EmitDefaultValue=false)]
        public string Rate { get; set; }
        /// <summary>
        /// The amount of the surcharge as a Money object. Exactly one of rate or amount_money should be set.
        /// </summary>
        /// <value>The amount of the surcharge as a Money object. Exactly one of rate or amount_money should be set.</value>
        [DataMember(Name="amount_money", EmitDefaultValue=false)]
        public V1Money AmountMoney { get; set; }
        /// <summary>
        /// Indicates whether the surcharge is taxable.
        /// </summary>
        /// <value>Indicates whether the surcharge is taxable.</value>
        [DataMember(Name="taxable", EmitDefaultValue=false)]
        public bool? Taxable { get; set; }
        /// <summary>
        /// The list of taxes that should be applied to the surcharge.
        /// </summary>
        /// <value>The list of taxes that should be applied to the surcharge.</value>
        [DataMember(Name="taxes", EmitDefaultValue=false)]
        public List<V1PaymentTax> Taxes { get; set; }
        /// <summary>
        /// Gets or Sets SurchargeId
        /// </summary>
        [DataMember(Name="surcharge_id", EmitDefaultValue=false)]
        public string SurchargeId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1PaymentSurcharge {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AppliedMoney: ").Append(AppliedMoney).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  AmountMoney: ").Append(AmountMoney).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Taxable: ").Append(Taxable).Append("\n");
            sb.Append("  Taxes: ").Append(Taxes).Append("\n");
            sb.Append("  SurchargeId: ").Append(SurchargeId).Append("\n");
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
            return this.Equals(obj as V1PaymentSurcharge);
        }

        /// <summary>
        /// Returns true if V1PaymentSurcharge instances are equal
        /// </summary>
        /// <param name="other">Instance of V1PaymentSurcharge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1PaymentSurcharge other)
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
                    this.AppliedMoney == other.AppliedMoney ||
                    this.AppliedMoney != null &&
                    this.AppliedMoney.Equals(other.AppliedMoney)
                ) && 
                (
                    this.Rate == other.Rate ||
                    this.Rate != null &&
                    this.Rate.Equals(other.Rate)
                ) && 
                (
                    this.AmountMoney == other.AmountMoney ||
                    this.AmountMoney != null &&
                    this.AmountMoney.Equals(other.AmountMoney)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Taxable == other.Taxable ||
                    this.Taxable != null &&
                    this.Taxable.Equals(other.Taxable)
                ) && 
                (
                    this.Taxes == other.Taxes ||
                    this.Taxes != null &&
                    this.Taxes.SequenceEqual(other.Taxes)
                ) && 
                (
                    this.SurchargeId == other.SurchargeId ||
                    this.SurchargeId != null &&
                    this.SurchargeId.Equals(other.SurchargeId)
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
                if (this.AppliedMoney != null)
                    hash = hash * 59 + this.AppliedMoney.GetHashCode();
                if (this.Rate != null)
                    hash = hash * 59 + this.Rate.GetHashCode();
                if (this.AmountMoney != null)
                    hash = hash * 59 + this.AmountMoney.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Taxable != null)
                    hash = hash * 59 + this.Taxable.GetHashCode();
                if (this.Taxes != null)
                    hash = hash * 59 + this.Taxes.GetHashCode();
                if (this.SurchargeId != null)
                    hash = hash * 59 + this.SurchargeId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}