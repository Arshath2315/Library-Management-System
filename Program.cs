namespace library
{
    internal class Program
    {
        struct Book
        {
            public int UniqueID;
            public string Name;
            public string Author;
            public int Year;
            public double RentalFee;
            public string IsRented;
            public string CanBeSold;
            public double UnitPrice;
            public int Quantity;


        }
        static void Main(string[] args)
        {
            #region Variables

            int employee = 0;
            int client = 0;
            int employeeId = 0;
            string employeeOrClient = "";
            string employeePassword = "";
            string[,] clients = new string[100, 2];
            string[] clientPassword = new string[100];
            int index = 0;
            int index1 = 0;
            int index2 = 0;
            bool signUp = false;
            string[,] newBooks = new string[100, 2];
            int[,] newBookInt = new int[100, 3];
            double[,] newBooksDouble = new double[100, 2];
            string[,] yesNo = new string[100, 2];
            int code = 0;
            int[] lol = new int[100];
            lol[0] = -1;
            int[] lul = new int[100];
            lul[0] = -1;
            int clientId = -1;
            string pass = "";
            bool clientCheck = false;
            int[,] rent = new int[100, 2];
            int xx = 0;
            int[,] sold = new int[100, 2];
            int xxx = 0;
            int[] daysRented = new int[100];
            double[] rentalFee1 = new double[100];
            double[] sellCost = new double[100];
            const int DEFAULTEMPLOYEEID = 111111;
            const string DEFAULTEMPLOYEEPASSWORD = "tester";
            Book[] books = new Book[100];



            Book book1, book2, book3, book4, book5;


            book1.UniqueID = 100000;
            book1.Name = "Wutherings";
            book1.Author = "Emily Bronte";
            book1.Year = 1847;
            book1.RentalFee = 1.50;
            book1.IsRented = "no";
            book1.CanBeSold = "yes";
            book1.UnitPrice = 25;
            book1.Quantity = 2;

            book2.UniqueID = 200000;
            book2.Name = "Monte Cristo";
            book2.Author = "Alexandre.D";
            book2.Year = 1844;
            book2.RentalFee = 2.50;
            book2.IsRented = "no";
            book2.CanBeSold = "yes";
            book2.UnitPrice = 45;
            book2.Quantity = 3;

            book3.UniqueID = 300000;
            book3.Name = "Harry Potter";
            book3.Author = "JK.Rowling";
            book3.Year = 1997;
            book3.RentalFee = 3.50;
            book3.IsRented = "no";
            book3.CanBeSold = "yes";
            book3.UnitPrice = 15;
            book3.Quantity = 2;

            book4.UniqueID = 400000;
            book4.Name = "The Lion";
            book4.Author = "Lewis Las";
            book4.Year = 1950;
            book4.RentalFee = 4.50;
            book4.IsRented = "no";
            book4.CanBeSold = "yes";
            book4.UnitPrice = 35;
            book4.Quantity = 2;


            book5.UniqueID = 500000;
            book5.Name = "Mause second";
            book5.Author = "Art Spegeilman";
            book5.Year = 1991;
            book5.RentalFee = 4.50;
            book5.IsRented = "no";
            book5.CanBeSold = "yes";
            book5.UnitPrice = 20;
            book5.Quantity = 1;
            #endregion

            books[0] = book1;
            books[1] = book2;
            books[2] = book3;
            books[3] = book4;
            books[4] = book5;

            for (int g = 0; g < 100; g++)
            {
                yesNo[g, 0] = "no";
                yesNo[g, 1] = "yes";

            }


            Console.ForegroundColor = ConsoleColor.Green;
            while (true)
            {
                bool signedInAsEmployee, signedInAsClient;
                EmployeeClientSignOut(out employeeOrClient, clientCheck, out signedInAsEmployee, out signedInAsClient);

                if (employeeOrClient == "1")
                {
                    EmployeeSignUp(out employeeId, out employeePassword, DEFAULTEMPLOYEEID, DEFAULTEMPLOYEEPASSWORD, out signUp, out signedInAsEmployee);

                    while (signedInAsEmployee)
                    {
                        EmployeeOptions();

                        while (!int.TryParse(Console.ReadLine(), out employee))
                        {
                            Console.WriteLine("Invalid option value, please try again.");
                        }

                        if ((employee != 1) && (!signUp))
                        {
                            Console.WriteLine("Please enter number 1 to enter EMPLOYEE DATA before anything else.");
                        }

                        else
                        {


                            switch (employee)
                            {
                                case 1:
                                    {
                                        clientCheck = CreateClient(clients, clientPassword, ref index);
                                        break;
                                    }

                                case 2:
                                    {
                                        DataTable(DEFAULTEMPLOYEEID, DEFAULTEMPLOYEEPASSWORD, clients, clientPassword);
                                        break;
                                    }

                                case 3:
                                    {
                                        CreateBook(books, ref index1, ref index2, newBooks, newBookInt, newBooksDouble);

                                        break;

                                    }

                                case 4:
                                    {
                                        LibraryData(books, newBooks, newBookInt, newBooksDouble, yesNo, lol, lul);

                                        break;
                                    }

                                case 5:
                                    {
                                        xx = RentBook(clients, clientPassword, books, newBooks, newBookInt, newBooksDouble, out code, lol, lul, out clientId, out pass, rent, xx, daysRented, rentalFee1, book1, book2, book3, book4, book5);

                                        break;
                                    }

                                case 6:
                                    {
                                        ReturnBook(clients, clientPassword, books, newBookInt, out code, lol, lul, out clientId, out pass, rent);

                                        break;
                                    }

                                case 7:
                                    {
                                        xxx = SellBook(clients, clientPassword, books, newBookInt, newBooksDouble, out code, lul, out clientId, out pass, sold, xxx, sellCost);

                                        break;
                                    }

                                case 8:
                                    {
                                        DisplayRent(rent, daysRented, rentalFee1);
                                        break;
                                    }

                                case 9:
                                    {
                                        DisplaySells(sold);

                                        break;
                                    }

                                case 10:
                                    {
                                        TotalSalesCost(daysRented, rentalFee1, sellCost);

                                        break;
                                    }

                                case 11:
                                    {
                                        signedInAsEmployee = EmployeeExit();

                                        break;
                                    }

                            }

                        }
                        Console.WriteLine();
                        Console.Write("Please press Enter key");
                        Console.ReadLine();
                        Console.Clear();

                    }

                }



                else if (employeeOrClient == "2")
                {
                    ClientSignUp(clients, clientPassword, out clientId, out pass);

                    while (signedInAsClient)
                    {
                        ClientOptions();

                        while (!int.TryParse(Console.ReadLine(), out client))
                        {
                            Console.WriteLine("Invalid option value, please try again.");
                        }

                        switch (client)
                        {
                            case 1:
                                {
                                    ClientRent(clients, clientId, rent, daysRented, rentalFee1);

                                    break;
                                }

                            case 2:
                                {
                                    ClientSold(clients, clientId, sold);

                                    break;
                                }

                            case 3:
                                {
                                    signedInAsClient = ClientExit();

                                    break;
                                }


                        }
                        Console.WriteLine();
                        Console.Write("Please press Enter key");
                        Console.ReadLine();
                        Console.Clear();

                    }

                }
                else if (employeeOrClient == "3")
                {
                    Console.WriteLine("Good bye");

                    Environment.Exit(0);
                }
            }

        }
        /// <summary>
        /// This is where it will show every book that the signed up client bought.
        /// </summary>
        /// <param name="clients"></param>
        /// <param name="clientId"></param>
        /// <param name="sold"></param>
        private static void ClientSold(string[,] clients, int clientId, int[,] sold)
        {
            Console.WriteLine($"Books that {clients[clientId, 0]} {clients[clientId, 1]} Sold");
            Console.WriteLine("CLIENT ID \tSOLD BOOKS ID");
            Console.WriteLine("-----------------------------");
            for (int aa = 0; aa < 100; aa++)
            {
                if (sold[aa, 0] == clientId)
                {
                    Console.WriteLine(sold[aa, 0] + "\t\t" + sold[aa, 1]);
                }

            }
        }
        /// <summary>
        /// This is where it will show every rented book and its information of the client that is signed in at the moment.
        /// </summary>
        /// <param name="clients"></param>
        /// <param name="clientId"></param>
        /// <param name="rent"></param>
        /// <param name="daysRented"></param>
        /// <param name="rentalFee1"></param>
        private static void ClientRent(string[,] clients, int clientId, int[,] rent, int[] daysRented, double[] rentalFee1)
        {
            Console.WriteLine($"Books that {clients[clientId, 0]} {clients[clientId, 1]} Rented");
            Console.WriteLine("CLIENT ID \tRENTED BOOKS ID\tDays rented\tRental price");
            Console.WriteLine("------------------------------------------------------------");
            for (int a = 0; a < 100; a++)
            {
                if (rent[a, 0] == clientId)
                {
                    Console.WriteLine(rent[a, 0] + "\t\t" + rent[a, 1] + "\t\t" + daysRented[a] + "\t\t" + (rentalFee1[a] * daysRented[a]));
                }

            }
        }
        /// <summary>
        /// This is the case where the client wants to exit back to the main menu.
        /// </summary>
        /// <returns>false is the boolean used to tell the program that you do not wish to stay signed as a client so that you get dragged to the main menu.</returns>
        private static bool ClientExit()
        {
            return false;
        }
        /// <summary>
        /// This shows all the options that the client can choose after signing up.
        /// </summary>
        private static void ClientOptions()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("1. Display the books I have rented");
            Console.WriteLine("2. Display the books I have purchased");
            Console.WriteLine("3. Sign Out: to return to the main menu");
            Console.Write("Enter your choice: ");
        }
        /// <summary>
        /// This is the verification for the client that wants to sign up, it will ask for the client ID and password.
        /// </summary>
        /// <param name="clients"></param>
        /// <param name="clientPassword"></param>
        /// <param name="clientId"></param>
        /// <param name="pass"></param>
        private static void ClientSignUp(string[,] clients, string[] clientPassword, out int clientId, out string pass)
        {
            Console.Write("Enter client ID:");
            while (!int.TryParse(Console.ReadLine(), out clientId) || clientId > 100 || clientId < 0)
            {
                Console.WriteLine("Invalid option value, please try again(must be between 0 and 100).");
            }
            while (clients[clientId, 0] == null)
            {
                Console.Write("Client ID doesnt exist please retry:");
                while (!int.TryParse(Console.ReadLine(), out clientId) || clientId > 100 || clientId < 0)
                {
                    Console.WriteLine("Invalid option value, please try again(must be between 0 and 100).");
                }
            }
            Console.Write("Enter client password:");
            pass = Console.ReadLine();

            while (pass != clientPassword[clientId])
            {
                Console.WriteLine("password invalid,please try again");
                Console.Write("Enter client password:");
                pass = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {clients[clientId, 0]} {clients[clientId, 1]}");
            Console.ReadLine();
            Console.Clear();
        }
        /// <summary>
        /// Main menu where you have the option to sign in as an employee or a client unless you want to choose the 3rd option to sign out.
        /// </summary>
        /// <param name="employeeOrClient"></param>
        /// <param name="clientCheck"></param>
        /// <param name="signedInAsEmployee"></param>
        /// <param name="signedInAsClient"></param>
        private static void EmployeeClientSignOut(out string employeeOrClient, bool clientCheck, out bool signedInAsEmployee, out bool signedInAsClient)
        {
            Console.WriteLine("1.Employee Menu");
            Console.WriteLine("2.Client Menu");
            Console.WriteLine("3.Sign out");
            Console.Write("Enter your choice:");
            employeeOrClient = Console.ReadLine();

            while (employeeOrClient != "1" && employeeOrClient != "2" && employeeOrClient != "3" || (employeeOrClient == "2" && clientCheck == false))
            {
                if (employeeOrClient != "2" || string.IsNullOrEmpty(employeeOrClient))
                {
                    Console.Write("invalid choice, please choose again:");
                    employeeOrClient = Console.ReadLine();
                }
                else if (employeeOrClient == "2" && clientCheck == false)
                {
                    Console.WriteLine("you cannot use the option 'Client' until at least 1 client ID gets created.");
                    Console.Write("Enter your choice:");
                    employeeOrClient = Console.ReadLine();
                }
            }

            signedInAsEmployee = true;
            signedInAsClient = true;
        }
        /// <summary>
        /// This shows all the options that the employee can choose after signing up.
        /// </summary>
        private static void EmployeeOptions()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1. Create a client");
            Console.WriteLine("2. Show Data");
            Console.WriteLine("3. Create a book");
            Console.WriteLine("4. Show Library Data");
            Console.WriteLine("5. Rent a book");
            Console.WriteLine("6. Return a book");
            Console.WriteLine("7. Sell a book");
            Console.WriteLine("8. Display all the books rented");
            Console.WriteLine("9. Display all the books sold");
            Console.WriteLine("10. Display the total of sales and rent books");
            Console.WriteLine("11. Back to menu");
            Console.Write("Enter your choice:");
        }
        /// <summary>
        /// This table shows the total money gained from rented books and sold books.
        /// </summary>
        /// <param name="daysRented"></param>
        /// <param name="rentalFee1"></param>
        /// <param name="sellCost"></param>
        private static void TotalSalesCost(int[] daysRented, double[] rentalFee1, double[] sellCost)
        {
            double totalRent = 0;
            double totalSales = 0;
            Console.WriteLine("OPTION 10:Display the total of sales and the total earned by rent books");

            for (int tsr = 0; tsr < 100; tsr++)
            {
                totalRent += (rentalFee1[tsr] * daysRented[tsr]);
                totalSales += sellCost[tsr];
            }
            Console.WriteLine("Total for rent books\tTotal sales");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(totalRent + "\t\t\t" + totalSales);
        }
        /// <summary>
        ///This is where clients will perminantely buy book from the library.
        /// </summary>
        /// <param name="clients"></param>
        /// <param name="clientPassword"></param>
        /// <param name="books"></param>
        /// <param name="newBookInt"></param>
        /// <param name="newBooksDouble"></param>
        /// <param name="code"></param>
        /// <param name="lul"></param>
        /// <param name="clientId"></param>
        /// <param name="pass"></param>
        /// <param name="sold"></param>
        /// <param name="xxx"></param>
        /// <param name="sellCost"></param>
        /// <returns>xxx is an integer used to be inside the arrays that are usualy involved for the sold book table in the future cases.</returns>
        /// Implmented by Georges and Arshat
        private static int SellBook(string[,] clients, string[] clientPassword, Book[] books, int[,] newBookInt, double[,] newBooksDouble, out int code, int[] lul, out int clientId, out string pass, int[,] sold, int xxx, double[] sellCost)
        {
            int yy = 0;
            int rr = 99;
            Console.WriteLine("OPTION 7: SELL BOOK:");
            Console.Write("Enter Client ID:");
            while (!int.TryParse(Console.ReadLine(), out clientId) || clientId > 100 || clientId < 0)
            {
                Console.WriteLine("Invalid option value, please try again(must be between 0 and 100).");
            }
            while (clients[clientId, 0] == null)
            {
                Console.Write("Client ID doesnt exist please retry:");
                while (!int.TryParse(Console.ReadLine(), out clientId) || clientId > 100 || clientId < 0)
                {
                    Console.WriteLine("Invalid option value, please try again(must be between 0 and 100).");
                }
            }
            Console.Write("Enter client password:");
            pass = Console.ReadLine();

            while (pass != clientPassword[clientId])
            {
                Console.WriteLine("password invalid,please try again");
                Console.Write("Enter client password:");
                pass = Console.ReadLine();
            }

            Console.Write("Enter the unique ID of the book you want to sell:");
            while (!int.TryParse(Console.ReadLine(), out code))
            {
                Console.WriteLine("Please type an integer number");
            }
            for (int z = 0; z < 100; z++)
            {
                if (newBookInt[z, 0] == code)
                {
                    if (newBookInt[z, 2] > 0)
                    {
                        newBookInt[z, 2] = newBookInt[z, 2] - 1;
                        sold[xxx, yy] = clientId;
                        yy++;
                        sold[xxx, yy] = code;
                        yy--;


                        if (newBookInt[z, 2] == 0)
                        {
                            lul[z] = z;
                        }
                        sellCost[xxx] = newBooksDouble[z, 1];

                        xxx++;
                        Console.WriteLine("Book Sold!!!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, the book is unavailable");

                    }
                    rr = z;

                }
                else if (books[z].UniqueID == code)
                {
                    if (books[z].Quantity > 0)
                    {
                        books[z].Quantity = books[z].Quantity - 1;

                        sold[xxx, yy] = clientId;
                        yy++;
                        sold[xxx, yy] = code;
                        yy--;

                        if (books[z].Quantity == 0)
                        {
                            books[z].CanBeSold = "no";
                        }

                        sellCost[xxx] = books[z].UnitPrice;

                        xxx++;
                        Console.WriteLine("Book Sold!!!");
                    }
                    else
                    {

                        Console.WriteLine("Sorry, the book is unavailable");
                    }
                    rr = z;
                }
                else if (rr == z && z == 99)
                {
                    Console.WriteLine("ID doesn't exist");
                }

            }

            return xxx;
        }
        /// <summary>
        /// This is where Clients will put their ID and password to rent an available book of their choice for maximum 5 days.
        /// </summary>
        /// <param name="clients"></param>
        /// <param name="clientPassword"></param>
        /// <param name="books"></param>
        /// <param name="newBooks"></param>
        /// <param name="newBookInt"></param>
        /// <param name="newBooksDouble"></param>
        /// <param name="code"></param>
        /// <param name="lol"></param>
        /// <param name="lul"></param>
        /// <param name="clientId"></param>
        /// <param name="pass"></param>
        /// <param name="rent"></param>
        /// <param name="xx"></param>
        /// <param name="daysRented"></param>
        /// <param name="rentalFee1"></param>
        /// <param name="book1"></param>
        /// <param name="book2"></param>
        /// <param name="book3"></param>
        /// <param name="book4"></param>
        /// <param name="book5"></param>
        /// <returns>xx is an integer used to be inside the arrays that are usualy involved for the rent table in the future cases.</returns>
        private static int RentBook(string[,] clients, string[] clientPassword, Book[] books, string[,] newBooks, int[,] newBookInt, double[,] newBooksDouble, out int code, int[] lol, int[] lul, out int clientId, out string pass, int[,] rent, int xx, int[] daysRented, double[] rentalFee1, Book book1, Book book2, Book book3, Book book4, Book book5)
        {
            int y = 0;
            int dd = 99;
            int choice = -1;
            string clientId1 = "";
            code = 0;
            Console.WriteLine("OPTION 5: RENT BOOK:");
            Console.Write("Enter Client ID:");

            while (!int.TryParse(Console.ReadLine(), out clientId) || clientId > 100 || clientId < 0)
            {
                Console.WriteLine("Invalid option value, please try again(must be between 0 and 100).");
            }
            while (clients[clientId, 0] == null)
            {
                Console.Write("Client ID doesnt exist please retry:");
                while (!int.TryParse(Console.ReadLine(), out clientId) || clientId > 100 || clientId < 0)
                {
                    Console.WriteLine("Invalid option value, please try again(must be between 0 and 100).");
                }
            }
            Console.Write("Enter client password:");
            pass = Console.ReadLine();

            while (pass != clientPassword[clientId])
            {
                Console.WriteLine("password invalid,please try again");
                Console.Write("Enter client password:");
                pass = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("Do you want to rent the book by ID or by book Name/Author?");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("1. Rent book by ID.");
            Console.WriteLine("2. Rent by book Name/Author.");
            Console.Write("Enter your choice:");
            while (!int.TryParse(Console.ReadLine(), out choice) || choice > 2 || choice < 1)
            {
                Console.WriteLine("Please enter an integer number between 0 and 1");
            }
            if (choice == 1)
            {
                Console.Write("Enter the unique ID of the book you want to rent:");
                while (!int.TryParse(Console.ReadLine(), out code))
                {
                    Console.WriteLine("Please enter an integer number");
                }
            }
            else if (choice == 2)
            {

                while (string.IsNullOrEmpty(clientId1))
                {
                    Console.Write("Enter the book's Name or Author to rent it:");
                    clientId1 = Console.ReadLine();
                }

                if (clientId1 == book1.Name || clientId1 == book1.Author || clientId1 == book2.Name || clientId1 == book2.Author || clientId1 == book3.Name || clientId1 == book3.Author || clientId1 == book4.Name || clientId1 == book4.Author || clientId1 == book5.Name || clientId1 == book5.Author)
                {
                    for (int idd = 0; idd < 100; idd++)
                    {
                        if (clientId1 == books[idd].Name || clientId1 == books[idd].Author)
                        {
                            code = books[idd].UniqueID;
                        }

                    }
                }
                else if (code == 0)
                {
                    for (int idd = 0; idd < 10; idd++)
                    {
                        if (clientId1 == newBooks[idd, 0] || clientId1 == newBooks[idd, 1])
                        {
                            code = newBookInt[idd, 0];
                        }

                    }
                }
                if (code == 0)
                {
                    Console.WriteLine("ID doesn't exist");
                    dd = 200;
                    code = -1;
                }
            }


            for (int s = 0; s < 10; s++)
            {



                if (newBookInt[s, 0] == code)
                {
                    if (newBookInt[s, 2] > 0 && lol[s] != s)
                    {

                        newBookInt[s, 2] = newBookInt[s, 2] - 1;

                        lol[s] = s;
                        rent[xx, y] = clientId;
                        y++;
                        rent[xx, y] = code;
                        y--;

                        if (newBookInt[s, 2] == 0)
                        {
                            lul[s] = s;
                        }
                        Console.Write("Enter the amount of days that you want to rent the book:");
                        while (!int.TryParse(Console.ReadLine(), out daysRented[xx]) || daysRented[xx] < 1 || daysRented[xx] > 5)
                        {
                            Console.Write("Please enter 1 to 5 days:");
                        }
                        rentalFee1[xx] = newBooksDouble[s, 0];

                        Console.WriteLine("Book Rented!!!");
                        xx++;
                    }
                    else
                    {
                        if (newBookInt[s, 2] == 0)
                        {
                            lul[s] = s;
                        }
                        Console.WriteLine("Sorry, the book is unavailable");
                    }
                    dd = s;
                }
                else if (books[s].UniqueID == code)
                {
                    if (books[s].Quantity > 0 && books[s].IsRented == "no")
                    {
                        books[s].Quantity = books[s].Quantity - 1;
                        books[s].IsRented = "yes";
                        rent[xx, y] = clientId;
                        y++;
                        rent[xx, y] = code;
                        y--;

                        if (books[s].Quantity == 0)
                        {
                            books[s].CanBeSold = "no";
                        }
                        Console.Write("Enter the amount of days that you want to rent the book:");
                        while (!int.TryParse(Console.ReadLine(), out daysRented[xx]) || daysRented[xx] < 1 || daysRented[xx] > 5)
                        {
                            Console.Write("Please enter up to 5 days:");
                        }
                        rentalFee1[xx] = books[s].RentalFee;


                        Console.WriteLine("Book Rented!!!");
                        xx++;
                    }
                    else
                    {
                        if (books[s].Quantity == 0)
                        {
                            books[s].CanBeSold = "no";
                        }
                        Console.WriteLine("Sorry, the book is unavailable");
                    }
                    dd = s;
                }
                else if (dd == s && s == 99)
                {
                    Console.WriteLine("ID doesn't exist");
                }

            }

            return xx;
        }

        /// <summary>
        /// This is where the employee can add new clients.
        /// </summary>
        /// <param name="clients"></param>
        /// <param name="clientPassword"></param>
        /// <param name="index"></param>
        /// <returns>The return clientCheck was made to confirm that at least one client was created so that it is possible to go on a clients account on the main menu.</returns>
        private static bool CreateClient(string[,] clients, string[] clientPassword, ref int index)
        {
            bool clientCheck;
            Console.WriteLine("OPTION 1: ENTER CLIENTS' DATA:");

            while (string.IsNullOrEmpty(clients[index, 0]))
            {
                Console.Write("Enter First Name: ");
                clients[index, 0] = Console.ReadLine();
            }

            while (string.IsNullOrEmpty(clients[index, 1]))
            {
                Console.Write("Enter Last Name: ");
                clients[index, 1] = Console.ReadLine();
            }
            Console.Write("Enter password: ");
            clientPassword[index] = Console.ReadLine();
            if (clientPassword[index].Length < 6 || clientPassword[index].Length > 10)
            {

                while (clientPassword[index].Length < 6 || clientPassword[index].Length > 10)
                {
                    Console.WriteLine("invalid, password should be between 6 to 10 caracters");
                    clientPassword[index] = Console.ReadLine();
                }

            }
            clientCheck = true;
            index++;
            return clientCheck;
        }
        /// <summary>
        /// This is the table where every book rented is displayed besides their respective client ID.
        /// </summary>
        /// <param name="rent"></param>
        /// <param name="daysRented"></param>
        /// <param name="rentalFee1"></param>
        private static void DisplayRent(int[,] rent, int[] daysRented, double[] rentalFee1)
        {
            Console.WriteLine("OPTION 8: DISPLAY RENT:");
            Console.WriteLine("CLIENT ID\tRENTED BOOKS ID\tDays rented\tRental price");
            Console.WriteLine("------------------------------------------------------------");
            for (int a = 0; a < 100; a++)
            {
                Console.WriteLine(rent[a, 0] + "\t\t" + rent[a, 1] + "\t\t" + daysRented[a] + "\t\t" + (rentalFee1[a] * daysRented[a]));
            }
        }

        /// <summary>
        /// This is where clients that rented books will have to return it.
        /// </summary>
        /// <param name="clients"></param>
        /// <param name="clientPassword"></param>
        /// <param name="books"></param>
        /// <param name="newBookInt"></param>
        /// <param name="code"></param>
        /// <param name="lol"></param>
        /// <param name="lul"></param>
        /// <param name="clientId"></param>
        /// <param name="pass"></param>
        /// <param name="rent"></param>

        private static void ReturnBook(string[,] clients, string[] clientPassword, Book[] books, int[,] newBookInt, out int code, int[] lol, int[] lul, out int clientId, out string pass, int[,] rent)
        {
            int cc = 99;

            Console.WriteLine("OPTION 6: RETURN BOOK:");
            Console.Write("Enter client ID:");
            while (!int.TryParse(Console.ReadLine(), out clientId) || clientId > 100 || clientId < 0)
            {
                Console.WriteLine("Invalid option value, please try again(must be between 0 and 100).");
            }
            while (clients[clientId, 0] == null)
            {
                Console.Write("Client ID doesnt exist please retry:");
                while (!int.TryParse(Console.ReadLine(), out clientId) || clientId > 100 || clientId < 0)
                {
                    Console.WriteLine("Invalid option value, please try again(must be between 0 and 100).");
                }
            }
            Console.Write("Enter client password:");
            pass = Console.ReadLine();

            while (pass != clientPassword[clientId])
            {
                Console.WriteLine("password invalid,please try again");
                Console.Write("Enter client password:");
                pass = Console.ReadLine();
            }


            Console.Write("Enter the unique ID of the book you want to return:");
            while (!int.TryParse(Console.ReadLine(), out code))
            {
                Console.WriteLine("Please type an integer number");
            }

            for (int s = 0; s < 100; s++)
            {
                if (clientId == rent[s, 0] && code == rent[s, 1])
                {
                    for (int ll = 0; ll < 100; ll++)
                    {
                        if (newBookInt[ll, 0] == code)
                        {
                            if (lol[ll] == ll)
                            {
                                newBookInt[s, 2] = newBookInt[s, 2] + 1;

                                lol[ll] = -1;
                                if (newBookInt[s, 2] != 0)
                                {
                                    lul[ll] = -1;
                                }

                                Console.WriteLine("Book Returned!!!");
                            }
                            else
                            {

                                Console.WriteLine("Sorry, the book is unavailable");

                            }
                            cc = ll;

                        }





                        else if (books[ll].UniqueID == code)
                        {
                            if (books[ll].IsRented == "yes")
                            {
                                books[ll].Quantity = books[ll].Quantity + 1;
                                books[ll].IsRented = "no";

                                if (books[ll].Quantity != 0)
                                {
                                    books[ll].CanBeSold = "yes";
                                }
                                Console.WriteLine("Book Returned!!!");
                            }
                            else
                            {

                                Console.WriteLine("Sorry, the book is unavailable");
                            }
                            cc = ll;

                        }


                    }

                }
                else if (s == cc)
                {
                    Console.WriteLine("ID doesn't exist");
                }


            }
        }
        /// <summary>
        /// This is where all the booked are stored with all of their information.
        /// </summary>
        /// <param name="books"></param>
        /// <param name="newBooks"></param>
        /// <param name="newBookInt"></param>
        /// <param name="newBooksDouble"></param>
        /// <param name="yesNo"></param>
        /// <param name="lol"></param>
        /// <param name="lul"></param>
        private static void LibraryData(Book[] books, string[,] newBooks, int[,] newBookInt, double[,] newBooksDouble, string[,] yesNo, int[] lol, int[] lul)
        {
            int k = 0;
            Console.WriteLine("OPTION 4: LIBRARY DATA:");
            Console.WriteLine("4. Show Library Data");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Book ID\t\tName\t\tAuthor\t\tYear of Publication\tRental Fee\tRented\t\tCan be Sold\tPrice\t\tQuantity");




            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(books[i].UniqueID + "\t\t" + books[i].Name + "\t" + books[i].Author + "\t" + books[i].Year + "\t\t\t" + books[i].RentalFee + "\t\t" + books[i].IsRented + "\t\t" + books[i].CanBeSold + "\t\t" + books[i].UnitPrice + "\t\t" + books[i].Quantity);
            }
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------");


            for (int j = 0; j < 100; j++)
            {
                Console.Write(newBookInt[j, k] + "\t\t" + newBooks[j, k] + "\t\t");
                k++;
                Console.Write(newBooks[j, k] + "\t\t" + newBookInt[j, k] + "\t\t\t");
                k--;
                Console.Write(newBooksDouble[j, k] + "\t\t");
                if (j == lol[j])
                {
                    Console.Write(yesNo[j, 1] + "\t\t");
                }
                else
                {
                    Console.Write(yesNo[j, 0] + "\t\t");
                }
                k++;
                if (j == lul[j])
                {
                    Console.Write(yesNo[j, 0] + "\t\t");
                }
                else
                {
                    Console.Write(yesNo[j, 1] + "\t\t");
                }
                Console.Write(newBooksDouble[j, k] + "\t\t");
                k++;
                Console.WriteLine(newBookInt[j, k] + "\n");
                k--;
                k--;
            }
        }
        /// <summary>
        /// This is where all the books are created to fill up the library.
        /// </summary>
        /// <param name="books"></param>
        /// <param name="index1"></param>
        /// <param name="index2"></param>
        /// <param name="newBooks"></param>
        /// <param name="newBookInt"></param>
        /// <param name="newBooksDouble"></param>
        private static void CreateBook(Book[] books, ref int index1, ref int index2, string[,] newBooks, int[,] newBookInt, double[,] newBooksDouble)
        {
            int xy = 0;
            Console.WriteLine("OPTION 3: ENTER BOOK DATA:");
            Console.Write("enter the book ID:");

            while (!int.TryParse(Console.ReadLine(), out newBookInt[index1, index2]) || newBookInt[index1, index2] < 100000 || newBookInt[index1, index2] > 999999 || newBookInt[index1, index2] == books[0].UniqueID || newBookInt[index1, index2] == books[1].UniqueID || newBookInt[index1, index2] == books[2].UniqueID || newBookInt[index1, index2] == books[3].UniqueID || newBookInt[index1, index2] == books[4].UniqueID)
            {
                Console.Write("invalid, choose a different number between 100000 and 999999:");
            }
            for (int hh = 0; hh < index1; hh++)
            {

                if (newBookInt[index1, index2] == newBookInt[hh, index2] || newBookInt[index1, index2] == books[0].UniqueID || newBookInt[index1, index2] == books[1].UniqueID || newBookInt[index1, index2] == books[2].UniqueID || newBookInt[index1, index2] == books[3].UniqueID || newBookInt[index1, index2] == books[4].UniqueID)
                {

                    Console.Write("a book already has this ID, try a different integer number:");
                    hh--;

                    while (!int.TryParse(Console.ReadLine(), out newBookInt[index1, index2]) || newBookInt[index1, index2] < 100000 || newBookInt[index1, index2] > 999999)
                    {
                        Console.Write("invalid, choose a different number between 100000 and 999999:");
                    }
                }
            }
            xy++;


            while (string.IsNullOrEmpty(newBooks[index1, index2]))
            {
                Console.Write("enter the book name:");
                newBooks[index1, index2] = Console.ReadLine();
            }
            index2++;
            while (string.IsNullOrEmpty(newBooks[index1, index2]))
            {
                Console.Write("enter the author's name:");
                newBooks[index1, index2] = Console.ReadLine();
            }


            Console.Write("enter the year:");

            while (!int.TryParse(Console.ReadLine(), out newBookInt[index1, index2]))
            {
                Console.Write("Please enter an integer value for the year: ");
            }

            index2--;
            Console.Write("enter rental fee:");

            while (!double.TryParse(Console.ReadLine(), out newBooksDouble[index1, index2]))
            {
                Console.Write("Please enter a double value: ");
            }

            index2++;
            Console.Write("enter unit price:");

            while (!double.TryParse(Console.ReadLine(), out newBooksDouble[index1, index2]))
            {
                Console.Write("Please enter a double value:");
            }

            index2++;
            Console.Write("enter the quantity of this book:");

            while (!int.TryParse(Console.ReadLine(), out newBookInt[index1, index2]) || newBookInt[index1, index2] <= 0)
            {
                Console.Write("Please enter an integer value higher then 0: ");
            }

            Console.WriteLine("NEW BOOK CREATED");
            index2--;
            index2--;
            index1++;
        }
        /// <summary>
        /// This is the case where the employee wants to exit back to the main menu.
        /// </summary>
        /// <returns>false is the boolean used to tell the program that you do not wish to stay signed as an employee so that you get dragged to the main menu.</returns>
        private static bool EmployeeExit()
        {
            return false;
        }
        /// <summary>
        /// This is the table where every book sold is displayed besides their respective client ID.
        /// </summary>
        /// <param name="sold"></param>
        private static void DisplaySells(int[,] sold)
        {
            Console.WriteLine("OPTION 9: DISPLAY SELLS:");
            Console.WriteLine("CLIENT ID \tSOLD BOOKS ID");
            Console.WriteLine("-----------------------------");
            for (int aa = 0; aa < 100; aa++)
            {
                Console.WriteLine(sold[aa, 0] + "\t\t" + sold[aa, 1]);
            }
        }






        /// <summary>
        /// This table shows every client added to the program with all their information.
        /// </summary>
        /// <param name="DEFAULTEMPLOYEEID"></param>
        /// <param name="DEFAULTEMPLOYEEPASSWORD"></param>
        /// <param name="clients"></param>
        /// <param name="clientPassword"></param>
        private static void DataTable(int DEFAULTEMPLOYEEID, string DEFAULTEMPLOYEEPASSWORD, string[,] clients, string[] clientPassword)
        {
            Console.WriteLine("OPTION 2: DISPLAY EMPLOYE AND ALL CLIENTS");
            Console.WriteLine("employe ID\t\t\t\tPassword");
            Console.WriteLine(DEFAULTEMPLOYEEID + "\t\t\t\t\t" + DEFAULTEMPLOYEEPASSWORD);
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("ID\tFirst Name\tLast Name\tPassword");



            for (int i = 0; i < clients.GetLength(0); i++)
            {
                Console.Write(i + "\t");
                for (int j = 0; j < clients.GetLength(1); j++)
                {
                    Console.Write(clients[i, j] + "\t\t");
                }



                Console.Write(clientPassword[i]);
                Console.WriteLine();
            }
        }

        /// <summary>
        /// This is the verification for the employee that wants to sign up, it will ask for the employee ID and password.
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="employeePassword"></param>
        /// <param name="DEFAULTEMPLOYEEID"></param>
        /// <param name="DEFAULTEMPLOYEEPASSWORD"></param>
        /// <param name="signUp"></param>
        /// <param name="isSignedIn"></param>

        private static void EmployeeSignUp(out int employeeId, out string employeePassword, int DEFAULTEMPLOYEEID, string DEFAULTEMPLOYEEPASSWORD, out bool signUp, out bool isSignedIn)
        {
            bool isEmployeeIdValid = false;
            bool isEmployeePasswordValid = false;
            employeeId = DEFAULTEMPLOYEEID;
            employeePassword = DEFAULTEMPLOYEEPASSWORD;
            isSignedIn = false;


            while (!isEmployeeIdValid)
            {
                Console.WriteLine("-------------------------\n");
                Console.WriteLine("1. EMPLOYEE DATA\n");



                Console.Write("Unique ID: ");
                if (!int.TryParse(Console.ReadLine(), out employeeId))
                {
                    Console.WriteLine("Invalid ID number, please try again:");
                }



                else if (employeeId != 111111)
                {
                    Console.WriteLine("Invalid Id, please try again:");
                }

                else
                {
                    isEmployeeIdValid = true;
                    isSignedIn = true;
                    isEmployeeIdValid = employeeId == DEFAULTEMPLOYEEID;
                }
            }



            while (!isEmployeePasswordValid)
            {
                Console.Write("Password: ");
                employeePassword = Console.ReadLine();



                if (employeePassword != DEFAULTEMPLOYEEPASSWORD)
                {
                    Console.WriteLine("Invalid password, please try again:");
                }



                else if (employeePassword != "tester")
                {
                    Console.WriteLine("Invalid Password, please try again.");
                }



                else
                {
                    isEmployeePasswordValid = true;
                    isEmployeePasswordValid = employeePassword == DEFAULTEMPLOYEEPASSWORD;
                }




            }
            signUp = true;
            Console.Clear();

        }
    }
}
    
