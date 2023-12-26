The GestionDeLivre application is a Windows Forms application designed for the management of a simple book inventory. It provides a graphical user interface for users to add, update, and delete book records in a SQLite database. The application targets systems where the .NET Framework is installed and is capable of operating on a range of Windows versions that support this framework.

Application Features:

Database Initialization: Upon launching the application, it checks if the livreDB.db SQLite database file exists. If not found, the application creates the file and sets up a table called livre with columns for ISBN, title, and author.

Data Display: The main window contains a DataGridView control that displays the data fetched from the livre table, making it easy for users to view all records of books with their titles, authors, and ISBNs.

Data Insertion: Users can add new books to the database by entering the book’s title, author, and a unique ISBN. The application ensures that the ISBN is unique before insertion, thereby avoiding duplicate entries.

Data Updating: The application allows users to update the title and author details of a book based on the provided ISBN, ensuring that book records are current and accurate.

Data Deletion: Users can delete book records by specifying the book’s title. After the deletion is completed, the user receives feedback on whether the operation was successful.

User Input Validation: Before performing operations like insertion, updating, or deletion, the application validates user input to ensure that all necessary fields are filled out. It warns the user if any required information is missing.

Exception Handling: The application has basic exception handling mechanisms that catch any errors during database operations and inform the user through message boxes with appropriate error messages or warnings.
