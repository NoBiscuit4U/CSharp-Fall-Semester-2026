using Microsoft.Extensions.DependencyInjection;
using DepInjTest;

class Program{
    static void Main(string[] args){
        var services=new ServiceCollection();

        services.AddSingleton<IStudentRepository,StudentRepositoryService>();
        services.AddSingleton<StudentClient>();

        var serviceProvider=services.BuildServiceProvider();

        var studentClient=serviceProvider.GetRequiredService<StudentClient>();

        studentClient.Test();
    }
}
