using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ClassLibrary
{
    public class UsersResultStorage
    {
        public List<User> Users;
        public static string fileName = @"userInfo.json";
        public static void Save(User user)
        {
            var userResults = GetAll();
            userResults.Add(user);
            Save(userResults);
        }

        public static List<User> GetAll()
        {
            if(!FileProvider.Exist(fileName))
            {
                return new List<User>();
            }
            var value = FileProvider.GetValue(fileName);
            var userResults = JsonConvert.DeserializeObject<List<User>>(value);
            return userResults;
        }

        static void Save(List<User> userResults)
        {
            var jsonData = JsonConvert.SerializeObject(userResults, Formatting.Indented);
            FileProvider.Replace(fileName, jsonData);
        }
    }
}
