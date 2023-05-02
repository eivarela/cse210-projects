using System;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();
        job1._jobTitle = "Administrador de Redes";
        job1._company = "Banco LAFISE";
        job1._startYear = 2022;
        job1._endYear = 2023;

        //job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._jobTitle = "Soporte Tecnico";
        job2._company = "Banco LAFISE";
        job2._startYear = 2020;
        job2._endYear = 2022;
        
        //job2.DisplayJobDetails();

        Resume Resume1 = new Resume();
        Resume1._name = "Evans Varela";
        Resume1._jobs.Add(job1);
        Resume1._jobs.Add(job2);

        Resume1.DisplayResume();
        

    }
}