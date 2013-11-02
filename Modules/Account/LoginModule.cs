namespace Website.Modules.Account
{
    using Nancy;

    public class LoginModule : NancyModule
    {
        public LoginModule()
            : base("/account/login")
        {
            Get["/"] = _ => "login";
            Post["/"] = _ => "login";
        }
    }
}