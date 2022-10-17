using GreetMe_DataAccess.DTO;
using GreetMe_DataAccess.Model;

namespace GreetMe_API.ModelConversion
{
    public static class ViewDTOConverter
    {
        //Convert to ViewDto
        public static ViewDto ConvertTo(View view)
        {
            ViewDto viewDto = new ViewDto(
                view.Id,
                view.ViewName
                );
            return viewDto;
        }

        //Convert from ViewDto
        public static View ConvertFrom(ViewDto view)
        {
            //TODO
            throw new NotImplementedException();
        }
    }
}
