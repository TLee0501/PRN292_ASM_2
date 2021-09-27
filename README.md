# PRN292_ASM_2
- Create a dll assembly named MyBookLibrary.dll. This assembly is used to manage books in which the detail of a book includes: ID, name, publisher, and price. The assembly must provide the following features: 
  1. A list to store all books.
  2. A method to add a new book. All the details of a book are provided by users.
  3. A method to update an existing book from the list. The user will be asked to provide the ID of the book
  4. A method to delete an existing book from the list. The user will be asked to provide the ID of the book
- Create a client console application to use the MyBookLibrary.dll to mange books. The client application must provide the following features:
  1. Show a menu for users to select actions. For example: 
      + Add new book, 
      + Update a book, 
      + Delete a book, 
      + List all book, 
      + Quit.
   2. Depend on each feature selected by users, the program must show an appropriate message asking users to supply necessary parameters. For example, if users selected updating  a book, then the program must ask users to provide a book ID.
   3. When the user selects the deleting feature, the program must ask if the user really wants to delete that book. If the user answer “yes”, then the program will call the delete method in the MyBookLibrary.dll to delete the book from the list.
   4. After the actions: add new book, update book, delete book; the program must show an appropriate message to indicate the status of the action, which is success or failure
