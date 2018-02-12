using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class HadronColliderQuiz
    {
        static void Main()
        {

        int score = 0;

        Console.Write("check out https://home.cern for information about CERN and The Large Hadron Collider");
        Console.Write("\n What does CERN stand for?" +
            "\nA Center for Engineering and Research Nuclear" +
            "\nB Center for Enigmatic Research Nerds" +
            "\nC Conseil Européen pour la Recherche Nucléaire" +
            "\nD Council of European Research Networks\n");

        if (Char.ToLower(Convert.ToChar(Console.Read())) == 'c')
            score++;
        Console.ReadLine();

        Console.Write("\n Where is CERN located?" +
           "\nA Geneva" +
           "\nB Paris" +
           "\nC New York" +
           "\nD London\n");

        if (Char.ToLower(Convert.ToChar(Console.Read())) == 'a')
            score++;
        Console.ReadLine();

        Console.Write("\n There are two major questions that CERN is trying to answer, name one of them." +
          "\nA What is the meaning of life?" +
          "\nB What are the basic building blocks of matter?" +
          "\nC Where is Waldo?" +
          "\nD How did the universe begin?\n");

        if (Char.ToLower(Convert.ToChar(Console.Read())) == 'b') 
            score++;
        else if (Char.ToLower(Convert.ToChar(Console.Read())) == 'd')
            score++;
        Console.ReadLine();

        Console.Write("\n The Large Hadron Collider (or LHC) is the worlds largest '____' " +
           "\nA Nuclear Reactor" +
           "\nB Space Shuttle" +
           "\nC Particle Accelerator" +
           "\nD Proffesional Wrestler\n");

        if (Char.ToLower(Convert.ToChar(Console.Read())) == 'b')
            score++;
        Console.ReadLine();

        Console.Write("\n How many kilometers of superconducting magnets is The Large Hadron Collider comprised of?" +
           "\nA 56" +
           "\nB 2" +
           "\nC 37" +
           "\nD 27\n");

        if (Char.ToLower(Convert.ToChar(Console.Read())) == 'd')
            score++;
        Console.ReadLine();

        Console.Write("\nThe quark-gluon plasma created by scientists at CERN in the Large Hadron Collider momentarily reached tempuratures of about _________ trillion degrees Celsius:" +
          "\nA 5.5" +
          "\nB 6.2" +
          "\nC 1" +
          "\nD 4.6\n");

        if (Char.ToLower(Convert.ToChar(Console.Read())) == 'a')
            score++;
        Console.ReadLine();

        Console.Write("\nHow many collisions per second take place in The Large Hadron Collider?" +
          "\nA 2 billion" +
          "\nB 3 million" +
          "\nC 1 billion" +
          "\nD 1 trillion\n");

        if (Char.ToLower(Convert.ToChar(Console.Read())) == 'c')
            score++;
        Console.ReadLine();

        if (score == 7)
            Console.Write("\nExcellent!\n");
        else if (score == 6)
            Console.Write("\nVery Good!\n");
        else
            Console.Write("\nTime to brush up on your knowledge of CERN and LHC!\n");

    }
    }

