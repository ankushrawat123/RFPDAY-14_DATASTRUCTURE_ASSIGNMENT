// See https://aka.ms/new-console-template for more information
using RFPDAY_14_DATASTRUCTURE_ASSIGNMENT;
Console.WriteLine("WELCOME TO LINKED LIST PROGRAM!\n");
Console.WriteLine("Enter \n1 for SIMPLE LINKED LIST PROGRAM \n2 for Ability TO CREATE LINKED LIST AND ADDING NEW NODES IN FRONT PROGRAM \n3 to CREATE LINKED LIST AND ADD NEW NODES IN ND");
int num = Convert.ToInt32(Console.ReadLine());
switch (num) 
{
 case 1:
        SimpleLinkedList linkedlistobj = new SimpleLinkedList();
        linkedlistobj.simpleLinkedList();
        Console.WriteLine("Simple Linked List of 56, 30, 70");
        linkedlistobj.display();
 break;

 case 2:
        CreatingNewNode Nodesobj = new CreatingNewNode();
        Nodesobj.NewNodeAtFront(70); //Node with data 70 is First Created
        Nodesobj.NewNodeAtFront(30); //Next 30 is added to 70 in front of it
        Nodesobj.NewNodeAtFront(56); //Finally 56 is added to 30
        Nodesobj.print();
 break;

 case 3:
        CreatingNodeAtEnd EndNodeobj = new CreatingNodeAtEnd();
        EndNodeobj.NewNodeAtEnd(56);
        EndNodeobj.NewNodeAtEnd(30);
        EndNodeobj.NewNodeAtEnd(70);
        EndNodeobj.print();
 break;

        
}