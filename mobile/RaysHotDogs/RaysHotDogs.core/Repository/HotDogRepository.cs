using System;
using System.Collections.Generic;
using System.Linq;
using RaysHotDogs.core.Model;

namespace RaysHotDogs.core
{
    public class HotDogRepository
    {
        public HotDogRepository()
        {
            
        }

        public List<HotDog> GetAllHotDogs()
        {
            IEnumerable<HotDog> hotDogs =
                from hotDogGroup in hotDogGroups
                from hotDog in hotDogGroup.HotDogs
                select hotDog;
            return hotDogs.ToList<HotDog>();

        }

        public HotDog GetHotDogById(int id)
        {
            IEnumerable<HotDog> hotDogs = 
                from hotDogGroup in hotDogGroups
                from hotDog in hotDogGroup.HotDogs
                   where hotDog.HotDogId == id
                select hotDog;
            
            return hotDogs.FirstOrDefault();

        }

        public List<HotDogGroup> GetAllHotDogGroups()
        {
            return hotDogGroups;
        }

        public HotDogGroup GetHotDogGroupdById(int id)
        {
            return (from hdg in hotDogGroups
                 where hdg.HotDogGroupId == id
                 select hdg).FirstOrDefault();
        }

        //return favorites hotdogs
        public List<HotDog> GetFavoritesHogDogs()
        {
            return (from hdg in hotDogGroups
                    from HotDog in hdg.HotDogs
                    where HotDog.IsFavorite == true
                    select HotDog).ToList<HotDog>();
        }

        //return hotdogs for a particular group
        public  List<HotDog> GetHotDogsFromGroup(int groupId)
        {
            return (from hdg in hotDogGroups
                    from hd in hdg.HotDogs
                    where hdg.HotDogGroupId == groupId
                    select hd).ToList<HotDog>();
        }



        //Temorary methods to return fake data.

        private static List<HotDogGroup> hotDogGroups = new List<HotDogGroup>()
        {
            new HotDogGroup()
            {
                HotDogGroupId = 1, Title = "Meat Lovers", ImagePath="", HotDogs = new List<HotDog>()
                {
                    new HotDog()
                    {
                        HotDogId=1,
                        Name="The Rubens Hot Dog",
                        ShortDescription="The best hot dog in the planet",
                        Description="The Rubens Hot Dog ...",
                        ImagePath="",
                        Available=true,
                        PreparationTime=10,
                        Ingredients= new List<string>(){"regular bun", "sausage","ketchup","secret ingredients"},
                        price=8,
                        IsFavorite=false
                    },
                    new HotDog()
                    {
                        HotDogId=2,
                        Name="The Hot Dog",
                        ShortDescription="The second best hot dog in the planet",
                        Description="The Hot Dog ...",
                        ImagePath="",
                        Available=true,
                        PreparationTime=10,
                        Ingredients= new List<string>(){"regular bun", "sausage","ketchup","secret ingredients"},
                        price=8,
                        IsFavorite=true
                    },
                    new HotDog()
                    {
                        HotDogId=3,
                        Name="The Awesome Hot Dog",
                        ShortDescription="The second best hot dog in the planet by far",
                        Description="The Rubens Hot Dog ...",
                        ImagePath="",
                        Available=true,
                        PreparationTime=10,
                        Ingredients= new List<string>(){"regular bun", "sausage","ketchup","secret ingredients"},
                        price=8,
                        IsFavorite=false
                    }

                }

            },
            new HotDogGroup()
            {
                HotDogGroupId = 2, Title = "Veggie Lovers", ImagePath="", HotDogs = new List<HotDog>()
                {
                    new HotDog()
                    {
                        HotDogId=4,
                        Name="The XMen Hot Dog",
                        ShortDescription="The best hot dog in the planet",
                        Description="The Rubens Hot Dog ...",
                        ImagePath="",
                        Available=true,
                        PreparationTime=10,
                        Ingredients= new List<string>(){"regular bun", "sausage","ketchup","secret ingredients"},
                        price=8,
                        IsFavorite=false
                    },
                    new HotDog()
                    {
                        HotDogId=5,
                        Name="The DC Hot Dog",
                        ShortDescription="The second best hot dog in the planet",
                        Description="The Hot Dog ...",
                        ImagePath="",
                        Available=true,
                        PreparationTime=10,
                        Ingredients= new List<string>(){"regular bun", "sausage","ketchup","secret ingredients"},
                        price=8,
                        IsFavorite=true
                    },
                    new HotDog()
                    {
                        HotDogId=6,
                        Name="The Marvel Hot Dog",
                        ShortDescription="The second best hot dog in the planet by far",
                        Description="The Rubens Hot Dog ...",
                        ImagePath="",
                        Available=true,
                        PreparationTime=10,
                        Ingredients= new List<string>(){"regular bun", "sausage","ketchup","secret ingredients"},
                        price=8,
                        IsFavorite=false
                    }

                }

            }

        };

    }

}