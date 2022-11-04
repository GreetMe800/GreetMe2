using GreetMe_API.DTO;
using GreetMe_DataAccess.Model;

namespace GreetMe_API.ModelConverter
{
    public static class ComponentDtoConverter
    {
        //Convert to ComponentDto (convert from database, getdata) /\
        public static ComponentDto ConvertToDto(Component component)
        {
            List<ComponentPositionDto> positions = new List<ComponentPositionDto>();
            foreach (ComponentPosition cp in component.ComponentPositions)
            {
                positions.Add(ComponentPositionConverter.ConvertToDto(cp));
            }
            


            ComponentDto componentDto = new ComponentDto()
            {
                ComponentName = component.ComponentName,
                Id = component.Id,               
            };

            
          
            
            


            return componentDto;
        }

        //Convert from ComponentDto (convert to database, savedata) \/
        public static Component ConvertFromDto(ComponentDto componentDto)
        {
            Component component = new Component();
            component.ComponentName = componentDto.ComponentName;
            return component;
        }
    }
}
