namespace Grocery.Core.Models
{
    public class GroceryListItem : Model
    {
        private int groceryListId;
		public int GroceryListId
        {
            get
            {
                return groceryListId;
            }
            set
            {
				groceryListId = value;

			}
        }


		private int productId;     //To do: change it to a property
		public int ProductId
		{
			get
			{
				return productId;
			}
			set
			{
				productId = value;

			}
		}


		public int Amount { get; set; }
        public GroceryListItem(int id, int groceryListId, int productId, int amount) : base(id, "")
        {
            //To do:assign values to the properties
        }

        public Product Product { get; set; } = new(0, "None", 0);
    }
}
