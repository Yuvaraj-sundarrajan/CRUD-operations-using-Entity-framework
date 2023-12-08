using System.Text;

namespace Ef_Traineemanagement
{
    public class Read
    {
        public void PrintData()
        {

            using (var context = new TraineeContext())
            {


                foreach (var traineedetails in context.Traineedetails)
                {
                    var data = new StringBuilder();
                    data.AppendLine($"Empno: {traineedetails.Empno}");
                    data.AppendLine($"Name: {traineedetails.Name}");
                    data.AppendLine($"Domain: {traineedetails.Domain}");
                    data.AppendLine($"worklocation: {traineedetails.worklocation}");

                    Console.WriteLine(data.ToString());
                }
            }

        //     using (var context = new TraineeContext())
        // {
        //     var trainees = context.Traineedetails.ToList();
        //     Console.WriteLine("The trainees are..");
        //     foreach (var trainee in trainees)
        //     {
        //         Console.WriteLine($"|{trainee.Empno} -|- {trainee.Name} -|- {trainee.Domain}-|-{trainee.worklocation}");
        //     }
        //     Console.WriteLine("The Read operation done successfully...");
        // }


        }

    }


}


