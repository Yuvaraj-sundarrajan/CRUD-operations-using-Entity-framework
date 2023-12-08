namespace Ef_Traineemanagement{
    public class Create{
        public void InsertData()
    {
      using(var context = new TraineeContext())
      {
        
        context.Database.EnsureCreated();
        Console.WriteLine("Enter Employee id");
        int eid =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Name");
        string ename = Console.ReadLine();
        Console.WriteLine("Enter the Domain");
        string domain = Console.ReadLine();
        Console.WriteLine("Enter the worklocation");
        string location= Console.ReadLine();
        context.Traineedetails.Add(new Trainee
        {
          Empno=eid,
          Name=ename,
          Domain=domain,
          worklocation=location
        });
    
        context.SaveChanges();
      }
    }
        
    }

}