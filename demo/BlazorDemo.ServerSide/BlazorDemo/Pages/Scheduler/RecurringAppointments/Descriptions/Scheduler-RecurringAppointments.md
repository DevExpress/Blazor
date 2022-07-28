
This demo shows how to set up recurring appointments for the [Scheduler](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler) component. Note that the data object for a recurring appointment should contain the [DxSchedulerRecurrenceInfo](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerRecurrenceInfo) field (see the code above) to use this functionality.

The control UI allows users to create, edit, and delete recurring appointments.

**Create Recurring Series**

Select a value other than **Never** in the **Appointment** form’s **Repeat** section to create a recurring appointment series. The **Recurrence Rule** form appears. Fill in the fields to specify the recurrence rule and click **Save**.

**Edit Recurring Series**

To edit a recurring appointment, click it to show its tooltip and click the **Edit** button. A dialog appears.

* Click **Edit series** to invoke the **Appointment** form that allows you to modify the recurrence pattern and recurrence rule. Click **Save** to save changes to the pattern.
* Click **Edit appointment** to invoke the **Appointment** form without the **Repeat** section. Click **Save** to create a new appointment that is the recurrence exception.


**Delete Recurring Appointment or Series**

Click the recurring appointment to show the appointment tooltip and click the **Delete** button. A dialog appears.

* Click **Delete series** to delete the recurrence pattern and all appointments that belong to a series.
* Click **Delete appointment** to remove the recurring appointment.