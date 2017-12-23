using System;
using System.Collections.Generic;

namespace RaysHotDogs.core.Model
{
    public class HotDog
    {
        public HotDog()
        {
        }
        public int HotDogId { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }

        public float price { get; set; }

        public bool Available { get; set; }

        public float PreparationTime { get; set; }

        public List<string> Ingredients { get; set; }

        public bool IsFavorite { get; set; }

        public string GroupName { get; set; }


    }
}
