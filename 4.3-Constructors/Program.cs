using System;

namespace _4._3_Constructors
{
    // author: Benjamin Daniel Morgan
    // date: 23/01/18

    class Book
    {
        private string author;
        private string name, town, animal, weapon, job;

        public static void Main(string[] args)                                  // program starts executing here
        {
            Book myBook = new Book();                                           // create a new Book object

            Console.WriteLine("Enter your own Story or use the Defaults");
            Console.WriteLine("Enter 1/2");

            string input = Console.ReadLine();

            if(input == "1")
            {
                myBook.getDetails();                                            // call its getDetails() method
                myBook.writeChapter1();                                         // call its writeChapter1() method
            }

            if(input == "2")
            {
                Book mybook = new Book();
                myBook.writeChapter1();                                         // call its deafultStory() method
            }
        }
        public string ask(string prompt)                                        // use prompt to ask for information
        {
            string answer;
            Console.Write(prompt);
            answer = Console.ReadLine();
            return answer;
        }
        public void getDetails()
        {
            author = ask("Please enter your Name : ");
            name = ask("Please enter a Friend's name : ");
            town = ask("Please enter a Town : ");
            animal = ask("Please enter an Animal : ");
            job = ask("Please enter a type of Job : ");
            weapon = ask("Finally, enter a weapon of your choice : ");
        }
        public void writeChapter1()                                             // write chapter using information gathered
        {
            Console.Clear();
            Console.WriteLine("A Horror Story: by " + author);
            Console.WriteLine("============================================");
            Console.WriteLine("It was a dark night in " + town + " and " + name + " could hear " + animal + "'s scream in the distance.");
            Console.WriteLine(name + " staggered terrified through the streets of " + town + ", realising they had been followed.");
            Console.WriteLine("In the shadow of a doorway, a demented " + job + " waited clutching a meanacing " + weapon + " with death in his eyes.");
        }
        public Book()
        {
            this.author = "an Idiot";
            this.name = "Friend who doen't like you ";
            this.town = "LonaVille";
            this.animal = "Rabbit";
            this.job = "Librarian";
            this.weapon = "Christmas Tree";
        }
    } // end of Book class
}
