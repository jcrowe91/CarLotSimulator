using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{

    class Car
    {
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string HornNoise { get; set; }
        public string EngineNoise { get; set; }
        public bool IsDriveable { get; set; }

       public static string MakeEngineNoise(string noise)
        {
            return noise; 
        }
        public static string MakeHonkNoise(string noise)
        {
            return noise;
        }
    }
}
