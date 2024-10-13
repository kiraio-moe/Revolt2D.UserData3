namespace Revolt2D.UserData.Json
{
    public class Meta
    {
        public int TotalUserDataSize;
        public int UserDataCount;

        public override string ToString()
        {
            return $"  Total User Data Size: {TotalUserDataSize}\n  User Data Count: {UserDataCount}";
        }
    }
}
