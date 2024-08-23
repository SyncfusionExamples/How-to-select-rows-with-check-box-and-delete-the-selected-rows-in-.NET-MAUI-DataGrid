using System.Diagnostics;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        List<int> index = new List<int>();

        public MainPage()
        {
            InitializeComponent();
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

    }

}
