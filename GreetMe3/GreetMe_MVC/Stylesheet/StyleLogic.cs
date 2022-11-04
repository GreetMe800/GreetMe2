namespace GreetMe_MVC.Stylesheet
{
    public static class StyleLogic
    {

        public static List<int> getStyle() 
        {
            List<int> styles = new List<int>();
            styles.Add(1);
            styles.Add(1);
            styles.Add(1);
            styles.Add(1);
            styles.Add(0);
            styles.Add(1);
            styles.Add(1);
            return styles;
        }


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
