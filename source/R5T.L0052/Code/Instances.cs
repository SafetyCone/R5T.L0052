using System;


namespace R5T.L0052
{
    public static class Instances
    {
        public static F0109.IAssemblyInstancesDescriptorOperator AssemblyInstancesDescriptorOperator => F0109.AssemblyInstancesDescriptorOperator.Instance;
        public static IFilePaths FilePaths => L0052.FilePaths.Instance;
        public static IInstancesFileOperator InstancesFileOperator => L0052.InstancesFileOperator.Instance;
    }
}