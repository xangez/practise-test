using PracticeTest.Data;
using PracticeTest.Models;
using Newtonsoft.Json;


namespace PracticeTest.Data;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        var context = serviceProvider.GetRequiredService<PracticeTestContext>();


        // Look for courses.
        if (context.Courses.Any())
        {
            return; // DB has already been seeded.
        }


        context.SaveChanges();
    }
}