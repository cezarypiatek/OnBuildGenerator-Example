namespace SampleMappingLib
{
    class ExampleImplementationUsage
    {
        public void DoSomething()
        {
            var sampleMappingService = new SampleMapperService();
            var userEntity = sampleMappingService.MapFrom(new UserDTO());
        }
    }
}