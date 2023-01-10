using Microsoft.AspNetCore.Mvc;
using React_Dotnet_Project1.Models;

namespace React_Dotnet_Project1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController: ControllerBase
    {
        private static readonly IEnumerable<ItemModel> Items = new[] {
            new ItemModel() { Id = 1,Title = "The Godfather", ImageId = 1, Ranking = 0, ItemType = 1},
            new ItemModel() { Id = 2,Title = "Highlander", ImageId= 2, Ranking= 0, ItemType = 1},
            new ItemModel() { Id = 3,Title = "HighLander II", ImageId =3, Ranking = 0, ItemType = 1},
            new ItemModel() { Id = 4,Title = "Road House", ImageId = 4,Ranking = 0, ItemType= 1},
            new ItemModel() { Id = 5,Title = "Star Trek",ImageId = 5,Ranking = 0, ItemType=1}
        };


        [HttpGet("{itemType:int}")]
        public ItemModel[] Get(int itemType)
        {
            ItemModel[] items = Items.Where(i => i.ItemType == itemType).ToArray();
            System.Threading.Thread.Sleep(1000);
            return items;
        }
    }
}
