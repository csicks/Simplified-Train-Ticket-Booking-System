# Simplified-Train-Ticket-Booking-System
Implementation of a  simplified Client/Server train ticket booking system.

Instructions for the software and comments in the program are mainly in Chinese.

Notice:

- Before running the [Train_Server](./Train_Server/Train_Server/Program.cs), you need to have access to the corresponding database [Access](https://www.microsoft.com/en-ww/microsoft-365/access). Then you need to put the [Database1.accdb](./Database1.accdb) in a proper place and change the corresponding address in Train_server ([Form2.cs](./Train_Server/Train_Server/Form2.cs), [Form3.cs](./Train_Server/Train_Server/Form3.cs) and [Form6.cs](./Train_Server/Train_Server/Form6.cs). 

- Before running the [The_Trainbooking_Server](./The_Trainbooking_Server/The_Trainbooking_Server/Program.cs), you need to have the Train_Server running correctly and connected to Internet. Then you need to change the target IP "TIP" in [Server.cs](./The_Trainbooking_Server/The_Trainbooking_Server/Server.cs) in The_Trainbooking_Server to the IP of the Train_Server, which must be a constant value.

- As for the password, you may check the [Database1.accdb](./Database1.accdb) to find the username and the password for each account. You may also need to check [Form1.cs](./Train_Server/Train_Server/Form1.cs) in Train_Server to find the password for the server.

Actually, this version is not well developed as it's done in a few days, which leads to only a few functions and even some potential problems. This program is released to commemorate that period and provide novices like me a rough example of how to do program like this.


Finished in 2017.
