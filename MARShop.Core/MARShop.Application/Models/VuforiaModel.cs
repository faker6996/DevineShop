namespace MARShop.Application.Models
{
    public class VWSBase
    {
        public string AccessKey { get; set; }
        public string SecretKey { get; set; }
       
    }
    public class VWSCreate : VWSBase
    {
        public string Name { get; set; }
        public float Width { get; set; }
        public string Image { get; set; }
        public int Active_flag { get; set; }
        public string Application_metadata { get; set; }
    }
    public class VWSUpdate : VWSBase
    {
        public string IdTarget { get; set; }
        public float Width { get; set; }
        public string Image { get; set; }
        public int Active_flag { get; set; }
        public string Application_metadata { get; set; }
    }  
    public class VWSDelete : VWSBase
    {
        public string IdTarget { get; set; }
    }
    public class VWSGet: VWSBase
    {
        public string IdTarget { get; set; }
    }
    public class VWSJsonBase
    {
        public float width { get; set; }
        public string image { get; set; }
        public int active_flag { get; set; }
        public string application_metadata { get; set; }
    }
    public class VWSJsonCreate: VWSJsonBase
    {
        public string name { get; set; }
    }
    public class VWSJsonUpdate: VWSJsonBase
    {

    }
}
