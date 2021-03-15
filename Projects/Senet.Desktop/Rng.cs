using System;
using System.Collections.Generic;
using System.Text;

namespace Senet.Desktop
{
  public interface IRng
  {
    int Next();
    int Next(int maxValue);
    int Next(int minValue, int maxValue);
    double Next(double minimum, double maximum);
  }

  public sealed class Rng : IRng
  {
    // ref:  https://stackoverflow.com/questions/12316406/thread-safe-c-sharp-singleton-pattern

    //private static volatile Rng _instance;
    private static readonly object Sync = new object();

    private readonly Random _random;

    public Rng()
    {
      _random = new Random();
    }

    //public static Rng Instance
    //{
    //  get
    //  {
    //    if (_instance == null)
    //    {
    //      lock (Sync)
    //      {
    //        if (_instance == null)
    //        {
    //          _instance = new Rng();
    //        }
    //      }
    //    }

    //    return _instance;
    //  }
    //}

    public int Next()
    {
      return _random.Next();
    }

    public int Next(int maxValue)
    {
      return _random.Next(maxValue);
    }

    public int Next(int minValue, int maxValue)
    {
      return _random.Next(minValue, maxValue);
    }

    public double Next(double minimum, double maximum)
    {
      return _random.NextDouble() * (maximum - minimum) + minimum;
    }
  }
}
