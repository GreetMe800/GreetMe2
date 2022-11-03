using GreetMe_API.DTO;
using GreetMe_DataAccess.Model;

namespace GreetMe_API.ModelConverter
{
    public static class LayoutDtoConverter
    {
        //Convert to LayoutDto (convert from database, getdata) /\
        public static LayoutDto ConvertToDto(Layout layout)
        {
            List<ComponentPositionDto> componentPositions = new List<ComponentPositionDto>();
            foreach(ComponentPosition cp in layout.ComponentPositions) 
            {
                componentPositions.Add(ComponentPositionConverter.ConvertToDto(cp));
            }


            LayoutDto layoutDto = new LayoutDto()
            {
                ViewId = layout.ViewId,
                LayoutName = layout.LayoutName,
                ComponentPositionDtos = componentPositions
            };
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
