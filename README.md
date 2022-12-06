**TBMRS Help Documentation**

**“_The Best Movie Rental System_”**

**Login Screen**

The login screen will be used for the user to login into TBMRS, the screen will prompt the user for an ID, next the user will select if they want to log in as an Employee or Customer. After a successful login, the user will be redirected to the Employee or the Customer Screen. 

**Rental Screen**

The Rental Screen will be for the customers to Rent the movies. 



* The customer will search for a movie and choose a pickup day.
* The customer will then hit rent movie to pick the movie.
* This movie will be added to the customer’s queue.
* A Movie will be rented for 7 days.

The customer will be presented with a list of available rentals. 

**Account Screen**

The account screen is for customers to use to make changes to their information (name, membership, address, and payment). 



* To make changes to the account, users need to fill in the information they wish to change in the respective field and click edit information. 

**Employee Screen**

The Employee screen is used to add a new employee to the database. This is done by filling out essential fields such as the First Name, Last Name, Their hourly wage and their phone number. The screen also collects their social security number, City, State and their ZIP code. An employee will also be assigned an ID and a Position selected by the user. After filling out all the neccessary information the employee will hit the Add button and a new employee will be added to the system.

An employees information can also be edited or deleted



* Editing can be done by filling the information that needs to be edited, filling the Employee ID and clicking the “Edit Employee” Button
* An employee can be deleted by filling the Employee ID and hitting the “Delete” Employee Button. 

The Employee Screen also has a table of the employees currently working for TBMRS. 



* Employees can be searched based on their Employee ID, Name, Phone Number, Wage,Address. 
* The “Reset table” button is used to refresh the table. 

**Customer Screen** 

The Customer screen is used to add a new Customer to the database. This is done by filling out essential fields such as the First Name, Last Name, Credit Card and their phone number. The screen also collects their Email, Account type, City, State and their ZIP code. A Customer will also be assigned an ID. After filling out all the neccessary information the Customer will hit the Add button and a new customer will be added to the system. 

Just like the Employee screen, 

An Customers information can also be edited or deleted



* Editing can be done by filling the information that needs to be edited, filling the Customer ID and clicking the “Edit Customer” Button
* A Customer can be deleted by filling the Customer ID and hitting the “Delete” Customer Button. 

The Customer Screen also has a table of the Customers currently working for TBMRS. 



* Customers can be searched based on their Customer ID, Name, Phone Number, Address and AccountType
* The “Reset table” button is used to refresh the table. 

**Movie Screen **

This screen uses tabs for navigation and has the following tabs →   



* Add - Employee needs to fill in all the necessary details required (includes movie title, Available copies, Rental Fee, Distribution fee) for the information to be added
* Delete - Employees needs to Either Search by name or by Movie ID, when Submit is hit, a message box should appear letting the user know the title of the movie that was deleted
* Update - This screen asks employees to enter the ID of the Movie they wish to edit the details of. 
* Search - This screen is for the employee to search a specific movie, this can be done in multiple ways 
    * Either by MovieID, Genre, Available Copies, Rental Fee
    * All of the movies can also be listed by clicking on the “List all movies button”

**Actor Screen **

The actor screen is for the employee to add and manage actors' information in the database.

Add,Delete,Update Tab



* Add - user needs to fill the actor’s information into  the first name, last name, gender and date of birth text box. When the ‘add’ button is clicked, that actor will be added into the database with an auto-generated ID.
* Delete - to delete an actor off of the database, the actor ID is needed in the actor ID box.
* Update - actor ID is needed in the actor ID box in order to change that actor information, fill the information that needs to be updated in the respective box.

Search tab



* Users pick which information they want to use to search using the combo box and fill the information in the box beside the combo box.
* Users can combine different information to get more accurate results.

Actor Career tab



* To add a movie into an actor career, the user will need the actor id and the movie id. Movie id can be acquired by clicking the search move button which will open up the movie screen.

**Report Screen **

The report screen contains tabs with various reports an employee or manager may need.



* Sales Report
    * Displays the total revenue for the different account types in the given month.
    * Select a day in the month you wish to get a report from from the date picker. Day doesn’t matter. Only the month will be taken into account.
* Current Orders
    * Click Generate to create or refresh the list of current orders
    * Displays:
        * Customer Name
        * Movie Title
        * Number of copies currently rented by user
        * Return date for the movie
* All Orders
    * Click Generate to create or refresh the list of current orders
    * Displays:
        * Customer Name
        * Movie Title
        * Number of copies currently rented by the user
        * Date order was made
        * Pick-up date for the order
        * Drop-off date for the order
* Highly Rated Movies
    * Click Generate to create or refresh the list of highest rated movies ranked from highest to lowest.
    * Displays:
        * Movie Title
        * Movie Genre
        * Movie Rating
        * Times the movie has been rented
* Customers
    * Click Generate to create or refresh the list of all customers.
    * Displays:
        * Customer ID number
        * Customer Full Name
        * Customer Account Type
        * Customer Rating
* Customer Mailing List
    * Click Generate to create or refresh the list of all customers that need orders mailed to them.
    * Displays:
        * Customer Full Name
        * Customer E-Mail Address
        * Customer Mailing Address
        * Movie Title
        * Pick-up date for order
        * Date Order was made
* Most Active Employee
    * Click Generate to create or refresh the list of employees ranked by orders handled.
    * Displays:
        * Employee Full Name
        * Orders Handled
       
       
  **Thank you for reading!**
