// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for StorageAccountTypes.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(StorageAccountTypesConverter))]
    public struct StorageAccountTypes : System.IEquatable<StorageAccountTypes>
    {
        private StorageAccountTypes(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        public static readonly StorageAccountTypes StandardLRS = "Standard_LRS";

        public static readonly StorageAccountTypes PremiumLRS = "Premium_LRS";

        public static readonly StorageAccountTypes StandardSSDLRS = "StandardSSD_LRS";


        /// <summary>
        /// Underlying value of enum StorageAccountTypes
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for StorageAccountTypes
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type StorageAccountTypes
        /// </summary>
        public bool Equals(StorageAccountTypes e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to StorageAccountTypes
        /// </summary>
        public static implicit operator StorageAccountTypes(string value)
        {
            return new StorageAccountTypes(value);
        }

        /// <summary>
        /// Implicit operator to convert StorageAccountTypes to string
        /// </summary>
        public static implicit operator string(StorageAccountTypes e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum StorageAccountTypes
        /// </summary>
        public static bool operator == (StorageAccountTypes e1, StorageAccountTypes e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum StorageAccountTypes
        /// </summary>
        public static bool operator != (StorageAccountTypes e1, StorageAccountTypes e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for StorageAccountTypes
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is StorageAccountTypes && Equals((StorageAccountTypes)obj);
        }

        /// <summary>
        /// Returns for hashCode StorageAccountTypes
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}