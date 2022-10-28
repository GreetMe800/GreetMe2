using GreetMe_API.DTO;
using GreetMe_DataAccess.Model;

namespace GreetMe_API.ModelConverter
{
    public static class LayoutDTOConverter
    {
        //Convert to LayoutDto (convert from database, getdata) /\
        public static LayoutDto ConvertToDto(Layout layout)
        {
            LayoutDto layoutDto = new LayoutDto(
                layout.Id,
                layout.LayoutName
                );
            return layoutDto;
        }

        //Convert from LayoutDto (convert to database, savedata) \/
        public static Layout ConvertFromDto(LayoutDto layoutDto)
        {
            Layout layout = new Layout();
            layout.LayoutName = layoutDto.LayoutName;
            return layout;
        }
    }
}
