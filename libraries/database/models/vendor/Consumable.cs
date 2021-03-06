﻿using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.vendor
{

    /// <summary>
    /// Consumable model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "consumable")]
    public class ModelVendorConsumable
    {

        [XmlAttribute(AttributeName = "quantity")]
        public int Quantity { get; set; }

        [XmlText]
        public string Text { get; set; }

        [XmlAttribute(AttributeName = "level")]
        public int Level { get; set; }

    }

}
