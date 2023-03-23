using System;


namespace R5T.T0167.F000
{
    public class AssemblyNames : IAssemblyNames
    {
        #region Infrastructure

        public static IAssemblyNames Instance { get; } = new AssemblyNames();


        private AssemblyNames()
        {
        }

        #endregion
    }
}
