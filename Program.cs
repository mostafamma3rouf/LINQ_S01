using LINQ_S01.DataSource;
using System.Diagnostics;

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

            //var result = Source.ProductList.Select(P => new
            //{
            //    Name = P.ProductName,
            //    Price = P.UnitPrice,
            //    StockStatus = P.UnitsInStock > 0 ? "Available" : "Out of Stock"
            //});

            #endregion

            #region 7.Print each product's name along with its position (1-based) in the list. Expected format: 1.Chai, 2.Chang, etc.
            //var result = Source.ProductList.Select((P, I) => $"{I + 1}.{P.ProductName}").ToList();
            //Console.WriteLine(string.Join(", ", result));

            #endregion

            #region 8.Sort ProductList by Category ascending, then within each category, sort by UnitPrice descending.
            //var result = Source.ProductList.OrderBy(P => P.Category)
            //                               .ThenByDescending(P => P.UnitPrice);

            #endregion

            #region 9.Get all products from the "Beverages" category, sorted by UnitsInStock descending. Print name and stock.
            //var result = Source.ProductList.Where(P => P.Category == "Beverages")
            //                               .OrderByDescending(P => P.UnitsInStock)
            //                               .Select(P => new {P.ProductName, P.UnitsInStock});

            #endregion

            #region 10.Using QUERY SYNTAX with a compound from clause, list all orders placed in 1997 or later showing CustomerID and OrderDate.
            var result = from Cutomer in Source.CustomerList
                         from OrderItem in Cutomer.Orders
                         where OrderItem.OrderDate.Year >= 1997
                         select new { Cutomer.CustomerID, OrderItem.OrderDate };

            #endregion

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
