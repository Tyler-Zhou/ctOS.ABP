namespace ctOS.Permissions;

public static class ctOSPermissions
{
    public const string GroupName = "ctOS";

    public static class Library
    {
        public const string LibraryName = ".Library";
        public static class Books
        {
            public const string Default = GroupName + LibraryName + ".Books";
            public const string Create = Default + ".Create";
            public const string Edit = Default + ".Edit";
            public const string Delete = Default + ".Delete";
        }
    }
    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";
}
