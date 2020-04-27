In this repository, I will be describing and protraying my sample interface, that the user may encounter based on a given sysnopsis.

To begin with the task was to create and populate a database using a certain dataset, this dataset included users, workplaces, univeristies, friends and messages which all linked to the user using a primary key. 
But before I could create and populate the database I had to create UML diagrams, such as Entity Relationship Diagrams, class diagrams, sequence and state diagrams, which were completed by me normalising the data into third normal form. 

The diagrams described above are found in my report. 

So for the sample interface. 

First of all was to create the connection between the interface and the database, this can be found in the file DBConnection in the file section above. 
Next I wanted to create a simple log in screen, to replicate what the user would have to go through to access their profile,  this can be seen below. 

![login](https://user-images.githubusercontent.com/57363879/80374827-3474eb80-888f-11ea-8c68-cb19f75ad06f.PNG)

I will be discussing improvements at the end. 


When the user logs in, they will be presented with their profile, this is done through a simple query that gets the users ID from the textbox on the log in page and collects all the data from the users table in the database using the ID. 
The user's personal information such as gender or hometown, are found through selecting the column in the table and displaying them in a textbox. 

![usersprofile](https://user-images.githubusercontent.com/57363879/80376469-c251d600-8891-11ea-9f35-122a6763db84.PNG)
  
  
Also on the profile page, the user can identify the friends that they currently have, as well as the messages they have sent, the message table was a simple query where the datagrid is populated with all the information in the message table where the user ID is the same as the one in the log in page. 
Whereas the friends datagrid was a bit harder to pull off, as I had to inner join the user table with the friends table, this was to find the friend id and use it in the user table to display the first and last name of the friend/s. 



![userProfile2](https://user-images.githubusercontent.com/57363879/80376508-d269b580-8891-11ea-970a-3b4ad685704e.PNG)
  

Included on the profile page are the workplaces and the universities the user has attended or currently attending. If the user has no universities or workplaces then the datagrid table will be empty. 



Improvements:

There are a few improvements that I would make, for example instead of using datagrids, I could have used listboxes to display the data better and clearer for the user to view, following from this I would enable the user to click on the friend they have to view any message that have been sent to them. 

Additionally, I would also enable the user to add, edit or delete any part of their profile, whether it be removing friends, or editing their home town, they could do this through a separate form that loads when they click on edit profile or remove friends. 

Finally, I would also change the login page to incorporate a password box, because at the moment anyone could type in a userID and access that profile, however this would need to be included on the users table in the database. 







