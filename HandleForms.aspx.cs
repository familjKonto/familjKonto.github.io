using System;
using System.Web.Services;
using Newtonsoft.Json;

public partial class HandleForms : System.Web.UI.Page
{
    [WebMethod]
    public static string HandleForms(string name, string email, string message)
    {
        // Perform any necessary processing on the form data here
        // (e.g., save it to a database)

        // Return a JSON response indicating success or failure
        try
        {
            // Assume that the form was processed successfully
            var response = new { message = "Your form was processed successfully!" };
            return JsonConvert.SerializeObject(response);
        }
        catch (Exception ex)
        {
            // An error occurred while processing the form
            var response = new { message = "An error occurred while processing the form: " + ex.Message };
            return JsonConvert.SerializeObject(response);
        }
    }
}