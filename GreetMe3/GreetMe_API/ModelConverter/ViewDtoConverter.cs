using GreetMe_API.DTO;
using GreetMe_DataAccess.Model;

namespace GreetMe_API.ModelConverter
{
    public static class ViewDTOConverter
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
