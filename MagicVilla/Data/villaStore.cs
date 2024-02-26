using MagicVilla.Models.Dto;

namespace MagicVilla.Data
{
    public static class villaStore
    {
        public static List<villaDTO> villaList = new List<villaDTO>()
        {
                new villaDTO{Id=1, Name="Pool View"},
                new villaDTO{Id=2,Name="Beach View"}
        };
    }
}
