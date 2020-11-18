namespace BrahelBot.Models
{
    /// <summary>
    /// Information Box Class
    /// </summary>
    public class InformationBox
    {
        public string Tittle {get; set;}
        public string Contents {get; set;}
        public InformationBox ParentInformationBox {get; set;}
    }
}