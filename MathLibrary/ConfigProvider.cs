using System;

namespace MathLibrary
{
    public class ConfigProvider : IConfigProvider
    {
        // let's imagine it takes a data from an external source, e.g. database
        public double Pi => throw new NotImplementedException();
    }
}
