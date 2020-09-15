using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Assignment1.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Assignment1DbContext(serviceProvider.GetRequiredService<DbContextOptions<Assignment1DbContext>>()))
            {
                // Look for any Projects.
                if (context.Projects.Any())
                {
                    return; // DB has been seeded
                }

                context.Teams.AddRange(
                    new Team
                    {
                        teamName = "Alpha",
                        Members = new List<Member> {
                            new Member {
                                Name = "Christiana Hood",
                                year = "Junior",
                                email = "chood@codingclub.com"
                            },
                            new Member {
                                Name = "Ross Holman",
                                year = "Senior",
                                email = "rholman@codingclub.com"
                            },
                            new Member {
                                Name = "Lillie Huber",
                                year = "Senior",
                                email = "lhuber@codingclub.com"
                            }
                        },
                        Projects = new List<Project> {
                            new Project {
                                Name = "College of Business' Website",
                                Client = new Client {
                                    Name = "Kadeem Kennedy"
                                }
                            },
                            new Project {
                                Name = "College of Engineering's Website",
                                Client = new Client {
                                    Name = "Safah Philip"
                                }
                            }
                        }
                    },
                    new Team
                    {
                        teamName = "Bravo",
                        Members = new List<Member> {
                            new Member {
                                Name = "Ishmael Noel",
                                year = "Sophmore",
                                email = "inoel@codingclub.com"
                            },
                            new Member {
                                Name = "Rachelle Bryant",
                                year = "Junior",
                                email = "rbryant@codingclub.com"
                            },
                            new Member {
                                Name = "Jacque Webber",
                                year = "Senior",
                                email = "jwebber@codingclub.com"
                            }
                        },
                        Projects = new List<Project> {
                            new Project {
                                Name = "Fine Arts' Website",
                                Client = new Client {
                                    Name = "Jane Stevens"
                                }
                            },
                            new Project {
                                Name = "Agriculture Sciences' Website",
                                Client = new Client {
                                    Name = "Rosemarie Wheatley"
                                }
                            }
                        }
                    }
                );
                context.SaveChanges();
            }
        }
    }
}