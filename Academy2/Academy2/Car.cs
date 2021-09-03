using System;
using Academy2.Enums;

namespace Academy2
{
    public class Car
    {
        public Guid Id { get; set; }
        public Brand Brand { get; set; }
        public string Model { get; set; }
        public int Doors { get; set; }
        public string Color { get; set; }
    }
}
