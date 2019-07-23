namespace Footy.Api.Data
{
    using Microsoft.EntityFrameworkCore;
    using Models;
    using System.Collections.Generic;
    public class SampleTeamData
    {
        public List<Team> GetSampleTeamData() => new List<Team>
            {
                new Team{ Name = "AFC Bournemouth"},
                new Team{ Name = "Arsenal"},
                new Team{Name = "Brighton & Hove Albion"},
                new Team{Name = "Burnley"},
                new Team{Name = "Cardiff City"},
                new Team{Name = "Chelsea"},
                new Team{Name = "Crystal Palace"},
                new Team{Name = "Everton"},
                new Team{Name = "Fulham"},
                new Team{Name = "Huddersfield Town"},
                new Team{Name = "Leicester City"},
                new Team{Name = "Liverpool"},
                new Team{Name = "Manchester City"},
                new Team{Name = "Newcastle United"},
                new Team{Name = "Southampton"},
                new Team{Name = "Tottenham Hotspur"},
                new Team{Name = "Watford"},
                new Team{Name = "West Ham United"},
                new Team{Name = "Wolverhamtpon Wanderers"}
            };
    }
}