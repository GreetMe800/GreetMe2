using GreetMe_API.DTO;
using GreetMe_DataAccess.Model;

namespace GreetMe_API.ModelConverter
{
    public static class ViewDtoConverter
    {
        //Convert to ViewDto (convert from database, getdata) /\
        public static ViewDto ConvertToDto(View view)
        {
            List<ComponentDto> componentDtos = new List<ComponentDto>();
            foreach(Component c in view.Components) 
            {
                componentDtos.Add(ComponentDtoConverter.ConvertToDto(c));
            }

            ViewDto viewDto = new ViewDto(
                view.Id,
                view.ViewName,
                LayoutDtoConverter.ConvertToDto(view.Layout),
                componentDtos
                );
            return viewDto;
        }

        //Convert from ViewDto (convert to database, savedata) \/
        public static View ConvertFromDto(ViewDto viewDto)
        {
            View view = new View();
            view.ViewName = viewDto.ViewName;
            return view;
        }
    }
}
