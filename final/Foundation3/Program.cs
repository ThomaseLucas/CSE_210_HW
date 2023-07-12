using System;

namespace Foundation3
{
class Program
{
    static void Main(string[] args)
    {
        Gathering outdoorGathering1 = new Gathering();
        Lecture lecutre1 = new Lecture();
        Reception reception1 = new Reception();
        Adress adress1 = new Adress();
        Adress adress2 = new Adress();
        Adress adress3 = new Adress();
        List<Event> events = new List<Event>(); 

        outdoorGathering1.SetTitle("Summer Barbeque & Career Search");
        outdoorGathering1.SetEventType("Outdoor Gathering");
        outdoorGathering1.SetDate("7/14/2023");
        outdoorGathering1.SetTime("12:30pm - 6:30pm");
        outdoorGathering1.SetWeather("Sunny, with 5mph wind gusts. Small chance of rain.");
        outdoorGathering1.SetDescription("We will be grilling burgers and dogs, all while being able to meet new people and find new career oppurtunities. \n|  Be sure to bring your resume to be able to show employers your best work.");
        adress1.SetStreet("105 Birch St");
        adress1.SetCity("Longmont");
        adress1.SetState("Missisippi");
        adress1.SetPostalCode("10465");
        string fulladress1 = adress1.DisplayFullAdress();
        outdoorGathering1.SetAdress(fulladress1);
        events.Add(outdoorGathering1);

        lecutre1.SetTitle("Pixar Theory Lecture");
        lecutre1.SetEventType("Lecture");
        lecutre1.SetDate("8/29/2024");
        lecutre1.SetTime("8pm - 10pm");
        lecutre1.SetSpeakerName("Jon Negroni");
        lecutre1.SetDescription("Hear from the cretor of the Pixar Theory, and learn about the why! \n|  There will be tons of new information and theories born. Also a workshop will be held later on in the evening.");
        lecutre1.SetCapacity(150);
        adress2.SetStreet("139 Main St");
        adress2.SetState("New York");
        adress2.SetCity("Manhattan");
        adress2.SetPostalCode("24637");
        string fulladress2 = adress2.DisplayFullAdress();
        lecutre1.SetAdress(fulladress2);
        events.Add(lecutre1);

        reception1.SetTitle("Carleen and Kyle's Wedding Reception");
        reception1.SetEventType("Reception");
        reception1.SetDate("7/23/2023");
        reception1.SetTime("2pm");
        reception1.SetDescription("Come celebrate the union of Carleen and Kyle! Dancing and cake will be there!");
        reception1.SetEmail("CarleenAndKyle2023@gmail.com");
        adress3.SetStreet("094 Sage Ave");
        adress3.SetCity("Los Angeles");
        adress3.SetState("California");
        adress3.SetPostalCode("80504");
        string fulladress3 = adress3.DisplayFullAdress();
        reception1.SetAdress(fulladress3);
        events.Add(reception1);



        foreach (Event eventtype in events)
        {
            string typeOfEvent = eventtype.GetEventType();
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            if (typeOfEvent == "Reception")
            {
                reception1.DisplayShortDescription();
                reception1.DisplayEventInfo();
                reception1.DisplayRSVPEmail();
            } 
            else if (typeOfEvent == "Outdoor Gathering")
            {
                outdoorGathering1.DisplayShortDescription();
                outdoorGathering1.DisplayEventInfo();
                outdoorGathering1.DisplayWeather();
            }
            else if (typeOfEvent == "Lecture")
            {
                lecutre1.DisplayShortDescription();
                lecutre1.DisplayEventInfo();
                lecutre1.DisplayLecutreInfo();
            }
            else
            {
                Console.WriteLine();
            }

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine();

        }
        
    }
}
}