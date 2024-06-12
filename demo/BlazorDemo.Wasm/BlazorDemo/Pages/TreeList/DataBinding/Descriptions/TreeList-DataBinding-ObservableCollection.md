You can bind our Blazor TreeList to a data collection that implements the [INotifyCollectionChanged](https://docs.microsoft.com/dotnet/api/system.collections.specialized.inotifycollectionchanged) or [IBindingList](https://docs.microsoft.com/dotnet/api/system.componentmodel.ibindinglist) interface. This collection notifies the TreeList about relevant changes (when items are added or removed, when the entire collection is refreshed, etc). The TreeList listens to these notifications and updates its data automatically.
 
To enable automatic data updates for individual cells, the item object should implement the [INotifyPropertyChanged](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.inotifypropertychanged) interface. 

This demo illustrates real-time data update support when using our Blazor TreeList within a DevExpress-powered Blazor app (when bound to the standard [ObservableCollection\<T>](https://docs.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1)).

**Note**: The data used in this demo is not real and is for demonstration purposes only. The demo generates random stock quote data.
