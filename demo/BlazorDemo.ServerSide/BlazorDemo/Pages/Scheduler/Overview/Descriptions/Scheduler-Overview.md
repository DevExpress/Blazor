The DevExpress [Scheduler](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler) for Blazor is a full-featured scheduling solution that easily displays a detailed snapshot of events/appointments in your web application across a single day, a week, or a month.


The Scheduler component ships with the following built-in features: 

**View Types**  
Scheduler can contain the following views: Day View, Week View, Work Week View, Month View, and Timeline View. When you define multiple views, the Scheduler displays a view selector that allows users to switch between views. Use the [ActiveViewType](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler.ActiveViewType) property to specify the active view. If the property is not specified, the Scheduler initially shows the first defined view.

**Drag & Drop Support**  
Scheduler allows users to drag and drop appointments across the view.

**Data Binding**  
To bind the Scheduler component to a data source, create and configure a [DxSchedulerDataStorage](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerDataStorage) object and link it to the Scheduler component.

**Appointment Editing**  
The control implements two appointment edit forms: a compact edit form and a pop-up (detailed) edit form that allows users to edit appointments.

The following properties allow you to prevent users from creating, updating, and deleting appointments: [AllowCreateAppointment](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler.AllowCreateAppointment), [AllowEditAppointment](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler.AllowEditAppointment), and [AllowDeleteAppointment](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler.AllowDeleteAppointment).

**Recurring Appointments**  
Scheduler allows you to create, modify, and delete appointments that repeat on a schedule. You can manage recurring appointments in code or use a pop-up (detailed) edit form.


**Templates**  
You can use templates to customize the content and appearance of time cells, date headers, and resource headers in the Scheduler.
