using System;

namespace PizzaStuff
{
    public class PizzaException : Exception { 
        public PizzaException(string message)  {
            throw new NotImplementedException("Method is not implemented.");
        }
    }
}
