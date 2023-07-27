using System;

using R5T.T0132;
using R5T.F0109;


namespace R5T.L0052
{
    [FunctionalityMarker]
    public partial interface IInstancesFileOperator : IFunctionalityMarker
    {
        public AssemblyInstancesDescriptor Load_Instances_Synchronous()
        {
            var instancesFilePath = Instances.FilePaths.InstancesFilePath;

            var output = this.Load_Instances_Synchronous(instancesFilePath);
            return output;
        }

        public AssemblyInstancesDescriptor Load_Instances_Synchronous(T001.N001.IInstancesJsonFilePath instancesJsonFilePath)
        {
            var output = Instances.AssemblyInstancesDescriptorOperator.Deserialize_Synchronous(
                instancesJsonFilePath);

            return output;
        }

        public void Save_Instances_Synchronous(AssemblyInstancesDescriptor instances)
        {
            var instancesFilePath = Instances.FilePaths.InstancesFilePath;

            this.Save_Instances_Synchronous(
                instances,
                instancesFilePath);
        }

        public void Save_Instances_Synchronous(
            AssemblyInstancesDescriptor instances,
            T001.N001.IInstancesJsonFilePath instancesJsonFilePath)
        {
            Instances.AssemblyInstancesDescriptorOperator.Serialize_Synchronous(
                instancesJsonFilePath,
                instances);
        }
    }
}
