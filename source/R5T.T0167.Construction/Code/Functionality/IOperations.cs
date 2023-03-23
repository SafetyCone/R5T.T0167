using System;
using System.Collections.Generic;
using System.Linq;

using R5T.T0132;


namespace R5T.T0167.Construction
{
    [FunctionalityMarker]
    public partial interface IOperations : IFunctionalityMarker
    {
        public void List_AllTypesInAssemblyReflectionContext()
        {
            /// Inputs.
            var outputTextFilePath = Instances.FilePaths.OutputTextFilePath;

            /// Run.
            var typeNames = new List<string>();

            // No special runtime directory paths are required since current executable contains a reference to the target project.
            // Thus all required assemblies will be in the output directory (executable directory) of the current project.
            Instances.AssemblyReflectionContextOperator.InAssemblyReflectionContext(
                assembly => Instances.ReflectionOperations.List_TypesInAssembly(
                    assembly,
                    description =>
                    {
                        typeNames.Add(description);
                    }));

            var lines = typeNames
                .OrderAlphabetically()
                ;

            Instances.FileOperator.WriteLines_Synchronous(
                outputTextFilePath,
                lines);

            Instances.NotepadPlusPlusOperator.Open(outputTextFilePath);
        }
    }
}
