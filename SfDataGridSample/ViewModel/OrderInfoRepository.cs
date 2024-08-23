using System.Collections.ObjectModel;
namespace SfDataGridSample
{
    public class OrderInfoRepository
    {
        private ObservableCollection<OrderModel> orderInfo;
        public ObservableCollection<OrderModel> OrderInfoCollection
        {
            get { return orderInfo; }
            set { this.orderInfo = value; }
        }

        public OrderInfoRepository()
        {
            orderInfo = new ObservableCollection<OrderModel>();
            this.GenerateOrders();
        }

        public void GenerateOrders()
        {
            orderInfo.Add(new OrderModel("1001", "Maria Anders", "Germany", "ALFKI", "Berlin",false));
            orderInfo.Add(new OrderModel("1002", "Ana Trujillo", "Mexico", "ANATR", "Mexico D.F.",false));
            orderInfo.Add(new OrderModel("1003", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.",false));
            orderInfo.Add(new OrderModel("1004", "Thomas Hardy", "UK", "AROUT", "London",false));
            orderInfo.Add(new OrderModel("1005", "Tim Adams", "Sweden", "BERGS", "London",false));
            orderInfo.Add(new OrderModel("1006", "Hanna Moos", "Germany", "BLAUS", "Mannheim",false));
            orderInfo.Add(new OrderModel("1007", "Andrew Fuller", "France", "BLONP", "Strasbourg",false));
            orderInfo.Add(new OrderModel("1008", "Martin King", "Spain", "BOLID", "Madrid",false));
            orderInfo.Add(new OrderModel("1009", "Lenny Lin", "France", "BONAP", "Marsiella",false));
            orderInfo.Add(new OrderModel("1010", "John Carter", "Canada", "BOTTM", "Lenny Lin",false));
            orderInfo.Add(new OrderModel("1011", "Laura King", "UK", "AROUT", "London",false));
            orderInfo.Add(new OrderModel("1012", "Anne Wilson", "Germany", "BLAUS", "Mannheim",false));
            orderInfo.Add(new OrderModel("1013", "Martin King", "France", "BLONP", "Strasbourg",false));
            orderInfo.Add(new OrderModel("1014", "Gina Irene", "UK", "AROUT", "London",false));
        }
    }
}
