using System;


namespace R5T.T0167
{
    public class NotFunctionalities : INotFunctionalities01
    {
        #region Infrastructure

        public static INotFunctionalities01 Instance { get; } = new NotFunctionalities();


        private NotFunctionalities()
        {
        }

        #endregion
    }
}
