/* 
Pladd-Dot : Daylan Post
This is the code for holding the information for our products.
We will try and use the iterator design pattern in order to best fit a database
This is our first attempt and trial run
!!! Try to have a working prototype by the 4th !!!
 */

using System;

public class ProductInfo{

  string productName;
  double productPrice;
  int productId;

  //Constructor takes in productName, productPrice, and productId
  public ProductInfo(string productName, double productPrice, int productId){
    productName = this.productName;
    productPrice = this.productPrice;
    productId = this.productId;
  }

  public string getProductName(){
    return productName;
  }

  public double getProductPrice(){
    return productPrice
  }

  public int getProductId(){
    return productId;
  }

 }

 class TestProduct{
   static void Main(){
     var product1 = new ProductInfo("Guitar", 7.99, 1007);
     Console.WriteLine(product1.getProductName())
    
   }
 }