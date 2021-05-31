The [Pivot Grid](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPivotGrid-1) component summarizes data from the underlying data source and presents the results in cross-tabulated format. This demo allows you to browse sales data - number of sales and their amount - summarized against geographical regions and time intervals.

Note how the following Pivot Grid Fields are set up:

*   **Count** - Bound to the OrderId field and uses the Count summary function to display the number of transactions.

*   **Amount** - Bound to the Amount field and uses the Sum function. (You can also use Min, Max, and Average in addition to the two functions already mentioned.)

*   **Year, Quarter** - Both are bound to the same underlying data field, but use different GroupInterval values thus building a hierarchy of years and quarters.

Try expanding row/column values to reveal a more detailed view or collapsing them to return to the overall picture, respectively. Click headers, such as Region or Year, to change the order of values. Note the automatically calculated section sub-totals and grand totals.
