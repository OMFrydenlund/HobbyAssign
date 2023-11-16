using System;


        assignHobby();
        void assignHobby()
{
    Console.WriteLine("*clown honks* Handing out some hobbies, who wants one *sigh*");
    string nameInput = Console.ReadLine();

    string[] hobbyArray = { "street lamp", "watercooler", "clown", "cup", "janitor" };

    Random yourNewHobby = new Random();
    int randomIndex = yourNewHobby.Next(hobbyArray.Length);

    string randomHobby = hobbyArray[randomIndex];

    Console.WriteLine($"Poof! {nameInput} is now a {randomHobby}!");
}