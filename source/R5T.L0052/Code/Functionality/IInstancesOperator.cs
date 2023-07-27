using System;
using System.Threading.Tasks;
using R5T.F0109;
using R5T.T0132;


namespace R5T.L0052
{
    [FunctionalityMarker]
    public partial interface IInstancesOperator : IFunctionalityMarker
    {
        public Task In_InstancesContext(
            T001.N001.IInstancesJsonFilePath instancesJsonFilePath,
            Func<AssemblyInstancesDescriptor, Task> instancesAction)
        {
            var instances = Instances.InstancesFileOperator.Load_Instances_Synchronous(instancesJsonFilePath);

            return instancesAction(instances);
        }

        public void In_InstancesContext(
            T001.N001.IInstancesJsonFilePath instancesJsonFilePath,
            Action<AssemblyInstancesDescriptor> instancesAction)
        {
            var instances = Instances.InstancesFileOperator.Load_Instances_Synchronous(instancesJsonFilePath);

            instancesAction(instances);
        }

        public void In_ModifyInstancesContext(
            T001.N001.IInstancesJsonFilePath instancesJsonFilePath,
            Action<AssemblyInstancesDescriptor> instancesAction)
        {
            var instances = Instances.InstancesFileOperator.Load_Instances_Synchronous(instancesJsonFilePath);

            instancesAction(instances);

            Instances.InstancesFileOperator.Save_Instances_Synchronous(
                instances,
                instancesJsonFilePath);
        }

        public TOutput In_QueryInstancesContext<TOutput>(
            T001.N001.IInstancesJsonFilePath instancesJsonFilePath,
            Func<AssemblyInstancesDescriptor, TOutput> instancesFunction)
        {
            var instances = Instances.InstancesFileOperator.Load_Instances_Synchronous(instancesJsonFilePath);

            var output = instancesFunction(instances);
            return output;
        }

        public Task In_InstancesContext(Func<AssemblyInstancesDescriptor, Task> instancesAction)
        {
            return this.In_InstancesContext(
                Instances.FilePaths.InstancesFilePath,
                instancesAction);
        }

        public void In_InstancesContext(Action<AssemblyInstancesDescriptor> instancesAction)
        {
            this.In_InstancesContext(
                Instances.FilePaths.InstancesFilePath,
                instancesAction);
        }

        public TOutput In_QueryInstancesContext<TOutput>(Func<AssemblyInstancesDescriptor, TOutput> instancesFunction)
        {
            return this.In_QueryInstancesContext(
                Instances.FilePaths.InstancesFilePath,
                instancesFunction);
        }
    }
}
