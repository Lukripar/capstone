﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneIMS.Domain
{
    [BsonIgnoreExtraElements]
    public class Product
    {
        
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("SKU")]
        public string ItemNumber { get; set; }
        [BsonElement("Name")]
        public string ProductName { get; set; }
        [BsonElement("ProductType")]
        public string ProductType { get; set; }
        [BsonElement("DefaultPrice")]
        public decimal DefaultPrice { get; set; }

    }
}
