namespace Test_Taste_Console_Application.Constants
{
    public static class UriPath
    {
        public const string BaseUri = "https://api.le-systeme-solaire.net";
        private const string BodiesUri = "/rest/bodies";

        // Included gravity parameter in data query
        public const string GetAllPlanetsWithMoonsQueryParameters =
            BodiesUri + "?data=id,semiMajorAxis,gravity,moons,moon,rel&filter[]=isPlanet,neq,false";

        public const string GetAllMoonsWithMassQueryParameters = BodiesUri +
                                               "?data=id,mass,massValue,massExponent,massValue&filter[]=aroundPlanet,gt,null";

        public const string GetMoonByIdQueryParameters = BodiesUri + "/";
    }
}
