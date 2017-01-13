using System;

namespace StudentRecords
{
    class Program
    {

        static void Main(string[] args)
        {

            int choice = -1;
            int studCount = 0;
            student[] studArray=new student[20];

            bool superloop = true;
            bool loop = true;
            // get user choice, insuring that it is within range of choices
            while (superloop == true)
            {
                buildMenu();
                while (loop == true)
                {
                    int.TryParse(Console.ReadLine(), out choice);
                    if ((choice < 0) || (choice > 9))
                    {
                        Console.Write("Please enter one of the above choices: ");
                    }
                    else
                    {
                        loop = false;
                    }
                }
                loop = true;
                if (choice == 1)
                {
                    add(studArray, ref studCount);
                    choice = -1;                   
                }else if (choice == 2)
                {
                    delete(studArray, ref studCount);
                    choice = -1;                 
                }else if (choice == 3)
                {
                    update(studArray, studCount);
                    choice = -1;                   
                }else if (choice == 4)
                {
                    viewAll(studArray, studCount);
                    choice = -1;                  
                }else if(choice == 5)
                {
                    avg(studArray, studCount);
                    choice = -1;                 
                }else if (choice == 6)
                {
                    max(studArray, studCount);
                    choice = -1;
                }else if (choice == 7)
                {
                    min(studArray, studCount);
                    choice = -1;
                }else if (choice == 8)
                {
                    find(studArray, studCount);
                    choice = -1;
                }else if (choice == 9)
                {
                    sort(studArray, studCount);
                    choice = -1;
                }else
                {
                    superloop = false;
                }
            }
        }

        public static void buildMenu()
        {
            Console.WriteLine("==========================================");           
            Console.WriteLine("                 MENU                     ");           
            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.WriteLine("1. Add student records\n");
            Console.WriteLine("2. Delete student records\n");
            Console.WriteLine("3. Update student records\n");
            Console.WriteLine("4. View all student records\n");
            Console.WriteLine("5. Calculate average of selected student's scores\n");
            Console.WriteLine("6. Show student who gets max total score\n");
            Console.WriteLine("7. Show student who gets min total score\n");
            Console.WriteLine("8. Find student by ID\n");
            Console.WriteLine("9. Sort records by total scores\n");
            Console.WriteLine("0: Exit program\n");
            Console.Write("Enter your choice: ");
        }

        public struct student
        {
            public string id;
            public string name;
            public string sex;
            public double quiz1;
            public double quiz2;
            public double assignment;
            public double mid;
            public double final;
            public double total;
        }

        public static void add(student[] studArray, ref int studCount)
        {
            // get student's ID and check to make sure it doesn't already exist
            bool loop = true;
            while (loop == true)
            {
                Console.WriteLine();
                Console.Write("Enter the student's ID: ");
                studArray[studCount].id = Console.ReadLine();
                if (search(studArray, studArray[studCount].id, studCount) != -1)
                {
                    Console.WriteLine("This ID already exists.");
                }else
                {
                    loop = false;
                }
            }

            // get student's name
            Console.Write("Enter the student's name: ");
            studArray[studCount].name = Console.ReadLine();

            // get student's sex and make sure it's M or F
            loop = true;
            while (loop == true)
            {
                Console.Write("Enter the student's sex (M or F): ");
                studArray[studCount].sex = Console.ReadLine().ToUpper();
                if ((!studArray[studCount].sex.Equals("F")) && (!studArray[studCount].sex.Equals("M")))
                {
                    Console.Write("Please enter M or F for the student's sex!\n");
                }
                else
                {
                    loop = false;
                }
            }

            bool testRange = false;
            // get quiz1 score      
            while (testRange == false)
            {
                Console.Write("Enter the student's score from quiz#1: ");
                studArray[studCount].quiz1 = double.Parse(Console.ReadLine());
                if ((studArray[studCount].quiz1 < 0) || (studArray[studCount].quiz1 > 100))
                {
                    Console.WriteLine("Score must be between 0 and 100!");
                    Console.WriteLine();
                }else
                {
                    testRange = true;
                }
            }
            testRange = false;

            // get quiz2 score
            while (testRange == false)
            {
                Console.Write("Enter the student's score from quiz#2: ");
                studArray[studCount].quiz2 = double.Parse(Console.ReadLine());
                if ((studArray[studCount].quiz2 < 0) || (studArray[studCount].quiz2 > 100))
                {
                    Console.WriteLine("Score must be between 0 and 100!");
                    Console.WriteLine();
                }
                else
                {
                    testRange = true;
                }
            }
            testRange = false;

            // get assignment score
            while (testRange == false)
            {
                Console.Write("Enter the student's score from the assignment: ");
                studArray[studCount].assignment = double.Parse(Console.ReadLine());
                if ((studArray[studCount].assignment < 0) || (studArray[studCount].assignment > 100))
                {
                    Console.WriteLine("Score must be between 0 and 100!");
                    Console.WriteLine();
                }
                else
                {
                    testRange = true;
                }
            }
            testRange = false;

            // get midterm score
            while (testRange == false)
            {
                Console.Write("Enter the student's score from the midterm: ");
                studArray[studCount].mid = double.Parse(Console.ReadLine());
                if ((studArray[studCount].mid < 0) || (studArray[studCount].mid > 100))
                {
                    Console.WriteLine("Score must be between 0 and 100!");
                    Console.WriteLine();
                }
                else
                {
                    testRange = true;
                }
            }
            testRange = false;

            // get final score
            while (testRange == false)
            {
                Console.Write("Enter the student's score from the final: ");
                studArray[studCount].final = double.Parse(Console.ReadLine());
                if ((studArray[studCount].final < 0) || (studArray[studCount].final > 100))
                {
                    Console.WriteLine("Score must be between 0 and 100!");
                    Console.WriteLine();
                }
                else
                {
                    testRange = true;
                }
            }

            // calculate total score
            studArray[studCount].total = studArray[studCount].final + studArray[studCount].mid + studArray[studCount].assignment + studArray[studCount].quiz1 + studArray[studCount].quiz2;

            // increment counter variable
            ++studCount;

        }

