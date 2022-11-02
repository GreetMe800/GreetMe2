namespace GreetMe_MVC.Stylesheet
{
    public static class StyleLogic
    {


        public static string[,] getStyle(string Name)
        {
            
            if (Name == "style1")
            {
                string[,] a = { { "fill", "fill" }, { "double", "empty", }, { "empty", "fill", } }; ;
                return a;
            }
            else 
            {
                return null;
            }
           

          

        }
    }
}
