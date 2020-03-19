# Checkout Kata

Based on [https://rubygem.me/2014/01/16/shopping-cart-kata/](https://rubygem.me/2014/01/16/shopping-cart-kata/)


# The problem
Implement the code for a supermarket checkout that calculates the total price of a number of items placed into a basket. Goods are priced individually, however there are weekly special offers for when multiple items are bought. For example “Apples are 50 each or 3 for 130”.

Weekly offers change frequently.


|         SKU    |Unit Price                          |Special Offer
|----------------|-------------------------------|-----------------------------|
|A99|50|3 for 130|
|B15|30|2 for 45|
|C40|60||
|T34|99||




The checkout accepts the items in any order, so that if we scan a pack of Biscuits (B15), an apple (A99) and another pack of biscuits, we’ll recognise two packs of biscuits and apply the discount of 2 for 45.



## Your task

Please [fork](https://help.github.com/en/github/getting-started-with-github/fork-a-repo) this repo and implement the above requirements spending no more than 60 minutes. When you've done that please send the url of your solution to your representative..
