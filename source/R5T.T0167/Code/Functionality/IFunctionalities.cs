using System;

using R5T.T0132;


namespace R5T.T0167
{
    /// <summary>
    /// Functions for testing purposes.
    /// </summary>
    [FunctionalityMarker]
    public partial interface IFunctionalities : IFunctionalityMarker
    {
        public void Function01()
        {
            throw new NotImplementedException();
        }

        [Obsolete("An obsolete function.")]
        public void ObsoleteFunction02()
        {
            throw new NotImplementedException();
        }
    }
}
