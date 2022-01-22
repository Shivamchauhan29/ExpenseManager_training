namespace ExpenseManager.Models
{
    public class Category
    {
        public int Id;
        public string Title;
        public string Description;
        public CategoryType CategoryType;
        public DateTime CreatedOn;
        public DateTime UpdatedOn;
    }
    public enum CategoryType
    {
        Income,
        Expense
    }
}
