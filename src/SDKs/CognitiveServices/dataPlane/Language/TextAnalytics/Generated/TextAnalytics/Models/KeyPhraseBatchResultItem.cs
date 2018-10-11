// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.TextAnalytics.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class KeyPhraseBatchResultItem
    {
        /// <summary>
        /// Initializes a new instance of the KeyPhraseBatchResultItem class.
        /// </summary>
        public KeyPhraseBatchResultItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KeyPhraseBatchResultItem class.
        /// </summary>
        /// <param name="keyPhrases">A list of representative words or phrases.
        /// The number of key phrases returned is proportional to the number of
        /// words in the input document.</param>
        /// <param name="id">Unique document identifier.</param>
        public KeyPhraseBatchResultItem(IList<string> keyPhrases = default(IList<string>), string id = default(string))
        {
            KeyPhrases = keyPhrases;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets a list of representative words or phrases. The number of key
        /// phrases returned is proportional to the number of words in the
        /// input document.
        /// </summary>
        [JsonProperty(PropertyName = "keyPhrases")]
        public IList<string> KeyPhrases { get; private set; }

        /// <summary>
        /// Gets unique document identifier.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

    }
}
