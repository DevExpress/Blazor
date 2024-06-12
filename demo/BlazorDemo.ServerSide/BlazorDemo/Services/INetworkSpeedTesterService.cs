using System;
using System.Collections.Generic;
using DevExpress.Blazor.RichEdit;

namespace BlazorDemo.Services {
    public interface INetworkSpeedTesterService {
        event EventHandler<Tuple<DateTime, int>> DataReceived;

        List<Tuple<DateTime, int>> GetInitialData(DateTime end, int pointsCount = 60);
    }
}
