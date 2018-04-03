1. Background Information

	a) We are tasked to create a Library Management system to support the routine operations of a library. 
	The routine operations of the library would consist of the folowing:

		1) Creation and Maintenance of Member information(form)
		2) Creation and maintenance of Book information(Form)
		3) Creation and maintenance of any other key entity (if you think necessary)
		4) Query facility to search for books based on various citeria(Form)
		5) Query of avaliablity date for books on loan(Form)
		6) Lending of books(business transaction)- (Form or Forms)
		7) Returning of Books(business transactions) - (Form or Forms)
		8) Sample reports consisting of one simple report(eg: list of books), one management report(eg: cross tab report), one transaction output(eg:Borrow receipt) and one chart(eg. Trend or Pie Chart)
	

2. Our Defined Scope

	a) Our assumed library is a single floor library with only 10 shelves.

	b) What Librarians need to do with our proposed system?
	We are assuming the library customers are borrowing and returning books through the librarians.
	In addition to borrowing and returning the books, the librarians also need to manage the book details records, customer detail records and generate reports, as follows:

		1)Manage Books
			a)Search for a specific book by filters
			b)Add a new book to the Library
			c)Modify a specific book's details
			d)Display only avaliable books for loan
			d)Locate a specific book's shelf location in the library floor plan

		2)Manage Customers
			a)Search for a specific customer by customer name or by customer ID
			b)Add a new customer
			c)Modify a specific customer's details
			d)Delete a specific customer

		3)Borrow Books
			a)Search for a specific customer
			b)search for a specific book
			c)Add a specific book to a basket of books to be borrowed
			d)remove a specific book from a basket books to be borrowed
			e)Borrow Books
			d)Generate a borrow receipt for the customer
			e)Cancel borrowing books 

		4)Returning Books
			a)Search for a specific customer
			b)Display the specific customer's borrowed books
			c)Return each of the specific customer's borrowed books separately
			d)Record any lost book by the customer

		5)Generate Reports
			a)generate simple report
			b)generate cross tab report
			c)generate a chart


	c) What Customer can do with our proposed system?
	The library customers can search for a book in the library's booklist and locate the bookshelf location in the library floor plan using our proposed system, as follows:
	
		1)Search for a specific book by filters
		2)Locate the book shelf in the library plan where the book is put in


3.UI Design

	a)We are maintaining a consistent User interface layout for all our forms. This will allow our program to maintain the same look,feel and orientation throughout all forms.
	The proposed user interface consists of:

		1) A long tool Strip of width 66 at the top edge of the form
		2) A right side bar of width 400 at the right edge of the form


4.OOP/OOAP Proof-Of-Concept Demonstrated

	a) Object Reuse with Inheritance

		1) Parent form for form Layout
		2) Reuse of SearchForCustomer form to query customers database in BorrowBook Form and ReturnBook Form 
		3) Reuse of ManageBook form in Librarian Program, Customer Program and SeachForBook Interface

	b) USe of Interface

		1) ManageBooks Class is implementable with SearchforBooks Interface. BorrowBook Form calls the SeachForBook Interface method from ManageBook Class to search for Books.


5.Database Proof-Of-Concept Demonstrated
	
	a) Use of Views for Crystal Reports

		1)Created a GenreBorrowed View Table for generating Borrowing Trend Report
		2)Created a DuePayment View Table for generating Customer Due Report

	b) Enforcing Integrity Through Keys

		1)Every table that has to be updated will have a Primary keys, as follows:
			a)Booklists
			b)LibraryMembers
			c)IssueTrans
			d)BooksIssues
			e)DueTrans

		2) Table that does not to be updated will have a Primary keys, as follows:
			a)BooksRequested

		
6.Reports Proof-Of-Concept Demonstrated

	a) Crystal Reports Generated 
	
		1) Borrowed Receipts
		2) List of Books
		3) List of Requested Books
		4) Customer Due Report

	b) Chart Report Generated
	
		1) Borrowing Trend


7.Value-Added Features Proof-Of-Concept Demonstrated

	a) Short Cuts Used

		1)Control 1 -5 button on keyboard to access 1)Manage Books, 2)Manage Customers, 3)Borrow Books, 4)Returning Books, 5)Generate Reports tabs respectively from main menu
		2)Esc button on keyboard to exit to main menu.










