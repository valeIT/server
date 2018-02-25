﻿using System.Xml.Serialization;


namespace Libraries.database.models.vendor
{

    /// <summary>
    /// Material model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "material")]
    public class ModelVendorMaterial
    {

        [XmlAttribute(AttributeName = "quantity")]
        public int Quantity { get; set; }

        [XmlText]
        public string Text { get; set; }

        [XmlAttribute(AttributeName = "level")]
        public int Level { get; set; }

    }

}
