using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class HospitalDemo
    {
        public void Run()
        {
            Console.WriteLine("=== СИСТЕМА УПРАВЛІННЯ ЛІКАРНЕЮ ===\n");
            Hospital hospital = new Hospital();

            hospital.AddDoctor(new Doctor(1, "Мальований Максим", "Хірург"));
            hospital.AddDoctor(new Doctor(2, "Новосад Валентин", "Офтальмолог"));
            hospital.AddDoctor(new Doctor(3, "Дроб Анрдій", "Уролог"));
            hospital.AddDoctor(new Doctor(4, "Загоруй Іван", "Терапевт"));

            hospital.RegisterPatient(new Patient(1, "Заріцький Максим", 19));
            hospital.RegisterPatient(new Patient(2, "Анікієнко Максим", 20));
            hospital.RegisterPatient(new Patient(3, "Марчук Дмитро", 19));
            hospital.RegisterPatient(new Patient(4, "Маркевич Ліліана", 11));

            hospital.CreateRoom(new HospitalRoom(105, 3));
            hospital.CreateRoom(new HospitalRoom(111, 2));
            hospital.CreateRoom(new HospitalRoom(326, 1));

            hospital.HospitalizePatient(1, 111);
            hospital.HospitalizePatient(2, 326);
            hospital.HospitalizePatient(3, 105);
            hospital.HospitalizePatient(4, 326);

            hospital.AddMedicalRecord(new MedicalRecord(hospital.Patients[0], hospital.Doctors[0], DateTime.Now, "Застуда, призначено лікування"));
            hospital.AddMedicalRecord(new MedicalRecord(hospital.Patients[1], hospital.Doctors[1], DateTime.Now, "Операція апендициту"));

            Console.WriteLine("\n--- ІСТОРІЯ ПАЦІЄНТА ---");
            var history = hospital.GetPatientHistory(2);
            foreach (var record in history)
            {
                Console.WriteLine($"  Дата: {record.Date.ToShortDateString()}");
                Console.WriteLine($"  Лікар: {record.Doctor.Name}");
                Console.WriteLine($"  Опис: {record.Description}\n");
            }

            Console.WriteLine(hospital.GetStatistics());
        }
    }
}
