namespace Revolt2D.UserData.Json
{
    public class UserData3
    {
        public int Version;
        public Meta Meta;
        public UserData UserData;

        public override string ToString()
        {
            return $"Version: {Version}\nMeta: {Meta}\nUser Data: {UserData}";
        }
    }
}
