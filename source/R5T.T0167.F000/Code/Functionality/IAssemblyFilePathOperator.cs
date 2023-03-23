using System;

using R5T.T0132;
using R5T.T0172;
using R5T.T0172.Extensions;


namespace R5T.T0167.F000
{
    [FunctionalityMarker]
    public partial interface IAssemblyFilePathOperator : IFunctionalityMarker
    {
        public AssemblyFilePath Get_AllMarkerAttributeTypesAssemblyFilePath()
        {
            var exampleAssemblyFilePath = Instances.ExecutablePathOperator.Get_ExecutableDirectoryAssemblyFilePath(
                Instances.AssemblyNames.AllMarkerAttributeTypesAssemblyName);

            var output = exampleAssemblyFilePath.ToAssemblyFilePath();
            return output;
        }

        public DocumentationXmlFilePath Get_AllMarkerAttributeTypesAssemblyDocumentationFilePath()
        {
            var documentationFilePath = Instances.ExecutablePathOperator.Get_ExecutableDirectoryAssemblyDocumentatinFilePath(
                Instances.AssemblyNames.AllMarkerAttributeTypesAssemblyName);

            var output = documentationFilePath.ToDocumentationXmlFilePath();
            return output;
        }
    }
}
