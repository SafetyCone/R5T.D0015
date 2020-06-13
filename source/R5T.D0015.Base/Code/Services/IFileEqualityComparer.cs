using System;
using System.Threading.Tasks;


namespace R5T.D0015
{
    public interface IFileEqualityComparer
    {
        Task Equals(string filePath1, string filePath2);
    }
}
