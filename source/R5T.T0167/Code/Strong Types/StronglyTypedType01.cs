using System;

using R5T.T0150;
using R5T.T0151;


namespace R5T.T0167
{
    /// <summary>
    /// A strongly-typed type for use in testing strogly-typed type survey.
    /// </summary>
    [StrongTypeMarker]
    public class StronglyTypedType01 : TypedString, IStrongTypeMarker
    {
        public StronglyTypedType01(string value)
            : base(value)
        {
        }
    }
}
