namespace SMM.Data.Constants;

/// <summary>Maximum lengths shared by the database schema and input validation.</summary>
public static class DataConstants
{
    public const int UrlMaxLength = 500;

    public static class UserProfile
    {
        public const int DisplayNameMaxLength = 100;
        public const int BiographyMaxLength = 2000;
        public const int CountryMaxLength = 100;
        public const int CityMaxLength = 100;
    }

    public static class Track
    {
        public const int TitleMaxLength = 200;
        public const int DescriptionMaxLength = 2000;
    }

    public static class Post
    {
        public const int ContentMaxLength = 5000;
    }

    public static class Group
    {
        public const int NameMaxLength = 100;
        public const int DescriptionMaxLength = 2000;
    }

    public static class Message
    {
        public const int ContentMaxLength = 2000;
    }
}
