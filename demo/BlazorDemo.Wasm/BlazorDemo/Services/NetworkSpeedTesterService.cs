using System;
using System.Collections.Generic;
using System.Linq;
using BlazorDemo.Data;

namespace BlazorDemo.Services {
    public class NetworkSpeedTesterService : INetworkSpeedTesterService {

        const int min_speed = 80;
        const int max_speed = 200;

        IRandomWrapper rng = RandomWrapperFactory.Create();

        public event EventHandler<Tuple<DateTime, int>> DataReceived;

        public void TestNetworkSpeed() {
            /*BeginHide*/
#if !VISUALTESTS
            /*EndHide*/
            DataReceived?.Invoke(this, Tuple.Create(DateTime.Now, rng.Next(min_speed, max_speed)));
            /*BeginHide*/
#endif
            /*EndHide*/

        }

        public List<Tuple<DateTime, int>> GetInitialData(DateTime end, int pointsCount = 60) {
            /*BeginHide*/
#if VISUALTESTS            
            end = new DateTime(2022, 1, 1, 12, 0, 0);
#endif
            /*EndHide*/
            var points = Enumerable.Range(0, pointsCount).Reverse().Select(n => Tuple.Create(end.AddSeconds(-n), rng.Next(min_speed, max_speed)));
            return points.ToList();
        }
    }
}
