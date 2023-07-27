using System;

using R5T.T0131;

using R5T.L0052.T001;
using R5T.L0052.T001.Extensions;


namespace R5T.L0052.Z001
{
    [ValuesMarker]
    public partial interface IFilePaths : IValuesMarker
    {
        /// <summary>
        /// <para>"C:\Users\David\Dropbox\Organizations\Rivet\Shared\Data\Instances.json"</para>
        /// Just the simple file path for the instances JSON file.
        /// </summary>
        public IInstancesFilePath InstancesFilePath => @"C:\Users\David\Dropbox\Organizations\Rivet\Shared\Data\Instances.json".ToInstancesFilePath();
    }
}
