using GreetMe_DataAccess.Model;
using GreetMe_API.DTO;


namespace GreetMe_API.BusinessLogic
{
    public static class ViewDtoConverter
    {
        //Convert to ViewDto (convert from database, getdata) /\
        public static ViewDto ConvertToDto(View view)
        {
            ViewDto viewDto = new ViewDto(
            view.Id,
            view.ViewName
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