        public static void viewAll(student[] studArray, int studCount)
        {
            if (studCount == 0)
            {
                Console.WriteLine();
                Console.WriteLine("There are no records in the table.");
                Console.WriteLine();
                return;
            }
            Console.WriteLine();
            Console.WriteLine("{0,-5} {1,-20} {2,-5} {3,-5} {4,-5} {5,-5} {6,-5} {7,-5} {8,-5}", "ID", "NAME", "SX", "Q1", "Q2", "As", "MT", "FIN", "TOTAL");
            Console.WriteLine("=====================================================================");

            int i = 0;
            while (i < studCount)
            {
                if (studArray[i].id != null)
                {
                    Console.Write("{0,-5} {1,-20} {2,-6}",studArray[i].id, studArray[i].name, studArray[i].sex);
                    Console.Write("{0,-5} {1,-5} {2,-6}", studArray[i].quiz1, studArray[i].quiz2, studArray[i].assignment);
                    Console.Write("{0,-5} {1,-5} {2,-5}", studArray[i].mid, studArray[i].final, studArray[i].total);
                    Console.WriteLine();
                }
                i++;
            }
            Console.WriteLine();
        }

        public static int search(student[] studArray, string id, int studCount)
        {
            int found = -1;
            for(int i = 0; i < studCount && found == -1; i++)
            {
                if (studArray[i].id == id)
                {
                    found = i;
                }
            }
            return found;
        }

        public static void delete(student[] studArray, ref int studCount)
        {
            string id = "";
            int index;
            bool loop = true;
            if (studCount == 0)
            {
                Console.WriteLine();
                Console.WriteLine("There are no records to delete.");
                Console.WriteLine();
            }else
            {
                while (loop == true)
                {
                    Console.Write("Enter ID of student to be deleted or X to back out: ");
                    id = Console.ReadLine();
                    if ((id.Equals("x")) || (id.Equals("X")))
                    {
                        return;
                    }
                    else if (search(studArray, id, studCount) == -1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("That student does not exist in the record.");
                        Console.WriteLine();
                    }
                    else
                    {
                        loop = false;
                    }
                }
                index = search(studArray, id, studCount);
                if (index == studCount - 1) // if we're deleting the last record
                {
                    clean(studArray, index);
                    --studCount;
                    Console.WriteLine("The record was deleted.");
                }
                else // delete anything other than the last record
                {
                    for(int i = index; i < studCount - 1; i++)
                    {
                        studArray[i] = studArray[i + 1];
                    }
                    --studCount;
                    clean(studArray, studCount);
                }

            }
        }

