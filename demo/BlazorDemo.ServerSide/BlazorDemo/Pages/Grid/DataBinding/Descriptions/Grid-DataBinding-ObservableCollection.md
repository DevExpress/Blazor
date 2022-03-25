You can bind our Blazor [Grid](https://docs.devexpress.com/Blazor/403143/grid) to a data collection that implements the [INotifyCollectionChanged](https://docs.microsoft.com/dotnet/api/system.collections.specialized.inotifycollectionchanged) or [IBindingList](https://docs.microsoft.com/dotnet/api/system.componentmodel.ibindinglist) interface. This collection notifies the Grid about relevant changes (when items are added or removed, when the entire collection is refreshed, etc). The Grid will update its data automatically to reflect appropriate changes.  
 
Each item in the collection should also implement the [INotifyPropertyChanged](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.inotifypropertychanged) interface to notify the Grid when a property value is changed. 

This demo illustrates real-time data update support within our Blazor Grid (when bound to the standard [ObservableCollection\<T>](https://docs.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1)).
 
**Note**: The data used in this demo is for demonstration purposes only. The demo generates synthetic stock quote data.