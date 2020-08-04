using System;

namespace Lab8_5RealityShowInheritanceComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from Lab8_5RealityShowInheritanceComposition!!");

            // Testing the Classes
            //  In the Main program, create applications for Dream House Hunters, Paradise Island,
            //  and Above Deck. *Submit and accept them all*.

            //  ContestantApplication contestantApp = new ContestantApplication("Omar", "Smith", Convert.ToDateTime("2/4/1975"), 
            //                                                                "111 Bravo Way", "Los Angeles", "California", "90001",
            //                                                                "888-233-1234", "omar.smith@hotmail.com");

            DreamHouseHunterApplication houseApplication = new DreamHouseHunterApplication("Full Stack Web Developer", 100000, 6, 3, 2, "Omar", "Smith", Convert.ToDateTime("2/4/1975"),
                                                                            "111 Bravo Way", "Los Angeles", "California", "90001",
                                                                            "888-233-1234", "omar.smith@hotmail.com");
            houseApplication.Submit();
            houseApplication.Accept();

            ParadiseIslandApplication paradiseApplication = new ParadiseIslandApplication("Female", "Carl", 2, "Patti", "Johnson", Convert.ToDateTime("8/4/1994"),
                                                                            "211 Love Rd", "Los Angeles", "California", "90001",
                                                                            "988-444-1234", "patti.johnson@gmail.com");
            paradiseApplication.Submit();
            paradiseApplication.Accept();

            AboveDeckApplication deckApplication = new AboveDeckApplication(20, "American", "Captain", "Lee", Convert.ToDateTime("7/12/1964"),
                                                                            "311 Bravo Way", "Los Angeles", "California", "90001",
                                                                            "711-333-1234", "captain@gmail.com");
            deckApplication.Submit();
            deckApplication.Accept();

            // The best Reality TV Show of the Decade - Hackers!
            HackersApplication hackersApplication = new HackersApplication(5, "AlreadyGone", 25, "Bill", "Wright", Convert.ToDateTime("7/12/2000"),
                                                                            "123 Hacker Lane", "Charlotte", "North Carolina", "28123",
                                                                            "704-547-1234", "agimout@gmail.com");
            hackersApplication.Submit();
            hackersApplication.Accept();
            hackersApplication.Comment(); // new wasn't in the courseware...added by th 07142020

        }
    }
}
