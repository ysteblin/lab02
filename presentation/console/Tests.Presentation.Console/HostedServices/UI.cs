using Tests.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Presentation.Console.HostedServices
{
    public class UI
    {
        public static void Welcome()
        {
            System.Console.WriteLine("Выберите пункт меню для начала:");
            System.Console.WriteLine("1 - Добавить объект");
            System.Console.WriteLine("2 - Получить объект");
        }

        public static void Add() 
        {
            System.Console.WriteLine("Выберите объект:");
            System.Console.WriteLine("1 - Экзамен");
            System.Console.WriteLine("2 - Выпускной экзамен");
            System.Console.WriteLine("3 - Испытание");
        }

        public static string[] Test()
        {
            System.Console.WriteLine("Введите тему экзамена:");
            string Topic = System.Console.ReadLine();
            System.Console.Clear();

            System.Console.WriteLine("Введите время теста (в секундах):");
            string TestTime = System.Console.ReadLine();
            System.Console.Clear();

            return [Topic, TestTime];
        }

        public static int[] Exam()
        {
            System.Console.WriteLine("Введите уровень сложности:");
            int DifficultLevel = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Clear();

            System.Console.WriteLine("Введите количество вопросов:");
            int QuestionsCount = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Clear();

            System.Console.WriteLine("Введите проходной балл:");
            int PassingScore = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Clear();

            return [DifficultLevel, QuestionsCount, PassingScore];
        }

        public static int[] FinalExam()
        {
            System.Console.WriteLine("Введите уровень сложности:");
            int DifficultLevel = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Clear();

            System.Console.WriteLine("Введите количество вопросов:");
            int QuestionsCount = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Clear();

            System.Console.WriteLine("Введите проходной балл:");
            int PassingScore = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Clear();

            return [DifficultLevel, QuestionsCount, PassingScore];
        }


        public static string[] Challenge()
        {
            System.Console.WriteLine("Введите местоположение испытания:");
            string Location = System.Console.ReadLine();
            System.Console.Clear();

            System.Console.WriteLine("Введите дату испытания:");
            string Date = System.Console.ReadLine();
            System.Console.Clear();

            System.Console.WriteLine("Введите проходной балл:");
            string PassingScore = System.Console.ReadLine();
            System.Console.Clear();

            return [Location, Date, PassingScore];
        }


    }
}
