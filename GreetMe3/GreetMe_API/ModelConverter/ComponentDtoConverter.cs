using GreetMe_API.DTO;
using GreetMe_DataAccess.Model;

namespace GreetMe_API.ModelConverter
{
    public static class ComponentDtoConverter
    {
        //Convert to ComponentDto (convert from database, getdata) /\
        public static ComponentDto ConvertToDto(Component component)
        {
            ComponentDto componentDto = new ComponentDto()
            {
                Id = component.Id,
                ComponentName = component.ComponentName
            };

            return componentDto;
        }

        //Convert from ComponentDto (convert to database, savedata) \/
        public static Component ConvertFromDto(ComponentDto componentDto)
        {
            Component component = new Component()
            {
                ComponentName = componentDto.ComponentName,
            };
            return component;
        }
    }
}
