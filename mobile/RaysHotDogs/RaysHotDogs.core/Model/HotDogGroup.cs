using System;
using System.Collections.Generic;

namespace RaysHotDogs.core.Model
{
    public class HotDogGroup
    {
        public HotDogGroup()
        {
        }

        public int HotDogGroupId { get; set; }

        public string Title { get; set; }

        public string ImagePath { get; set; }

        public List<HotDog> HotDogs{ get; set; }
    }
}
