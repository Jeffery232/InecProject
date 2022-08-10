namespace InecVoters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void InecProject()
            {

                try
                {

                    // The sortedDictionary 
                    SortedDictionary<string, int> nameDict = new SortedDictionary<string, int>();


                    // The list created for name of Reg CANDIDATE 
                    var votersName = new List<string>
                {
                    "Mark", "Rush","Young" ,"Philly","Young" ,"Thug","Kelly", "Johnson","Boris" ,"Johnson","Johnsnow" ,"kris","Dave" ,"Von","Dave", "Von","Dave" ,"Von","Boris" ,"Johnson","Boris", "Johnson"
                };


                    //Converted into an Hashset to remove duplicates 

                    HashSet<string> sortedName = votersName.ToHashSet();

                    foreach (string name in sortedName)
                    {
                        int number = votersName.Count(x => x == name);
                        nameDict.Add(name, number);
                    }

                    //looping through the Dictornary 
                    foreach (var item in nameDict)
                    {
                        if (item.Value == 1)
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine($"The name {item.Key} exist {item.Value} times");
                        }
                    }

                    // To accept new Candidates 
                    Console.WriteLine("Regsiter new Candidates");
                    string? newCandidate = Console.ReadLine();
                    if (nameDict.ContainsKey(newCandidate))
                    {
                        Console.WriteLine("Candidate exist");
                    }
                    else
                    {
                        votersName.Add(newCandidate);
                        Console.WriteLine("The Candidate added");

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }





            }
            InecProject();
        }

    }

}
