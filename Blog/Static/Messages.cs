namespace Blog.Static
{
    public static class Messages
    {
        public static string Error500Message = "There was an error completing your request. Please try Again Later";
        
        public static string ErrorGETMessage(string methodName)
        {
            return $"Error Performing GET in {methodName}";
        }
        
        public static string ErrorNotFoudMessage(string methodName, int id)
        {
            return $"Record Not Found {methodName} - ID: {id}";
        }
        
        public static string ErrorNotFoudMessage(string methodName, string id)
        {
            return $"Record Not Found {methodName} - ID: {id}";
        }

        public static string WentWrong(string methodName)
        {
            return $"Something Went Wrong in the {methodName}";
        }
    }
}
