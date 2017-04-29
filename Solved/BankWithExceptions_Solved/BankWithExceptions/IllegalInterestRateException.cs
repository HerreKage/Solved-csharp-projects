﻿using System;

namespace BankWithExceptions
{
    /// <summary>
    /// This exception is to be thrown in case the bank account 
    /// is defined with an illegal interest rate
    /// </summary>
    class IllegalInterestRateException : Exception
    {
    }
}
