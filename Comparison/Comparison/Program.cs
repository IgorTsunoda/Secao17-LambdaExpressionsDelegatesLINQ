using Comparison.Entities;

namespace Comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("TV", 1900.00));
            list.Add(new Product("Notebook", 4000.00));
            list.Add(new Product("Freezer", 1800.00));

            Comparison<Product> comp = CompareProducts;

            list.Sort(CompareProducts);

            foreach (Product product in list)
            {
                Console.WriteLine(product);
            }
        }

        static int CompareProducts(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
    }
}
