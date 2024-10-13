namespace Revolt2D.UserData.Json
{
    public class UserData
    {
        public string Id;
        public string Target;
        public string Value;

        public override string ToString()
        {
            return $"  Id: {Id}\n  Target: {Target}\n  Value: {Value}";
        }
    }
}
