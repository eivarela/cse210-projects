using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
    
        Job job1 = new Job();

        job1._jobTitle = "Soporte Tecnico";
        job1._company = "FICOHSA";
        job1._startYear = 2020;
        job1._endYear = 2022;

        Job job2 = new Job();

        job2._jobTitle = "Administrador de Redes";
        job2._company = "LAFISE";
        job2._startYear = 2023;
        job2._endYear = 2023;

        Resume resume = new Resume();

        resume._name = "Evans Varela";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();     
    }
}