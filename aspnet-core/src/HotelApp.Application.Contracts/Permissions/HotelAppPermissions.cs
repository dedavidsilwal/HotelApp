namespace HotelApp.Permissions
{
    public static class HotelAppPermissions
    {
        public const string GroupName = "HotelApp";

        //Add your own permission names. Example:
        public static class Hotels
        {
            public const string Default = GroupName + ".Hotels";
            public const string Create = Default + ".Create";
            public const string Edit = Default + ".Edit";
            public const string Delete = Default + ".Delete";
        }

    }
}