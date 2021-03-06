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
    [DataContract]
    public partial class BatchUpsertCatalogObjectsRequest :  IEquatable<BatchUpsertCatalogObjectsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchUpsertCatalogObjectsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BatchUpsertCatalogObjectsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchUpsertCatalogObjectsRequest" /> class.
        /// </summary>
        /// <param name="IdempotencyKey">A value you specify that uniquely identifies this request among all your requests. A common way to create a valid idempotency key is to use a Universally unique identifier (UUID).  If you&#39;re unsure whether a particular request was successful, you can reattempt it with the same idempotency key without worrying about creating duplicate objects.  See [Idempotency](/basics/api101/idempotency) for more information. (required).</param>
        /// <param name="Batches">A batch of [CatalogObject](#type-catalogobject)s to be inserted/updated atomically. The objects within a batch will be inserted in an all-or-nothing fashion, i.e., if an error occurs attempting to insert or update an object within a batch, the entire batch will be rejected. However, an error in one batch will not affect other batches within the same request.  For each object, its &#x60;updated_at&#x60; field is ignored and replaced with a current [timestamp](#workingwithdates), and its &#x60;is_deleted&#x60; field must not be set to &#x60;true&#x60;.  To modify an existing object, supply its ID. To create a new object, use an ID starting with &#x60;#&#x60;. These IDs may be used to create relationships between an object and attributes of other objects that reference it. For example, you can create a [CatalogItem](#type-catalogitem) with ID &#x60;#ABC&#x60; and a [CatalogItemVariation](#type-catalogitemvariation) with its &#x60;item_id&#x60; attribute set to &#x60;#ABC&#x60; in order to associate the [CatalogItemVariation](#type-catalogitemvariation) with its parent [CatalogItem](#type-catalogitem).  Any &#x60;#&#x60;-prefixed IDs are valid only within a single atomic batch, and will be replaced by server-generated IDs.  Each batch may contain up to 1,000 objects. The total number of objects across all batches for a single request may not exceed 10,000. If either of these limits is violated, an error will be returned and no objects will be inserted or updated..</param>
        public BatchUpsertCatalogObjectsRequest(string IdempotencyKey = default(string), List<CatalogObjectBatch> Batches = default(List<CatalogObjectBatch>))
        {
            // to ensure "IdempotencyKey" is required (not null)
            if (IdempotencyKey == null)
            {
                throw new InvalidDataException("IdempotencyKey is a required property for BatchUpsertCatalogObjectsRequest and cannot be null");
            }
            else
            {
                this.IdempotencyKey = IdempotencyKey;
            }
            this.Batches = Batches;
        }
        
        /// <summary>
        /// A value you specify that uniquely identifies this request among all your requests. A common way to create a valid idempotency key is to use a Universally unique identifier (UUID).  If you&#39;re unsure whether a particular request was successful, you can reattempt it with the same idempotency key without worrying about creating duplicate objects.  See [Idempotency](/basics/api101/idempotency) for more information.
        /// </summary>
        /// <value>A value you specify that uniquely identifies this request among all your requests. A common way to create a valid idempotency key is to use a Universally unique identifier (UUID).  If you&#39;re unsure whether a particular request was successful, you can reattempt it with the same idempotency key without worrying about creating duplicate objects.  See [Idempotency](/basics/api101/idempotency) for more information.</value>
        [DataMember(Name="idempotency_key", EmitDefaultValue=false)]
        public string IdempotencyKey { get; set; }
        /// <summary>
        /// A batch of [CatalogObject](#type-catalogobject)s to be inserted/updated atomically. The objects within a batch will be inserted in an all-or-nothing fashion, i.e., if an error occurs attempting to insert or update an object within a batch, the entire batch will be rejected. However, an error in one batch will not affect other batches within the same request.  For each object, its &#x60;updated_at&#x60; field is ignored and replaced with a current [timestamp](#workingwithdates), and its &#x60;is_deleted&#x60; field must not be set to &#x60;true&#x60;.  To modify an existing object, supply its ID. To create a new object, use an ID starting with &#x60;#&#x60;. These IDs may be used to create relationships between an object and attributes of other objects that reference it. For example, you can create a [CatalogItem](#type-catalogitem) with ID &#x60;#ABC&#x60; and a [CatalogItemVariation](#type-catalogitemvariation) with its &#x60;item_id&#x60; attribute set to &#x60;#ABC&#x60; in order to associate the [CatalogItemVariation](#type-catalogitemvariation) with its parent [CatalogItem](#type-catalogitem).  Any &#x60;#&#x60;-prefixed IDs are valid only within a single atomic batch, and will be replaced by server-generated IDs.  Each batch may contain up to 1,000 objects. The total number of objects across all batches for a single request may not exceed 10,000. If either of these limits is violated, an error will be returned and no objects will be inserted or updated.
        /// </summary>
        /// <value>A batch of [CatalogObject](#type-catalogobject)s to be inserted/updated atomically. The objects within a batch will be inserted in an all-or-nothing fashion, i.e., if an error occurs attempting to insert or update an object within a batch, the entire batch will be rejected. However, an error in one batch will not affect other batches within the same request.  For each object, its &#x60;updated_at&#x60; field is ignored and replaced with a current [timestamp](#workingwithdates), and its &#x60;is_deleted&#x60; field must not be set to &#x60;true&#x60;.  To modify an existing object, supply its ID. To create a new object, use an ID starting with &#x60;#&#x60;. These IDs may be used to create relationships between an object and attributes of other objects that reference it. For example, you can create a [CatalogItem](#type-catalogitem) with ID &#x60;#ABC&#x60; and a [CatalogItemVariation](#type-catalogitemvariation) with its &#x60;item_id&#x60; attribute set to &#x60;#ABC&#x60; in order to associate the [CatalogItemVariation](#type-catalogitemvariation) with its parent [CatalogItem](#type-catalogitem).  Any &#x60;#&#x60;-prefixed IDs are valid only within a single atomic batch, and will be replaced by server-generated IDs.  Each batch may contain up to 1,000 objects. The total number of objects across all batches for a single request may not exceed 10,000. If either of these limits is violated, an error will be returned and no objects will be inserted or updated.</value>
        [DataMember(Name="batches", EmitDefaultValue=false)]
        public List<CatalogObjectBatch> Batches { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchUpsertCatalogObjectsRequest {\n");
            sb.Append("  IdempotencyKey: ").Append(IdempotencyKey).Append("\n");
            sb.Append("  Batches: ").Append(Batches).Append("\n");
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
            return this.Equals(obj as BatchUpsertCatalogObjectsRequest);
        }

        /// <summary>
        /// Returns true if BatchUpsertCatalogObjectsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BatchUpsertCatalogObjectsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchUpsertCatalogObjectsRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdempotencyKey == other.IdempotencyKey ||
                    this.IdempotencyKey != null &&
                    this.IdempotencyKey.Equals(other.IdempotencyKey)
                ) && 
                (
                    this.Batches == other.Batches ||
                    this.Batches != null &&
                    this.Batches.SequenceEqual(other.Batches)
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
                if (this.IdempotencyKey != null)
                    hash = hash * 59 + this.IdempotencyKey.GetHashCode();
                if (this.Batches != null)
                    hash = hash * 59 + this.Batches.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // IdempotencyKey (string) minLength
            if(this.IdempotencyKey != null && this.IdempotencyKey.Length < 1)
            {
                yield return new ValidationResult("Invalid value for IdempotencyKey, length must be greater than 1.", new [] { "IdempotencyKey" });
            }

            yield break;
        }
    }

}
