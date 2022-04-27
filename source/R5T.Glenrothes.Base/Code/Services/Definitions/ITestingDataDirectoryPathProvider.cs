using System;using R5T.T0064;


namespace R5T.Glenrothes
{[ServiceDefinitionMarker]
    public interface ITestingDataDirectoryPathProvider:IServiceDefinition
    {
        string GetTestingDataDirectoryPath();
    }
}
