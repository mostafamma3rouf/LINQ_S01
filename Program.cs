using LINQ_S01.DataSource;

namespace LINQ_S01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.Get all products from the "Seafood" category.Print each product's name and price.
            //var result = Source.ProductList.Where(P => P.Category == "Seafood")
            //                               .Select(P => new { P.ProductName, P.UnitPrice });

            #endregion

            #region 2.Get a list of only the product names from ProductList. Print each name.
            var result = Source.ProductList.Select(P => P.ProductName);

            #endregion

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
