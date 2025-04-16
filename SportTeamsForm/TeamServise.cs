using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace SportTeamsProg
{
    class TeamServise
    {
        private readonly TeamRepository _teamRepository;

        public TeamServise(TeamRepository repository)
        {
            _teamRepository = repository;
        }


        public static bool IsNumber(string s)
        {
            foreach (var item in s)
            {
                if (!char.IsDigit(item))
                    return false; //если хоasdasdasdasdsadsadь один символ не число, то выкидываешь "ложь"
            }
            return true; //если ни разу не выбило в цикле, значит, все символы - это цифры
        }
        public void AddTeam()
        {
            Console.WriteLine("добавить команду");
            Console.Write("название команды: ");
            var teamName = Console.ReadLine()!;
            int playerCount = GetPlayerCount();

            var IsProfessionalResult = 0;
            bool isProfessional = false;
            while (IsProfessionalResult == 0)
            {
                Console.WriteLine("это профессиональная команда? (Д/Н)");
                var IsProfesionalInput = Console.ReadLine()!;

                if (IsProfesionalInput == "д" || IsProfesionalInput == "Д")
                {
                    isProfessional = true;
                    IsProfessionalResult = 1;
                }
                else if (IsProfesionalInput == "н" || IsProfesionalInput == "Н")
                {
                    isProfessional = false;
                    IsProfessionalResult = 1;
                }
                else
                {
                    Console.WriteLine("неправильный ввод, попробуйте 'д' или 'н'");
                    IsProfessionalResult = 0;
                }
            }

            var result = _teamRepository.Add(new Team(teamName, playerCount, isProfessional));
            if (result)
                Console.WriteLine("команда добавлена");
            else
                Console.WriteLine("команда не добавлена, что-то пошло не так");
        }

        public void GetAll()
        {
            Console.WriteLine("список всех команд");
            Console.WriteLine("ID \tназвание команды\tколичество игроков\tпрофессиональная ли команда");
            var teams = _teamRepository.GetAll();
            foreach (var team in teams) 
            Console.WriteLine($"{team.Id}\t{team.TeamName}\t{team.PlayerCount}\t{team.IsProfessional}");
        }

        public void GetOne()
        {
            Console.WriteLine("вывод конкретной команды");
            Console.WriteLine("введите ID команды: ");
            int id = int.Parse(Console.ReadLine()!);
            var team = _teamRepository.Get(id);
            string IsProfesionalConvert = "";
            if (team == null)
            {
                Console.WriteLine("нет команды с таким ID");
                return;
            }

            Console.WriteLine("ID \tназвание команды\tколичество игроков\tпрофессиональная ли команда");
            if (team.IsProfessional == true)
                IsProfesionalConvert = "да";
            else
                IsProfesionalConvert = "нет";
            Console.WriteLine($"{team.Id}\t{team.TeamName}\t{team.PlayerCount}\t{IsProfesionalConvert}");

        }

        public void Delete()
        {
            Console.WriteLine("удаление команды");
            Console.WriteLine("введите ID команды: ");
            int id = int.Parse(Console.ReadLine()!);
            var result = _teamRepository.Delete(id);
            if (result)
                Console.WriteLine("команда удалена");
            else
                Console.WriteLine("команда не удалена, что-то пошло не так");
        }

        public void Update()
        {
            bool exit = false;
            while (!exit)
            {

                UpdateMenu1();
                string command = Console.ReadLine()!;
                Console.Clear();
                Console.WriteLine("изменение команды");
                switch (command)
                {
                    case "1":
                        UpdateAll();
                        break;
                    case "2":
                        UpdateName();
                        break;
                    case "3":
                        UpdateCount(); 
                        break;
                    case "4":
                        UpdateProfessional();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("неправильный ввод");
                        break;


                }
            }
        }
        public void UpdateAll()
        {
            Console.WriteLine("изменение команды");
            Console.WriteLine("введите ID команды");
            var teamId = int.Parse(Console.ReadLine()!);
            Console.Write("название команды: ");
            var teamName = Console.ReadLine()!;
            int playerCount = GetPlayerCount();
            var IsProfessionalResult = 0;
            bool isProfessional = false;
            while (IsProfessionalResult == 0)
            {
                Console.WriteLine("это профессиональная команда? (д/н)");
                var IsProfesionalInput = Console.ReadLine()!;

                if (IsProfesionalInput == "д" || IsProfesionalInput == "Д")
                {
                    isProfessional = true;
                    IsProfessionalResult = 1;
                }
                else if (IsProfesionalInput == "н" || IsProfesionalInput == "Н")
                {
                    isProfessional = false;
                    IsProfessionalResult = 1;
                }
                else
                {
                    Console.WriteLine("неправильный ввод, попробуйте 'д' или 'н'");
                    IsProfessionalResult = 0;
                }
            }

            var result = _teamRepository.UpdateAllPos(new Team(teamId, teamName, playerCount, isProfessional));
            if (result)
                Console.WriteLine("команда обновлена");
            else
                Console.WriteLine("команда не обновлена, что-то пошло не так");
        }

        public void UpdateName()
        {
            Console.WriteLine("введите ID команды");
            var teamId = int.Parse(Console.ReadLine()!);
            Console.Write("название команды: ");
            var teamName = Console.ReadLine()!;
            var result = _teamRepository.UpdateTeamName(new Team(teamId, teamName));
            if (result)
                Console.WriteLine("команда добавлена");
            else
                Console.WriteLine("команда не добавлена, что-то пошло не так");
        }

        public void UpdateCount()
        {
            Console.WriteLine("введите ID команды");
            var teamId = int.Parse(Console.ReadLine()!);
            int playerCount = GetPlayerCount();
            var result = _teamRepository.UpdatePlayerCount(new Team(teamId, playerCount));
            if (result)
                Console.WriteLine("количество игроков обновлено");
            else
                Console.WriteLine("количество игроков не обновлено, что-то пошло не так");
        }
        public void UpdateProfessional()
        {
            Console.WriteLine("введите ID команды");
            var teamId = int.Parse(Console.ReadLine()!);
            var IsProfessionalResult = 0;
            var isProfessional = false;
            while (IsProfessionalResult == 0)
            {
                Console.WriteLine("это профессиональная команда? (д/н)");
                var IsProfesionalInput = Console.ReadLine()!;

                if (IsProfesionalInput == "д" || IsProfesionalInput == "Д")
                {
                    isProfessional = true;
                    IsProfessionalResult = 1;
                }
                else if (IsProfesionalInput == "н" || IsProfesionalInput == "Н")
                {
                    isProfessional = false;
                    IsProfessionalResult = 1;
                }
                else
                {
                    Console.WriteLine("неправильный ввод, попробуйте 'д' или 'н'");
                    IsProfessionalResult = 0;
                }
            }

            var result = _teamRepository.UpdateIsProfessional(new Team(teamId, isProfessional));
            if (result)
                Console.WriteLine("команда добавлена");
            else
                Console.WriteLine("команда не добавлена, что-то пошло не так");
        }
        static void UpdateMenu1()
        {
            Console.Clear();
            Console.WriteLine("1: изменить полностью");
            Console.WriteLine("2: название команды");
            Console.WriteLine("2: количество игроков");
            Console.WriteLine("2: професиональная ли команда");
            Console.WriteLine("0: выход");
        }
        private int GetPlayerCount()
        {
            int playerCount;
            while (true)
            {
                Console.WriteLine("игроков в команде: ");
                var input = Console.ReadLine();
                if (int.TryParse(input, out playerCount) && playerCount > 0)
                {
                    return playerCount;
                }
                else
                {
                    Console.WriteLine("неправильный ввод, введите положительное число.");
                }
            }
        }


    }
}
