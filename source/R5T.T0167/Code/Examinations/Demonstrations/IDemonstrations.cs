using System;

using R5T.T0141;


namespace R5T.T0167
{
    /// <summary>
    /// Demonstrations for testing purposes.
    /// </summary>
    [DemonstrationsMarker]
    public partial interface IDemonstrations : IDemonstrationsMarker
    {
        public void Demonstration01()
        {
            throw new NotImplementedException();
        }

        [Obsolete("An obsolete demonstration.")]
        public void ObsoleteDemonstration02()
        {
            throw new NotImplementedException();
        }
    }
}