        public static void clean(student[] studArray, int index)
        {
            studArray[index].id = null;
            studArray[index].name = null;
            studArray[index].sex = null;
            studArray[index].quiz1 = 0;
            studArray[index].quiz2 = 0;
            studArray[index].assignment = 0;
            studArray[index].mid = 0;
            studArray[index].final = 0;
            studArray[index].total = 0;
        }

        public static void update(student[] studArray, int studCount)
        {
            if (studCount == 0)
            {
                Console.WriteLine();
                Console.WriteLine("There are no students in the table yet.");
                Console.WriteLine();
                return;
            }
            string id = "";
            int column = 0;
            bool loop = true;
            while (loop == true)
            {
                Console.Write("Enter ID of student to update: ");
                id = Console.ReadLine();      
                if (search(studArray, id, studCount) == -1)
                {
                    Console.WriteLine("That ID does not exist in the record.");
                    Console.WriteLine();
                }else
                {
                    loop = false;
                }
            }
            loop = true;
            Console.WriteLine("1. Name");
            Console.WriteLine("2. Sex");
            Console.WriteLine("3. Quiz 1");
            Console.WriteLine("4. Quiz 2");
            Console.WriteLine("5. Assignment");
            Console.WriteLine("6. Midterm");
            Console.WriteLine("7. Final");
            while (loop == true)
            {
                Console.WriteLine("Which field would you like to update?");
                int.TryParse(Console.ReadLine(), out column);
                if ((column < 1) || (column > 7))
                {
                    Console.WriteLine("Please enter one of the choices above!");
                }else
                {
                    loop = false;
                }
            }
            loop = true;
            int index = search(studArray, id, studCount);
            switch (column)
            {
                case (1):
                    Console.Write("Enter student's name: ");
                    studArray[index].name = Console.ReadLine();
                    break;
                case (2):
                    while (loop == true)
                    {
                        Console.Write("Enter the student's sex (M or F): ");
                        studArray[index].sex = Console.ReadLine().ToUpper();
                        if ((!studArray[index].sex.Equals("F")) && (!studArray[index].sex.Equals("M")))
                        {
                            Console.Write("Please enter M or F for the student's sex!\n");
                        }
                        else
                        {
                            loop = false;
                        }
                    }                    
                    break;
                case (3):
                    while (loop == true)
                    {
                        Console.Write("Enter the student's score from quiz#1: ");
                        studArray[index].quiz1 = double.Parse(Console.ReadLine());
                        if ((studArray[index].quiz1 < 0) || (studArray[index].quiz1 > 100))
                        {
                            Console.WriteLine("Score must be between 0 and 100!");
                            Console.WriteLine();
                        }
                        else
                        {
                            loop = false;
                        }
                    }
                    break;
                case (4):
                    while (loop == true)
                    {
                        Console.Write("Enter the student's score from quiz#2: ");
                        studArray[index].quiz2 = double.Parse(Console.ReadLine());
                        if ((studArray[index].quiz2 < 0) || (studArray[index].quiz2 > 100))
                        {
                            Console.WriteLine("Score must be between 0 and 100!");
                            Console.WriteLine();
                        }
                        else
                        {
                            loop = false;
                        }
                    }
                    break;
                case (5):
                    while (loop == true)
                    {
                        Console.Write("Enter the student's score from assignment: ");
                        studArray[index].assignment = double.Parse(Console.ReadLine());
                        if ((studArray[index].assignment < 0) || (studArray[index].assignment > 100))
                        {
                            Console.WriteLine("Score must be between 0 and 100!");
                            Console.WriteLine();
                        }
                        else
                        {
                            loop = false;
                        }
                    }
                    break;
                case (6):
                    while (loop == true)
                    {
                        Console.Write("Enter the student's score from midterm: ");
                        studArray[index].mid = double.Parse(Console.ReadLine());
                        if ((studArray[index].mid < 0) || (studArray[index].mid > 100))
                        {
                            Console.WriteLine("Score must be between 0 and 100!");
                            Console.WriteLine();
                        }
                        else
                        {
                            loop = false;
                        }
                    }
                    break;
                case (7):
                    while (loop == true)
                    {
                        Console.Write("Enter the student's score from final: ");
                        studArray[index].final = double.Parse(Console.ReadLine());
                        if ((studArray[index].final < 0) || (studArray[index].final > 100))
                        {
                            Console.WriteLine("Score must be between 0 and 100!");
                            Console.WriteLine();
                        }
                        else
                        {
                            loop = false;
                        }
                    }
                    break;
            }

            // re-calculate total score
            studArray[index].total = studArray[index].final + studArray[index].mid + studArray[index].assignment + studArray[index].quiz1 + studArray[index].quiz2;
        }

