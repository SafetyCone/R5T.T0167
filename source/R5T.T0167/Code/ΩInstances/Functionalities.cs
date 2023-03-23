using System;


namespace R5T.T0167
{
    public class Functionalities : IFunctionalities
    {
        #region Infrastructure

        public static IFunctionalities Instance { get; } = new Functionalities();


        private Functionalities()
        {
        }

        #endregion
    }
}
