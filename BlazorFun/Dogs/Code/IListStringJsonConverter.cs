using System.Collections.Generic;

namespace Dogs.Code
{
    public interface IListStringJsonConverter
    {
        List<string> GetDogsFromResult(string json);

    }
}