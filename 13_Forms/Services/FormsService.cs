using FormsModel.Models;
using System.Text.Json;

namespace FormsServices.Services;
public static class FormsServices
{
    static List<Forms> Users {get;}
    static int nextId = 1;

    static FormsServices()
    {   
        string jsonString = File.ReadAllText("Data/users.json");
        Users = JsonSerializer.Deserialize<List<Forms>>(jsonString)!;
    }

    public static List<Forms> GetAll() => Users;

     public static Forms? Get(int id) => Users.FirstOrDefault(p => p.Id == id);

    public static void Add(Forms user)
    {   
        foreach(var usr in Users){
            if(user.Name == usr.Name){
                return;
            }
        }

        user.Id = nextId;
        nextId += 1;
        Users.Add(user);

        string AllUsers = JsonSerializer.Serialize<List<Forms>>(Users);
        System.IO.File.WriteAllText("Data/users.json", AllUsers);
    }

    public static void Delete(int id)
    {
        var usr = Get(id);
        if(usr == null){
            return;
        }
        Users.Remove(usr);

        string AllUsers = JsonSerializer.Serialize<List<Forms>>(Users);
        System.IO.File.WriteAllText("Data/users.json", AllUsers);
    }

    public static void Update(Forms usr)
    {
        var index = Users.FindIndex(x => x.Id == usr.Id);
        if(index == -1){
            return;
        }
        Users[index] = usr;

        string AllUsers = JsonSerializer.Serialize<List<Forms>>(Users);
        System.IO.File.WriteAllText("Data/users.json", AllUsers);
    }
}