using System;
using System.Threading.Tasks;

using R5T.D0010;


namespace R5T.D0015
{
    public interface IFileEqualityComparer
    {
        Task Equals(string filePath1, string filePath2, IMessageSink messageSink);
    }
}
