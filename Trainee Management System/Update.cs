namespace Ef_Traineemanagement
{
    public class Update
    {
        public void UpdateData()
        {
            using (var context = new TraineeContext())
            {

                Console.Write("Enter your employee id ");
                int Employeeid = Convert.ToInt32(Console.ReadLine());

                var TraineeToUpdate = context.Traineedetails.FirstOrDefault(b => b.Empno == Employeeid);

                if (TraineeToUpdate != null)
                {
                    Console.WriteLine("Updating  values into the tables: ");
                    Console.WriteLine("What you want to update");
                    Console.WriteLine("1.Name \n 2.Domain\n 3.Worklocation");
                    int updatechoice = Convert.ToInt32(Console.ReadLine());
                    switch (updatechoice)
                    {
                        case 1:
                            Console.WriteLine($"Current Name: {TraineeToUpdate.Name}");
                            Console.Write("Enter new Name : ");
                            string newname = Console.ReadLine();
                            TraineeToUpdate.Name = newname;
                            break;
                        case 2:
                            
                            Console.WriteLine($"Current Domain: {TraineeToUpdate.Domain}");
                            Console.Write("Enter new Domain: ");
                            string newDomain = Console.ReadLine();
                            TraineeToUpdate.Domain = newDomain;
                            break;
                        case 3:
                            Console.WriteLine($"Current Location: {TraineeToUpdate.worklocation}");
                            Console.Write("Enter new Location: ");
                            string newlocation = Console.ReadLine();
                            TraineeToUpdate.worklocation = newlocation;
                            break;

                    }
                    context.SaveChanges();
                }

                else
                {
                    Console.WriteLine($"Employe Id {Employeeid} not found.");
                }
            }
        }



    }

}