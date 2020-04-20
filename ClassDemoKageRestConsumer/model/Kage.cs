using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoKageRestConsumer.model
{
    class Kage
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public int NoOfPieces { get; set; }

        public int Id { get; set; }

        public Kage()
        {
        }

        public Kage(string name, double price, int noOfPieces, int id)
        {
            Name = name;
            Price = price;
            NoOfPieces = noOfPieces;
            Id = id;
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Price)}: {Price}, {nameof(NoOfPieces)}: {NoOfPieces}, {nameof(Id)}: {Id}";
        }
    }
}
