namespace Website.Modules.Account
{
    using Nancy;

    public class ProfileModule : NancyModule
    {
        public ProfileModule()
            : base("/account/profile")
        {
            Get["/"] = _ => "profile...";
        }
    }
}