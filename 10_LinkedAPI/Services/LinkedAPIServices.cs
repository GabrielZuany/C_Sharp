using System.Text.Json;
using System.Net;
using MyLinkedAPI.Models;

namespace MyLinkedAPIServices.Services;
public class LinkedAPIService
{
    static List<LinkedAPI>data {get; }
    static LinkedAPIService()
    {
        var json = new WebClient().DownloadData("https://jsonplaceholder.typicode.com/posts");
        data = JsonSerializer.Deserialize<List<LinkedAPI>>(json)!;
    }

    public static List<LinkedAPI> GetAll() => data;

    public static LinkedAPI? Get(int id) => data.FirstOrDefault(x => x.id == id);

    public static void Add(LinkedAPI api_data)
    {
        data.Add(api_data);
    } 
    public static void Delete(int id)
    {
        var api_id = Get(id);
        if (api_id == null){
            return;
        }
        data.Remove(api_id);
    }

    public static void Update(LinkedAPI api)
    {
        var index = data.FindIndex(p => p.id == api.id);
        if(index == -1){
            return;
        }
        data[index] = api;
    }

}
