using Microsoft.EntityFrameworkCore;
using PhonebookWebApp.Data;

namespace PhonebookWebApp.Models
{
	public class SeedData
	{
		public static void Initialize(IServiceProvider serviceProvider)
		{
			using (PhonebookWebAppContext context = new(
				serviceProvider.GetRequiredService<
					DbContextOptions<PhonebookWebAppContext>>()))
			{
				if (context.Note.Any())
				{
					return;
				}
				context.Note.AddRange(
					new Note
					{
						SecondName = "SName1",
						Name = "Name1",
						ThirdName = "THName1",
						Phone = "+1 111 111 11 11",
						Address = "Russian Federation",
						Description = "bad guy"
					},
					new Note
					{
						SecondName = "SName2",
						Name = "Name2",
						ThirdName = "THName2",
						Phone = "+2 222 222 22 22",
						Address = "Russian Federation",
						Description = "good guy"
					},
					new Note
					{
						SecondName = "SName3",
						Name = "Name3",
						ThirdName = "THName3",
						Phone = "+3 333 333 33 33",
						Address = "Russian Federation",
						Description = "so so guy"
					},
					new Note
					{
						SecondName = "SName4",
						Name = "Name4",
						ThirdName = "THName4",
						Phone = "+4 444 444 44 44",
						Address = "Russian Federation",
						Description = "bestie"
					}
				);
				context.SaveChanges();
			}
		}
	}
}