        public static void avg(student[] studArray, int studCount)
        {
            if (studCount == 0)
            {
                Console.WriteLine();
                Console.WriteLine("There are no students in the table yet.");
                Console.WriteLine();
                return;
            }
            string id = "";
            double avg;
            bool loop = true;
            while (loop == true)
            {
                Console.Write("Enter student's ID: ");
                id = Console.ReadLine();
                if(search(studArray, id, studCount) == -1)
                {
                    Console.WriteLine("That ID does not exist!");
                }else
                {
                    loop = false;
                }
            }           
            int index = search(studArray, id, studCount);            
            avg = studArray[index].total / 5.000;
            Console.WriteLine();
            Console.WriteLine("{0}'s average score is {1}.",studArray[index].name,avg);
            Console.WriteLine();
        }

        public static void max(student[] studArray, int studCount)
        {
            double max = studArray[0].total;
            int index = 0;
            if (studCount == 0)
            {
                Console.WriteLine();
                Console.WriteLine("There are not any students in the table.");
                Console.WriteLine();
                return;
            }else if (studCount == 1)
            {
                Console.WriteLine();
                Console.WriteLine("The max score is {0} and is held by Student ID {1}.",studArray[0].total,studArray[0].id);
            }else
            {
                for(int i = 0; i < studCount - 1; i++)
                {
                    if (max < studArray[i + 1].total)
                    {
                        max = studArray[i + 1].total;
                        index = i + 1;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("The max score is {0} and is held by Student ID {1}.",max,studArray[index].id);
                Console.WriteLine();
            }
        }

        public static void min(student[] studArray, int studCount)
        {
            double min = studArray[0].total;
            int index = 0;
            if (studCount == 0)
            {
                Console.WriteLine();
                Console.WriteLine("There are not any students in the table.");
                Console.WriteLine();
                return;
            }
            else if (studCount == 1)
            {
                Console.WriteLine();
                Console.WriteLine("The min score is {0} and is held by Student ID {1}.", studArray[0].total, studArray[0].id);
            }
            else
            {
                for (int i = 0; i < studCount - 1; i++)
                {
                    if (min > studArray[i + 1].total)
                    {
                        min = studArray[i + 1].total;
                        index = i + 1;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("The max score is {0} and is held by Student ID {1}.", min, studArray[index].id);
                Console.WriteLine();
            }
        }

        public static void find(student[] studArray, int studCount)
        {
            if (studCount == 0)
            {
                Console.WriteLine();
                Console.WriteLine("There are no students yet in the table.");
                Console.WriteLine();
                return;
            }
            bool loop = true;
            string id = "";
            while (loop == true)
            {
                Console.Write("Please enter student ID: ");
                id = Console.ReadLine();
                if (search(studArray, id, studCount) == -1)
                {
                    Console.WriteLine();
                    Console.WriteLine("That student ID is not in the record.");
                    Console.WriteLine();
                }else
                {
                    loop = false;
                }
            }
            int index = search(studArray, id, studCount);
            Console.WriteLine();
            Console.WriteLine("{0,-5} {1,-20} {2,-5} {3,-5} {4,-5} {5,-5} {6,-5} {7,-5} {8,-5}", "ID", "NAME", "SX", "Q1", "Q2", "As", "MT", "FIN", "TOTAL");
            Console.WriteLine("=====================================================================");
            Console.Write("{0,-5} {1,-20} {2,-6}", studArray[index].id, studArray[index].name, studArray[index].sex);
            Console.Write("{0,-5} {1,-5} {2,-6}", studArray[index].quiz1, studArray[index].quiz2, studArray[index].assignment);
            Console.Write("{0,-5} {1,-5} {2,-5}", studArray[index].mid, studArray[index].final, studArray[index].total);
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void sort(student[] studArray, int studCount)
        {
            if (studCount == 0)
            {
                Console.WriteLine();
                Console.WriteLine("There are no records in the table yet.");
                Console.WriteLine();
                return;
            }
            if (studCount == 1)
            {
                Console.WriteLine();
                Console.WriteLine("{0,-5} {1,-20} {2,-5} {3,-5} {4,-5} {5,-5} {6,-5} {7,-5} {8,-5}", "ID", "NAME", "SX", "Q1", "Q2", "As", "MT", "FIN", "TOTAL");
                Console.WriteLine("=====================================================================");
                Console.Write("{0,-5} {1,-20} {2,-6}", studArray[0].id, studArray[0].name, studArray[0].sex);
                Console.Write("{0,-5} {1,-5} {2,-6}", studArray[0].quiz1, studArray[0].quiz2, studArray[0].assignment);
                Console.Write("{0,-5} {1,-5} {2,-5}", studArray[0].mid, studArray[0].final, studArray[0].total);
                Console.WriteLine();
                return;
            }
            double temp;
            string tempstr;
            int len = studCount - 1;
            student[] tempArray = studArray;
            while (len > 0)
            {
                for (int i = 0; i < len; i++)
                {
                    if (tempArray[i].total > tempArray[i + 1].total)
                    {
                        tempstr = tempArray[i + 1].id;
                        tempArray[i + 1].id = tempArray[i].id;
                        tempArray[i].id = tempstr;

                        tempstr = tempArray[i + 1].name;
                        tempArray[i + 1].name = tempArray[i].name;
                        tempArray[i].name = tempstr;

                        tempstr = tempArray[i + 1].sex;
                        tempArray[i + 1].sex = tempArray[i].sex;
                        tempArray[i].sex = tempstr;

                        temp = tempArray[i + 1].quiz1;
                        tempArray[i + 1].quiz1 = tempArray[i].quiz1;
                        tempArray[i].quiz1 = temp;

                        temp = tempArray[i + 1].quiz2;
                        tempArray[i + 1].quiz2 = tempArray[i].quiz2;
                        tempArray[i].quiz2 = temp;

                        temp = tempArray[i + 1].assignment;
                        tempArray[i + 1].assignment = tempArray[i].assignment;
                        tempArray[i].assignment = temp;

                        temp = tempArray[i + 1].mid;
                        tempArray[i + 1].mid = tempArray[i].mid;
                        tempArray[i].mid = temp;

                        temp = tempArray[i + 1].final;
                        tempArray[i + 1].final = tempArray[i].final;
                        tempArray[i].final = temp;

                        temp = tempArray[i + 1].total;
                        tempArray[i + 1].total = tempArray[i].total;
                        tempArray[i].total = temp;
                    }
                }
                len--;
            }
            viewAll(tempArray, studCount);
            len = studCount - 1;
            while (len > 0)
            {
                for (int i = 0; i < len; i++)
                {
                    if (int.Parse(tempArray[i].id) > int.Parse(tempArray[i + 1].id))
                    {
                        tempstr = tempArray[i + 1].id;
                        tempArray[i + 1].id = tempArray[i].id;
                        tempArray[i].id = tempstr;

                        tempstr = tempArray[i + 1].name;
                        tempArray[i + 1].name = tempArray[i].name;
                        tempArray[i].name = tempstr;

                        tempstr = tempArray[i + 1].sex;
                        tempArray[i + 1].sex = tempArray[i].sex;
                        tempArray[i].sex = tempstr;

                        temp = tempArray[i + 1].quiz1;
                        tempArray[i + 1].quiz1 = tempArray[i].quiz1;
                        tempArray[i].quiz1 = temp;

                        temp = tempArray[i + 1].quiz2;
                        tempArray[i + 1].quiz2 = tempArray[i].quiz2;
                        tempArray[i].quiz2 = temp;

                        temp = tempArray[i + 1].assignment;
                        tempArray[i + 1].assignment = tempArray[i].assignment;
                        tempArray[i].assignment = temp;

                        temp = tempArray[i + 1].mid;
                        tempArray[i + 1].mid = tempArray[i].mid;
                        tempArray[i].mid = temp;

                        temp = tempArray[i + 1].final;
                        tempArray[i + 1].final = tempArray[i].final;
                        tempArray[i].final = temp;

                        temp = tempArray[i + 1].total;
                        tempArray[i + 1].total = tempArray[i].total;
                        tempArray[i].total = temp;
                    }
                }
                len--;
            }
        }


    }
}