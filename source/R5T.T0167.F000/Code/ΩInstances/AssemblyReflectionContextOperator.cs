using System;


namespace R5T.T0167.F000
{
    public class AssemblyReflectionContextOperator : IAssemblyReflectionContextOperator
    {
        #region Infrastructure

        public static IAssemblyReflectionContextOperator Instance { get; } = new AssemblyReflectionContextOperator();


        private AssemblyReflectionContextOperator()
        {
        }

        #endregion
    }
}
