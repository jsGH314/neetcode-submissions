public class Solution 
{
    public int CountStudents(int[] students, int[] sandwiches) 
    {
        // 0 = circular sandwiches, 1 = square sandwiches 
        // the number of sandwiches is equal to the number of students
        // students in a queue, sandwiches in a stack

        //if the student at the front of the queue prefers the sandwich variant,
        // they will take it and leave the queue, otherwise they will leave it and
        // go back to end of the line

        // return the number of students unable to eat
        
        int circularCount = 0;
        int squareCount = 0;

        foreach(int student in students)
        {
            if(student == 0) circularCount++;
            else squareCount++;
        }

        foreach(int item in sandwiches)
        {
            if(item == 0)
            {                
                if(circularCount == 0) break; // no one wants circular 
                circularCount--;
            }
            else
            {
                if(squareCount == 0) break; // no one wants square
                squareCount--;
            }

        }
        return circularCount + squareCount;
    }
}