namespace Website.Modules.Account
{
    using Nancy;

    public class RegisterModule : NancyModule
    {
        public RegisterModule()
            : base("/account/register")
        {
            Get["/"] = _ => "register";
            Post["/"] = _ => "register";
        }
    }
}