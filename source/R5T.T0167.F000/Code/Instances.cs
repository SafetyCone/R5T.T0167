using System;


namespace R5T.T0167.F000
{
    public static class Instances
    {
        public static IAssemblyFilePathOperator AssemblyFilePathOperator => F000.AssemblyFilePathOperator.Instance;
        public static IAssemblyNames AssemblyNames => F000.AssemblyNames.Instance;
        public static F0002.IExecutablePathOperator ExecutablePathOperator => F0002.ExecutablePathOperator.Instance;
        public static IFilePaths FilePaths => F000.FilePaths.Instance;
        public static F0018.IReflectionOperator ReflectionOperator => F0018.ReflectionOperator.Instance;
    }
}