using System;

using R5T.T0131;
using R5T.T0172;


namespace R5T.T0167.F000
{
    [ValuesMarker]
    public partial interface IFilePaths : IValuesMarker
    {
        public AssemblyFilePath AllMarkerAttributeTypesAssemblyFilePath => Instances.AssemblyFilePathOperator.Get_AllMarkerAttributeTypesAssemblyFilePath();
        public DocumentationXmlFilePath AllMarkerAttributeTypesAssemblyDocumentationFilePath =>
            Instances.AssemblyFilePathOperator.Get_AllMarkerAttributeTypesAssemblyDocumentationFilePath();
    }
}
