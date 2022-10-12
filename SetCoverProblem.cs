using System.Collections.Generic;
using System.Linq;

namespace SetCoverProblem
{
    public class SetCoverProblem
    {
        private List<string> _states;
        private Dictionary<string, List<string>> _stations;
        private List<string> _finalStations;

        public SetCoverProblem(List<string> states, Dictionary<string, List<string>> stations)
        {
            _states = states;
            _stations = stations;
            _finalStations = new List<string>();
        }

        public List<string> GetBestStations()
        {
            while (_states.Count > 0)
            {
                string bestStation = null;
                List<string> states_covered = new List<string>();
                foreach (string station in _stations.Keys)
                {
                    var statesForStation = _stations[station];
                    var covered = _states.Intersect(statesForStation).ToList();
                    if (covered.Count > states_covered.Count)
                    {
                        bestStation = station;
                        states_covered = covered;
                    }
                }
            
                _states = _states.Except(states_covered).ToList();
                _finalStations.Add(bestStation);   
            }

            return _finalStations;
        }
    }
}