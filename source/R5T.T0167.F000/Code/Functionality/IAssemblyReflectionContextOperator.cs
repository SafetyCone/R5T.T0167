using System;
using System.Reflection;

using R5T.T0132;


namespace R5T.T0167.F000
{
    [FunctionalityMarker]
    public partial interface IAssemblyReflectionContextOperator : IFunctionalityMarker
    {
        public void InAssemblyReflectionContext(
            Action<Assembly> assemblyAction)
        {
            Instances.ReflectionOperator.InAssemblyContext(
                Instances.FilePaths.AllMarkerAttributeTypesAssemblyFilePath,
                assemblyAction);
        }
    }
}
