namespace Ef_Traineemanagement
{
    public class Delete{
       public void RemoveData()
{
    using (var context = new TraineeContext())
    {
    
        
        Console.Write("Enter the Employee Id ");
        int  isbnToRemove = Convert.ToInt32(Console.ReadLine());

        
        var TarineeToRemove = context.Traineedetails.FirstOrDefault(b => b.Empno == isbnToRemove);

        if (TarineeToRemove != null)
        {
       
            Console.WriteLine($"Removing Trainee - id: {TarineeToRemove.Empno}, Employee name: {TarineeToRemove.Name}");

     
            context.Traineedetails.Remove(TarineeToRemove);

            
            context.SaveChanges();

            Console.WriteLine("Removal successful!");
        }
        else
        {
            Console.WriteLine($"Employee id is {isbnToRemove} not found.");
        }
    }
}


    }

}