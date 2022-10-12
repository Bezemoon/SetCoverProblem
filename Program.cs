using System;
using System.Collections.Generic;


namespace SetCoverProblem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<string> states = new List<string> { "mt", "wa", "or", "id", "nv", "ut", "ca", "az" };

            Dictionary<string, List<string>> stations = new Dictionary<string, List<string>>();
            stations["kone"] = new List<string> {"id", "nv", "ut"};
            stations["ktwo"] = new List<string> {"wa", "id", "mt"};
            stations["kthree"] = new List<string> {"or", "nv", "ca"};
            stations["kfour"] = new List<string> {"nv", "ut"};
            stations["kfive"] = new List<string> {"ca", "az"};

            SetCoverProblem setCoverProblem = new SetCoverProblem(states, stations);

            foreach (var station in setCoverProblem.GetBestStations())
            {
                 Console.WriteLine(station);
            }
        }
    }
}