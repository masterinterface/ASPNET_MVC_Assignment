using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CA1.Models
{   
    // this class has two purposes:
    // 1. To simulate the db by storing contact details within a 'table' (here the table is a list of Person obejcts)
    // 2. To provide a serach(string string) method that uses the two input string to search the 'db' and return a negative or positive confirmation
    public class Contacts
    {
        public List<Person> contacts = new List<Person>() 
        {
            new Person("tom", "dickens", "083", "1452343"), 
            new Person("harry", "mancg", "082", "1287354"), 
            new Person("sean", "blake", "086", "7856783"),
            new Person("sinead", "mcd", "088", "1457453"), 
            new Person("mark", "johnson", "089", "3534546"),
            new Person("pierce", "brosnan", "080", "2353267"), 
            new Person("emily", "thatcher", "082", "5790523"), 
            new Person("jackie", "mcguire", "084", "4567345"),
            new Person("zoe", "tompson", "085", "2453457"), 
            new Person("aoife", "alberry", "081", "3499883"),
        };

        //method to search through the 'contacts' List and return a negative or positive confirmation
        public String search(string destArea, string destNum)
        {
            try
            {
                //looks for input parameter matches within the List of Person objects 
                int indexDestArea = contacts.FindIndex(x => x.destArea == destArea);
                //looks for input parameter matches within the List of Person objects 
                int indexDestNum = contacts.FindIndex(x => x.destNum == destNum);

                if (indexDestArea == indexDestNum)
                    //this return value string is passed to the 'Success' View, which displays it to the user 
                    return "Your message was sent to " + contacts.ElementAt(indexDestArea).fName + " " + contacts.ElementAt(indexDestArea).lName;
                //this return value is used within an if statement to redirectt user to the 'Error' View / User does not see the content of this string
                else return "nomatch";
            }
            //exception handling to provide an execution path if the LINQ queries within search() reach the end of the contacts List without finding a match. 
            catch (System.ArgumentOutOfRangeException)
            {
                return "nomatch";
            }
        }
    }
}