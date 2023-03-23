using System;

using R5T.T0132;


namespace R5T.T0167
{
    [FunctionalityMarker]
    public partial interface IObsoleteFunctionalities : IFunctionalityMarker
    {
        public void FunctionInObsolete01()
        {
            throw new NotImplementedException();
        }

        [Obsolete("An obsolete function.")]
        public void ObsoleteFunctionInObsolete02()
        {
            throw new NotImplementedException();
        }
    }
}
