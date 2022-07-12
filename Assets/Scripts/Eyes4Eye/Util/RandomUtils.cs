
using System;

namespace Eyes4Eye.Utils
{

    public class RandomUtils
    {   
        //Generate number in range inclusive
        public static int GenRandom(int min, int max)
        {
            UnityEngine.Random.InitState(DateTime.Now.Millisecond);
            return UnityEngine.Random.Range(min, max + 1);
        }
    }

}