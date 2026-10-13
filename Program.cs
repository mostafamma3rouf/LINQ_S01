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
            //var result = Source.ProductList.Select(P => P.ProductName);

            #endregion

            #region 3.Sort all products by UnitPrice(ascending). Print each product's name and price.
            //var result = Source.ProductList.Where(P => P.UnitPrice > 0)
            //                               .OrderBy(P => P.UnitPrice)
            //                               .Select(P => new{P.ProductName, P.UnitPrice});

            #endregion

            #region 4.Get all products where UnitPrice is between 10 and 30
            //var result = Source.ProductList.Where(P => P.UnitPrice > 10 && P.UnitPrice < 30);

            #endregion

            #region 5.Get all products that are in stock(UnitsInStock > 0) and belong to the "Condiments" category.
            //var result = Source.ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Condiments");

            #endregion

            #region 6.Create a new anonymous type with three properties: 
            //● Name → the product name
            //● Price → the unit price
            //● StockStatus → a string: "Available" if UnitsInStock > 0, otherwise "Out of Stock"
            //● Print the result.

            var result = Source.ProductList.Select(P => new
            {
                Name = P.ProductName,
                Price = P.UnitPrice,
                StockStatus = P.UnitsInStock > 0 ? "Available" : "Out of Stock"
            });

            #endregion

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
