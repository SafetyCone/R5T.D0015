using System;
using System.Threading.Tasks;

using R5T.D0010;
using R5T.T0064;


namespace R5T.D0015
{
    [ServiceDefinitionMarker]
    public interface IFileEqualityComparer : IServiceDefinition
    {
        Task Equals(string filePath1, string filePath2, IMessageSink messageSink);
    }
}
