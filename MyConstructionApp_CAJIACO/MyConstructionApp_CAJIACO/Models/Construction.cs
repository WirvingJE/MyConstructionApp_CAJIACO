using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyConstructionApp_CAJIACO.Models
{
    public  class Construction
    {
        public Construction()
        {
            //ConstructionStepConstructionSteps = new HashSet<ConstructionStep>();
        }

        [JsonIgnore]
        public RestRequest Request { get; set; }

        public int ProtocolId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime CreationDate { get; set; }
        public bool? Active { get; set; }
        public int UserId { get; set; }
        public int ConstructionCategory { get; set; }

       // public virtual ConstructionCategory? ConstructionCategoryNavigation { get; set; } = null!;
       // public virtual User? User { get; set; } = null!;

        public virtual ICollection<ConstructionStep>? ConstructionStepConstructionSteps { get; set; }


        public async Task<ObservableCollection<Construction>> GetConstructionListByUser()
        {

            try
            {
                string RouteSufix = string.Format("Constructions/GetConstructionListByUser?id={0}", this.UserId);
                //armamos la ruta completa al endpoint en el API 
                string URL = Services.APIConnection.ProductionPrefixURL + RouteSufix;

                RestClient client = new RestClient(URL);

                Request = new RestRequest(URL, Method.Get);

                //agregamos mecanismo de seguridad, en este caso API key
                Request.AddHeader(Services.APIConnection.ApiKeyName, Services.APIConnection.ApiKeyValue);
                Request.AddHeader(GlobalObjects.ContentType, GlobalObjects.MimeType);

                //ejecutar la llamada al API 
                RestResponse response = await client.ExecuteAsync(Request);

                //saber si las cosas salieron bien 
                HttpStatusCode statusCode = response.StatusCode;

                if (statusCode == HttpStatusCode.OK)
                {

                    var list = JsonConvert.DeserializeObject<ObservableCollection<Construction>>(response.Content);

                    return list;
                }
                else
                {
                    return null;
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