using System;
using System.Collections.Generic;
using RaysHotDogs.core.Model;
namespace RaysHotDogs.core
{
    public class HotDogsDataService
    {
        private static HotDogRepository hotDogsRepository = new HotDogRepository();

        public HotDogsDataService()
        {

        }

        public HotDog GetHotDog(int hotDogId)
        {
            return hotDogsRepository.GetHotDogById(hotDogId);
        }

        public List<HotDog> GetAllHotDogs()
        {
            return hotDogsRepository.GetAllHotDogs();
        }

        public List<HotDog> GetAllFavoriteHotDogs()
        {
            return hotDogsRepository.GetFavoritesHogDogs();
        }


        public List<HotDog> GetHotDogsFromGroup(int groupId)
        {
            return hotDogsRepository.GetHotDogsFromGroup(groupId);
        }


        public HotDogGroup GetGroupHotDog(int groupId)
        {
            return hotDogsRepository.GetHotDogGroupdById(groupId);
        }

        public List<HotDogGroup> GetAllGroupHotDogs()
        {
            return hotDogsRepository.GetAllHotDogGroups();
        }





    }
}
