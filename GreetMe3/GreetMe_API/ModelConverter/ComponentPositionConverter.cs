using GreetMe_API.DTO;
using GreetMe_DataAccess.Model;

namespace GreetMe_API.ModelConverter
{
    public static class ComponentPositionConverter
    {

        public static ComponentPositionDto ConvertToDto(ComponentPosition componentPosition) 
        {
            ComponentPositionDto componentPositionDto = new ComponentPositionDto()
            {
                Id = componentPosition.Id,
                Position = componentPosition.Position,
                Width = componentPosition.Width,
                Height = componentPosition.Height,
                ComponentDto = ComponentDtoConverter.ConvertToDto(componentPosition.Component)
            };
            return componentPositionDto;
        }

    }
}
