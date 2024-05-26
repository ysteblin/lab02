using Microsoft.Extensions.Hosting;
using Tests.Application.Common.Interfaces.Services;
using System;

namespace Tests.Presentation.Console.HostedServices
{
    public class HostedServiceWorker : IHostedService
    {

        private readonly IExamService _examService;
        private readonly IChallengeService _challengeService;
        private readonly IFinalExamService _finalExamService;

        public HostedServiceWorker(IExamService examService, IChallengeService challengeService, IFinalExamService finalExamService){
            _examService = examService;
            _finalExamService = finalExamService;
            _challengeService = challengeService;
        }
        
        public async Task StartAsync(CancellationToken cancellationToken){
            await Task.Delay(1);
            BuildMenu();
        }

        private void BuildMenu(){

            UI.Welcome();

            var key = System.Console.ReadKey();
            System.Console.Clear();

            switch (key.KeyChar)
            {
                case '1':
                    System.Console.Clear();
                    UI.Add();

                    key = System.Console.ReadKey();
                    System.Console.Clear();

                    string[] Test = UI.Test();

                    if (key.KeyChar == '1')
                    {
                        int[] Exam = UI.Exam();

                        var newExam = new Domain.Entities.Exam()
                        {
                            Id = Guid.NewGuid(),
                            Name = $"Тест от {DateTime.Now.ToString()}",
                            TestTime = Int32.Parse(Test[1]),
                            Topic = Test[0],
                            DifficultyLevel = Exam[0],
                            QuestionsCount = Exam[1],
                            PassingScore = Exam[2]

                        };

                        System.Console.WriteLine($"Создан тест Id: {newExam.Id}");
                        _examService.Add(newExam);

                    }
                    else if (key.KeyChar == '2')
                    {
                        int[] finalExam = UI.FinalExam();

                        var newFinalExam = new Domain.Entities.FinalExam()
                        {
                            Id = Guid.NewGuid(),
                            Name = $"Тест от {DateTime.Now.ToString()}",
                            TestTime = Int32.Parse(Test[1]),
                            Topic = Test[0],
                            DifficultyLevel = finalExam[0],
                            QuestionsCount = finalExam[1],
                            PassingScore = finalExam[2]

                        };

                        System.Console.WriteLine($"Создан тест Id: {newFinalExam.Id}");
                        _finalExamService.Add(newFinalExam);
                    }

                    else if (key.KeyChar == '3')
                    {
                        string[] challenge = UI.Challenge();

                        var newChallenge = new Domain.Entities.Challenge()
                        {
                            Id = Guid.NewGuid(),
                            Name = $"Тест от {DateTime.Now.ToString()}",
                            TestTime = Int32.Parse(Test[1]),
                            Topic = Test[0],
                            Location = challenge[0],
                            Date = challenge[1],
                            PassingScore = Int32.Parse(challenge[2]),

                        };

                        System.Console.WriteLine($"Создан тест Id: {newChallenge.Id}");
                        _challengeService.Add(newChallenge);
                    }

                    break;
                case '2':
                    System.Console.Clear();
                    UI.Add();

                    key = System.Console.ReadKey();
                    System.Console.Clear();

                    System.Console.WriteLine("Введите Id теста: ");
                    Guid id = Guid.Parse(System.Console.ReadLine());
                    System.Console.Clear();

                    if (key.KeyChar == '1')
                    {
                        

                        System.Console.WriteLine("Id: " + _examService.GetById(id).Id);
                        System.Console.WriteLine("Название: " + _examService.GetById(id).Name);
                        System.Console.WriteLine("Время теста: " + _examService.GetById(id).TestTime);
                        System.Console.WriteLine("Тема теста: " + _examService.GetById(id).Topic);
                        System.Console.WriteLine("Уровень сложности: " + _examService.GetById(id).DifficultyLevel);
                        System.Console.WriteLine("Количество вопросов: " + _examService.GetById(id).QuestionsCount);
                        System.Console.WriteLine("Проходной балл: " + _examService.GetById(id).PassingScore);
                    }

                    else if(key.KeyChar == '2')
                    {

                        System.Console.WriteLine("Id: " + _finalExamService.GetById(id).Id);
                        System.Console.WriteLine("Название: " + _finalExamService.GetById(id).Name);
                        System.Console.WriteLine("Время теста: " + _finalExamService.GetById(id).TestTime);
                        System.Console.WriteLine("Тема теста: " + _finalExamService.GetById(id).Topic);
                        System.Console.WriteLine("Уровень сложности: " + _finalExamService.GetById(id).DifficultyLevel);
                        System.Console.WriteLine("Количество вопросов: " + _finalExamService.GetById(id).QuestionsCount);
                        System.Console.WriteLine("Проходной балл: " + _finalExamService.GetById(id).PassingScore);
                    }

                    else if(key.KeyChar == '3')
                    {

                        System.Console.WriteLine("Id: " + _challengeService.GetById(id).Id);
                        System.Console.WriteLine("Название: " + _challengeService.GetById(id).Name);
                        System.Console.WriteLine("Время теста: " + _challengeService.GetById(id).TestTime);
                        System.Console.WriteLine("Тема теста: " + _challengeService.GetById(id).Topic);
                        System.Console.WriteLine("Местоположение: " + _challengeService.GetById(id).Location);
                        System.Console.WriteLine("Дата: " + _challengeService.GetById(id).Date);
                        System.Console.WriteLine("Проходной балл: " + _challengeService.GetById(id).PassingScore);
                    }

                    System.Console.ReadKey();
                    break;
                default:
                    break;
            }

            BuildMenu();
        }

        public async Task StopAsync(CancellationToken cancellationToken){
            await Task.Delay(1);
        }


        


    }
}
