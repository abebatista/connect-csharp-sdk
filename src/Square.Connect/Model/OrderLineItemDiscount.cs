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
    /// Represents a discount that applies to one or more line items in an order.  Fixed-amount, order-level discounts are distributed across all non-zero line item totals. The amount distributed to each line item is relative to that item’s contribution to the order subtotal.
    /// </summary>
    [DataContract]
    public partial class OrderLineItemDiscount :  IEquatable<OrderLineItemDiscount>, IValidatableObject
    {
        /// <summary>
        /// The type of the discount. If it is created by API, it would be either `FIXED_PERCENTAGE` or `FIXED_AMOUNT`.  VARIABLE_* is not supported in API because the order is created at the time of sale and either percentage or amount has to be specified.  See [OrderLineItemDiscountType](#type-orderlineitemdiscounttype) for possible values.
        /// </summary>
        /// <value>The type of the discount. If it is created by API, it would be either `FIXED_PERCENTAGE` or `FIXED_AMOUNT`.  VARIABLE_* is not supported in API because the order is created at the time of sale and either percentage or amount has to be specified.  See [OrderLineItemDiscountType](#type-orderlineitemdiscounttype) for possible values.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum UNKNOWNDISCOUNT for "UNKNOWN_DISCOUNT"
            /// </summary>
            [EnumMember(Value = "UNKNOWN_DISCOUNT")]
            UNKNOWNDISCOUNT,
            
            /// <summary>
            /// Enum FIXEDPERCENTAGE for "FIXED_PERCENTAGE"
            /// </summary>
            [EnumMember(Value = "FIXED_PERCENTAGE")]
            FIXEDPERCENTAGE,
            
            /// <summary>
            /// Enum FIXEDAMOUNT for "FIXED_AMOUNT"
            /// </summary>
            [EnumMember(Value = "FIXED_AMOUNT")]
            FIXEDAMOUNT,
            
            /// <summary>
            /// Enum VARIABLEPERCENTAGE for "VARIABLE_PERCENTAGE"
            /// </summary>
            [EnumMember(Value = "VARIABLE_PERCENTAGE")]
            VARIABLEPERCENTAGE,
            
            /// <summary>
            /// Enum VARIABLEAMOUNT for "VARIABLE_AMOUNT"
            /// </summary>
            [EnumMember(Value = "VARIABLE_AMOUNT")]
            VARIABLEAMOUNT
        }

        /// <summary>
        /// Indicates the level at which the discount applies. This field is set by the server. If set in a CreateOrder request, it will be ignored on write. See [OrderLineItemDiscountScope](#type-orderlineitemdiscountscope) for possible values.
        /// </summary>
        /// <value>Indicates the level at which the discount applies. This field is set by the server. If set in a CreateOrder request, it will be ignored on write. See [OrderLineItemDiscountScope](#type-orderlineitemdiscountscope) for possible values.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ScopeEnum
        {
            
            /// <summary>
            /// Enum OTHERDISCOUNTSCOPE for "OTHER_DISCOUNT_SCOPE"
            /// </summary>
            [EnumMember(Value = "OTHER_DISCOUNT_SCOPE")]
            OTHERDISCOUNTSCOPE,
            
            /// <summary>
            /// Enum LINEITEM for "LINE_ITEM"
            /// </summary>
            [EnumMember(Value = "LINE_ITEM")]
            LINEITEM,
            
            /// <summary>
            /// Enum ORDER for "ORDER"
            /// </summary>
            [EnumMember(Value = "ORDER")]
            ORDER
        }

        /// <summary>
        /// The type of the discount. If it is created by API, it would be either `FIXED_PERCENTAGE` or `FIXED_AMOUNT`.  VARIABLE_* is not supported in API because the order is created at the time of sale and either percentage or amount has to be specified.  See [OrderLineItemDiscountType](#type-orderlineitemdiscounttype) for possible values.
        /// </summary>
        /// <value>The type of the discount. If it is created by API, it would be either `FIXED_PERCENTAGE` or `FIXED_AMOUNT`.  VARIABLE_* is not supported in API because the order is created at the time of sale and either percentage or amount has to be specified.  See [OrderLineItemDiscountType](#type-orderlineitemdiscounttype) for possible values.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Indicates the level at which the discount applies. This field is set by the server. If set in a CreateOrder request, it will be ignored on write. See [OrderLineItemDiscountScope](#type-orderlineitemdiscountscope) for possible values.
        /// </summary>
        /// <value>Indicates the level at which the discount applies. This field is set by the server. If set in a CreateOrder request, it will be ignored on write. See [OrderLineItemDiscountScope](#type-orderlineitemdiscountscope) for possible values.</value>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public ScopeEnum? Scope { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderLineItemDiscount" /> class.
        /// </summary>
        /// <param name="CatalogObjectId">The catalog object id referencing [CatalogDiscount](#type-catalogdiscount)..</param>
        /// <param name="Name">The discount&#39;s name..</param>
        /// <param name="Type">The type of the discount. If it is created by API, it would be either &#x60;FIXED_PERCENTAGE&#x60; or &#x60;FIXED_AMOUNT&#x60;.  VARIABLE_* is not supported in API because the order is created at the time of sale and either percentage or amount has to be specified.  See [OrderLineItemDiscountType](#type-orderlineitemdiscounttype) for possible values..</param>
        /// <param name="Percentage">The percentage of the tax, as a string representation of a decimal number. A value of &#x60;7.25&#x60; corresponds to a percentage of 7.25%.  The percentage won&#39;t be set for an amount-based discount..</param>
        /// <param name="AmountMoney">The total monetary amount of the applicable discount. If it is at order level, it is the value of the order level discount. If it is at line item level, it is the value of the line item level discount.  The amount_money won&#39;t be set for a percentage-based discount..</param>
        /// <param name="AppliedMoney">The amount of discount actually applied to this line item.  Represents the amount of money applied to a line item as a discount When an amount-based discount is at order-level, this value is different from &#x60;amount_money&#x60; because the discount is distributed across the line items..</param>
        /// <param name="Scope">Indicates the level at which the discount applies. This field is set by the server. If set in a CreateOrder request, it will be ignored on write. See [OrderLineItemDiscountScope](#type-orderlineitemdiscountscope) for possible values..</param>
        public OrderLineItemDiscount(string CatalogObjectId = default(string), string Name = default(string), TypeEnum? Type = default(TypeEnum?), string Percentage = default(string), Money AmountMoney = default(Money), Money AppliedMoney = default(Money), ScopeEnum? Scope = default(ScopeEnum?))
        {
            this.CatalogObjectId = CatalogObjectId;
            this.Name = Name;
            this.Type = Type;
            this.Percentage = Percentage;
            this.AmountMoney = AmountMoney;
            this.AppliedMoney = AppliedMoney;
            this.Scope = Scope;
        }
        
        /// <summary>
        /// The catalog object id referencing [CatalogDiscount](#type-catalogdiscount).
        /// </summary>
        /// <value>The catalog object id referencing [CatalogDiscount](#type-catalogdiscount).</value>
        [DataMember(Name="catalog_object_id", EmitDefaultValue=false)]
        public string CatalogObjectId { get; set; }
        /// <summary>
        /// The discount&#39;s name.
        /// </summary>
        /// <value>The discount&#39;s name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The percentage of the tax, as a string representation of a decimal number. A value of &#x60;7.25&#x60; corresponds to a percentage of 7.25%.  The percentage won&#39;t be set for an amount-based discount.
        /// </summary>
        /// <value>The percentage of the tax, as a string representation of a decimal number. A value of &#x60;7.25&#x60; corresponds to a percentage of 7.25%.  The percentage won&#39;t be set for an amount-based discount.</value>
        [DataMember(Name="percentage", EmitDefaultValue=false)]
        public string Percentage { get; set; }
        /// <summary>
        /// The total monetary amount of the applicable discount. If it is at order level, it is the value of the order level discount. If it is at line item level, it is the value of the line item level discount.  The amount_money won&#39;t be set for a percentage-based discount.
        /// </summary>
        /// <value>The total monetary amount of the applicable discount. If it is at order level, it is the value of the order level discount. If it is at line item level, it is the value of the line item level discount.  The amount_money won&#39;t be set for a percentage-based discount.</value>
        [DataMember(Name="amount_money", EmitDefaultValue=false)]
        public Money AmountMoney { get; set; }
        /// <summary>
        /// The amount of discount actually applied to this line item.  Represents the amount of money applied to a line item as a discount When an amount-based discount is at order-level, this value is different from &#x60;amount_money&#x60; because the discount is distributed across the line items.
        /// </summary>
        /// <value>The amount of discount actually applied to this line item.  Represents the amount of money applied to a line item as a discount When an amount-based discount is at order-level, this value is different from &#x60;amount_money&#x60; because the discount is distributed across the line items.</value>
        [DataMember(Name="applied_money", EmitDefaultValue=false)]
        public Money AppliedMoney { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderLineItemDiscount {\n");
            sb.Append("  CatalogObjectId: ").Append(CatalogObjectId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
            sb.Append("  AmountMoney: ").Append(AmountMoney).Append("\n");
            sb.Append("  AppliedMoney: ").Append(AppliedMoney).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
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
            return this.Equals(obj as OrderLineItemDiscount);
        }

        /// <summary>
        /// Returns true if OrderLineItemDiscount instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderLineItemDiscount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderLineItemDiscount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CatalogObjectId == other.CatalogObjectId ||
                    this.CatalogObjectId != null &&
                    this.CatalogObjectId.Equals(other.CatalogObjectId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Percentage == other.Percentage ||
                    this.Percentage != null &&
                    this.Percentage.Equals(other.Percentage)
                ) && 
                (
                    this.AmountMoney == other.AmountMoney ||
                    this.AmountMoney != null &&
                    this.AmountMoney.Equals(other.AmountMoney)
                ) && 
                (
                    this.AppliedMoney == other.AppliedMoney ||
                    this.AppliedMoney != null &&
                    this.AppliedMoney.Equals(other.AppliedMoney)
                ) && 
                (
                    this.Scope == other.Scope ||
                    this.Scope != null &&
                    this.Scope.Equals(other.Scope)
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
                if (this.CatalogObjectId != null)
                    hash = hash * 59 + this.CatalogObjectId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Percentage != null)
                    hash = hash * 59 + this.Percentage.GetHashCode();
                if (this.AmountMoney != null)
                    hash = hash * 59 + this.AmountMoney.GetHashCode();
                if (this.AppliedMoney != null)
                    hash = hash * 59 + this.AppliedMoney.GetHashCode();
                if (this.Scope != null)
                    hash = hash * 59 + this.Scope.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // CatalogObjectId (string) maxLength
            if(this.CatalogObjectId != null && this.CatalogObjectId.Length > 192)
            {
                yield return new ValidationResult("Invalid value for CatalogObjectId, length must be less than 192.", new [] { "CatalogObjectId" });
            }

            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 255.", new [] { "Name" });
            }

            // Percentage (string) maxLength
            if(this.Percentage != null && this.Percentage.Length > 10)
            {
                yield return new ValidationResult("Invalid value for Percentage, length must be less than 10.", new [] { "Percentage" });
            }

            yield break;
        }
    }

}
