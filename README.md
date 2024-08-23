# How to select rows with checkbox and delete the selected rows in .NET-MAUI-DataGrid.
In this article, we will show you how to select rows with checkbox and delete the selected rows in [.Net Maui DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid). The dataGrid_CellValueChanged method updates the selection in the data grid based on changes in the "IsChecked" column. It adjusts the selected index and removes unchecked rows from the selection, ensuring the data grid stays accurate.

The Button_Clicked method handles the button click event by removing selected rows from the dataGrid. It retrieves the view model and gets the list of checked items. If there are any, it removes them from the OrderInfoCollection and clears the dataGrid selection.

## C#
The below code illustrates how to select rows with checkbox and delete the selected rows in DataGrid.
```
List<int> index = new List<int>();

private void dataGrid_CellValueChanged(object sender, Syncfusion.Maui.DataGrid.DataGridCellValueChangedEventArgs e)
{
    var rowData = e.RowData as OrderModel;
    if (e.Column.MappingName == "IsChecked")
    {               
        
        this.dataGrid!.SelectedIndex = e.RowColumnIndex.RowIndex;
        Debug.WriteLine(e.RowColumnIndex.RowIndex);
        int num = e.RowColumnIndex.RowIndex;
        this.dataGrid!.SelectedIndex = num;
        
    }
    if (e.Column.MappingName == "IsChecked" && !(rowData.IsChecked))
    {
        this.dataGrid!.SelectedRows.Remove(rowData);
    }
    
}

private void Button_Clicked(object sender, EventArgs e)
{
    var model = this.viewModel!;
    OrderInfoRepository orderInfoRepository = model;
    int count = index.Count;
    var selectedItems = model.OrderInfoCollection.Where(item => item.IsChecked).ToList();
    if (selectedItems.Any())
    {
        // bool deleteConfirmed = DisplayAlert("Delete Rows", "Do you want to delete the selected rows?", "Yes", "No").Result;
        if (true)
        {
            foreach (var item in selectedItems)
            {
                model.OrderInfoCollection.Remove(item);
            }
        }
    }
    
    this.dataGrid!.ClearSelection();
}
```

 ![LatestDemo.gif](https://support.syncfusion.com/kb/agent/attachment/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjI4NjEwIiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.ZcbBg4qpIUpZ6iLub_bbzmMmIJLbnR1tb7Pvmmhc86I)

[View sample in GitHub](https://github.com/SyncfusionExamples/How-to-select-rows-with-check-box-and-delete-the-selected-rows-in-.NET-MAUI-DataGrid)

Take a moment to explore this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more information about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples. Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid (SfDataGrid).
 
##### Conclusion
 
I hope you enjoyed learning about how to select rows with checkbox and delete the selected row in .NET MAUI DataGrid (SfDataGrid).
 
You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. 
For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.
 
If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!