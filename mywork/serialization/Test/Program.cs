using System.Reflection;
string path= @"F:\Module\MS Dotnet\git_repo_dotnet\ms_dotnet\serialization\Faculty\bin\Debug\net7.0\faculty.dll";
Assembly assy = Assembly.LoadFile(path);
string name = assy.FullName;
Console.WriteLine(name);

Type[] types = assy.GetTypes();

for(int i=0;i<types.Count();i++){
    string typeName=types[i].Name;
    Console.WriteLine(typeName);
    MethodInfo [] methinfo = types[i].GetMethods();
    foreach(MethodInfo m in methinfo){
        string methodName=m.Name;
        Console.WriteLine(methodName);
    }
}