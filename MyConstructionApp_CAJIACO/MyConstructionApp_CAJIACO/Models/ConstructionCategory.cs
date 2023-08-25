using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyConstructionApp_CAJIACO.Models
{
    public  class ConstructionCategory
    {
        public ConstructionCategory()
        {
           // Constructions = new HashSet<Construction>();
        }
        public RestRequest Request { get; set; } 
        public int ConstructionCategory1 { get; set; }
        public string Description { get; set; } = null!;
        public int UserId { get; set; }

        //public virtual User? User { get; set; } = null!;
        // public virtual ICollection<Construction>? Constructions { get; set; }

        public async Task<bool> AddConstructionCategoryAsync()
        {
            try
            {
                string RouteSufix = string.Format("ConstructionCategories");
                //armamos la ruta completa al endpoint en el API 
                string URL = Services.APIConnection.ProductionPrefixURL + RouteSufix;

                RestClient client = new RestClient(URL);

                Request = new RestRequest(URL, Method.Post);

                //agregamos mecanismo de seguridad, en este caso API key
                Request.AddHeader(Services.APIConnection.ApiKeyName, Services.APIConnection.ApiKeyValue);

                //en el caso de una operación POST debemos serializar el objeto para pasarlo como 
                //json al API 
                string SerializedModelObject = JsonConvert.SerializeObject(this);
                //agregamos el objeto serializado el el cuuerpo del request. 
                Request.AddBody(SerializedModelObject, GlobalObjects.MimeType);

                //ejecutar la llamada al API 
                RestResponse response = await client.ExecuteAsync(Request);

                //saber si las cosas salieron bien 
                HttpStatusCode statusCode = response.StatusCode;

                if (statusCode == HttpStatusCode.Created)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw;
            }

        }



    }
}
