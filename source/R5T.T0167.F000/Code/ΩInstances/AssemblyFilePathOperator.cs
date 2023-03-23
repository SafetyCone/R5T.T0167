using System;


namespace R5T.T0167.F000
{
    public class AssemblyFilePathOperator : IAssemblyFilePathOperator
    {
        #region Infrastructure

        public static IAssemblyFilePathOperator Instance { get; } = new AssemblyFilePathOperator();


        private AssemblyFilePathOperator()
        {
        }

        #endregion
    }
}
