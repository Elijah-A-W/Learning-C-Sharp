using Azure.Core;
using EntityFramework.Data;
using EntityFrameworkCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace GraspEnityFrameWorkMainConsoleApp
{
    class Program
    {
        private static readonly FootballLeagueDbContext context = new FootballLeagueDbContext();

        static async Task Main(string[] args)
        {
            await QueryRelatedRecords();


            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
        

        // ***** DELETING INFO FROM THE DATABASE ****** //
        // Deleting table value with relationships 
        // with another table
        static async Task DeleteRecordWithRelationship()
        {
            var league = await context.Leagues.FindAsync(15);
            context.Leagues.Remove(league);
            await context.SaveChangesAsync();
        }


        // Deleting a table value without relationships 
        static async Task DeleteSimpleRecord()
        {
            var recordToDelete = await context.Leagues.FindAsync(4);
            context.Leagues.Remove(recordToDelete);
            await context.SaveChangesAsync();
        }



        // *******  UPDATING OR MAKING CHANGES TO THE DB ******* //

        // Updating table data using object of the db Team
        static async Task UpdatingAlternativeApproch()
        {
            var team = new Team
            {
                Id = 5,
                Name = "Apara Boys",
                LeagueId = 1
            };
            context.Teams.Update(team);
            await context.SaveChangesAsync();
        }

        // printing the updated record
        static async Task ReturnUpdatedTeam()
        {
            // run the update returnd team record
            await UpdateReturnedTeamRecord();
            // return the updated Teams record 
            var updatedteams = await context.Teams.FindAsync(10);
            Console.WriteLine($"The team is called {updatedteams.Name}");

        }

        // Updating the returned record 
        static async Task UpdateReturnedTeamRecord()
        {
            // Retrieve record by its ID 10
            var team = await context.Teams.FindAsync(10);
            // Updating the record
            team.Name = "Kessii fc";
            // save changes
            await context.SaveChangesAsync();

        }




        // ********** RETURNIN & FILTERINGF DATA FROM THE DB ********* //

        // Another way to return filtered results
        static async Task FilterAnyResult()
        {
            Console.Write("Filter for any team: ");
            var getName = Console.ReadLine();

            var queryTheDB = await (from i in context.Teams
                                    where i.Name.Contains(getName)
                                    select i).ToListAsync();

            foreach (var team in queryTheDB)
            {
                Console.WriteLine($"{team.Name} with {team.LeagueId}");
            }
        }


        // filtering a specific result
        static async Task FilterSpecificResult()
        {
            Console.Write($"Enter team Name (Or Part Of): ");
            var teamName = Console.ReadLine();
            var teams = await (from i in context.Teams
                               where EF.Functions.Like(i.Name, $"%{teamName}%")
                               select i).ToListAsync();

            foreach (var team in teams)
            {
                Console.WriteLine($"{team.Id} - {team.Name}");
            }
        }


        // Different methods to help return DB data
        static async Task ReturningDataAlternatives()
        {
            var leagues = context.Leagues;

            var list = await leagues.ToListAsync();
            var first = await leagues.FirstAsync();
            var firstOrDefault = await leagues.FirstOrDefaultAsync();
            /// var single = await leagues.SingleAsync();
            /// var singleOrDeafult = await leagues.SingleOrDefaultAsync();

            /// var count = await leagues.CountAsync();
            /// var longCount = await leagues.LongCountAsync();
            /// var min = await leagues.MinAsync();
            /// var max = await leagues.MaxAsync(); 

        }


        //Method to return League data from DB
        static async Task ReturnLeagueData()
        {
            var leagues = await context.Leagues.Where(q => q.Name == "Serie A").ToListAsync();

            foreach (var league in leagues)
            {
                Console.WriteLine($"{league.Id} - {league.Name}");
            }
        }

        // Querying related recods
        static async Task QueryRelatedRecords()
        {
            //// Get many related records - League ->  Teams 
            var leagues = await context.Leagues.Include(q => q.Teams).ToListAsync();
            
            //// Get One Related Record -  Team -> Coach
            //// var teams = await context.Teams.Include(s => s.Coach).FirstOrDefaultAsync(s => s.Id == 3);
            
            //// Get 'Grand children related record' - Team -> Matches -> Home/Away Team
            /* var teamsWithTheirFixtures = await context.Teams
                .Include(w => w.HomeMatches).ThenInclude(w => w.HomeTeam).ThenInclude(w => w.Coach)
                .Include(w => w.AwayMatches).ThenInclude(w => w.AwayTeam).ThenInclude(w => w.Coach)
                .ToListAsync(); */

            //// Get One Record with Related records - Team -> Matches ->
            //// Get all the teams with HomeMatches and their coach 
            /* var allHomeGames = await context.Teams
                .Where(q => q.HomeMatches.Count() > 0)
                .Include(q => q.Coach)
                .ToListAsync(); */
        }


        // Selecting a particluar record property
        static async Task SelectOneProperty()
        {
            var getOneProperty = await context.Teams.Select(q => q.Name).ToListAsync(); 
        }

        static async Task AnonymousProjection()
        {
            var teams = await context.Teams
                .Include(q => q.Coach)
                .Select(q => new { TeamName = q.Name, CoachName = q.Coach.Name })
                .ToListAsync();

            foreach(var item in teams)
            {
                Console.WriteLine($"Team: {item.TeamName} | Coach: {item.CoachName}");
            }
        }

        static async Task StronglyTypedProjection()
        {

        }




        // *********** ADDING DATA TO THE DB ************ //
        // Method to add new a new league :POST
        static async Task AddNewLeague()
        {
            var league = new League { Name = "MZ PLF" };


            await context.AddAsync(league);
            await context.SaveChangesAsync();

            await AddMultipleTeamsToLeague(league);

        }

        // Method to add a new Team     :POST
        static async Task AddNewTeam(League league)
        {
            var team = new Team { Name = "Amavumbi stars", LeagueId = league.Id };

            await context.AddAsync(team);
            await context.SaveChangesAsync();

        }

        // Method to add multiple teams to the DB
        static async Task AddMultipleTeamsToLeague(League league)
        {
            var Teams = new List<Team>
            {
                new Team
                {
                    Name = "Kesi Fc", LeagueId = league.Id
                },
                new Team
                {
                    Name = "Nairobi FC", LeagueId=league.Id
                },
                new Team
                {
                    Name = "kasi FC", LeagueId = league.Id
                }
            };
            await context.AddRangeAsync(Teams);
            await context.SaveChangesAsync();
        }

        // Method to add new teams with a selected league
        static async Task AddNewTeamsWithLeague()
        {
            // Here we reference the league
            // add the newly created teams to the league

            var newteams = new List<Team>
            {
                new Team
                {
                    Name = "Weere Fc"
                },
                new Team
                {
                    Name = "busamaga Fc"
                }
            };

            var addleague = new League { Id = 3 , Teams = newteams };
            await context.AddAsync(addleague);
            await context.SaveChangesAsync();
        }

        // Method to add a new team with a league
        static async Task AddNewTeamWithLeagueId()
        {
            // create both new League and new team
            // attach the new league to the teams 
            var newleague = new League { Name="EngPL"};
            var newTeam = new Team { Name = "SouthAmptom", LeagueId = newleague.Id };

            await context.AddAsync(newTeam);
            await context.SaveChangesAsync();
        }

        // Method to add new league with teams
        static async Task AdddNewLeagueWithTeams()
        {
            // create a new league and add
            // new teams to the league
            var teams = new List<Team>
            {
                new Team
                {
                    Name = "wuyo fc",
                },
                new Team
                {
                    Name = "guyo fc"
                }
            };
            var newLeague = new League { Name = "Yaffe league", Teams = teams };
            await context.AddAsync(newLeague);
            await context.SaveChangesAsync();
        }


        // Method to add new matches 
        static async Task AddNewMatches()
        {
            var matches = new List<Match>
            {
                new Match
                {
                    HomeTeamId = 3, AwayTeamId = 4, Date = new DateTime(2023, 11, 16)
                },
                new Match
                {
                    HomeTeamId = 6, AwayTeamId = 5, Date =DateTime.Now
                },
                new Match
                {
                    HomeTeamId = 10, AwayTeamId = 11, Date = new DateTime(2023, 11, 18)
                }
            };
            await context.AddRangeAsync(matches);
            await context.SaveChangesAsync();
        }

        // Method to add new Coach
        static async Task AddNewCoach()
        {
            var coaches = new Coach
            {
                Name = "Musa LP",
                TeamId = 3
            };
            await context.AddAsync(coaches);
            await context.SaveChangesAsync();
        }

    }
}