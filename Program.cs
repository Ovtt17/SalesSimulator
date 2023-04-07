/*Escriba un programa en C# que permita simular una venta. Se debe introducir el
nombre del producto que se está comprando, su precio y la cantidad. El programa
debe imprimir el total a pagar, suponiendo que se aplica un 10 % de descuento.*/

using System;

namespace SalesSimulator
{
  class Program
  {
    static void Main(string[] args)
    {
      // Ask for the name of the product
      Console.Write("Enter the name of the product: ");
      string productName = Console.ReadLine();

      // Ask for the price of the product
      Console.Write("Enter the price of the product: ");
      double productPrice = double.Parse(Console.ReadLine());

      // Ask for the quantity of products
      Console.Write("Enter the quantity of products: ");
      int quantity = int.Parse(Console.ReadLine());

      // Calculate the total price without discount
      double totalWithoutDiscount = productPrice * quantity;

      // Calculate the total price with discount
      double discount = totalWithoutDiscount * 0.1;
      double totalWithDiscount = totalWithoutDiscount - discount;

      // Print the total price with discount
      Console.WriteLine($"The total price for {quantity} {productName}(s) is: {totalWithDiscount:C}");
    }
  }
}
