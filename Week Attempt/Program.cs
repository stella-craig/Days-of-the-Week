using System;

public class ProblemSolution
{
    public string solution(string S, int k) //Input a string that represents a weekday and k number of days after that weekday and returns the weekday k number of days after S
    {
        string[] days = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };    //A string of all the possible weekdays
        int startDay = -1;  //keep track of the position the inputted day is in the array

        for(int i = 0; i < days.Length; i++) //loop through the array and check if the inputted array is in it
        {
            if (days[i] == S)
            {
                startDay= i;    //the inputted strings is days[j], so we keep track of that j
                break;
            }
        }

        if (startDay == -1) //if the inputted string isn't in our array
        {
            return "Error"; //return error
        }

        k  = k + startDay; //add the location in the array of the first day to the number of days we're counting
        int x = k % 7;  //find the mod of 7, which is the number of days in a week
        return days[x]; //return the string at the location found in the previous line
    }

    public static void Main(string[] args)
    {
        ProblemSolution solution = new ProblemSolution();
        Console.WriteLine(solution.solution("Wed", 2));     //Fri
        Console.WriteLine(solution.solution("Sat", 23));    //Mon
        Console.WriteLine(solution.solution("Ice", 23));    //Error
        Console.WriteLine(solution.solution("Sat", 24));    //Tue
        Console.WriteLine(solution.solution("Mon", 1));     //Tue
        Console.WriteLine(solution.solution("Sat", 0));     //Sat
    }
}