namespace ImlSampleDialog.UI
{
    using System;
    using System.Collections.Generic;
    using Incoding.Data;

    public class Product : IncEntityBase
    {
        public static List<Product> Db = new List<Product>();

        public new string Id { get; set; }

        public string Name { get; set; }

        public DateTime CreatedDt { get; set; }
    }
}