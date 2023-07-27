using System;

using R5T.T0131;
using R5T.T0181;
using R5T.T0181.Extensions;


namespace R5T.L0052.Z001
{
    [ValuesMarker]
    public partial interface IFileNames : IValuesMarker
    {
        public IJsonFileName Instances => "Instances.json".ToJsonFileName();
    }
}
