namespace Website.Modules.Account
{
    using Nancy;

    public class DetailsModule : NancyModule
    {
        public DetailsModule()
            : base("/account/details")
        {
            Get["/"] = _ => "details";
        }
    }
}