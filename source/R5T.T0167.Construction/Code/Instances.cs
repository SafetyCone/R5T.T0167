using System;


namespace R5T.T0167.Construction
{
    public static class Instances
    {
        public static F000.IAssemblyReflectionContextOperator AssemblyReflectionContextOperator => F000.AssemblyReflectionContextOperator.Instance;
        public static F0000.IFileOperator FileOperator => F0000.FileOperator.Instance; 
        public static Z0015.IFilePaths FilePaths => Z0015.FilePaths.Instance;
        public static F0033.INotepadPlusPlusOperator NotepadPlusPlusOperator => F0033.NotepadPlusPlusOperator.Instance;
        public static F0018.IReflectionOperations ReflectionOperations => F0018.ReflectionOperations.Instance;
    }
}