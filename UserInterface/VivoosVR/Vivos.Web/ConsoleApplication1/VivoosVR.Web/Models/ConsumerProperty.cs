﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ConsoleApplication1.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class ConsumerProperty
    {
        /// <summary>
        /// Initializes a new instance of the ConsumerProperty class.
        /// </summary>
        public ConsumerProperty() { }

        /// <summary>
        /// Initializes a new instance of the ConsumerProperty class.
        /// </summary>
        public ConsumerProperty(Guid? id = default(Guid?), Guid? consumerId = default(Guid?), string value = default(string), bool? available = default(bool?), DateTime? entryDate = default(DateTime?), int? typeNo = default(int?), ConsumerPropertyType consumerPropertyType = default(ConsumerPropertyType), Consumer consumer = default(Consumer))
        {
            Id = id;
            ConsumerId = consumerId;
            Value = value;
            Available = available;
            EntryDate = entryDate;
            TypeNo = typeNo;
            ConsumerPropertyType = consumerPropertyType;
            Consumer = consumer;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public Guid? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ConsumerId")]
        public Guid? ConsumerId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Value")]
        public string Value { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Available")]
        public bool? Available { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EntryDate")]
        public DateTime? EntryDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TypeNo")]
        public int? TypeNo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ConsumerPropertyType")]
        public ConsumerPropertyType ConsumerPropertyType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Consumer")]
        public Consumer Consumer { get; set; }

    }
}
