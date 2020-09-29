using System;
namespace dot_net_tdd.model.exceptions
{
  public class EmptyStackException : Exception
  {
    public EmptyStackException(string message) : base(message)
    {
    }
  }
}
