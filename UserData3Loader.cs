using System.Text.Json;

namespace Revolt2D.UserData.Json
{
    public class UserData3Loader
    {
        private UserData3 _userdata;

        public UserData3Loader(string filePath)
        {
            _userdata = LoadFromFile(filePath);
        }

        public UserData3 GetUserData()
        {
            return _userdata;
        }

        public UserData3? LoadFromFile(string filePath)
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
                throw new Exception($"Invalid path! {filePath}");

            string? jsonData = File.ReadAllText(filePath);
            return LoadJson(jsonData);
        }

        public UserData3? LoadJson(string jsonData)
        {
            try
            {
                if (string.IsNullOrEmpty(jsonData))
                    throw new Exception("JSON data empty!");

                JsonSerializerOptions options = new JsonSerializerOptions { IncludeFields = true };
                return JsonSerializer.Deserialize<UserData3>(jsonData, options);
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }
    }
}
