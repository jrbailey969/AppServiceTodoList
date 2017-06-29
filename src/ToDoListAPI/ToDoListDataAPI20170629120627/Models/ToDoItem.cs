﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ToDoListAPI.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class ToDoItem
    {
        /// <summary>
        /// Initializes a new instance of the ToDoItem class.
        /// </summary>
        public ToDoItem() { }

        /// <summary>
        /// Initializes a new instance of the ToDoItem class.
        /// </summary>
        public ToDoItem(int? id = default(int?), string description = default(string), string owner = default(string))
        {
            ID = id;
            Description = description;
            Owner = owner;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ID")]
        public int? ID { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Owner")]
        public string Owner { get; set; }

    }
}
