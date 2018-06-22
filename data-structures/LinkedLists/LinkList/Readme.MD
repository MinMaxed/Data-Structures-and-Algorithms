# Linked Lists

## description
fundamentals of nodes and linked lists, with core methods to be used for manipulating lists. Have tests for added to lists, and finding existing or non existing nodes on the list. 
## visual
![alt text]()


## methods 

 LinkedList ll = new LinkedList();


 AddNode: adds a node to the beginning of the list;   
 ll.AddNode(newNode), ll.AddNode(newNode2) = newNode2 --> newNode --> null

 AddAfter: add a node after a previously existing node;
 ll.AddAfter(existingNode, newNode) = existingNode --> newNode --> otherNode --> null
 

 AddBefore: add a node before a previously existing node;
 ll.AddBefore(newNode, existingNode) = otherNode --> newNode --> existingNode --> null


 AddLast: add a node to the end of the list;
 ll.AddLast(newNode) = existingNode --> otherNode --> newNode --> null


 Find: Find a specified node within the list;
 ll.Find(value) = foundNode.Value;


 Print: Prints nodes to the console;
 ll.Print() = on the Console, node1.Value --> node2.Value --> null