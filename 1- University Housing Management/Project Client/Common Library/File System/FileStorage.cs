using System.IO;
using Newtonsoft.Json;
using Common_Library.File_System;


namespace Common_Library
{
    public class FileStorage
    {
        private const string FileName = "LoginInfo.json";

        public static void SaveLoginInfo(LoginInfo loginInfo)
        {
            var json = JsonConvert.SerializeObject(loginInfo, Formatting.Indented);

            File.WriteAllText(FileName, json);
        }
        public static LoginInfo LoadLoginInfo()
        {
            if (!File.Exists(FileName))
                return null;

            var json = File.ReadAllText(FileName);

            return JsonConvert.DeserializeObject<LoginInfo>(json);
        }
        public static void DeleteLoginInfo()
        {
            if (File.Exists(FileName))
                File.Delete(FileName);
        }
    
    }
}
