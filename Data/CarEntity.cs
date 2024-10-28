using System;

namespace EfLocalDbTest.Data
{
    public class CarEntity
    {
        public Guid Id { get; set;}

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public DateTime BuiltOn { get; set; }

        public string Color { get; set; }
    }
}
