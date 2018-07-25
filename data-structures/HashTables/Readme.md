# Hash Tables

# Description
A hash table is a data structure of key/value pairs, similar to dictionaries. 
Unlike dictionaries, the organization is based on the hash code value of the key. 
They can be organized to look like a number of other structures, but I find Linked Lists to be the easiest to conceptualize.

The hashing of the key is used to help make the values unique, but in the event that the hashing results in multiple indexes of the same value,
they will be added into the Linked List/Binary Tree/Whatever you're using, that's at that index. These situations are known as colisions. 


This table has Add, Find, Contains, and can ascii value-ify a string. It also accounts for collisions. collision test strings provided by classmates
## Visual

![console visual](https://github.com/MinMaxed/Data-Structures-and-Algorithms/blob/master/assets/HashTable.png)

