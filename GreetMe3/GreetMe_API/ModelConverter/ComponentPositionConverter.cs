﻿using GreetMe_API.DTO;
using GreetMe_DataAccess.Model;

namespace GreetMe_API.ModelConverter
{
    public static class ComponentPositionConverter
    {
        //Convert to ComponentPositionDto (convert from database, getdata) /\
        public static ComponentPositionDto ConvertToDto(ComponentPosition componentPosition) 
        {
            ComponentPositionDto componentPositionDto = new ComponentPositionDto()
            {
                Id = componentPosition.Id,
                Position = componentPosition.Position,
                ComponentDto = ComponentDtoConverter.ConvertToDto(componentPosition.Component)
            };
            return componentPositionDto;
        }

        //Convert from ComponentPositionDto (convert to database, savedata) \/
        public static ComponentPosition ConvertFromDto(ComponentPositionDto componentPositionDto)
        {
            ComponentPosition componentPosition = new ComponentPosition() 
            {
                Position = componentPositionDto.Position,
                ComponentId = componentPositionDto.ComponentId,
            };
            return componentPosition;
        }
    }
}