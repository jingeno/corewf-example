using System.Activities.XamlIntegration;

Console.WriteLine("Loading workflow...");
string xaml = File.ReadAllText("WorkflowExample.xaml");
var helloWorldActivity = ActivityXamlServices.Load(new StringReader(xaml));

Console.WriteLine("Invoking workflow...");
System.Activities.WorkflowInvoker.Invoke(helloWorldActivity);

Console.ReadLine();
